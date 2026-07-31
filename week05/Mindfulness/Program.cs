//clears the console frequently so only relevant information is shown
//the program, on completion of an activity, asks the user if they want to do that activity again, they they select no then they are returned to the main screen 
//lists are shuffled so that a random prompt is chosen and prevents a duplicate prompt from being selected

using System;
using System.ComponentModel.Design;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{   
    static void Main(string[] args)
    {
        int selection = 0;
        while (selection != 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App.");
            Console.WriteLine(new string('-', 50));
            
            Console.WriteLine("\nThe activities available are:");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Exit program");
            Console.WriteLine("");
            Console.Write("Select one of the listed activities: ");
            string selectionStr = Console.ReadLine();

            if (int.TryParse(selectionStr, out selection))
            {
                if(selection != 0 && selection <= 4)
                {
                    if (selection == 1)
                    {
                        BreathingActivity breathing = new BreathingActivity();
                    
                        breathing.DisplayStartingMessage();

                        breathing.Run();

                        breathing.DisplayEndingMessage();
                        Console.WriteLine("Would you like to try another activity? y/n ");
                        string continueActivity = Console.ReadLine
                        ();
                        string lowerText = continueActivity.ToLower();
                        if (lowerText == "n")
                        {
                            selection = 4;
                        }                             
                    }
                    else if (selection == 2)
                    {
                        ReflectingActivity reflecting = new ReflectingActivity();

                        reflecting.DisplayStartingMessage();
                        
                        reflecting.Run();

                        reflecting.DisplayEndingMessage();
                        Console.WriteLine("Would you like to try another activity? y/n ");
                        string continueActivity = Console.ReadLine
                        ();
                        string lowerText = continueActivity.ToLower();
                        if (lowerText == "n")
                        {
                            selection = 4;
                        }                                               
                    }
                    else if (selection == 3)
                    {
                        ListingActivity listing = new ListingActivity();
                        listing.DisplayStartingMessage();
                        
                        listing.Run();

                        listing.DisplayEndingMessage();
                        Console.WriteLine("Would you like to try another activity? y/n ");
                        string continueActivity = Console.ReadLine();
                        string lowerText = continueActivity.ToLower();
                        if (lowerText == "n")
                        {
                            selection = 4;
                        }    
                    }               
                }
                else
                {
                    Console.WriteLine("Invalid selection, please enter a valid number");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please enter a valid number");
            }
        }       
    }
}