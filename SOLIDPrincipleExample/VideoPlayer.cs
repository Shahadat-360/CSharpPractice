using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class VideoPlayer
    {
        private readonly IFileUtility _fileUtility;
        public VideoPlayer(IFileUtility fileUtility) 
        {
            _fileUtility = fileUtility;
        }
        public void play(string FileName)
        {
            Stream stream = _fileUtility.ReadStream(FileName);
        }
    }
}
