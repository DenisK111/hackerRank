using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Helpers
{
    internal static class Utils
    {
        public static List<T> List<T>(params T[] parameters) => parameters.ToList();
    }
}
