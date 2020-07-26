using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PLII.cv7
{
    public class FileManager
    {
        /*
        public static void CreateFile(string nameOfFile)
        {

        }
        */
        public static void SaveToFile(string nameOfFile, IEnumerable<string> lines)
        {
            File.WriteAllLines(nameOfFile, lines);
        }

        public static List<string> LoadFromFile(string nameOfFile)
        {
            List<string> lines = new List<string>();
            foreach(string line in File.ReadAllLines(nameOfFile))
            {
                lines.Add(line);
            }
            return lines;
        }
        
        public static void SaveToBinaryFile(string nameOfFile, IEnumerable<string> lines)
        {
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(nameOfFile)))
            {
                foreach(string line in lines)
                {
                    writer.Write(line);
                }
            }
        }
        
    }
}
