using System;
using MotorVehicles.TestFolder;

namespace MotorVehicles
{
    class MotorVehicles
    {


        static void Main(string[] args)
        {
            Vehicle truck = new Truck();

            //truck.WheeleSize = 95;

            Random rnd = new Random();
            for (int i = 0; i <= 100; i++)
            {
                int randomNumber = rnd.Next();
                if (IsOdd(randomNumber))
                {
                    Console.WriteLine("Random number is:" + randomNumber); //test line
                                                                           //If the number is Odd: create a Truck with ModelName = "Coupe " + current random number
                                                                           //Truck Coupe = new Truck();


                }
                else
                {
                    //If the number is Even:  create a Coupe with Model = "Coupe " + current random number

                }
            }
            Console.WriteLine("finished");

            static bool IsOdd(int value)
            {
                return value % 2 != 0;
            }


        }
    }
}


