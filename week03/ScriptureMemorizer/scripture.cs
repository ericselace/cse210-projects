using System;
using System.Collections.Generic;
using System.Linq;


class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide();
        }
    }

    public bool AllHidden()
    {
        return words.All(w => w.IsHidden());
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.GetReference());
        Console.WriteLine(string.Join(" ", words.Select(w => w.Display())));
    }
}
