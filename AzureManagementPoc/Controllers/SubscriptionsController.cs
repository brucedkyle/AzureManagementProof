using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureManagementPoc.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        // GET: Subscriptions
        public ActionResult Index()
        {
            return View();
        }
    }
}