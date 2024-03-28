using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Luodaan uusi olio ja annetaan arvot 
            Album album = new Album();

            album.Albumi = "Kostolom";

            album.Artist = "Slaughter To Prevail";

            album.Genre = "Deathcore";

            album.Artist = "Slaughter To Prevail";

            //Luodaan uusi olio ja annetaan arvot, jotka tallentuvat suoraan "Songs" listaan
            Song song1 = new Song("Bonebreaker", "4:25");
            album.AddSongs(song1);

            Song song2 = new Song("Demolisher", "3:36");
            album.AddSongs(song2);

            Song song3 = new Song("Baba Yaga", "4:15");
            album.AddSongs(song3);

            Song song4 = new Song("Made In Russia", "3:55");
            album.AddSongs(song4);

            Song song5 = new Song("Zavali Ebalo", "3:51");
            album.AddSongs(song5);

            Song song6 = new Song("Agony", "3:57");
            album.AddSongs(song6);

            Song song7 = new Song("Your Only", "3:53");
            album.AddSongs(song7);

            Song song8 = new Song("I Killed A Man", "3:53");
            album.AddSongs(song8);

            Song song9 = new Song("Bratva", "4:50");
            album.AddSongs(song9);

            Song song10 = new Song("Ouroboros", "3:51");
            album.AddSongs(song10);

            Song song11 = new Song("Head On A Plate", "4:28");
            album.AddSongs(song11);

            Song song12 = new Song("Father", "3:55");
            album.AddSongs(song12);

            album.PrintData();

            Console.ReadLine();
        }
    }
}
