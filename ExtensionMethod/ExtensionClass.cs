using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtensionClass
    {
        public static int CountWords(this string text,bool trimBlank)
        {
            if(trimBlank)
                text = text.Trim();
            string[] parts = text.Split(" ");
            int len=parts.Count(x=>!string.IsNullOrWhiteSpace(x));
            return len;
        }
    }
}
