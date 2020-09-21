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
    public class DashboardController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository and IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interviewTR;
        private readonly IUserInterviewTrackerRepository _userTR;
        public DashboardController(IInterviewTrackerRepository interviewTrackerRepository,
            IUserInterviewTrackerRepository userInterviewTrackerRepository)
        {
            _interviewTR = interviewTrackerRepository;
            _userTR = userInterviewTrackerRepository;
        }
        /// <summary>
        /// Get all Interview From Sql server and display on Index Page
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<ActionResult> Index(string search, int page = 1)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Edit Existing Interview to change or reschedule
        /// </summary>
        /// <param name="InterviewId"></param>
        /// <returns></returns>
        [HttpGet]
        public async  Task<ActionResult> EditInterview(int InterviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Post method after edit value is submitted
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> EditInterview(EditInterviewViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete Interview from InMemory Db by passing ineterviewId
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteInterview(int interviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Display confirmation message to delete Interview
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        [HttpPost, ActionName("DeleteInterview")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteInterviewConfirmed(int interviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}