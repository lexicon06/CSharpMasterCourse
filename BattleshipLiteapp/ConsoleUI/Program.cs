using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO https://onedrive.live.com/view.aspx?resid=A97DBB57FDE9FA86%2116216&id=documents

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] gamePieces = new string[] { "🚢", "💣", "🔷" };
            
            foreach(string piece in gamePieces)
            {
                Console.WriteLine(piece);
            }

            Console.ReadLine();
        }
    }
}
