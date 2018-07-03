using System;

namespace episodes.Models
{
    public class Exceptions
    {

        public void Test()
        {
            try
            {
                User user = new User("email","pass");
                user = null;
                throw new ArgumentNullException(nameof(user));
             //logic  
                // throw new Exception("random");  
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Null error: {ex}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex}");

            }
            finally
            {
                //Dispose()
            }
            Console.WriteLine("OK");
        }
    }
}