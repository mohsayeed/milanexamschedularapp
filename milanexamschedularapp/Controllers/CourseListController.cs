using milanexamschedularapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace milanexamschedularapp.Controllers
{
    public class CourseListController : ApiController
    {
        // GET: CourseList
        Entities1 db = new Entities1();
        public IEnumerable<courseInfo> Get()
        {
            return db.courseInfoes.ToList();
        }
    }
}