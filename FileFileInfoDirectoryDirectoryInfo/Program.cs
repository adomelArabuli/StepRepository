namespace FileFileInfoDirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File, FileInfo classes

            //File.Create("C:\\Users\\a.arabuli\\Desktop\\test.txt");

            //FileInfo fileInfo = new FileInfo("C:\\Users\\a.arabuli\\Desktop\\test.txt");

            //fileInfo.Open(FileMode.Open);

            //Console.WriteLine($"The name of file is: {fileInfo.Name}");
            //Console.WriteLine($"The extension of file is: {fileInfo.Extension}");
            //Console.WriteLine($"The size of file is: {fileInfo.Length} in bytes");

            //string content = File.ReadAllText(fileInfo.FullName);
            //Console.WriteLine(content);

            //Directory, DirectoryInfo classes


            //DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\a.arabuli\\Desktop");

            //FileInfo[] files = directoryInfo.GetFiles();
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file.Name);
            //}

            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\a.arabuli\\Desktop\\");
            FileInfo newFile = new FileInfo(Path.Combine(directoryInfo.FullName, "NewFile.txt"));

            if(!newFile.Exists)
            {
                using(StreamWriter sw = newFile.CreateText())
                {
                    sw.WriteLine("Hi");
                }

                Console.WriteLine("File created successfully");
            }
            else
            {
                Console.WriteLine("File already exist");
            }

        }
    }
}