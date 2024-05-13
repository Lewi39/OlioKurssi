using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace t13
{
    class Player
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int player_number { get; set; }
    }

    class team
    {
        public string name { get; set; }
        public string city { get; set; }

        private Dictionary<int, Player> players = new Dictionary<int, Player>();

        public Player GetPlayer(int id)
        {
            if (players.ContainsKey(id)) 
            {
                return players[id]; 
            }
            else
            {
                throw new KeyNotFoundException("Numerolla ei löydy pelaajaa " + id);
            }
        }
        public void addplayer(Player player)
        {
            if (!players.ContainsKey(player.player_number))
            {
                players.Add(player.player_number, player);
            }
            else
            {
                Console.WriteLine($"Numerolla [player] löytyi pelaaja: ");
            }
        }

        public void removeplayer(int id)
        {
            if (players.ContainsKey(id))
            {
                players.Remove(id);
            }
            else { throw new KeyNotFoundException("Numerolle ei löydy pelaajaa" + id);  }
        }

        public void updatePlayerName(int playerId, string newFirstName, string newLastName)
        {
            Player playerToUpdate = GetPlayer(playerId);
            if (playerToUpdate != null)
            {
                playerToUpdate.first_name = newFirstName;
                playerToUpdate.last_name = newLastName;
                Console.WriteLine("Pelaajan nimi päivitetty.");
            }
            else
            {
                throw new Exception("Pelaajaa ei löytynyt annetulla pelaajanumerolla.");
            }
        }

        public List<Player> GetPlayers()
        {
            return new List<Player>(players.Values);
        }

    }
}

