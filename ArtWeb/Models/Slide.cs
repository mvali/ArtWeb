using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Slide
    {
        public string  Large { get; set; }
        public string Small { get; set; }
        public string Link { get; set; }

        public Slide() { }
        public Slide(string large, string small, string link)
        {
            Large = large;
            Small = small;
            Link = link;
        }

        public List<Slide> GetList()
        {
            var items = new List<Slide>();
            int i = 1;
            bool bOk = true;

            var rm = Resources.Slider.ResourceManager;
            while (bOk)
            {
                try
                {
                    var name = rm.GetString("slide" + i + "Large");
                    if (name == null) bOk = false;
                    else
                    {
                        items.Add(new Slide(name
                            , rm.GetString("slide" + i + "Small")
                            , rm.GetString("slide" + i + "Link")));
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
