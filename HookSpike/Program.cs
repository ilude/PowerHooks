using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HookSpike {
  class Program {
    static void Main(string[] args) {

      var arguments = new List<string>(args);

      foreach(var argument in arguments) {
        Console.WriteLine("{0,2}: {1}", arguments.IndexOf(argument), argument);
      }
    }
  }
}
