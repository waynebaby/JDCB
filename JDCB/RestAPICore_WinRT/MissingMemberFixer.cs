using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class MissingMemberFixer
    {

        public static void ForEach<T>(this List<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            
            }
        
        }
    }
}
