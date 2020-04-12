using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoutingTechniqueinMVC.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string Collage { get; set; }
        public DateTime DOB { get; set; }

       
        public Address _Address { get; set; }
       

    }

    public class Address
    {
        public string phone { get; set; }
        public string address { get; set; }
        public string Mobile { get; set; }
    }



}