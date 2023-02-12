using System;

class ScriptureReference
{
   private string _book = "3 Nephi";
   private string _chapter = "11";
   private string _startVerse =  "29";
   private string _endVerse;

   public ScriptureReference(string _startVerse)
   {
        
   }
   public ScriptureReference(string _startVerse, string _endVerse)
   {

   }

   public string createReference()
   {
    if (_startVerse != null && _endVerse != null)
    {
        string reference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        return reference;
    } else
    {
        string reference = $"{_book} {_chapter}:{_startVerse}";
        return reference;
    }
    
   }

}