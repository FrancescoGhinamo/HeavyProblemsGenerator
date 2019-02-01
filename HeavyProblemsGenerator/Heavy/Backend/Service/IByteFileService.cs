using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyProblemsGenerator.Heavy.Backend.Service
{
    public interface IByteFileService
    {
        void WriteBytes(string path, long n);
    }
}
