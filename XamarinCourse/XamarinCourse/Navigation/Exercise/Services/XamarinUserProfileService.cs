using System.Collections.Generic;
using System.Linq;
using XamarinCourse.Navigation.Exercise.Model;

namespace XamarinCourse.Navigation.Exercise.Services
{
    public class XamarinUserProfileService : UserProfileService
    {
        private readonly List<UserProfile> _userProfiles;

        public XamarinUserProfileService()
        {
            _userProfiles = new List<UserProfile>()
            {
                new UserProfile() {Description = "I am the first user", Id = 1, Name = "First"},
                new UserProfile() {Description = "I am the second user", Id = 2, Name = "Second"},
                new UserProfile() {Description = "I am the third user", Id = 3, Name = "Third"},
                new UserProfile() {Description = "I am the fourth user", Id = 4, Name = "Fourth"},
                new UserProfile() {Description = "I am the fifth user", Id = 5, Name = "Fifth"},
            };
        }

        public UserProfile Get(int id)
        {
            return _userProfiles.SingleOrDefault(u => u.Id == id);
        }
    }
}