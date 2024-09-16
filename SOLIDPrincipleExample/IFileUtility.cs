using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public interface IFileUtility
    {
        Stream ReadStream(string filePath);
    }
}
