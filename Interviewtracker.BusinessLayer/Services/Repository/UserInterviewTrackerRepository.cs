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
    public class UserInterviewTrackerRepository : IUserInterviewTrackerRepository
    {
        private readonly InterviewerTrackerDbContext _interviewDb;

        /// <summary>
        /// Creating field and object or dbcontext and all collection, injecting BlogEntities
        /// in constructor and getting a Collection from sql server
        /// </summary>
        public UserInterviewTrackerRepository(InterviewerTrackerDbContext interviewerTrackerDbContext)
        {
            _interviewDb = interviewerTrackerDbContext;
        }
        /// <summary>
        /// Delete a registred user from Sql Server
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUserById(int UserId)
        {
            try
            {
                var success = false;
                var user = _interviewDb.ApplicationUsers.Find(UserId);
                if (user != null)
                    _interviewDb.ApplicationUsers.Remove(user);
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
        /// Get All user from Sql Server
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            try
            {
                var user = await _interviewDb.ApplicationUsers.
                OrderByDescending(x => x.FirstName).ToListAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public IEnumerable<ApplicationUser> GetUser()
        {
            try
            {
                var user = _interviewDb.ApplicationUsers.
                OrderByDescending(x => x.FirstName).ToList();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// Get a registred user from Sql Server
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserById(int? userId)
        {
            try
            {
                var result = await _interviewDb.ApplicationUsers
                                 .Where(x => x.UserId == userId)
                                 .FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Creating or registreing a new user in Sql Server
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> Register(ApplicationUser user)
        {
            try
            {
                _interviewDb.ApplicationUsers.Add(user);
                var result = await _interviewDb.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Update an Existing user by passing its object
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UpdateUser(ApplicationUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(typeof(ApplicationUser).Name + "Object or may be UserId is Null");
            }
            try
            {
                _interviewDb.Entry(user).State = EntityState.Modified;
                var rseult = await _interviewDb.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public IEnumerable<ApplicationUser> User()
        {
            var user = _interviewDb.ApplicationUsers.
                 OrderByDescending(x => x.FirstName).ToList();
            return user;
        }
    }
}
