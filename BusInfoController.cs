using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusInfo_Assignment2.Models;
using System.Data.SqlClient;
using System.Data;
using System.Web.Mvc;

namespace BusInfo_Assignment2.Controllers
{
    public class BusInfoController : Controller
    {
        BusInfoContext db = new BusInfoContext();


        public ActionResult Index()
        {
            db.BusInfo.ToList();
            return View();
        }
        [HttpPost]
        public void Save(string boardpoint, string traveldate, decimal amount,int rating)
        {
            SqlConnection con = new SqlConnection("data source = LMI-5F5G2G2\\SQLEXPRESS; database = BusInfo_assignment; integrated security=SSPI");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Execute spBusInfo @BoardingPoint,@Traveldate,@Amount,@Rating";
            cmd.Parameters.Add("@BoardingPoint", SqlDbType.VarChar, 50).Value = boardpoint;// teamname1 is textbox name in html
            cmd.Parameters.Add("@Traveldate", SqlDbType.VarChar, 50).Value = traveldate;
            cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
            cmd.Parameters.Add("@Rating", SqlDbType.Int, 4).Value = rating;
            cmd.ExecuteNonQuery();
            cmd.Dispose(); //free the resources 
            con.Close();
        }
    }
}