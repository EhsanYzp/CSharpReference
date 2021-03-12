using System;
using System.IO;
using System.Linq;

namespace CSharpReference.IO
{
    public class FileManagement
    {
        string dummyLines = "This is first line." + Environment.NewLine +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

        string filePath = @"D:\DummyFile.txt";
        string copyFilePath = @"D:\NewDummyFile";
        string newFilePath = @"D:\DummyFile";

        public bool ImportantFileFunctions()
        {
            try
            {
                //Opens DummyFile.txt and append lines. If file is not exists then create and open.
                File.AppendAllLines(filePath, dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());

                //Opens DummyFile.txt and append Text. If file is not exists then create and open.
                File.AppendAllText(filePath, "This is File testing");

                //Opens DummyFile.txt and write texts. If file is not exists then create and open.
                File.WriteAllText(filePath, "This is dummy text");

                // Check whether file is exists or not at particular location
                bool isFileExists = File.Exists(filePath); // returns false

                //Copy DummyFile.txt as new file DummyFileNew.txt
                Random random = new Random();
                int randomNumber = random.Next(0, 100000);
                randomNumber.ToString();
                copyFilePath += randomNumber;
                copyFilePath += ".txt";

                File.Copy(filePath, copyFilePath);

                //Get when the file was accessed last time 
                DateTime lastAccessTime = File.GetLastAccessTime(filePath);

                //get when the file was written last time
                DateTime lastWriteTime = File.GetLastWriteTime(filePath);

                // Move file to new location
                int randomNumber2 = random.Next(0, 100000);
                randomNumber.ToString();
                newFilePath += randomNumber2;
                newFilePath += ".txt";
                File.Move(filePath, newFilePath);

                //Open file and returns FileStream for reading bytes from the file
                FileStream fs = File.Open(filePath, FileMode.OpenOrCreate);

                //Open file and return StreamReader for reading string from the file
  //             StreamReader sr = File.OpenText(filePath);

                //Delete file
     //          File.Delete(filePath);
                return true;

            }
            catch (Exception)
            {
                return false;
               
            }
            

        }

    }
}
