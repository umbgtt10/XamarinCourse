using System;
using System.Text;

namespace XamarinCourse.Navigation.Exercise.Model
{
    public class Activity
    {
         public int Id { get; set; }
         public string Description { get; set; }

         public string ImageUrl
         {
             get { return $"http://lorempixel.com/100/100/people/{Id}"; }

             set { throw new NotImplementedException(); }
         }
    }
}
