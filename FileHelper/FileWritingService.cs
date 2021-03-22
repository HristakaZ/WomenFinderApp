using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHelper
{
    public class FileWritingService
    {
        public void WriteToAFile(string fullFilePath, ConsoleKey userOption)
        {
            List<string> womenNames = new List<string>();
            StreamWriter streamWriter = new StreamWriter(fullFilePath);
            using (streamWriter)
            {
                while (userOption == ConsoleKey.D1)
                {
                    Console.WriteLine("\nEnter the content you wish to write to the file(Enter the symbol ~ if you want to exit writing mode):");
                    string userContent = Console.ReadLine();
                    if (userContent.Contains("~"))
                    {
                        womenNames.ForEach(x =>
                        {
                            streamWriter.Write(x + "\n");
                        });
                        return;
                    }
                    womenNames.Add(userContent);
                }
            }
        }
    }
}