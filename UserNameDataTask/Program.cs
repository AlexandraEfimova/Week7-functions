using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal oma eesnime
            //programm kusib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tahte
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("sisesta oma eesnime:");
            string userName = Console.ReadLine();
            Console.WriteLine("vali arvu '1','2' voi '3'");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    One(userName);
                        break;
                case '2':
                    Two(userName);
                    break;
                case '3':
                    Three(userName);
                    break;

                default:
                    Console.WriteLine("Kena paeva!");
                    break;
                

            }
        }
        public static void One(string userInput)
        {
            for(int i = userInput.Length -1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void Two(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene taht on {userInput[0]}");
        }
        public static void Three(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk.");
        }



    }


}
