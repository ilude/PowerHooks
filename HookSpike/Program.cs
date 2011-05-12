using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;

namespace HookSpike {
  internal class Program {
    private static void Main(string[] args) {
      var runspace = RunspaceFactory.CreateRunspace();

      // open it

      runspace.Open();

      // create a pipeline and feed it the script text

      var pipeline = runspace.CreatePipeline();
      pipeline.Commands.AddScript("ps | Out-String");

       // execute the script

      var results = pipeline.Invoke();

      // close the runspace

      runspace.Close();

      // convert the script result into a single string

      var stringBuilder = new StringBuilder();
      foreach (var obj in results)
      {
          stringBuilder.AppendLine(obj.ToString());
      }

      Console.WriteLine(stringBuilder.ToString());

      Console.ReadLine();

      //var arguments = new List<string>(args);



      //foreach(var argument in arguments) {
      //  Console.WriteLine("{0,2}: {1}", arguments.IndexOf(argument), argument);
      //}

      //var env = Environment.GetEnvironmentVariables().Cast<DictionaryEntry>().ToDictionary(de => de.Key.ToString(), de => de.Value.ToString()).OrderBy(key => key.Key);
      //foreach(var pair in env) {
      //  Console.WriteLine("  {0} = {1}", pair.Key, pair.Value);
      //}

      //Console.WriteLine(Directory.GetCurrentDirectory());

      //Environment.Exit(1);
    }
  }
}
