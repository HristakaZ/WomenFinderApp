using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileHelper
{
    public class FileReadingService
    {
        public void ReadAFile(string fullFilePath)
        {
            string fileContentToDisplay = "";
            if (File.Exists(fullFilePath))
            {
                StreamReader streamReader = new StreamReader(fullFilePath);
                using (streamReader)
                {
                    List<string> womenNames = new List<string>();
                    string fileContent = streamReader.ReadLine();
                    List<char> englishVowels = new List<char>()
                    {
                        'A', 'E', 'I', 'O', 'U', 'Y' //the vowels(in English)
                    };
                    if (fileContent == null)
                    {
                        fileContentToDisplay = "There is no content in this file!";
                    }
                    while (fileContent != null)
                    {
                        womenNames.Add(fileContent);
                        fileContent = streamReader.ReadLine();
                    }
                    womenNames.Sort();
                    Console.WriteLine("The contents of the file {0} are:\n", fullFilePath);
                    foreach (string womenName in womenNames)
                    {
                        foreach (char englishVowel in englishVowels)
                        {
                            if (womenName.StartsWith(englishVowel))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }
                        Console.WriteLine(womenName);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            else
            {
                fileContentToDisplay = "The file does not exist, please write to it first(Option 1) to create it!";
                Console.WriteLine(fileContentToDisplay);
            }
        }
    }
}