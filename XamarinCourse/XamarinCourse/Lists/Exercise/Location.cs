using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCourse.Lists.Exercise
{
    public class Location
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string Title
        {
            get { return $"{City}, {State}, {Country}"; }
        }

        public string TimeSpan
        {

            get { return $"{Start.ToShortDateString()} - {End.ToShortDateString()}"; }
        }
    }

}


