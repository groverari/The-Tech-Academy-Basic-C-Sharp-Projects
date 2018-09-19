using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    { 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name?");
            string playerName = Console.ReadLine();
            if(playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Number);
                    Console.Write(exception.ExceptionType);
                    Console.Write(exception.ExceptionType);
                    Console.Write(exception.TimeStamp);
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("only enter numbers and no decimals");
                    
                }
            }
            Console.WriteLine("Would you like to play a game of 21 right now");
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes"||answer =="yeah"|| answer == "y"||answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something is wrong contact an administrtor");
                        UpdateDbWithException(ex);
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank You for playing");
            }
            Console.WriteLine("Feel free to look around. By for now");
            Console.ReadLine();

        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                                      "Initial Catalog=TwentyOneGame;Integrated" +
                                      " Security=True;Connect Timeout=30;Encrypt=False;" +
                                      "TrustServerCertificate=False;ApplicationIntent=" +
                                      "ReadWrite;MultiSubnetFailover=False";
            string querryString = "INSERT into Exceptions (ExceptionType, ExceptionMessage, TimeStamp) Values" +
                                    "(@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                                      "Initial Catalog=TwentyOneGame;Integrated" +
                                      " Security=True;Connect Timeout=30;Encrypt=False;" +
                                      "TrustServerCertificate=False;ApplicationIntent=" +
                                      "ReadWrite;MultiSubnetFailover=False";
            string queryString = "@Select Number, ExceptionType, ExceptionMesssage, TimeStamp From Exceptions";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Number = Convert.ToInt32(reader["Number"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
