using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Assignment3.Models
{
    public static class TempStorage
    {
        private static List<MovieAddition> applications = new List<MovieAddition>();

        public static IEnumerable<MovieAddition> Applications => applications;

        public static void AddApplication(MovieAddition application)
        {
            applications.Add(application);
        }
    }
}
