using System;

class Word
{
   private bool isHidden = false;

   public Word()
   {
      
      
   }

   // public string getScriptureString ()
   // {
   //  Scripture scripture = new Scripture();
   //  string scriptureString = scripture.getString();
   //  return scriptureString;
   // }

   public string separateWords(string scriptureString)
   {
    string str1 = scriptureString;
    List<string> result = str1?.Split(' ').ToList();
    var random = new Random();
    int index = random.Next(result.Count);
    string randomWord = result[index];
    Console.WriteLine(randomWord);
    return randomWord;
    
   }
    

  
}