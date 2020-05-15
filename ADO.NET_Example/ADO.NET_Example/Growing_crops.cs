using System;
using System.Collections.Generic;
using System.Text;
using LinqToDB.Mapping;

namespace ADO.NET_Example
{
    [Table(Name = "Growing_crops")]
    public class Growing_crops
    {
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(Name = "Name_crops")]
        public string Name_crops { get; set; }
        [Column(Name = "Area")]
        public int Area { get; set; }
    }
}
