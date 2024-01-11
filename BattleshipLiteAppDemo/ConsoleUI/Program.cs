using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

namespace ConsoleUI
{
    public class Program
    {
        static void Main()
        {
            WelcomeMessage();

            PlayerInfoModel Player1 = CreatePlayer("Player 1");
            PlayerInfoModel Player2 = CreatePlayer("Player 2");

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Console Game");
            Console.WriteLine("Created by Pablo Santillan");
            Console.WriteLine("");
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            //Ask user for their name
            output.UsersName = AskForUsersName();
            //Load up the shot grid
            GameLogic.InitializeGrid(output);

            //Ask the user for their 5 placements
            PlaceShips(output);

            //Clear
            Console.Clear();

            return output;

        }

        private static string AskForUsersName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }


        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();
                bool isValidLocation = GameLogic.StoreShip(model, location);

                if (!isValidLocation)
                {
                    Console.WriteLine("That is not a valid location. Please try again.");
                }

            } while (model.ShipLocations.Count < 5);
        }

        //static void Main(string[] args)
        //{
        //    WelcomePlayers();
        //    bool KeepRunning = true;

        //    do
        //    {
        //        try
        //        {
        //            string Spot = SpotInput("Please enter your spot");
        //            Console.WriteLine($"You just have entered {Spot}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //        try
        //        {
        //            KeepRunning = WannaPlay();

        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    } while (KeepRunning);
        //    Console.ReadLine();
        //}

        //public static string SpotInput(string inputMsg)
        //{
        //    Console.WriteLine(inputMsg);
        //    string output = Console.ReadLine();

        //    if (output.Length != 2)
        //    {
        //        throw new ArgumentException("Invalid input, make sure you enter a valid position such as b2");
        //    }
        //    else if (!char.IsLetter(output[0]) || !char.IsDigit(output[1]))
        //    {
        //        throw new ArgumentException("Invalid position, make sure your pos is correct");
        //    }

        //    return output;
        //}

        //private static void WelcomePlayers()
        //{
        //    Console.WriteLine("Battleship game v1.0 Console Game");
        //}

        //private static void DisplayGrid()
        //{
        //    //grid here
        //}

        //private static bool WannaPlay()
        //{
        //    string userInput = Console.ReadLine();
        //    Console.WriteLine("Wanna play? yes/no");
        //    if (userInput.ToLower() == "yes" || userInput.ToLower() == "no")
        //    {

        //        return userInput.ToLower() == "yes";
        //    }
        //    else
        //    {
        //        throw new InvalidDataException("Bad input the value must be only yes or no");
        //    }
        //}
    }
}
