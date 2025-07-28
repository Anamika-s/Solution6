namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"C:\users\anami\test.txt");
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("Line1");
            writer.WriteLine("Line2");
            writer.Close();
            fs.Close();

            fs = fi.Open(FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string str = reader.ReadLine();
            while (str != null)
            {
                {
                    Console.WriteLine(str);
                    str = reader.ReadLine();
                }
            }
                reader.Close();
                fs.Close();

            fs = fi.Open(FileMode.Open, FileAccess.Read);
            reader = new StreamReader(fs);
            Console.WriteLine(reader.ReadToEnd());

            reader.Close();
            fs.Close();

            fs = fi.Open(FileMode.Open, FileAccess.Read);
            reader = new StreamReader(fs);
            
            while (reader.Peek() > 0)
            {
                Console.Write((char)reader.Read());
            }



            reader.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"C:\users\anami\practiceDemo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer1 = new StreamWriter(fs1);
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            writer1.WriteLine(name);
            Console.WriteLine("Enter Your Department");
            string dept = Console.ReadLine();
            writer1.WriteLine(dept);

            Console.WriteLine("To Read");
            writer1.Close();
            //fs1.Close();
            fs1 = new FileStream(@"C:\users\anami\practiceDemo.txt", FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fs1);
            Console.WriteLine(streamReader.ReadToEnd());

            //FileInfo f1 = new FileInfo(@"C:\users\anami\pr.txt");
            //if (f1.Exists)
            //{
            //    Console.WriteLine("file already exists");
            //}
            //else
            //    f1.Create();
             
            //f1.CopyTo(@"C:\users\anami\pr1.txt");
            //f1.Delete();


            //File.Create(@"C:\users\anami\p1.txt");
            //File.WriteAllText(@"C:\users\anami\p1.txt", "this is a ile");
            //File.Copy(@"C:\users\anami\p1.txt", @"C:\users\anami\p2.txt");
            //File.Delete(@"C:\users\anami\p1.txt");



            DirectoryInfo directory = new DirectoryInfo(@"C:\users\anami");
            //directory.Create("dir001");
            Console.WriteLine(directory.CreationTime);
            var dirs = from dir in
            Directory.EnumerateDirectories(@"C:\users\anami")
                       select dir;
            Console.WriteLine("Subdirectories: {0}", dirs.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }
            string root = @"C:\users\anami\training-contents";
            // Get a list of all subdirectories
            var files = from file in
            Directory.EnumerateFiles(root)
                        select file;
            Console.WriteLine("Files: {0}", files.Count<string>().ToString());
            Console.WriteLine("List of Files");
            foreach (var file in files)
            {
                Console.WriteLine("{0}", file);
            }

        }
    }

}