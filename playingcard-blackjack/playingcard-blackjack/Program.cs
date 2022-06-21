using System;

namespace playingcard_blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int contor_player_1 = 0;
            int contor_player_2 = 0;
            Console.WriteLine("Jucator 1:");
            Console.WriteLine("Trage carti pana ai minim 15 puncte!");
            while (contor_player_1 < 21)
            {
                Card card = new Card(i);
                card.Display();
                int card_value = card.Card_Value(i);
                if (card_value == 11)
                {
                    if ((contor_player_1 + 11) > 21)
                    {
                        contor_player_1 += 1;
                    }
                    else
                    {
                        contor_player_1 += card_value;
                    }
                }
                else
                {
                    contor_player_1 += card_value;
                }
                i++;
                if (contor_player_1 > 14 && contor_player_1 < 21)
                {
                    Console.WriteLine("Jucatorul 1 are {0} puncte", contor_player_1);
                    Console.WriteLine("Doresti sa tragi mai multe carti?");
                    Console.WriteLine("Scrie Yes sau No.");
                    string decision = Console.ReadLine();
                    if (decision == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Jucatorul 1 are {0} puncte", contor_player_1);
                }
            }
            Console.WriteLine("Jucatorul 2:");
            Console.WriteLine("Trage carti pana ai minim 15 puncte!");
            while (contor_player_2 < 21)
            {
                Card card = new Card(i);
                card.Display();
                int card_value = card.Card_Value(i);
                if (card_value == 11)
                {
                    if ((contor_player_2 + 11) > 21)
                    {
                        contor_player_2 += 1;
                    }
                    else
                    {
                        contor_player_2 += card_value;
                    }
                }
                else
                {
                    contor_player_2 += card_value;
                }
                i++;
                if (contor_player_2 > 14 && contor_player_2 < 21)
                {
                    Console.WriteLine("Jucatorul 2 are {0} puncte", contor_player_2);
                    Console.WriteLine("Doresti mai multe carti?");
                    Console.WriteLine("Scrie Yes sau No.");
                    string decision = Console.ReadLine();
                    if (decision == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Jucatorul 2 are {0} puncte", contor_player_2);
                }
            }

            if (contor_player_1 <= 21 && contor_player_2 <= 21 && contor_player_1 == contor_player_2)
            {
                Console.WriteLine("Egalitate");
            }
            else
            {
                if (contor_player_1 <= 21 && contor_player_1 > contor_player_2)
                {
                    Console.WriteLine("Jucatorul 1 e castigator cu {0} puncte", contor_player_1);
                }
                else
                {
                    if (contor_player_2 <= 21 && contor_player_2 > contor_player_1)
                    {
                        Console.WriteLine("Jucatorul 2 e castigator cu {0} puncte", contor_player_2);
                    }
                    else
                    {
                        if (contor_player_1 <= 21 && contor_player_2 > 21)
                        {
                            Console.WriteLine("Jucatorul 1 e castigator cu  {0} puncte", contor_player_1);
                        }
                        else
                        {
                            if (contor_player_2 <= 21 && contor_player_1 > 21)
                            {
                                Console.WriteLine("Jucatorul 2 e castigator cu {0} puncte", contor_player_2);
                            }
                            else
                            {
                                if (contor_player_1 > 21 && contor_player_2 > 21)
                                {
                                    if (contor_player_1 - 21 < contor_player_2 - 21)
                                    {
                                        Console.WriteLine("Jucatorul 1 e castigator cu {0} puncte", contor_player_1);
                                    }
                                    else
                                    {
                                        if (contor_player_2 - 21 < contor_player_1 - 21)
                                        {
                                            Console.WriteLine("Jucatorul 2 e castigator cu {0} puncte", contor_player_2);
                                        }
                                        else
                                        {
                                            if (contor_player_1 > 21 && contor_player_2 > 21 && contor_player_1 == contor_player_2)
                                            {
                                                Console.WriteLine("Egalitate");
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}