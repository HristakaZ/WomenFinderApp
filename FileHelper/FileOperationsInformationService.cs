using System;
using System.Collections.Generic;
using System.Text;

namespace FileHelper
{
    public class FileOperationsInformationService
    {
        public void DisplayInformation(string fileName)
        {
            Console.WriteLine($"\nPress 1 to write to {fileName}.txt");
            Console.WriteLine($"Press 2 to read {fileName}.txt");
            Console.WriteLine($"Press 3 to exit the application\n");
        }
    }
}
