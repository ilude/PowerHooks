using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HookSpike {
  internal class Program {
    private static void Main(string[] args) {
      var arguments = new List<string>(args);

      foreach(var argument in arguments) {
        Console.WriteLine("{0,2}: {1}", arguments.IndexOf(argument), argument);
      }
      
      var env = Environment.GetEnvironmentVariables().Cast<DictionaryEntry>().ToDictionary(de => de.Key.ToString(), de => de.Value.ToString()).OrderBy(key => key.Key);
      foreach(var pair in env) {
        Console.WriteLine("  {0} = {1}", pair.Key, pair.Value);
      }

      Console.WriteLine(Directory.GetCurrentDirectory());
      
      Environment.Exit(1);
    }
  }
}
