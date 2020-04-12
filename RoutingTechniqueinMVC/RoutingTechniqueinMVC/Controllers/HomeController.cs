using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutingTechniqueinMVC.Controllers;
using RoutingTechniqueinMVC.Models;

namespace RoutingTechniqueinMVC.Controllers
{
    [RoutePrefix("Students")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

       // [Route("Students")]
        public ActionResult GetStudent()
        {
            var Student = Students();
            return View(Student);
        }
        [Route("{id:int:min(5)}")]
        // [Route("Students/{id}")]
        public ActionResult GetSingleStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.id == id);

            return View();
        }
        [Route("{id}/address")]
        // [Route("Students/{id}/address")]
        public ActionResult GetStudentaddress(int id)
        {
            var studentAddress = Students().Where(x => x.id == id).Select(x => x._Address).FirstOrDefault();
            return View();
        }



        [Route("{id}")]
        // [Route("Students/{id}")]
        public string mystring(string id)
        {
            

            return id;
        }

        [Route("~/about-us")]
        [Route("~/aboutus")]
        // [Route("Students/{id}")]
        public string aboutus(string id)
        {


            return id;
        }





        private List<Student> Students()
        {
            return new List<Student>();
            {
                new Student()

                {
                    id = 1,
                    name = "nikhil shukla",
                    Collage = "invertis university",
                    email = "nikhilshuklaiarmy@gmail.com",
                    DOB = DateTime.Now,

                    _Address = new Address()
                    {
                        address = "Sidhuali",
                        Mobile = "9451111336",
                        phone = "8115511891"
                    }
                },
                new Student()

                {
                    id = 1,
                    name = "nikhil shukla",
                    Collage = "invertis university",
                    email = "nikhilshuklaiarmy@gmail.com",
                    DOB = DateTime.Now,

                    _Address = new Address()
                    {
                        address = "Sidhuali",
                        Mobile = "9451111336",
                        phone = "8115511891"
                    }
                },
                new Student()

                {
                    id = 1,
                    name = "nikhil shukla",
                    Collage = "invertis university",
                    email = "nikhilshuklaiarmy@gmail.com",
                    DOB = DateTime.Now,

                    _Address = new Address()
                    {
                        address = "Sidhuali",
                        Mobile = "9451111336",
                        phone = "8115511891"
                    }
                },
               
      

         

            }
           
            
        }
        

    
        
    }
    }