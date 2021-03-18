using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyNewer.WinForms
{
    public class FileCopier
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public List<string> FilesCopied { get; private set; }

        public int CopyFiles()
        {
            FilesCopied = new List<string>();
            string[] files = Directory.GetFiles(DestinationPath);

            foreach (var f in files)
            {
                string fName = f.Substring(DestinationPath.Length + 1);

                if (File.Exists(Path.Combine(SourcePath, fName)))
                {
                    if (File.GetLastWriteTime(Path.Combine(SourcePath, fName)) > File.GetLastWriteTime(Path.Combine(DestinationPath, fName)))
                    {
                        File.Copy(Path.Combine(SourcePath, fName), Path.Combine(DestinationPath, fName), true);
                        FilesCopied.Add(fName);
                    }
                }
            }
            SaveResult();
            return FilesCopied.Count;
        }

        private void SaveResult()
        {
            using (FileStream fs = File.Create(DestinationPath + "//result.txt"))
            {
                foreach (var fc in FilesCopied)
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(fc + "\r\n");
                    fs.Write(info, 0, info.Length);
                }
            }
        }

    }
}
