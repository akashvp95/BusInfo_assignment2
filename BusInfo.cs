using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusInfo_Assignment2.Models
{
    [Table("tblBusInfo")]
    public class BusInfo
    {
        [Key]
        public int BusID { get; set; }
        public string BoardPoint { get; set; }

        public string TravelDate { get; set; }
        public decimal Amount { get; set; }
        public int Rating { get; set; }
    }
}