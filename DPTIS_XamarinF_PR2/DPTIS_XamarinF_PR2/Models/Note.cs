using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPTIS_XamarinF_PR2.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public Int32 ID { get; set; }
        public String Text { get; set; }
        public DateTime Date { get; set; }
    }
}
