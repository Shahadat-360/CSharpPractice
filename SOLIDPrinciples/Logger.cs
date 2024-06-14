using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class Logger
    {
        public void logerror(string message)
        {
            System.IO.File.WriteAllText("C:\\Users\\Shahadat\\Documents\\Shahadat\\CSharpPractice\\CSharpPractice\\SOLIDPrinciples", message);
        }
    }
}
