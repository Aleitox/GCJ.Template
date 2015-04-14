using System.Collections.Generic;
using System.IO;

namespace GoogleCodeJam.FileIO
{
    public class FileManager
    {
        public FileManager(string relativePath = "", string basePath = "")
        {
            var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory());

            basePath = currentDirectory.Name == "bin"
                ? currentDirectory.Parent.Parent.FullName + "\\Files\\"
                : currentDirectory.FullName;


            RelativePath = relativePath;
            BasePath = basePath;
        }

        public string BasePath { get; set; }

        public string RelativePath { get; set; }

        private string ReadFilePath { get { return Path.Combine(BasePath, RelativePath + ".in"); } }

        private string WriteFilePath { get { return Path.Combine(BasePath, RelativePath + ".out"); } }


        public List<List<string>> ReadFile() 
        {
            var ret = new List<List<string>>();
            string line;

            var file = new System.IO.StreamReader(ReadFilePath);
            while ((line = file.ReadLine()) != null)
                ret.Add(new List<string>(line.Split(' ')));
            
            file.Close();
            return ret;
        }

        public void WriteFile(List<string> output)
        {
            var file = new System.IO.StreamWriter(WriteFilePath);

            foreach (var line in output)
                file.WriteLine(line);

            file.Close();
        }
    }
}
