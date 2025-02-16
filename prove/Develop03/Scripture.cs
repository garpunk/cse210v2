using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private Random rand = new Random();

     
     //this is something called the fisher-yates shuffle
     //that I learned about when researching for this project
     //it's really cool and supposedly super efficient for randomizing!
    private void ShuffleWords(List<Word> words)
{
    for (int i = words.Count - 1; i > 0; i--)
    {
        int j = rand.Next(i + 1);
        (words[i], words[j]) = (words[j], words[i]); 
    }
}

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
          _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numWords)
    {
      

      // Get a list of words that are NOT hidden
      List<Word> visibleWords = new List<Word>();


      foreach (Word word in _words)
      {
       if (!word.IsHidden())
       {
        visibleWords.Add(word);
       }
      }

      if (visibleWords.Count == 0) return;  

  

       // Shuffle the list of words
        ShuffleWords(visibleWords);
     
   
      int wordsToHide = Math.Min(numWords, visibleWords.Count);

      for (int i = 0; i < wordsToHide; i++)
      {
        visibleWords[i].Hide(); 
      }
    }

   public bool IsAllHidden()
   {
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            return false;
        }
    }
    return true;
   }

  public string GetDisplayContent()
  {
     string result = "";
    foreach (Word word in _words)
    {
        result += word.GetDisplayContent() + " ";
    }
    return result.Trim(); // Trim things up
  }

  public Reference GetReference()
{
    return _reference;
}


}