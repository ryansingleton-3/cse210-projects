using System;

class Scripture
{
   private string _scriptureText;

   private string _scriptureReference;
   private string _randomWord;
   private bool _isCompletelyHidden = false;

   public Scripture()
   {
      _scriptureText = "For verily, verily I say unto you, he that hath the spirit of contention is not of me, but is of the devil, who is the father of contention, and he stirreth up the hearts of men to contend with anger, one with another.";
      _scriptureReference = getReference();
      Word newWord = new Word();
      _randomWord = newWord.separateWords(_scriptureText);
   }

   public string getReference()
   {
      ScriptureReference scriptureReference = new ScriptureReference("29");
      _scriptureReference = scriptureReference.createReference();
      return _scriptureReference;
      
   }

   public string deleteOneWord()
   {
      string str = _scriptureText;
      List<string> scriptureList = str?.Split(' ').ToList();
      for(int i=0;i<scriptureList.Count;i++)
      {
         if(scriptureList[i] == _randomWord)
            scriptureList[i] = "_";
      }
      string str2 = string.Join(" ", scriptureList.ToArray());
      _scriptureText = str2;
      Word newWord = new Word();
      _randomWord = newWord.separateWords(_scriptureText);
      return _scriptureText;

   }

   public bool checkHidden()
   {
      string str = _scriptureText;
      List<string> scriptureList = str?.Split(' ').ToList();
      bool isAllEqual = scriptureList.Distinct().Count() == 1;
      if (isAllEqual == true) 
      {
         _isCompletelyHidden = true;
         return true;
      }
      return false;
   }

   public string getString()
   {
      return _scriptureText;
   }

   public void Display()
   {
      Console.WriteLine($"{_scriptureReference} - {_scriptureText}");
   }

}