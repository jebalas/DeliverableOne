using System;

namespace DeliverableOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vacation would you like to go on?");
            Console.Write("Please enter - musical, tropical, or adventurous: ");
            string vacationType = Console.ReadLine();

            string Destination;
            string TravelSuggestion = "";

            if (vacationType == "musical") {
                Destination = "New Orleans";
            }
            else if (vacationType == "tropical") {
                Destination = "Mexico for a Beach Vacation!";
            }
            else {
                Destination = "the Grand Canyon for a Whitewater Rafting trip!";
            }


            Console.Write("How many people are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());
                        
            if (groupSize <= 2) {
                TravelSuggestion = " fly First Class to ";
            }
            else {
                if (groupSize <= 5) {
                    TravelSuggestion = " take a helicopter to ";
                }
                else {
                    TravelSuggestion = " take a charter flight to ";
                }
            }

            string result = "Since you are a group of " + groupSize.ToString() +
                            "going on a " + vacationType + " vacation, you should"
                            + TravelSuggestion + Destination;
            Console.WriteLine(result);
        }
    }
}
