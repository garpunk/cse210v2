using System;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public override string ToString()
{
    return $"{_date} ~ {_promptText} ~ {_entryText}";
}

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        DateTime entryDate = DateTime.Parse(_date);
        string _formattedDate = entryDate.ToString("dddd, MMMM dd, yyyy"); //Exceeds requirements

        Console.WriteLine($"Date: {_formattedDate}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}