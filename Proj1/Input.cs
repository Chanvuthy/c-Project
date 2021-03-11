using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1
{
    class Input
    {
        public int id;
        public string name;
        public string gender;
        public string address;
        public string subject;
        public double score;

        public Input()
        {
            Console.Write("\nID   =");
            id = int.Parse(Console.ReadLine());
            Console.Write("\nName   =");
            name = Console.ReadLine();
            Console.Write("\nGender =");
            gender = Console.ReadLine();
            Console.Write("\nAddress    =");
            address = Console.ReadLine();
            Console.Write("\nSubject    =");
            subject = Console.ReadLine();
            Console.Write("\nScore  =");
            score = double.Parse(Console.ReadLine());
            Console.WriteLine("========================================");
        }
        public Input(int id, string name, string gender, string address, string subject, double score)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.subject = subject;
            this.score = score;
        }
        public override string ToString()
        {
            return id.ToString("000") + "\t" + name + "\t" + gender + "\t" + address + "\t" + subject + "\t" + score;
        }
    }
}
