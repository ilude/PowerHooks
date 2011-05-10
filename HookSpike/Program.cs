using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HookSpike {
  internal class Program {
    private static void Main(string[] args) {
      var arguments = new List<string>(args);

      foreach(var argument in arguments) {
        Console.WriteLine("{0,2}: {1}", arguments.IndexOf(argument), argument);
      }

      IDictionary environmentVariables = Environment.GetEnvironmentVariables();
      foreach(DictionaryEntry de in environmentVariables) {
        Console.WriteLine("  {0} = {1}", de.Key, de.Value);
      }
    }
  }
}
