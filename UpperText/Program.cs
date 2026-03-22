namespace UpperText
{
    internal class Program
    {
        static string WordToUpper(string input)
        {
            List<string> words = new List<string>();

            int begin = 0;
            int end;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || i == input.Length  - 1) 
                {
                    end = (i == input.Length - 1) ? i : i - 1;
                    string word = input.Substring(begin, end - begin + 1);


                    char[] part = [word[0]];
                    if (new String(part) != new String(part).ToUpper())
                    {
                        word = word.Substring(0, 1).ToUpper() + word.Substring(1);
                    }

                    words.Add(word);

                    begin = end + 2;    
                }
            }

            return string.Join(" ", words);    
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WordToUpper("Hello, world hello! wefwef wefwe wef wef"));
        }
    }


}
