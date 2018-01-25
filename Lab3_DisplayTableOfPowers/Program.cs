using System;

namespace Lab3_DisplayTableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {

            //WELCOME
            Console.WriteLine("Learn your squares and cubes!");

            //PROCESS

            bool ContinueProgram = true;
            while (ContinueProgram)
            {
                //INPUT
                Console.WriteLine("");
                Console.WriteLine("Enter an integer: ");
                int Input = int.Parse(Console.ReadLine());

                Console.WriteLine("Number" + "  " + "Squared" + "  " + "Cubed");
                Console.WriteLine(Input + "          " + SquareIt(Input) + "     " + CubeIt(Input));

                for (int i = 1; i <= Input; i++)
                //{
                //    Console.WriteLine("Number" + "  " + "Squared" + "  " + "Cubed");
                //    Console.WriteLine(Input + "          " + SquareIt(Input) + "     " + CubeIt(Input));  //look up how to generate a table {t}
                //}


                //REPEAT?
                Console.WriteLine("Continue? Y/N");
                string Continue = Console.ReadLine();

                if (Continue == "Y")//|| "y")
                {
                    ContinueProgram = true;
                }

                else
                {
                    ContinueProgram = false;
                    Console.WriteLine("Goodbye!");
                }

            }

        }

        public static int SquareIt(int Input) //method for squaring the original input
        {
            int SquareIt = Input * Input;
            return SquareIt;
        }

        public static int CubeIt(int Input) //method for cubing the original input
        {
            int CubeIt = Input * Input * Input;
            return CubeIt;
        }
    }
}
