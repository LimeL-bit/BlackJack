namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KÖRIGEN = "Y";
            while (KÖRIGEN == "Y" || KÖRIGEN == "y" || KÖRIGEN == "yes" || KÖRIGEN == "Yes" || KÖRIGEN == "ja" || KÖRIGEN == "Ja")
            {

                Console.WriteLine("du ska nu köra ett spel som går ut på att komma så nära du kan talet 21 utan att gå över det");
                Console.WriteLine("du kommer att köra mot en ai. Och du ska försöka vinna!");
                Console.WriteLine("skriv något när du är redo och skriv stanna för att stanna med numret du har.");

                Random rand = new Random();
                int sum = 0;
                int Dsum = 0;
                int Rnumber = rand.Next(1, 7);
                int DRnumber = rand.Next(1, 7);
                string cast = Console.ReadLine();
                while (cast != "Stanna" && cast != "stanna" && cast != "Stana" && cast != "stana")
                {
                    //playerns runda
                    Rnumber = rand.Next(1, 7);
                    sum = sum + Rnumber;
                    Console.WriteLine("du slog " + Rnumber + ", du har nu " + sum + " poäng");
                    //dealerns runda
                    if (Dsum <= 17)
                    {
                        DRnumber = rand.Next(1, 7);
                        Dsum = Dsum + DRnumber;
                        Console.WriteLine("Dealern slog " + DRnumber + ", dealern har nu " + Dsum + " poäng");
                        Console.WriteLine();
                    }
                    else if (Dsum <= 21 && Dsum > 17)//om dealern inte vill fortsäta (alltså om dealer är över 17P)
                    {
                        Console.WriteLine("Delern vill inte fortsäta");
                        Console.WriteLine("Delerns poäng är " + Dsum);
                    }


                    //om man vill fortsäta
                    if (sum <= 21 && Dsum <= 21)
                    {
                        Console.WriteLine("vill du stanna eller fortsäta?");
                        cast = Console.ReadLine();
                        Console.WriteLine();
                    }
                    else if (Dsum >= 22)
                    {
                        Console.WriteLine();
                        Console.WriteLine("dealern slog över 21 :[");
                        Console.WriteLine();
                        break;
                    }
                    else if (sum >= 22)
                    {
                        Console.WriteLine();
                        Console.WriteLine("du fick över 21 poäng och förlorade :(");
                        Console.WriteLine();
                        break;
                    }
                }
                //om dealer inte är klar
                while (Dsum <= 17)
                {
                    DRnumber = rand.Next(1, 7);
                    Dsum = Dsum + DRnumber;
                    Console.WriteLine("Dealern slog " + DRnumber + ", dealern har nu " + Dsum + " poäng");
                    Console.WriteLine();
                }


                //vem som vinner
                if (Dsum <= 21)
                {
                    if (sum <= 21 && sum > Dsum)
                    {
                        Console.WriteLine("både du och dealern käner sig klara");
                        Console.WriteLine();
                        Console.WriteLine("Du van!");
                    }
                    else if (Dsum > sum)
                    {
                        Console.WriteLine("både du och dealern käner sig klara");
                        Console.WriteLine();
                        Console.WriteLine("dealern van:)");
                    }
                    else if (Dsum == sum)
                    {
                        Console.WriteLine("både du och dealern käner sig klara");
                        Console.WriteLine();
                        Console.WriteLine("ingen van det blev lika");
                    }
                }
                else if (Dsum > 21)
                {
                    if (sum <= 21)
                    {
                        Console.WriteLine("både du och dealern käner sig klara");
                        Console.WriteLine();
                        Console.WriteLine("Du van! :]");
                    }
                    else if (sum > 21)
                    {
                        Console.WriteLine("både du och dealern käner sig klara");
                        Console.WriteLine();
                        Console.WriteLine("nice ingen van :[");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("vill du köra igen?" + "Y eller N");
                KÖRIGEN = Console.ReadLine();
            }
        }
    }
}

