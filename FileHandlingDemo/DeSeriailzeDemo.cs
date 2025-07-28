using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LinqDemo
{
    
    class DeSeriailzeDemo
    {
        static void Main()
        {
            FileStream stream = new FileStream("C:\\users\\anami\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
}
