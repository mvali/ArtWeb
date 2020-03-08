using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Skill
    {
        public string Name{ get; set; }
        public string Percent { get; set; }

        public Skill() { }
        public Skill(string name, string percent)
        {
            Name = name;
            Percent = percent;
        }

        public List<Skill> GetList()
        {
            var items = new List<Skill>();
            int i = 1;
            bool bOk = true;

            var rm = Resources.Home.Skills.ResourceManager;
            while (bOk)
            {
                try
                {
                    var name = rm.GetString("skill" + i + "Name");
                    if (name == null) bOk = false;
                    else
                    {
                        items.Add(new Skill(name
                            , rm.GetString("skill" + i + "Percent")));
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
