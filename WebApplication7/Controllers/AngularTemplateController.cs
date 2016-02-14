using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class AngularTemplateController : Controller
    {
        public PartialViewResult HomeTemplate()
        {
            return PartialView();
        }

        public PartialViewResult LoginTemplate()
        {
            return PartialView();
        }

        public PartialViewResult RegisterTemplate()
        {
            return PartialView();
        }
    }
}