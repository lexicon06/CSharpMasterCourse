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

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                DisplayShotGrid(activePlayer);

                // Display grid from player 1 on where they fired
                // Ask player 1 for a shot
                // Determine if it is a valid shot
                RecordPlayerShot(activePlayer, opponent);
                // Determine shot results
                // Determine if the game is over
                // If over, set player1 as the winner 
                // else swap positions (activePlayer to opponent)
            } while (winner == null);

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

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }
                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.WriteLine($" {gridSpot.SpotLetter}{gridSpot.SpotNumber}");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.WriteLine(" X ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.WriteLine(" O ");
                }
                else
                {
                    Console.WriteLine(" ? ");
                }
            }
        }

        private static void RecordPlayerShot(PlayerInfoModel p1, PlayerInfoModel p2)
        {

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
