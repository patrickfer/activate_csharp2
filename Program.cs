using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] vect = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)

            {
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");  
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect [i]);
                }
            }
            Console.ReadLine();
         
               




              



        }
    }
}

