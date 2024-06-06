using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> notes = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Uusi muistiinpano");
            Console.WriteLine("2. Tulosta muistiinpanot");
            Console.WriteLine("3. Tyhjennä muistiinpanot");
            Console.WriteLine("4. Lopeta");

            Console.Write("Valitse komento: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNote(notes);
                    break;
                case 2:
                    PrintNotes(notes);
                    break;
                case 3:
                    ClearNotes(notes);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddNote(List<string> notes)
    {
        Console.Write("Enter your note: ");
        string note = Console.ReadLine();
        notes.Add(note);
        File.WriteAllLines("notes.txt", notes);
    }

    static void PrintNotes(List<string> notes)
    {
        if (!File.Exists("notes.txt"))
        {
            Console.WriteLine("No notes found.");
        }
        else
        {
            string[] lines = File.ReadAllLines("notes.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }

    static void ClearNotes(List<string> notes)
    {
        if (!File.Exists("notes.txt"))
        {
            Console.WriteLine("No notes found.");
        }
        else
        {
            notes.Clear();
            File.WriteAllLines("notes.txt", notes);
        }
    }
}