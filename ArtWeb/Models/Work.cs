using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Work
    {
        public string Title { get; set; }
        public string TimeInterval { get; set; }
        public string Period { get; set; }
        public string Content { get; set; }

        public Work() { }
        public Work(string title, string timeinterval, string period, string content)
        {
            Title = title;
            TimeInterval = timeinterval;
            Period = period;
            Content = content;
        }

        public List<Work> GetList()
        {
            var items = new List<Work>();
            //var rm = new System.Resources.ResourceManager("Resources.Home", typeof(Work).Assembly);
            //var nr = Utils.Str2Int(rm.GetString("workNr"));
            int i = 1;
            bool bOk = true;

            var rm = Resources.Home.Education.ResourceManager;
            while (bOk)
            {
                try
                {
                    var name = rm.GetString("workExp" + i + "Title");
                    if (name == null) bOk = false;
                    else
                    {
                        items.Add(new Work(rm.GetString("workExp" + i + "Title")
                            , rm.GetString("workExp" + i + "TimeInterval")
                            , rm.GetString("workExp" + i + "Period")
                            , rm.GetString("workExp" + i + "Content")));
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