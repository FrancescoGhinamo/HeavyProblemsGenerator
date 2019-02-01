using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyProblemsGenerator.Heavy.Backend.Service
{
    public class ByteFileFactory
    {
        public static IByteFileService GetByteFileService()
        {
            return (IByteFileService)new ByteFileServiceImpl();

        }
    }
}
