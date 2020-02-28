using System;
using System.Collections.Generic;

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
      wordsAndDefinitions.Add("Hungry", "What happens when it is almost noon");

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */
      Console.WriteLine("----- Using square bracket - remember it is a string -----");
      Console.WriteLine($"words {wordsAndDefinitions["Awesome"]}");
      Console.WriteLine("----- Now Loop with KeyValuePair-------");
      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
      */
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value}");
      }

      /////////////////////////////////////////////////////////////

      // Make a new list
      List<Dictionary<string, string>> dictionaryOfWords2 = new List<Dictionary<string, string>>();

      /*
          You want to track the following about each word:
              word, definition, part of speech, example sentence

          Example of one dictionary in the list:
          {
              "word": "excited",
              "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
              "part of speech": "adjective",
              "example sentence": "I am excited to learn C#!"
          }
      */

      // Create dictionary to represent a few words
      Dictionary<string, string> excitedWord = new Dictionary<string, string>();

      // Add each of the 4 bits of data about the word to the Dictionary
      excitedWord.Add("word", "excited");
      excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
      excitedWord.Add("part of speech", "adjective");
      excitedWord.Add("example sentence", "I am excited to learn C#!");

      // Add Dictionary to your `dictionaryOfWords2` list
      dictionaryOfWords2.Add(excitedWord);

      Dictionary<string, string> simpleWord = new Dictionary<string, string>();

      // create another Dictionary and add that to the list
      simpleWord.Add("word", "simple");
      simpleWord.Add("definition", "simple is simple");
      simpleWord.Add("part of speech", "adjective");
      simpleWord.Add("example sentence", "Not too many colors, it is simple");

      dictionaryOfWords2.Add(simpleWord);
      /*
          Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

          Example output for one word in the list of dictionaries:
              word: excited
              definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
              part of speech: adjective
              example sentence: I am excited to learn C#!
      */

      // Iterate the List of Dictionaries
      int count = 0;
      foreach (var item in dictionaryOfWords2)
      {
        count++;
        Console.WriteLine($"----- ITEM  {count} -----");
        foreach (KeyValuePair<string, string> prop in item)
        {
          Console.WriteLine($"{prop.Key}: {prop.Value}");
        }
      }

    }
  }
}
