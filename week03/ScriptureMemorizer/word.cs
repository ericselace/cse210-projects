using System;
using System.Collections.Generic;
using System.Linq;


class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        this.hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public string Display()
    {
        return hidden ? new string('_', text.Length) : text;
    }
}