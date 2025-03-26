using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Dictionarydemo
    {
        Dictionary<string, string> studentDict = new Dictionary<string, string>();

        public void addStudents()
        {
            studentDict["name"] = "Aman";
            studentDict["course"] = "BCA";
            studentDict.Add("sem", "5");
            studentDict.Add("age", "21");

            foreach(string val in studentDict.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
            foreach(string key in studentDict.Keys)
            {
                Console.WriteLine(key + ":" + studentDict[key]);
            }
            Console.WriteLine();
            foreach(var student in studentDict)
            {
                Console.WriteLine(student.Key + ":" + student.Value);
            }
        }
    }
}
