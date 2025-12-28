using LuyenTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LuyenTap.Controllers
{
    public class DonViController : ApiController
    {
        QLLuongEntities db = new QLLuongEntities();

        [HttpGet]
        public List<DonVi> LayDonVis()
        {
            return db.DonVis.ToList();
        }
    }
}
