using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSortingAlgorithm.Interfaces
{
    interface ISortingStrategies
    {
        public List<string> SortBySurname(List<string> names);
    }
}
