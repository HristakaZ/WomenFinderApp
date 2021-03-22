using System;
using System.Collections.Generic;
using System.Text;

namespace FileHelper
{
    public class UserInputCheckService
    {
        public void CheckUserInput(FileWritingService fileWritingService, FileReadingService fileReadingService,
            FileOperationsInformationService fileOperationsInformationService, string fullFilePath, ConsoleKey userOption, string fileName)
        {
            bool done = false;
            do
            {
                switch (userOption)
                {
                    case ConsoleKey.D1:
                        fileWritingService.WriteToAFile(fullFilePath, userOption);
                        fileOperationsInformationService.DisplayInformation(fileName);
                        userOption = Console.ReadKey().Key;
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                        fileReadingService.ReadAFile(fullFilePath);
                        fileOperationsInformationService.DisplayInformation(fileName);
                        userOption = Console.ReadKey().Key;
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nExiting the program");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("The key you have entered does not correspond to any of the application's commands, exiting " +
                            "the program ...");
                        done = true;
                        break;
                }
            } while (done == false);
        }
    }
}
