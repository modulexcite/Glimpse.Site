﻿using System.Web.Mvc;
using Glimpse.Issues;
using Glimpse.Site.Framework;

namespace Glimpse.Site.Controllers
{
    public class IssuesController : Controller
    {
        private readonly GlimpsePackageViewModelMapper _glimpsePackageViewModelMapper = new GlimpsePackageViewModelMapper();
        //
        // GET: /Issues/

        [OutputCache(Duration = 30 * 60)]
        public ActionResult Index()
        {
            var jsonFile = Server.MapPath("~/Content/packages.json");
            var packageIssueProvider = new PackageIssueProvider(new PackageRepository(jsonFile), new IssueRepository(new GithubIssueService()));
            var issuesView = _glimpsePackageViewModelMapper.ConvertToIndexViewModel(packageIssueProvider.GetPackageIssues());
            return View(issuesView);
        }
    }
}
