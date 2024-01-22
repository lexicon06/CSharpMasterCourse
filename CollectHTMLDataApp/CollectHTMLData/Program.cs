using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var doc = new HtmlDocument();
        doc.Load("C:\\Users\\Foxhound\\source\\repos\\CollectHTMLDataApp\\CollectHTMLData\\file.html"); // replace with your file path

        var imgNodes = doc.DocumentNode.SelectNodes("//img");

        if (imgNodes == null)
        {
            Console.WriteLine("No img tags found.");
            return;
        }

        List<string> ids = new List<string>();
        List<string> srcs = new List<string>();

        foreach (var img in imgNodes)
        {
            var id = img.GetAttributeValue("id", "");
            var src = img.GetAttributeValue("src", "");

            ids.Add(id);
            srcs.Add($"\"{src}\", ");
        }


        File.WriteAllLines("C:\\Users\\Foxhound\\source\\repos\\CollectHTMLDataApp\\CollectHTMLData\\srcs.txt", srcs);



        Console.ReadLine();
    }
}
