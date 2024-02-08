using System;

namespace FileStreamPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            //string filePath = "C:\\Users\\a.arabuli\\Desktop\\FileStream.txt";

            //using(FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            //{
            //    byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello");
            //    fs.Write(data, 0, data.Length);
            //}

            //using (FileStream fs = new FileStream(filePath, FileMode.Open))
            //{
            //    byte[] buffer = new byte[1024];
            //    int bytesToRead = fs.Read(buffer, 0, buffer.Length);
            //    string content = System.Text.Encoding.UTF8.GetString(buffer,0,bytesToRead);
            //    Console.WriteLine($"File content: {content}");
            //}

            //using(StreamReader sr = new StreamReader(filePath))
            //{
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}

            //using (StreamWriter sr = new StreamWriter(filePath))
            //{
            //    sr.WriteLine("Test");
            //}
            #endregion

            #region MemoryStream
            //byte[] initialData = { 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7 };

            //using (MemoryStream ms = new MemoryStream(initialData))
            //{
            //    ms.Seek(0, SeekOrigin.Begin);
            //    byte[] buffer = new byte[ms.Length];

            //    ms.Read(buffer, 0, (int)ms.Length);
            //    Console.WriteLine($"Initial data {BitConverter.ToString(buffer)}");

            //    ms.Seek(0, SeekOrigin.Begin);
            //    byte[] newData = { 0x6, 0x7, 0x8 };
            //    ms.Write(newData, 0, newData.Length);

            //    ms.Seek(0, SeekOrigin.Begin);
            //    buffer = new byte[ms.Length];
            //    ms.Read(buffer, 0, (int)ms.Length);
            //    Console.WriteLine($"Initial data {BitConverter.ToString(buffer)}");
            //}

                  /* 
                  1A3F = (1 * 16^3) + (10 * 16^2) + (3 * 16^1) + (15 * 16^0)
                  = (1 * 4096) + (10 * 256) + (3 * 16) + (15 * 1)
                  = 4096 + 2560 + 48 + 15
                  = 6719
                  */
                  // 0 - 9 A-F
            #endregion

            #region BufferedStream

            string filePath = "C:\\Users\\a.arabuli\\Desktop\\FileStream.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            using (BufferedStream bfs = new BufferedStream(fs))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Strnig hello world");
                bfs.Write(data, 0, data.Length);

                bfs.Flush();

                bfs.Seek(0, SeekOrigin.Begin);
                byte[] buffer = new byte[1024];
                int bytesRead = bfs.Read(buffer, 0, buffer.Length);

                string content = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);

                Console.WriteLine(content);
            }


            #endregion
        }
    }
}