public class Affirmations
{
    public List<string> _affirmations = new List<string> {
        "You are a new person Everyday.",
        "Punishing yourself for the past won't make any feel better.",
        "Open yourself up to new life, new experiences, and new people.",
        "You still haven't met all the people yet who will love you.",
        "You can choose to reconnect with joy and love.",
        "you can do more with self-compassion than self-criticism",
        "What do you fear will happen if you are less critical of yourself?"
    };

    public string GetRandomAffirmation()
    {
        int randomIndex = Random.Shared.Next(_affirmations.Count);
        string randomAffirmation = _affirmations[randomIndex];

        return randomAffirmation;
    }
    
}