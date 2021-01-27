using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _86_Tic_Tac_Toe_game
{
    class Program
    {

        // declare the playfield as a 2Darray 
        // we will replace thesenumbers in game play
        static char[,] playField =
        {
            {'1','2','3'},
            { '4','5','6'},
            {'7','8','9' }
        };

     

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            
            //set user input to 0
            int input = 0;

            // check if right input has been made by user
            bool inputCorrect = true;

           

            /////////// this do while loop checks to see which player comes up next
                do
                { 
                        // check for player and switch players/
                        // if current player is player 2 switch to player 1
                         if (player == 2)
                        {
                            player = 1;
                            EnterXorO(player, input);

                        }
                        // or if current player is 1 switch to player 2
                        else if (player == 1)
                        {
                            player = 2;
                            EnterXorO(player, input);
                        }


                        //set field 
                        SetFields();

                #region
                // check winning condition

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)

                {
                    if (

                        ((playField[0,0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) ||

                         ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1,2] == playerChar)) ||

                          ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)) ||

                           ((playField[0, 0] == playerChar) && (playField[1,0] == playerChar) && (playField[2, 0] == playerChar)) ||

                            ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2,1] == playerChar)) ||

                             ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)) ||

                              ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar)) ||

                               ((playField[0,2] == playerChar) && (playField[1,1] == playerChar) && (playField[2, 0] == playerChar))
                    )

                    {

                        if (playerChar == 'X')
                        {
                            Console.WriteLine("We have a winner!");
                        }

                        else
                        {
                            Console.WriteLine("\n Player 1 has won!");
                        }

                        Console.WriteLine("Please press any key to rest the game!");
                        Console.ReadKey();

                        resetFields();

                        break;
                    }

                    else if (turns == 10)
                    {
                        Console.WriteLine("\n It's a Draw!");
                        Console.WriteLine("Please press any key to rest the game!");
                        Console.ReadKey();

                        resetFields();

                        break;
                    }
                }

                #endregion

                #region
                // region tests if field is taken
                // check do while loop as long as the input is incoreect try again
                do
                {
                    Console.WriteLine("\nPlayer {0}: Choose your field! ", player);

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        { inputCorrect = true; }

                    else if ((input == 2) && (playField[0, 1] == '2'))
                { inputCorrect = true; }

                else if ((input == 3) && (playField[0, 2] == '3'))
                { inputCorrect = true; }

                else if ((input == 4) && (playField[1, 0] == '4'))
                { inputCorrect = true; }

                else if ((input == 5) && (playField[1, 1] == '5'))
                { inputCorrect = true; }

                else if ((input == 6) && (playField[1, 2] == '6'))
                { inputCorrect = true; }

                else if ((input == 7) && (playField[2, 0] == '7'))
                { inputCorrect = true; }

                else if ((input == 8) && (playField[2, 1] == '8'))
                { inputCorrect = true; }

                else if ((input == 9) && (playField[2, 2] == '9'))
                { inputCorrect = true; }

                else
                {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputCorrect = false;
                }



            } while (!inputCorrect);
                #endregion

            } while (true);

         


        }

        public static void resetFields()
        {

           char[,] playFieldInitial =
   {
            {'1','2','3'},
            { '4','5','6'},
            {'7','8','9' }
        };
            playField = playFieldInitial;
            SetFields();
            turns = 0;

        }


        public static void SetFields()
            {
                Console.Clear();

                Console.WriteLine("     |       |       ");
                Console.WriteLine("  {0}  |   {1}   |  {2}  ", playField[0,0], playField[0, 1], playField[0, 2]);
                Console.WriteLine("_____________________");
                Console.WriteLine("                     ");
                Console.WriteLine("     |       |       ");
                Console.WriteLine("  {0}  |   {1}   |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
                Console.WriteLine("     |       |       ");
                Console.WriteLine("_____________________");
                Console.WriteLine("                     ");
                Console.WriteLine("     |       |       ");
                Console.WriteLine("  {0}  |   {1}   |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
                Console.WriteLine("     |       |       ");
                Console.WriteLine("                     ");
            turns++;
        }



        // check input and enter input
        // need to use another switch statement
        public static void EnterXorO(int player, int input)
        {

           

            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'X';
            }

            else if (player == 2)
            {

                playerSign = 'O';
            }

                 
              switch (input)
                      {

                            case 1: playField[0, 0] = playerSign; break;
                            case 2: playField[0, 1] = playerSign; break;
                            case 3: playField[0, 2] = playerSign; break;
                            case 4: playField[1, 0] = playerSign; break;
                            case 5: playField[1, 1] = playerSign; break;
                            case 6: playField[1, 2] = playerSign; break;
                            case 7: playField[2, 0] = playerSign; break;
                            case 8: playField[2, 1] = playerSign; break;
                            case 9: playField[2, 2] = playerSign; break;
                        }          
                   
             
  
        }
          
    }
}
