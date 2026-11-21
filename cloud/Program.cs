using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        bool isPalindrome= true;
        Console.WriteLine("Enter  name: ");
        string cleaned = Console.ReadLine();
        cleaned = new string(cleaned.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        for (int i = 0; i < cleaned.Length / 2; i++)
        {       int j = cleaned.Length - 1 - i;
            

            if (cleaned[i] != cleaned[j])
                {
                 isPalindrome = false;
                break;
            }
             
            

        }
        if(isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}
