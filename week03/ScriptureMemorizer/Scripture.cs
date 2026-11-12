public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] textPieces = text.Split(" ");

        foreach (string textPiece in textPieces)
        { 
            Word word = new Word(textPiece);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(0, _words.Count());
            _words[magicNum].Hide();
        }

    }
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string words = "";
        foreach (Word word in _words)
        {

            words = $"{words} {word.GetDisplayText()}";
        }
        string displayText = $"{reference}{words}";
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;
    }

}