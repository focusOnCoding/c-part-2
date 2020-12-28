using System;

namespace Delegates
{
     class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhototFilterHandler filterHandler = filters.ApplyBrightness;

            
            // add another filter
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.Process("phoo.jpg", filterHandler);
            Console.WriteLine("Hello World!");
        }
        // if i want to create my own filter that did not come with the framwork i can do the below
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Appy RemoveRedEye");
        }
    }
}
