using System;
using System.Net;
using System.IO;

class Program
{
    static void Main()
    {
        string[] urls = File.ReadAllLines("C:\\Users\\Foxhound\\source\\repos\\ImageDownloaderGif\\ImageDownloaderGif\\urls.txt");

        using (WebClient client = new WebClient())
        {
            foreach (string url in urls)
            {
                string fileName = Path.GetFileName(new Uri(url).AbsolutePath);
                client.DownloadFile(url, fileName);
                Console.WriteLine($"Downloaded {fileName}");
            }

            Console.ReadLine();
        }
    }
}
