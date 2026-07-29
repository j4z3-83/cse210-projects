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
                        Console.Clear();
                        breathing.SetName("Breathing Activity");
                        breathing.SetDescription("This activity will help you relax by guiding you through Box breathing.");
                        breathing.DisplayStartingMessage();
                        
                        Console.Clear();
                        Console.WriteLine("Preparing activity");
                        breathing.ShowSpinner(5);
                        
                        breathing.Run();
                        Console.Clear();
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
                        Console.Clear();
                        reflecting.SetName("Reflecting Activity"); 
                        reflecting.SetDescription("This activity will allow you to reflect on time in your past when you have show inner strength and resilience. This will help you to recognize the your power and how you can use it in all aspects of your life.");
                        reflecting.DisplayStartingMessage();
                        
                        Console.Clear();
                        Console.WriteLine("Preparing activity");
                        reflecting.ShowSpinner(5);
                        
                        reflecting.Run();
                        Console.Clear();
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
                        Console.Clear();
                        listing.SetName("Listing Activity");
                        listing.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        listing.DisplayStartingMessage();
                        
                        Console.Clear();
                        Console.WriteLine("Preparing activity");
                        listing.ShowSpinner(5);

                        listing.Run();
                        Console.Clear();
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