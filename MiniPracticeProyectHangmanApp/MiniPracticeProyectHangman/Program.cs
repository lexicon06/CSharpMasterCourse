using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPracticeProyectHangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    interface IGameDictionary
    {
        string Word { get; set; }
        int Len { get; set; }
    }


    internal class GameDictionary : IGameDictionary
    {

        public string Word { get; set; }
        public int Len { get; set; }
    }

    internal class GameLogic
    {

    }

    public class RandomWords
    {
        internal List<string> slangs = new List<string> { "ADD", "WORDS" };
      
    }

    public class GetWord : RandomWords
    {
        private List<GameDictionary> words = new List<GameDictionary>();

        public GetWord()
        {
            //we have to populate our words list with random word maybe indeed we don't need a list at all probably but still we're gonna get it
        }
    }



    public class Player
    {
        public  string Name { get; set; }
        public bool IsPlaying { get; set; }
    }
}
