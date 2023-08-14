using System;
using System.Diagnostics;

namespace RussianRoulete {
    internal class Program {
        static void Main(string[] args) {

            Random rnd  = new Random();

            int randomShoot = rnd.Next(1,7);

            Console.WriteLine("Write a number between 1 and 6");

            int resposta = int.Parse(Console.ReadLine());

            Console.WriteLine(randomShoot);

             if(resposta == randomShoot) {

                Console.WriteLine("Congrats! you guessed it right");
            }       
             else {

                ToRestartPC.Restarting(true);
              
            }   

        }
    }
}
