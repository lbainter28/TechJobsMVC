using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobs.Models
{
    public class JobDictionary : List<Dictionary<string, string>>
    {
        public void SortByName()
        {
            this.Sort(new JobComparer("name"));
        }
    }
}
