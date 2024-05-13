using System;

namespace t13
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Lisää pelaajan nimi: ");

            string UserInput_First; UserInput_First = Console.ReadLine();

            Console.Write("Lisää pelaajan sukunimi: ");

            string UserInput_Last;  UserInput_Last = Console.ReadLine();
            
            Console.Write("Lisää pelaajan pelinumero: ");

            int UserInput_number; UserInput_number = Int32.Parse(Console.ReadLine());



            team team = new team
            {
                name = "nimi",
                city = "Vantaa"
            };

            try
            {
                Player[] players = new Player[5];
                for (int i = 0; i < 5; i++)
                {


                    if (UserInput_First != null && UserInput_Last!=null)
                    {
                        players[i] = new Player 
                        { 
                            first_name = UserInput_First,
                            last_name = UserInput_Last,
                            player_number = UserInput_number 

                            
                        };
                        while (true)
                        {
                            if (players[1] == null)
                            {
                                Console.ReadLine();
                            }
                        }
                    }
                    team.addplayer(players[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            
           
            try
            {
                Player gotplayer = team.GetPlayer(1);
                Console.WriteLine("Haettu pelaaja oli " + gotplayer.first_name + " " + gotplayer.last_name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Player gotplayer = team.GetPlayer(2);
                Console.WriteLine("Haettu pelaaja oli " + gotplayer.first_name + " " + gotplayer.last_name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Lisää pelaajan numero, jota päivittää: ");
                int playerNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Lisää uusi etunimi: ");
                string newFirstName = Console.ReadLine();

                Console.WriteLine("Lisää uusi sukunimi: ");
                string newLastName = Console.ReadLine();

                team.updatePlayerName(playerNumber, newFirstName, newLastName);

                Player updatedPlayer = team.GetPlayer(playerNumber);
                Console.WriteLine("Pelaajan nimi päivitetty: " + updatedPlayer.first_name + " " + updatedPlayer.last_name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}