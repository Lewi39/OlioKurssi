using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace harjoitus13
{
    public class Player
    {
        public string First_Name {  get; set; }
        public string Last_Name { get; set;}
        public int Player_Number { get; set; }
        public void Print_Player()
        {
            Console.WriteLine("Etunimi: " + First_Name + " Sukunimi: " + Last_Name +" Pelinumero: "+ Player_Number);
        }
    }
    class Team
    {
        public string Team_Name { get; set; }
        public string Home_City { get; set; }

        public Dictionary<int, Player> Playing_4_Team = new Dictionary<int, Player>();
        public void AddPlayer(Player player, int Player_Number)
        {
            Playing_4_Team.Add(Player_Number, player);  
        }

        public void Print_Team_Players()
        {
            Console.WriteLine("Pelaajat tiimissä: " + Team_Name + " " + Home_City + ";");

            foreach (var player in Playing_4_Team)
            {
                Console.WriteLine("Pelinumero: " + player.Key +
                   ", nimi: " + player.Value.First_Name + " " + player.Value.Last_Name);
            }
        }


    }
}