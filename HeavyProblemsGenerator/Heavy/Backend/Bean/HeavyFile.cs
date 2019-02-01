using HeavyProblemsGenerator.Heavy.Backend.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyProblemsGenerator.Heavy.Backend.Bean
{
    public class HeavyFile
    {
        public readonly string Path;

        public long Size { get; set; }

        public long SizeOnDisk
        {
            
            get
            {
                return Sectors * 4096;
            }
        }

        public int Sectors
        {
            get
            {
                return (int) (Size / 4096) + 1;
            }
        }
    

        public HeavyFile(string path)
        {
            this.Path = path;
        }


        public void CreateFile()
        {
            IByteFileService s = ByteFileFactory.GetByteFileService();
            s.WriteBytes(Path, Size);
        }

    }
}
