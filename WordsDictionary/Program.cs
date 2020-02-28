using System;

namespace WordsDictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
Create a dictionary with key value pairs to
represent words (key) and its definition (value)
*/
      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

      // Add several more words and their definitions
      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
      wordsAndDefinitions.Add("Taco", "Variable name implying 'it could be anything'");
      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */

      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
      */
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
      }
    }
  }
}
