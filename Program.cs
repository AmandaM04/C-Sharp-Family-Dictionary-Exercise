using System;
using System.Collections.Generic;

namespace C_Sharp_Family_Dictionary_Exercise
{
  class Program
  {
    static void Main(string[] args)
    {

      Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

      myFamily.Add("mom", new Dictionary<string, string>(){
    {"name", "Lynn"},
    {"age", "50"}
});

      myFamily.Add("brother", new Dictionary<string, string>(){
    {"name", "Brandon"},
    {"age", "31"}
});

// you have to set what the keyValuePairs are and also what is inside the dictionary
      foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
      {
        // you access the value of the member and state what key you are wanting to access using dot notation
        Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old");
      }
    }
  }
}
