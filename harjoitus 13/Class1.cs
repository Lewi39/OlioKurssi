using harjoitus13;

class class1
{
    static void Main()
    {
        Team team = new Team();

        if (true)
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

            if (user.ToLower() == "kyllä")
            {
                Console.Write("Anna uuden joukkueen nimi: ");
                team.Team_Name = Console.ReadLine();

                if (string.IsNullOrEmpty(team.Team_Name))
                {
                    System.Environment.Exit(1);
                }

                bool List_Players = false;

                while (true)
                {
                    Console.Write("Lisää " + team.Team_Name + " joukkueelle pelaajia kyllä / ei ");
                    string Add_Players = Console.ReadLine();

                    if (string.IsNullOrEmpty(Add_Players) || Add_Players.ToLower() == "ei")
                    {
                        System.Environment.Exit(1);
                    }
                    else if (Add_Players.ToLower() == "kyllä")
                    {



                        Console.WriteLine("Lisää pelaajan etunimi: ");
                        string FN = Console.ReadLine();

                        if (string.IsNullOrEmpty(FN))
                        {
                            break;
                        }
                        else
                        {
                            Player player = new Player();
                            {
                                player.First_Name = FN;
                            }
                        }

                        Console.WriteLine("Pelaajan sukunimi: ");
                        string LN = Console.ReadLine();

                        if (string.IsNullOrEmpty(LN))
                        {
                            break;
                        }
                        else
                        {
                            Player player = new Player();
                            {
                                player.Last_Name = LN;
                            }
                        }


                        Console.WriteLine("Pelaajan pelinumero: ");
                        int PN = Convert.ToInt32(Console.Read());

                        if (int.IsNegative(PN) || PN <= 0 || PN >= 99)
                        {
                            break;
                        }
                        else
                        {
                            Player player = new Player();
                            {
                                player.Player_Number = PN;
                                team.AddPlayer(player, player.Player_Number);
                            }
                        }

                        Console.Write("Haluatko listan joukkueen pelaajista");
                        string User_lista = Console.ReadLine();

                        if (User_lista.ToLower() == "kyllä")
                        {
                            team.Print_Team_Players();
                            List_Players = true;
                        }
                        if (List_Players)
                        {
                            break;
                        }

                    }
                }
            }

        }

    }
}
