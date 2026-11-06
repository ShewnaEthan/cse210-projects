// This class will generate a prompt from a list that will be the top of each journal entry.

public class GeneratePrompt
{
    List<string> _prompts = ["What was your favourite thing that you did today?", "If you could have a do over, what would you do differently?", "What was the strongest emotion I felt today?", "How did I work towards my goals today?", "Who did I spend time with today?", "Did I get anywork done today?", "What did I read about to today?", "What hobbies did I do today"];
    public string GetRandomPrompt()
    {
        Random randomNum = new Random();
        int randomIndex = randomNum.Next(0, _prompts.Count());
        return _prompts[randomIndex];
    }
}