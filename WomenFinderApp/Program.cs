using FileHelper;
using System;

namespace WomenFinderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLocatorService fileLocatorService = new FileLocatorService();
            Console.WriteLine("Enter the name of the file(how you wish it would be called(without the file extension)).: ");
            string fileName = Console.ReadLine();
            string fullFilePath = fileLocatorService.AssignFilePath(fileName);
            FileOperationsInformationService fileOperationsInformationService = new FileOperationsInformationService();
            fileOperationsInformationService.DisplayInformation(fileName);
            ConsoleKey userOption = Console.ReadKey().Key;
            Console.WriteLine();
            FileWritingService fileWritingService = new FileWritingService();
            FileReadingService fileReadingService = new FileReadingService();
            UserInputCheckService userInputCheckService = new UserInputCheckService();
            userInputCheckService.CheckUserInput(fileWritingService, fileReadingService, fileOperationsInformationService, fullFilePath,
                userOption, fileName);
        }
    }
}
