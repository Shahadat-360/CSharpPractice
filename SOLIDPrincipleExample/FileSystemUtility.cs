using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class FileSystemUtility : IFileUtility
    {
        public Stream OpenFile(string path,FileMode mode)
        {
            throw new NotImplementedException();
        }
        public Stream ReadStream(string filePath)
        {
            return OpenFile(filePath,FileMode.Open);
        }
    }
}
