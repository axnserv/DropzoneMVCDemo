using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace DropzoneMVCDemo.Controllers
{
    public class FileUploadController : Controller
    {
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Upload(HttpPostedFileBase file)
        {
            //TODO Handle the uploaded file here
            return View();
        }
    }
}
