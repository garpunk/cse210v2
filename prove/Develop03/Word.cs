public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
      _text = text;

      _isHidden = false;
    }

    public void Hide() //trying to randomize the chances of the boolean being true or false
    {
        _isHidden = true;
        
    }

   public bool IsHidden()
    {
        return _isHidden;
    }

   public string GetDisplayContent()
   {
    return _isHidden ? new string('_', _text.Length) : _text; 
    //really cool way to convert each letter individually into '_'
    //to keep the underscores the same length of the original word
   }

}