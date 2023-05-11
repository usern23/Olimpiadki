namespace Golden_Fish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader("input_s1_01.txt");
            int Count=Convert.ToInt32(a.ReadLine());
            string[,]Words=new string[Count,2];
            var Begin = new Dictionary<string, int>();
            var End = new Dictionary<string, int>();
            List<string> wordlist = new List<string>();
            for (int i = 0; i < Count; i++)
            {
                wordlist.Add(a.ReadLine());
            }
            wordlist.Sort();
            for (int i = 0; i < Count; i++)
            {
                string word = wordlist[i];
                Char[] letters = word.ToCharArray();
                Words[i, 0] = Convert.ToString(letters[0]); Words[i, 1] = Convert.ToString(letters[letters.Length-1]);
            }
            int Count1 = Convert.ToInt32(a.ReadLine());
            for (int i = 0;i < Count1; i++)
            {
                string perm=a.ReadLine();
                string[] info = perm.Split(" ");
                Begin.Add(info[0], Convert.ToInt32(info[1]));
            }
            Count1 = Convert.ToInt32(a.ReadLine());
            for (int i = 0; i < Count1; i++)
            {
                string perm = a.ReadLine();
                string[] info = perm.Split(" ");
                End.Add(info[0], Convert.ToInt32(info[1]));
            }
            int Sum = 0;
            for (int i = 0;i<Count; i++)
            {
                if ((Begin.Keys.Contains(Words[i, 0]))&& (End.Keys.Contains(Words[i, 1])))
                    if ((Begin[Words[i, 0]] > 0)&&(End[Words[i, 1]] > 0))
                    {
                        Sum++;
                        Begin[Words[i, 0]] = Begin[Words[i, 0]] - 1;
                        End[Words[i, 1]] = End[Words[i, 1]] - 1;
                    }
            }
            Console.WriteLine(Sum);
        }
    }
}