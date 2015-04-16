using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GoogleCodeJam.FileIO
{
    public class FileManager
    {
        public FileManager()
        {
            var currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            var filePath = currentDirectory;
            const string filter = "*.in";
            var files = Directory.GetFiles(filePath, filter);

            var fileFullName = files.FirstOrDefault();
            if (string.IsNullOrEmpty(fileFullName))
            {
                Console.WriteLine("Not 'in' file found in path: '{0}'", filePath);
                Console.Read();
                throw new Exception(String.Format("Not 'in' file found in path: '{0}'", filePath));
            }

            var fileName = fileFullName.Substring(fileFullName.LastIndexOf("\\") + 1, fileFullName.LastIndexOf(".in") - fileFullName.LastIndexOf("\\") - 1);

            FileName = fileFullName.Substring(0, fileFullName.Length - 3);
            FilePath = currentDirectory;
        }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        private string Input { get { return Path.Combine(FilePath, FileName + ".in"); } }

        private string Output { get { return Path.Combine(FilePath, FileName + ".out"); } }


        public List<List<string>> ReadFile() 
        {
            var ret = new List<List<string>>();
            string line;

            var file = new System.IO.StreamReader(Input);
            while ((line = file.ReadLine()) != null)
                ret.Add(new List<string>(line.Split(' ')));
            
            file.Close();
            return ret;
        }

        public void WriteFile(List<string> output)
        {
            var file = new System.IO.StreamWriter(Output);

            foreach (var line in output)
                file.WriteLine(line);

            file.Close();
        }
    }
}
