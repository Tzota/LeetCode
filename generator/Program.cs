using System;
using System.IO;
using static System.Console;

namespace generator
{
    class Program
    {
        static string srcPattern = @"
namespace leetcode
{{
    /// <summary>
    ///
    /// </summary>
    public class {0}
    {{

    }}
}}
        ";
        static string testPattern = @"
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{{
    [TestClass]
    public class {0}Test
    {{
        [TestMethod]
        public void {0}_In_Out()
        {{

        }}
    }}
}}
        ";

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                WriteLine("Gimme da name");
                return;
            }

            var srcPath = Path.Combine(System.Environment.CurrentDirectory, $"../src/leetcode/{args[0]}.cs");
            var testPath = Path.Combine(System.Environment.CurrentDirectory, $"../test/leetcode.test/{args[0]}Test.cs");
            File.WriteAllText(srcPath, String.Format(srcPattern, args[0]));
            File.WriteAllText(testPath, String.Format(testPattern, args[0]));
            WriteLine(Path.GetFullPath(srcPath));
        }
    }
}
