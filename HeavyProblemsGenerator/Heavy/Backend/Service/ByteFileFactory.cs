using HeavyProblemsGenerator.Heavy.Backend.Bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyProblemsGenerator.Heavy.Backend.Service
{
    public class ByteFileFactory
    {
        public static IByteFileService GetByteFileService(IObserver obs)
        {
            return (IByteFileService)new ByteFileServiceImpl(obs);

        }
    }
}
