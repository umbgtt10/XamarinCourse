using System.Collections.Generic;
using XamarinCourse.Navigation.Exercise.Model;

namespace XamarinCourse.Navigation.Exercise.Services
{
    public class XamarinActivityService : ActivityService
    {
        private IList<Activity> _activities;

        public XamarinActivityService()
        {
            _activities = new List<Activity>()
            {
                new Activity() {Id = 1, Description = "I am the first activity"},
                new Activity() {Id = 2, Description = "I am the second activity"},
                new Activity() {Id = 3, Description = "I am the third activity"},
                new Activity() {Id = 4, Description = "I am the fourth activity"},
                new Activity() {Id = 5, Description = "I am the fifth activity"},
            };
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activities;
        }
    }
}