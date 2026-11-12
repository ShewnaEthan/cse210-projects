public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        string displayText = "";
        if (IsHidden())
        {
            foreach (char character in _text)
            {
                displayText = $"{displayText}_";
            }
        }
        else if (!IsHidden())
        {
            foreach (char character in _text)
            {
                displayText = $"{displayText}{character}";
            }
        }
        return displayText;
    }
}