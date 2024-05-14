using harjoitus13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

class class1
{
    static void Main()
    {
        Team team = new Team();
        

        while (true)
        {
            if (true)
            {
                while (true)
                {
                    Console.Write("Haluatko lisätä uuden joukkueen Kyllä/ei     ");
                    string user = Console.ReadLine();
                    try
                    {
                        if (string.IsNullOrEmpty(user))
                        {
                            System.Environment.Exit(1);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("string.nullempty");
                    }
                    try
                    {
                        if (user.ToLower() == "ei")
                        {
                            System.Environment.Exit(1);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("ei");
                    }
                    try
                    {
                        if (user.ToLower() == "kyllä")
                        {
                            Console.Write("Anna uuden joukkueen nimi: ");
                            team.Team_Name = Console.ReadLine();
                        }
                        if (string.IsNullOrEmpty(user))
                        {
                            System.Environment.Exit(1);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("ei");
                    }

                    Console.ReadLine();
                    Console.Write("Lisää joukkueelle pelaajia kyllä / ei");
                    while (true)
                    {
                        Console.Write("Pelaajan etunimi: ");
                        string FN = Console.ReadLine();

                        if (FN.ToLower() == "ei" && FN.ToLower() == null)
                        {
                            break;
                        }

                        Player player = new Player();
                        {
                            player.First_Name = FN;
                        }
                        Console.WriteLine("Pelaajan sukunimi: ");
                        string LN = Console.ReadLine();
                        player.Last_Name = LN;

                        Console.WriteLine("Pelaajan pelinumero: ");
                        int PN = Convert.ToInt32(Console.Read());
                        player.Player_Number = PN;
                        team.AddPlayer(player, player.Player_Number);
                        team.Print_Team_Players();
                    }
                    Console.WriteLine("Joukkueen pelaajat: ");
                }                
            }
        }
    }
}
