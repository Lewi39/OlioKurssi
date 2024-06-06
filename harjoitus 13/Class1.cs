using harjoitus13;

class class1
{
    static void Main()
    {
        Team team = new Team();


        while (true)
        {
            if (team.Team_Name != null)
            {
                break;
            }
            Console.Write("Haluatko lisätä uuden joukkueen Kyllä/ei     ");
            string user = Console.ReadLine();

            //jos käyttäjä ei anna syötettä sulkeutuu ohjelma 
            if (string.IsNullOrEmpty(user))
            {
                System.Environment.Exit(1);
            }

            //jos käyttäjän syöte on ei ohjelma sulkeutuu
            if (user.ToLower() == "ei")
            {
                System.Environment.Exit(1);
            }

            // jos käyttäjän syöte on kyllä kysytään tältä uuden joukkueen nimeä
            else if (user.ToLower() == "kyllä")
            {

                Console.Write("Anna uuden joukkueen nimi: ");
                team.Team_Name = Console.ReadLine();

                // jos käyttäjän syöte on tyhjä ohjelma sulkeutuu
                if (string.IsNullOrEmpty(team.Team_Name))
                {
                    System.Environment.Exit(1);
                }
                // käyttäjän syöte kaupungille
                Console.Write("Anna joukkueen " + team.Team_Name + " Kotikaupunki   ");
                team.Home_City = Console.ReadLine();

                if (string.IsNullOrEmpty(team.Home_City))
                {
                    System.Environment.Exit(1);
                }


                while (true)
                {
                    Console.Write("Lisää joukkueelle pelaajia kyllä / ei   ");
                    string User_Add_Players = Console.ReadLine();

                    // jos käyttäjän syöte on tyhjä ohjelma sulkeutuu
                    if (string.IsNullOrEmpty(User_Add_Players) && User_Add_Players.ToLower() == "ei")
                    {
                        break;
                    }

                    // jos käyttäjän syöte on ei ohjelma sulkeutuu
                    if (User_Add_Players.ToLower() == "ei" || (string.IsNullOrEmpty(User_Add_Players)) && team.Print_Team_Players != null)
                    {
                        team.Print_Team_Players();
                    }


                    // jos käyttäjän syöte on kyllä kysytään tältä uuden pelaajan tiedot ja pelaaja lisätään joukkueeseen


                    else if (User_Add_Players.ToLower() == "kyllä")
                    {
                        Player player = new Player();


                        Console.Write("Anna uuden pelaajan etunimi: ");
                        string FN = Console.ReadLine();


                        if (string.IsNullOrEmpty(FN))
                        {
                            break;
                        }

                        player.First_Name = FN;

                        Console.Write("Pelaajan sukunimi: ");
                        string LN = Console.ReadLine();
                        if (string.IsNullOrEmpty(LN))
                        {
                            break;
                        }

                        player.Last_Name = LN;

                        Console.Write("Pelaajan pelinumero: ");
                        int PN = Convert.ToInt32(Console.ReadLine());
                        player.Player_Number = PN;

                        team.AddPlayer(player, player.Player_Number);

                        Console.Write("Haluatko listan " + team.Team_Name + " pelaajista kyllä / ei  ");
                        string User_players = Console.ReadLine();
                        if (User_players.ToLower() == "kyllä")
                        {
                            // tulostaa joukkueen pelaajat
                            team.Print_Team_Players();

                            Console.Write("Haluatko poistaa pelaajan joukkueesta kyllä/ei   ");
                            string User_Remove = Console.ReadLine();
                            if (User_Remove.ToLower() == "ei" || (string.IsNullOrEmpty(User_Remove)))
                            {
                                break;
                            }

                            if (User_Remove.ToLower() == "kyllä")
                            {
                                Console.Write("Anna pelaajan pelinumero: ");
                                int PN1 = Convert.ToInt32(Console.ReadLine());
                                if (team.Playing_4_Team.ContainsKey(PN1))
                                {
                                    team.Playing_4_Team.Remove(PN1);
                                    Console.WriteLine("Pelaaja poistettu");
                                }
                                else
                                {
                                    Console.WriteLine("Pelaajaa ei löydetty");
                                }
                                team.Print_Team_Players();  
                                break;
                            }

                        }
                    }
                }
            }
        }
    }

}
