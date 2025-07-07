// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Make sure the example file exists
        const string filename = "TestFile.txt";

        if (!File.Exists(filename))
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine("This is a text file.");
            }
        }

        // TODO: Get some information about the file
        Console.WriteLine($"File exists: {File.Exists(filename)}");
        Console.WriteLine($"File size: {new FileInfo(filename).Length} bytes");
        Console.WriteLine($"File creation time: {File.GetCreationTime(filename)}");
        Console.WriteLine($"File last access time: {File.GetLastAccessTime(filename)}");
        Console.WriteLine($"File last write time: {File.GetLastWriteTime(filename)}");

        // TODO: We can also get general information using a FileInfo
        FileInfo fi = new FileInfo(filename);
        Console.WriteLine($"\nFull Name: {fi.FullName}");
        Console.WriteLine($"Directory: {fi.DirectoryName}");
        Console.WriteLine($"Extension: {fi.Extension}");
        Console.WriteLine($"Is Read Only: {fi.IsReadOnly}");

        // TODO: File information can also be manipulated
        Console.WriteLine("\nChanging file attributes to ReadOnly...");
        fi.IsReadOnly = true;
        Console.WriteLine($"Is Read Only: {fi.IsReadOnly}");

        Console.WriteLine("Changing file attributes back to writable...");
        fi.IsReadOnly = false;
        Console.WriteLine($"Is Read Only: {fi.IsReadOnly}");

        Console.WriteLine("\nRenaming the file to 'TestFileRenamed.txt'...");
        string newFilename = "TestFileRenamed.txt";
        if (File.Exists(newFilename))
        {
            File.Delete(newFilename);
        }
        fi.MoveTo(newFilename);
        Console.WriteLine($"File renamed to: {newFilename}");

    }
}

