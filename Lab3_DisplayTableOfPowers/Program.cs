﻿using System;

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


                

                for (int i = 0; i <= Input; i++)
                    {
                    Console.WriteLine(Input);
                    
                    }



                Console.WriteLine("Number" + "Squared" + "Cubed");

                //else  
                //{
                //    if ( )  
                //    {
                //        //
                //    }

                //    else if ( )  

                //    {
                //        //
                //    }

                //    else if ( )  //if it's even and none of those other things, do this

                //    {
                //        //
                //    }
                //}

                //REPEAT?
                Console.WriteLine("Continue? Y/N");
                string Continue = Console.ReadLine();

                if (Continue == "Y"|| "y")
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

        public static int SquareIt(Input) //method for squaring the original input
        {
            int SquareIt = Input * Input;
            return SquareIt;
        }

        public static int CubeIt(Input) //method for cubing the original input
        {
            int CubeIt = Input * Input * Input;
            return CubeIt;
        }
    }

