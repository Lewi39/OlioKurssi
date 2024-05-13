using harjoitus13;
using System;
using System.Collections.Generic;
using System.Linq;
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
                try
                {
                    Console.WriteLine("Anna uuden joukkueen nimi: ");
                    team.Team_Name = Console.ReadLine();

                    Console.WriteLine("Lisää joukkueelle pelaajia (Paina 'q' lopettaaksesi");
                    while (true)
                    {
                        Console.WriteLine("Pelaajan etunimi: ");
                        string FN = Console.ReadLine();

                        if (FN.ToLower() == "q")
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
                        int PN = Convert.ToInt32(Console.ReadLine());
                        player.Player_Number = PN;
                        team.AddPlayer(player, player.Player_Number);
                    }
                    Console.WriteLine("Joukkueen pelaajat: ");
                    team.Print_Team_Players();
                }
                catch 
                {
                    Console.WriteLine("Line 19 Try");
                }
            }
        }
    }
}
