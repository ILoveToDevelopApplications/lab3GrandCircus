using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3GrandCircus
{
    class Program
    {
        //private static string restartApps;

        static void Main(string[] args)
        {

            // Console.WriteLine("Enter a number between 1 and 100 \n");

            //private static string restartApps;

            //restartApps = Console.ReadLine();

            bool restart = false;


            while (!restart)
            {


                // user input
                Console.WriteLine("Enter a number between 1 and 100 \n");


                int inputNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                //check for even number
                if (inputNumber % 2 == 0)
                {
                    if (inputNumber <= 0)
                    {


                        Console.WriteLine(" Please a valid number \n ");
                    }
                    if (inputNumber <= 25 && inputNumber >= 2)
                    {
                        Console.WriteLine(" Even and less than 25 \n");

                    }
                    if (inputNumber >= 26 && inputNumber <= 60)
                    {
                        Console.WriteLine("Even \n");
                    }
                    if (inputNumber > 60)
                    {
                        Console.WriteLine(inputNumber + " " + " Even  \n");
                    }
                    

                }
                // check for odd number over 60
                else 
                {
                    if(inputNumber >= 1)
                    {
                        Console.WriteLine("Odd \n");
                    }
                    if (inputNumber > 60)
                    {
                        Console.WriteLine(inputNumber + " and Odd \n ");
                    }

                    Console.WriteLine("Bye! \n");
                }


                Console.WriteLine("Continue ? Yes or No. \n");

                Console.WriteLine("\n");


              

                string restartApps = Console.ReadLine();


                if (restartApps == "yes")
                {
                    restart = true;
                }



                

            }













        }
    }




}




    











    





