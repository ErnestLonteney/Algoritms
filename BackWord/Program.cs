namespace BackWord
{
    internal class Program
    {
        // O(n)
        static string BackWordZero(string word)
        {
            char[] charArray = new char[word.Length];
           
            for (int i = word.Length - 1, j = 0; i >= 0; i--, j++)
            {
                charArray[j] = word[i];
            }

            return new String(charArray);
        }

        static string BackWord(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            
            return new String(charArray);   
        }

        static string BackWord2(string word)
        {
            string result = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            
            return result;
        }
        
        static string BackWord3(string word)
        {
            char[] charArray = word.ToCharArray();

            for (int i = 0, j = word.Length - 1; i < word.Length / 2 && j > 0; i++, j--)
            {
                var buf = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = buf;
            }

            return new String(charArray);   
        }   

        static void Main(string[] args)
        {
            string result = BackWord3("Apple is tasty");

            Console.WriteLine(result);
        }
    }
}
