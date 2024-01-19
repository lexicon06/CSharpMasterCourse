using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
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

                RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue)
                {
                    //swap pos
                    (activePlayer, opponent) = (opponent, activePlayer);
                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);

            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Gratz to {winner.UsersName} for winning!");
            Console.WriteLine($"{winner.UsersName} took {GameLogic.GetShotCount(winner)} shots.");
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

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;
            do
            {
                string shot = AskForShot();
                (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                isValidShot = GameLogic.ValidateShot(activePlayer, row, column);

                if (!isValidShot)
                {
                    Console.WriteLine("Please enter a valid shot.");
                }


            } while (!isValidShot);

            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

        }

        private static string AskForShot()
        {
            Console.WriteLine($"Please enter your shot selection");
            string output = Console.ReadLine();
            return output;
        }
    }
}
