using System;
using System.Data.Linq.Mapping;

namespace WpfApp1.Tables
{
    [Table(Name = "tanto")]
    public class TantoMaster
    {
        [Column(Name = "no", IsPrimaryKey = true)]
        public int No { get; set; }
        [Column(Name = "name")]
        public String Name { get; set; }
        [Column(Name = "cdate")]
        public String cDate { get; set; }
        [Column(Name = "edate")]
        public String eDate { get; set; }
    }
}
