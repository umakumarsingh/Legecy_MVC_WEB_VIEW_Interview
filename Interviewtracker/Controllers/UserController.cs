using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Interviewtracker.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IUserInterviewTrackerRepository _uITRepository;
        public UserController(IUserInterviewTrackerRepository userInterviewTrackerRepository)
        {
            _uITRepository = userInterviewTrackerRepository;
        }
        // GET: User
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register New User
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterUser()
        {
            return View();
        }
        /// <summary>
        /// Register new user after post, form fill
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> RegisterUser(RegisterViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// edit Registred user 
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> EditUser(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Edit user after load User on edit mode
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> EditUser(UserEditViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete User from InMemory Db by passing UserId
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DeleteUser(int? UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Display confirmation message to delete User
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteUserConfirmed(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}