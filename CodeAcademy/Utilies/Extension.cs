using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Utilies
{
    public static class Extension
    {
        public static int MatchCount(this string word,string repeat)
        {
            int count =0;
            var res=word.Split();
            foreach(var item in res) {
                if (item.Contains(repeat)) count++;
            }
            return count;
        }
    }
}
