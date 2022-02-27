using milanexamschedularapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace milanexamschedularapp.Controllers
{
    public class DatesListController : ApiController
    {
        // GET: DatesList
        Entities1 db = new Entities1();
        public IEnumerable<listofdates_Result> Get(string courseId)

        {
            return db.listofdates(courseId).ToList();
        }
    }
}