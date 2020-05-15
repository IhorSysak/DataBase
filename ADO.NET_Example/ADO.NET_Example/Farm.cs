using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET_Example
{
    [Table(Name = "Farm")]
    public class Farm
    {
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(Name = "Name_farm")]
        public string Name_farm { get; set; }
        [Column(Name = "Number_of_cattle")]
        public int Number_of_cattle { get; set; }
    }
}
