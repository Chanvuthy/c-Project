using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class Student
    {
        static void Main()
        {
            
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            Input[] student = new Input[n];
            for(int i=0;i<n;i++)
            {
                student[i] = new Input();
            }
            Console.WriteLine("ID\t" + "Name\t" + "Gender\t" + "Address\t" + "Subject\t" + "Score\n");
            foreach (Input temp in student )
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();


        }
    }
}
