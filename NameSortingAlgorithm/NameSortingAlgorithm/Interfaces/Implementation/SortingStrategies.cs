using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSortingAlgorithm.Interfaces.Implementation
{
    public class SortingStrategies : ISortingStrategies
    {
        public List<string> SortBySurname(List<string> names)
        {
            List<string> sortedNames = names.OrderBy(name =>
            {
                string[] nameParts = name.Split(' ');
                return nameParts[nameParts.Length - 1]; // Sorting by last name
            }).ThenBy(name =>
            {
                string[] nameParts = name.Split(' ');
                return string.Join(" ", nameParts.Take(nameParts.Length - 1)); // Sorting by given names
            }).ToList();

            return sortedNames;
        }
    }
}
