using static System.Net.Mime.MediaTypeNames;

namespace TauTauTauKita
{
    internal class Program
    {


        static string Convert_Word(string word)
        {
            char[] tmp = new char[word.Length];
            int count = word.Length / 2;
            for (int i = 0; i < word.Length; i++)
            {
                count += Convert.ToInt32(Math.Pow(-1, i) * i);
                tmp[i] = word[count];
            }
            return new string(tmp);
        }
        static void Main()
        {
            Console.Write("Введите строчку: ");
            string[] text = Console.ReadLine().Split(' ');
            string[] tmp = new string[text.Length];

            int count = text.Length / 2;
            for (int i = 0; i < text.Length; i++)
            {
                count += Convert.ToInt32(Math.Pow(-1, i) * i);
                tmp[i] = Convert_Word(text[count]);
            }
            Console.WriteLine(String.Join(" ", tmp));
            Console.ReadKey();
        }


    }
}