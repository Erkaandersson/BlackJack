using System.ComponentModel.Design;
using System.Numerics;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int användarensKort = 0;
            int datornsKort = 0;
            string vinnare = "";


            bool körProgram = true;
            while (körProgram)
            {
                Console.WriteLine("Välkommen till 21:an!");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Spela 21:an \n2.Visa senaste vinnaren\n3.Spelets regler\n4.Avsluta programmet");
                int alternativVal = Convert.ToInt32(Console.ReadLine());
                datornsKort = 0;
                datornsKort += random.Next(1, 11);
                datornsKort += random.Next(1, 11);
                användarensKort = 0;
                användarensKort += random.Next(1, 11); //Generar ett slumpat nummer mellan 1-10
                användarensKort += random.Next(1, 11); //Generar ett slumpat nummer mellan 1-10

                switch (alternativVal)
                {
                    
                    case 1:
                        //Spelarens runda
                        bool runda = true;
                        while (runda)
                        {
                           
                            Console.WriteLine($"Din poäng är {användarensKort}\nVill du ha ett nytt kort? j/n");
                            string svar = Console.ReadLine().ToLower();
                            if (svar == "j")
                            {
                                användarensKort += random.Next(1, 11);
                                if (användarensKort > 21)
                                {
                                    Console.WriteLine("Du gick över 21, datorn vann!");
                                    Console.WriteLine("Klicka för att komma vidare!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (svar == "n")
                            {
                                Console.WriteLine($"Din poäng är {användarensKort}, nu är det datorns tur!");

                            }
                            else
                            {
                                Console.WriteLine("Fel svar, endast j eller n är giltigt! Försök igen");
                                continue;
                            }
                            // Datorns runda


                            if (användarensKort <= 21)
                            {
                                while (datornsKort < 21 && datornsKort <= användarensKort)
                                {
                                    datornsKort += random.Next(1, 11);
                                    Console.WriteLine($"Datorn poäng: {datornsKort}");
                                }
                                if (användarensKort < datornsKort && datornsKort <= 21)
                                {
                                    Console.WriteLine("Datorn har vunnit!");
                                    vinnare = "Datorn";
                                    runda = false;
                                    Console.WriteLine("Klicka för att komma vidare!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                
                                }
                                else if (datornsKort > 21)
                                {
                                    Console.WriteLine("Du har vunnit!, Skriv in ditt namn:");
                                    vinnare = Console.ReadLine();
                                    runda = false;
                                    Console.WriteLine("Klicka för att komma vidare!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                            }
                
                        }
                     break;

                    case 2:
                        Console.WriteLine($"Senaste vinnaren är: {vinnare}");
                        Console.WriteLine("Klicka för att komma vidare!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("1. Du får först 2 kort sen är målet att komma så nära 21 som möjligt," +
                            " du kan välja att ta ett nytt kort eller stanna efter varje runda. Datorns mål är att försöka slå dig" +
                            "så den kommer ta ett kort så länge den har en poäng som är under eller lika med din.");
                        Console.WriteLine("Klicka för att komma vidare!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Programmet avslutas!");
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
    

