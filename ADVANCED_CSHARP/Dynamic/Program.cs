using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic make working with dynamicaly typed programms easyer {IronPyton, js}

            object obj = "Siyabonga";
            // call method in object
            //obj.GetHashCode()

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

         /* object execlObject = "Siya";
            execlObject.Optimise(); // returns an error */

            // but when using dynamics i can using .Optimise()
            dynamic execlObjectDynamic = "Siya";
            execlObjectDynamic.Optimise();

            // CLR => DLR => is what DYNAMICS use to compile the types when im using it

            dynamic name = "Siya_D";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            // var is not dynamic its just a short hand for the runtime to dicaed
            var c = " ";
            // if i add a + b in a var that type changes to dynamic because im adding up to dynamics
            var cc = a + b;
            // with dynamics i get implisit convertion
            int i = 5;
            dynamic z = i; // this will be converted to {dynamic int}
            long l = z; // z will now be a long without no explisit convertion

        }
    }
}
