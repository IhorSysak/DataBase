using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET_Example
{
    [Table(Name = "Enterprice_contract")]
    public class Enterprice_contract
    {
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(Name = "Contract_number")]
        public int Contract_number { get; set;}
        [Column(Name = "Addres_shop")]
        public string Addres_shop { get; set; }
        [Column(Name = "ProductID")]
        public int ProductID { get; set; }
    }
}
