using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNombreMagique
{
    class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int number = min - 1;

            while ((number < min || number > max))
            {
                Console.Write($" Rentrez un nombre entre {min} et {max} : ");
                string response = Console.ReadLine();

                try
                {
                    number = int.Parse(response);
                    if ((number < min|| number > max)){
                        Console.WriteLine($"ERREUR ! Le nombre doit être compris entre {min} et {max} ");
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR ! Rentrez un nombre valide ");
                }
            }
            

            return number;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int NUMBER_MIN = 1;
            const int NUMBER_MAX = 10;
            int nbrVie = 4;
            int nombreMagique = rand.Next(NUMBER_MIN,NUMBER_MAX +1);
            int nombre = nombreMagique + 1;


            while(nbrVie > 0)
            {
                Console.WriteLine();
                Console.WriteLine(" Vies restantes : " + nbrVie);
                nombre = DemanderNombre(NUMBER_MIN, NUMBER_MAX);
                if (nombre > nombreMagique)
                {
                    Console.WriteLine(" le nombre magique est plus petit que " + nombre);
                }
                else if (nombre < nombreMagique)
                {
                    Console.WriteLine(" Le nombre magique est plus grand que " + nombre);
                }
                else
                {
                    Console.WriteLine(" BRAVO ! vous avez trouvez le nombre magique ");
                    break;
                }
                nbrVie--;
            }
            
            if(nbrVie == 0)
            {
                Console.WriteLine();
                Console.WriteLine($" Vous avez perdu, le nombre magique était {nombreMagique} ");
            }

            //Console.WriteLine($" Votre nombre est : {nombre} ");
            Console.ReadKey();
        }
    }
}
