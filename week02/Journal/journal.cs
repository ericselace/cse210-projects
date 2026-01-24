using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    
    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry();
        entry._PromptText = prompt;  
        entry._EntryText = response;  
        entries.Add(entry);
    }

    
    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    
    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry._date + "~|~" + entry._PromptText + "~|~" + entry._EntryText);
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    
    public void LoadJournal(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._PromptText = parts[1];
                entry._EntryText = parts[2];
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}
