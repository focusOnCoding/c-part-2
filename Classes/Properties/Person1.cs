using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Person
    {
        // create auto impemanted prpertiy {prop    }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthday)
        {
            Birthdate = birthday; 
        }
        public int Age
        {
            get
            {
                var timespane = DateTime.Today - Birthdate;
                var years = timespane.Days / 365;
                return years;
            }
        }
    }
}
