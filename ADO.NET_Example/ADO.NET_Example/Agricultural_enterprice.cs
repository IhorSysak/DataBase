using System;
using System.Collections.Generic;
using System.Text;
using LinqToDB.Mapping;

namespace ADO.NET_Example
{
    [Table(Name = "Agricultural_enterprice")]
    public class Agricultural_enterprice
    {
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(Name = "Name_of_company")]
        public string Name_of_company { get; set; }
        [Column(Name = "OwnerShip")]
        public string OwnerShip { get; set; }
        [Column(Name = "Address")]
        public string Address { get; set; }
        [Column(Name = "Number_of_Employees")]
        public int Number_of_Employees { get; set; }
        [Column(Name = "Cultivated_cropsID")]
        public int Cultivated_cropsID { get; set; }
        [Column(Name = "FarmID")]
        public int FarmID { get; set;}
    }
}
