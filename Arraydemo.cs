using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Arraydemo
    {
        string[] myArray = { "a", "b" };
        int[] numbers = { 1, 2, 3, 4, 5 };
        string[] students = { "Aman", "Jenesis", "Sagar" };
        string[] students1 = new string[5];

        //List
        List<string> studentList = new List<string>();
        public void addStudents()
        {
            students1[0] = "Bishal"; 
            students1[1] = "Bishes"; 
            students1[2] = "Bastabik";

            studentList.Add("Sujan");
            studentList.Add("Sujit");
            studentList.Add("Simon");
            studentList.Add("Sudip");
        }


        public void displayStudents()
        {
            Console.WriteLine(students[1]);
            Console.WriteLine();

            for(int i=0; i<students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine();
            
            for(int i=0; i<studentList.Count; i++) //for loop for List
            {
                Console.WriteLine(studentList[i]);
            }

            Console.WriteLine();
            
            for(int i=0; i<students1.Length; i++) //for loop for List
            {
                Console.WriteLine(students1[i]);
            }

            Console.WriteLine();

            foreach(string student in students) //foreach(type varname in arrayname)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            foreach(string student in studentList) //for each for List
            {
                Console.WriteLine(student);
            }
        }

        public void percentage()
        {
            Console.WriteLine("Please enter the number of subjects.");
            int subject = int.Parse(Console.ReadLine());

            string[] subjectNames = new string[subject]; //array to store name of subjects with size given by user.
            float[] marks = new float[subject]; //array to store marks of subject.
            float total = subject*100;
            float obtainedMarks=0, percentage;

            for(int i=0; i<subject; i++)
            {
                Console.WriteLine("Enter the name of subject {0}", i + 1);
                subjectNames[i] = Console.ReadLine();

                Console.WriteLine("Enter the marks for {0}", subjectNames[i]);
                marks[i] = float.Parse(Console.ReadLine());

                obtainedMarks += marks[i];
            }
            percentage = obtainedMarks/total*100;

            Console.WriteLine("\nThe result is:\n");

            for(int i=0; i<subject; i++)
            {
                Console.WriteLine("{0} : {1} marks", subjectNames[i], marks[i]);
            }
            Console.WriteLine("Total marks:{0}", total);
            Console.WriteLine("Obtained marks:{0}", obtainedMarks);
            Console.WriteLine("Percentage:{0:F2}%", percentage);


        }

    }
}
