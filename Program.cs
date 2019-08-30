using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dictionary_Lookup
{
    class Program
    {
        public static void Dict_Lookup(string textfile, string search)
        {
            //Create the dictionary list
            List<string> words = System.IO.File.ReadAllText(textfile).Split(new string[] { "\n" }, StringSplitOptions.None).ToList();
            
            //Search the dictionary list
            List<string> results = words.FindAll(delegate (string s) { return s.Contains(search); });
            //Display the results
            results.ForEach(i => Console.WriteLine("{0}", i));
            //Wait for user to press key
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            String path = "";
            String src = "";
            Console.WriteLine("Enter path for text file:");
            path = Console.ReadLine();
            Console.Write("Enter search word or part of word:");
            src = Console.ReadLine();
            Dict_Lookup(path,src);
        }
    }
}
