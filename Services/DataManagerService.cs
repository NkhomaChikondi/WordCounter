using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Interfaces;

namespace WordCounter.Services
{
    public class DataManagerService : IDataManager
    {
        public void getFile(string[] args)
        {
            int linesInTotal = 0, wordsIntotal = 0;
            long bytesInTotal = 0;
            // loop through all the files that are passed from from the command line argument
            foreach (string file in args)
            {
              // check if the file exist
              if(File.Exists(file))
              {
                // initialize a wrapper for file path
                var fileInfor = new FileInfo(file);
                    int lines = File.ReadLines(file).Count();
                    // call the wordCount method 
                    int words = wordCount(file);
                    long bytes = fileInfor.Length;

                    linesInTotal += lines;
                    wordsIntotal += words;
                    bytesInTotal += bytes;
                    Console.WriteLine($"{lines}\t{words}\t{bytes}\t{file}");
              }
                else
                {
                    Console.WriteLine($"File not found: {file}");
                }
            }
   
            Console.WriteLine($"{linesInTotal}\t{wordsIntotal}\t{bytesInTotal}\tTotal");
        }

        public int wordCount(string file)
        {
            string text = File.ReadAllText(file);
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
