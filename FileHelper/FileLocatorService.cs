using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FileHelper
{
    public class FileLocatorService
    {
        public string AssignFilePath(string fileName)
        {
            string locationOfDLL = Assembly.GetEntryAssembly().Location;
            string locationOfProject = locationOfDLL.Substring(0, locationOfDLL.IndexOf(@"bin"));
            string locationOfProjectWithoutEndSlash = Path.TrimEndingDirectorySeparator(locationOfProject);
            string fullFilePath = Path.Combine(locationOfProjectWithoutEndSlash, string.Format("{0}.txt", fileName));
            if (File.Exists(fullFilePath))
            {
                Console.Write("A file with that name already exists! What would you like to do? \n");
            }
            return fullFilePath;
        }
    }
}
