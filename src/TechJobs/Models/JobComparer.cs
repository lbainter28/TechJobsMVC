using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobs.Models
{
    public class JobComparer : IComparer<Dictionary<string, string>>
    {
        private readonly string leField;

        public JobComparer(string fieldName)
        {
            leField = fieldName;
        }

        public int Compare(Dictionary<string, string> x, Dictionary<string, string> y)
        {
            return String.Compare(x[leField], y[leField]);
        }
    }
}
