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
    public class InterviewTrackerServices : IInterviewTrackerServices
    {
        /// <summary>
        /// creating a referance object of IInterviewTrackerRepository
        /// </summary>
        private readonly IInterviewTrackerRepository _interviewTR;

        /// <summary>
        /// injecting IInterviewTrackerRepository in consructor to access all methods
        /// </summary>
        public InterviewTrackerServices(IInterviewTrackerRepository interviewTrackerRepository)
        {
            _interviewTR = interviewTrackerRepository;
        }
        /// <summary>
        /// Add new interview
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> AddInterview(Interview interview)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete interview
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteInterviewById(int interviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all interview
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> GetAllInterview()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Interview by id
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public async Task<Interview> GetInterviewrById(int interviewId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get interview by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> InterviewByName(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get total interview
        /// </summary>
        /// <returns></returns>
        public long TotalCount()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update interview
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> UpdateInterview(Interview interview)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
