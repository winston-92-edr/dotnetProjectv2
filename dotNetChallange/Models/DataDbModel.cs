using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dotNetChallange.Models
{
    public class DataDbModel
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string low_24 { get; set; }
        public string high_24 { get; set; }
        public string avg_24h { get; set; }
        public string volume_24h { get; set; }
        public string timestamp { get; set; }
        public DateTime dateTime { get; set; }
    }
}