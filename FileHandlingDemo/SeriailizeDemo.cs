using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LinqDemo
{
   
    class SeriailizeDemo1
    {
        static void Main()
        {
            FileStream stream = new FileStream("C:\\users\\anami\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student(101, "sonoo");
            formatter.Serialize(stream, s);

            stream.Close();

        }
    }
}
