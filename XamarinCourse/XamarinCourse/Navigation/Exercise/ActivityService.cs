using System;
using System.Collections.Generic;
using XamarinCourse.Navigation.Exercise.Model;

namespace XamarinCourse.Navigation.Exercise
{
    public interface ActivityService
    {
        IEnumerable<Activity> GetAll();
    }
}