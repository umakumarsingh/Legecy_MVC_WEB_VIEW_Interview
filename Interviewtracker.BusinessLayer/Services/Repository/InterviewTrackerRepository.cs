using Interviewtracker.DataLayer;
using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services.Repository
{
    public class InterviewTrackerRepository : IInterviewTrackerRepository
    {
        /// <summary>
        /// Creating field and object or dbcontext and all collection, injecting DbContext
        /// in constructor and getting a data from sql server
        /// </summary>
        private readonly InterviewerTrackerDbContext _interviewDb;
        public InterviewTrackerRepository(InterviewerTrackerDbContext context)
        {
            _interviewDb = context;
        }
        /// <summary>
        /// Add a new interview into sql table
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> AddInterview(Interview interview)
        {
            try
            {
                if (interview == null)
                {
                    throw new ArgumentNullException(typeof(Interview).Name + "Object is Null");
                }
                _interviewDb.Interviews.Add(interview);
                await _interviewDb.SaveChangesAsync();
                return interview;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Delate a saved interview by passing InterviewId
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteInterviewById(int interviewId)
        {
            try
            {
                var success = false;
                var interview = _interviewDb.Interviews.Find(interviewId);
                if (interview != null)
                    _interviewDb.Interviews.Remove(interview);
                var rseult = await _interviewDb.SaveChangesAsync();
                if (rseult == 1)
                    success = true;
                return success;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get all Interview and show on Dashboard Api
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> GetAllInterview()
        {
            try
            {
                var interview = await _interviewDb.Interviews.
                OrderByDescending(x => x.InterviewDate).ToListAsync();
                return interview;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get a single interview from sql table
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public async Task<Interview> GetInterviewrById(int interviewId)
        {
            try
            {
                var result =  await _interviewDb.Interviews
                                 .Where(x => x.InterviewId == interviewId)
                                 .FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Search in interview data by Passing Interview name and Interviewer name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> InterviewByName(string name)
        {
            try
            {
                var result = await _interviewDb.Interviews.
                Where(x => x.InterviewName == name || x.Interviewer == name).Take(10).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get Total Count of Interview In sql table
        /// </summary>
        /// <returns></returns>
        public long TotalCount()
        {
            int count = _interviewDb.Interviews.Select(x => x.InterviewId).Count();
            return count;
        }
        /// <summary>
        /// Update an Existing Interview
        /// </summary>
        /// <param name="InterviewId"></param>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> UpdateInterview(Interview interview)
        {
            if (interview == null)
            {
                throw new ArgumentNullException(typeof(Interview).Name + "Object or may be InterviewId is Null");
            }
            try
            {
                _interviewDb.Entry(interview).State = EntityState.Modified;
                var rseult = await _interviewDb.SaveChangesAsync();
                return interview;
            }
            catch(Exception ex)
            {
                throw (ex);
            }
           
        }
    }
}
