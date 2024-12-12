using System;
namespace Tumakov
{
    public class Files
    {
        List<string> list = new List<string>();
        public List<string> FileProcessing(string path)
        {
            if (File.Exists(path))
            {
                string file = (File.ReadAllText(path)).ToUpper();
                list.Add(file);
                return list;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
