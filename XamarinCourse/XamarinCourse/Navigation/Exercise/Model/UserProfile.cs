using System;

namespace XamarinCourse.Navigation.Exercise.Model
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get { return $"http://lorempixel.com/200/200/people/{Id}"; }

            set { throw new NotImplementedException(); }
        }
    }
}