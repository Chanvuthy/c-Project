using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class Program
    {
        static void Mainx(string[] args)
        {
            InputName student1 = new InputName();
            InputName student2 = new InputName();
            InputName student3 = new InputName(1, "Daro", "Male", "TK", "DS", 92);

            student1.id = 1;
            student1.name = "Dara";
            student1.gender = "Male";
            student1.address = "PP";
            student1.subject = "MIS";
            student1.score = 94;

            student2.id = 1;
            student2.name = "Dara";
            student2.gender = "Male";
            student2.address = "PP";
            student2.subject = "MIS";
            student2.score = 94;


            Console.WriteLine("ID\t"  +"Name\t"+ "Gender\t"+"Address\t"+"Subject\t"+"Score\n");
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.ReadKey();
        }
    }
}
