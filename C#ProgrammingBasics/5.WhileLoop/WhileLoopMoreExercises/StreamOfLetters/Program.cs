using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int oTimes = 0;
            int cTimes = 0;
            int nTimes = 0;
            string letters = "";
            char symbols = ' ';
            string output = "";
            

            while (input != "End")
            {
                symbols = char.Parse(input);
                if (char.IsLetter(symbols))
                {
                    switch (symbols)
                    {
                        case 'o':
                            oTimes++;
                            if (oTimes > 1)
                            {
                                letters += symbols;
                            }
                            break;
                        case 'c':
                            cTimes++;
                            if (cTimes > 1)
                            {
                                letters += symbols;
                            }
                            break;
                        case 'n':
                            nTimes++;
                            if (nTimes > 1)
                            {
                                letters += symbols;
                            }
                            break;
                    }
                    if (symbols != 'o' && symbols != 'c' && symbols != 'n')
                    {
                        letters += symbols;
                    }
                    if (oTimes >= 1 && cTimes >= 1 && nTimes >= 1)
                    {
                        oTimes = 0;
                        cTimes = 0;
                        nTimes = 0;
                        letters += " ";
                        output = letters;   
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{output}");
        }
    }
}
