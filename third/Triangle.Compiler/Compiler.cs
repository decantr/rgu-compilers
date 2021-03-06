using System;
using Triangle.Compiler.SyntacticAnalyzer;

namespace Triangle.Compiler
{
    /// <summary>
    /// Compiles a program in Triangle for the triangle abstract machine
    /// </summary>
    public class Compiler
    {
        /// <summary>
        /// The file containing the source code
        /// </summary>
        private SourceFile source;

        /// <summary>
        /// The scanner
        /// </summary>
        private Scanner scanner;

        /// <summary>
        /// Creates a compiler for the given source file.
        /// </summary>
        /// <param name="sourceFileName">The file to read source code from</param>
        public Compiler(string sourceFileName)
        {
            source = new SourceFile(sourceFileName);
            scanner = new Scanner(source);
        }


        /// <summary>
        /// Triangle compiler main program.
        /// </summary>
        /// <param name="args">Command line arguments - should be one argument containing the name of the source file</param>
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Must provide exactly one argument - the source code file");
                return;
            }

            string sourceFileName = args[0];
            if (sourceFileName != null)
            {
                Compiler compiler = new Compiler(sourceFileName);
                foreach (var token in compiler.scanner)
                {
                    Console.WriteLine(token);
                }

            }
        }
    }
}