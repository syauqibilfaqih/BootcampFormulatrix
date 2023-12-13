using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Specify the file path
        string filePath = "example.txt";

        // Some data to append to the file
        string dataToAppend = "\nThis is new data to be appended.";

        // Append data to the file
        AppendToFile(filePath, dataToAppend);

        // Read and display the contents of the file
        ReadFileContents(filePath);
    }

    static void AppendToFile(string filePath, string data)
    {
        try
        {
            // Open the file in append mode
            using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                // Convert the string data to bytes
                byte[] bytes = Encoding.UTF8.GetBytes(data);

                // Write the data to the end of the file
                fileStream.Write(bytes, 0, bytes.Length);

                Console.WriteLine("Data appended to the file successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void ReadFileContents(string filePath)
    {
        try
        {
            // Read the contents of the file
            string fileContents = File.ReadAllText(filePath);

            Console.WriteLine($"File contents:\n{fileContents}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }
    }
}
