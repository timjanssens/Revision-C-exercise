using System;
using System.Collections.Generic;
using System.Text;

namespace MainProgramFile.H8KlassenEnObjecten
{
    class Student
    {
        public string Name { get; set; }
        private byte age;

        public byte Age
        {
            get { return age; }
            set
            {
                if (value > 120)
                    age = 120;
                else
                    age = value;
            }
        }

        public ClassGroups ClassGroup { get; set; }

        private byte markCommunication;

        public byte MarkCommunication
        {
            get { return markCommunication; }
            set
            {
                if (value > 20)
                    markCommunication = 20;
                else
                    markCommunication = value;
            }
        }

        private byte markProgrammingPrinciples;

        public byte MarkProgrammingPrinciples
        {
            get { return markProgrammingPrinciples; }
            set
            {
                if (value > 20)
                    markProgrammingPrinciples = 20;
                else
                    markProgrammingPrinciples = value;
            }
        }

        private byte markWebTech;

        public byte MarkWebTech
        {
            get { return markWebTech; }
            set
            {
                if (value > 20)
                    markWebTech = 20;
                else
                    markWebTech = value;
            }
        }

        private double overallMark;

        public double OverallMark
        {
            get { return (MarkWebTech + MarkProgrammingPrinciples + MarkCommunication) / 3.0; }

        }

        public void ShowOverview()
        {
            Console.WriteLine($"{this.Name}, {this.Age} years");
            Console.WriteLine($"Class: {this.ClassGroup}");
            Console.WriteLine($"");
            Console.WriteLine($"Grades:");
            Console.WriteLine("********");
            Console.WriteLine($"Communiation:\t\t{this.MarkCommunication}");
            Console.WriteLine($"Programming Principles:\t{this.MarkProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:\t\t{this.MarkWebTech}");
            Console.WriteLine($"Average:\t\t{this.OverallMark}");
        }

        public static void Main()
        {
            Console.Clear();

            Student student1 = new Student();
            student1.ClassGroup = ClassGroups.EA2;
            student1.Age = 21;
            student1.Name = "Joske Vermeulen";
            student1.MarkCommunication = 12;
            student1.MarkProgrammingPrinciples = 15;
            student1.MarkWebTech = 13;
            student1.ShowOverview();



            Console.ReadKey();
        }
    }
}
