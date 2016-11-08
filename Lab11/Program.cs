using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            string address1 = Console.ReadLine();

            Console.WriteLine("Enter student program: ");
            string program1 = Console.ReadLine();

            Console.WriteLine("Enter student year: ");
            int year1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student fee: ");
            double fee1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter staff school: ");
            string school1= Console.ReadLine();

            Console.WriteLine("Enter staff pay: ");
            double pay1= double.Parse(Console.ReadLine());

            Person One = new Person(name1, address1);

            //Student Two = new Student(name1, address1, program1, year1, fee1);

           // Staff Three = new Staff(name1, address1, school1, pay1);

            Console.WriteLine(One);
            ///TODO add method for user input and loop beteeen staff,student person
        }
    }
}
