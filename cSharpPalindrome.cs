using System.Text.RegularExpressions;
internal class Program
{
    public static string RemoveSpecialCharacters(string str)
    //REGEX Method to remove all special characters from user input
    {
        return Regex.Replace(str, "[^a-zA-Z_.]+", "", RegexOptions.Compiled);
    }
    public static string Reverse(string s)
    //Method to reverse string
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome, enter a word to check if it is a palindrome, type 'exit' to exit.");
        //Start of global variables
        bool isPalindrome = true;
        int count = 1;
        //Start of program logic
        while (true)
        {
            //Get user input and convert to lowercase and remove all special characters and spaces (REGEX)
            string input = Console.ReadLine();
            string lowInput = input.ToLower();
            string formattedInput = RemoveSpecialCharacters(lowInput);
            string flippedInput = Reverse(formattedInput);
            if (input == "quit" || input == "exit")
            {
                break;
            }
            if (formattedInput == flippedInput)
            {
                isPalindrome = true;
                Console.WriteLine("Palindrome: " + isPalindrome);
                Console.WriteLine("Character Length: " + input.Length);
                Console.WriteLine("Number of attempts: " + count);

            }
            else
            {
                isPalindrome = false;
                Console.WriteLine("Palindrome: " + isPalindrome);
                Console.WriteLine("Character Length: " + input.Length);
                Console.WriteLine("Number of attempts: " + count);
            }
            count++;
        }
    }
}
