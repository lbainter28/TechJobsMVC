using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        [Route("/Search")]
        [HttpPost]
        public IActionResult Results(string searchType = "all", string searchTerm = "")
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = string.Format("Search: {0} - \"{1}\"", searchType.Substring(0, 1).ToUpper() + searchType.Substring(1),
                                                                   searchTerm.Substring(0, 1).ToUpper() + searchTerm.Substring(1));
            ViewBag.searchType = searchType;
            ViewBag.searchTerm = searchTerm;

            if (searchType.Equals("all"))
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
            }
            else
            {
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }

            return View("Index");
        }
    }
}
