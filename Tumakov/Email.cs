using System;
namespace Tumakov
{
    public class Email
    {
        List<string> emailList = new List<string>();
        public List<string> GetEmail(string path)
        {
            if (File.Exists(path))
            {
                foreach (string line in File.ReadAllLines(path))
                {
                    string email = SearchEmail(line);
                    if (!string.IsNullOrEmpty(email))
                    {
                        emailList.Add(email);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
            return emailList;
        }
        public string SearchEmail(string s)
        {
            if (s.Contains("#"))
            {
                int index = s.IndexOf('#');
                return s.Substring(index + 1).Trim();
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
