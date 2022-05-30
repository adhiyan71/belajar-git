using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;
namespace demo.Models
{
    public class EmpClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public detailaddress address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public detailcompany company { get; set; }
    }

    public class detailaddress
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public coradress geo { get; set; }
    }

    public class coradress
    {
        public string int { get; set; }
        public string int { get; set; }
    }

    public class detailcompany
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }

    public class displayinfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string address_street { get; set; }
    }
}