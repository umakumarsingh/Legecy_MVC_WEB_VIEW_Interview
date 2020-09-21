using InterviewTracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Interfaces
{
    public interface IInterviewTrackerServices
    {
        //List of method to perform all User related operation
        Task<Interview> AddInterview(Interview interview);
        Task<Interview> GetInterviewrById(int interviewId);
        Task<IEnumerable<Interview>> GetAllInterview();
        Task<bool> DeleteInterviewById(int interviewId);
        Task<Interview> UpdateInterview(Interview interview);
        long TotalCount();
        Task<IEnumerable<Interview>> InterviewByName(string name);

    }
}
