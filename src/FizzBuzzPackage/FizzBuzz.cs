namespace FizzBuzzPackage
{
    public class FizzBuzz
    {
        public static string GetResult(int number)
        {        
            string result = "";

            if (number % 3 == 0)  
            {  
                result += "Fizz";  
            }  
            if (number % 5 == 0)  
            {  
                result += "Buzz";  
            }  
            if (result.Length == 0 || number == 0)  
            {  
                result = "None"; 
            }  

            return result;
        }
    }
}