using System;

namespace Convert_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //A type conversion and try/catch block demonstration will be below.


            //This conversion to byte won't work due to the fact our number is to large. A try/catch block can be used here
            //You can just type try and hit tab twice then it will auto produce itself.
            //The code in the try block will be monitored and if an action occurs the code in the catch block will active. If this doesn't happen a runtime crash will occur and an error displayed.
            //We want the exception to be caught here and not crash. 
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {   
                //This console message will popup saying the number is too large then readline will keep console open to be read. 
                Console.WriteLine("The number could not be converted to a byte");
                Console.ReadLine();
            }



            //Another example is below.
            //Here string and bool are not compatible so we can't go explicite converting. Have to use the convert class. 
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(str);
            }
            catch (Exception)
            {
                Console.WriteLine("The string cannot be converted to a boolean");
            }

        }
    }
}
