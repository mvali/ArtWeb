using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EducationWorkVM // ViewModel
    {
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Work> Works { get; set; }
    }
}
