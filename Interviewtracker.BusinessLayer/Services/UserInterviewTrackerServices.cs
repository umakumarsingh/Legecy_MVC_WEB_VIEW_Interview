using Interviewtracker.DataLayer;
using InterviewTracker.BusinessLayer.Interfaces;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services
{
    public class UserInterviewTrackerServices : IUserInterviewTrackerServices
    {
        /// <summary>
        /// creating a referance object of IUserInterviewTrackerRepository
        /// </summary>
        private readonly IUserInterviewTrackerRepository _userInterviewTR;

        /// <summary>
        /// injecting IUserInterviewTrackerRepository in consructor to access all methods
        /// </summary>
        public UserInterviewTrackerServices(IUserInterviewTrackerRepository userInterviewTrackerRepository)
        {
            _userInterviewTR = userInterviewTrackerRepository;
        }

        public UserInterviewTrackerRepository SInterviewTrackerRepository { get; }
        /// <summary>
        /// Delete User by Id
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUserById(int UserId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all user
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a user
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ApplicationUser> GetUser()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserById(int? userId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> Register(ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UpdateUser(ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get User List
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ApplicationUser> User()
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
