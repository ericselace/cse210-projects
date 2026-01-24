using System;

public class Entry
{
    public string _EntryText;
    public string _PromptText;
    public string _date;

    public Entry()
    {
        _EntryText = "";
        _PromptText = "";
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
    }

    public override string ToString()
    {
        return _date + " | Prompt: " + _PromptText + " | Response: " + _EntryText;
    }
}
