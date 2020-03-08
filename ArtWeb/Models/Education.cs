using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Education
    {
        public string Title { get; set; }
        public string TimeInterval { get; set; }
        public string Grade { get; set; }
        public string Content { get; set; }

        public Education() { }
        public Education(string title, string timeinterval, string grade, string content)
        {
            Title = title;
            TimeInterval = timeinterval;
            Grade = grade;
            Content = content;
        }

        public List<Education> GetList()
        {
            var items = new List<Education>();
            //var rm = new System.Resources.ResourceManager("ArtWeb.Resources.Home.Resources.Home", typeof(Education).Assembly);
            //var nr = Utils.Str2Int(rm.GetString("educationNr"));
            int i = 1;
            bool bOk = true;

            var rm = Resources.Home.Education.ResourceManager;
            while (bOk)
            {
                try
                {
                    var name = rm.GetString("education" + i + "Title");
                    if (name == null) bOk = false;
                    else
                    {
                        items.Add(new Education(rm.GetString("education" + i + "Title")
                            , rm.GetString("education" + i + "Period")
                            , rm.GetString("education" + i + "Gpa")
                            , rm.GetString("education" + i + "Content")));
                    }
                    i++;
                }
                catch (Exception)
                {
                    bOk = false;
                }
            }
            return items;
        }
    }
}
