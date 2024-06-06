using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    internal class Album
    {
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Albumi { get; set; }
        public String Length { get; set; }
        public List<Song> Songs { get; set; }

        public Album() 
        {
            Songs = new List<Song>();
        }

        //Tulostaa albumin datan
        public void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi: - " + Albumi);
            Console.WriteLine("--Artisti: - " + Artist);
            Console.WriteLine("--Genre: - " + Genre);
            Console.WriteLine();
            Console.WriteLine("Songs: ");
            Console.WriteLine();
            //Käy kaiken listan datan lävitse kerran ja tallentaa sen Printdataan
            foreach (var song in Songs)
            {
                Console.WriteLine("--- " + song.Songg + " - " + song.Lengthh);
                Console.WriteLine();
            }
        }

        public void AddSongs(Song Song)
        {
            Songs.Add(Song);
        }
        }

    }
   



    

