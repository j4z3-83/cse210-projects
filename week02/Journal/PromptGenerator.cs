using System.Collections.Generic;

public class PromptGenerator
{
    // create list of prompts
    public List<string> _prompts = new List<string> {
        "What are three great things that happened today?",
        "What are you looking forward to right now?", 
        "I am proud of myself for ___.",
        "What did I do today to get closer to my goal?",
        "What was a coincidence that you noticed?",
        "What was your first thought when you woke up this morning?",
        "What are you looking forward to tomorrow?",
        "How much time do you spend outside today?",
        "What excites you about this week?",
        "What happened today that made you hopeful for the future?"};

  


    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        return randomPrompt;
    }
}