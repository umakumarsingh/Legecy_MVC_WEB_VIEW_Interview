using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Interviewtracker.Controllers
{
    public class InterviewController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository and IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interview;
        private readonly IUserInterviewTrackerRepository _userTR;
        public InterviewController(IInterviewTrackerRepository interviewTrackerRepository, IUserInterviewTrackerRepository userInterviewTrackerRepository)
        {
            _interview = interviewTrackerRepository;
            _userTR = userInterviewTrackerRepository;
        }
        /// <summary>
        /// Add New Interview in InMemorydb
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddNewInterview()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Post method of AddNewInterview after AddNewInterview page is added.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddNewInterview(AddInterviewViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}