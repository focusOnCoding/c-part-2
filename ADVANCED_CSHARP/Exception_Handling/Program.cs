using System;
using System.IO;

namespace Exception_Handling
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator;
                var reault = calculator.Divide(5, 0);
            }
            // i can handle many different types of errors with catch from most specific to most generic
            catch(DivideByZeroException ex) // from most spesific to most generic ↓↓
            {
                Console.WriteLine("You cant divide by zero 0.");
            }
            catch(ArithmeticException ex)
            {

            }
            // this needs to be the last handled error coz its the most generic one 
            // if i put it on the first line the other two exceptions wont be handled order is important {highaky}
            catch (Exception ex) // eccess the error {ex}
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
                
            }
            finally
            {
                // this helps with resorces that a not managed by CLR {no garbge collection}
                // this is where i do the clearn up
                IDisposable
            }


            // stream reader eg
            //StreamReader streamReader = null;
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpexted error occurred");
            }
            /*finally  this is no longer needed since im using the using key function
            {
                if(streamReader != null)
                    streamReader.Dispose();
                // close file and network resources
            }*/


            try
            {
                var api = new YouTubeAPI();
                var videos = api.GetVideo("Dlamini");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
