using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // in C# a value cant be null but can be true or false
            //DateTime date = null; error
            Nullable<DateTime> date = null;
            // short hand
            //DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault);
            Console.WriteLine("GetValueOrDefault():" + date.GetValueOrDefault()); // better way of getting value if null dont error
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

            DateTime? date2 = new DateTime(2021, 1, 6);
            // put value above into this not nullable date
            DateTime date3 = date2.GetValueOrDefault();

            // value type to nullable
            DateTime? date4 = date3;

            // 
            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 DateTime.Today;

            // short hand
            DateTime date5 = date ?? DateTime.Today;
            //               option1    option2
            DateTime date6 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            //                condition           option1                 option2
        }
    }
}
