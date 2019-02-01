using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyProblemsGenerator.Heavy.Backend.Service
{
    public class ByteFileServiceImpl : IByteFileService
    {
        internal ByteFileServiceImpl() { }

        public void WriteBytes(string path, long n)
        {
            Stream write = null;
            try
            {
                write = File.Create(path);
                for (int i = 0; i < n; i++)
                {
                    write.WriteByte(1);
                }
            }
            catch (Exception) { }
            finally
            {
                if(write != null)
                {
                    write.Flush();
                    write.Close();
                }
            }
        }
    }
}
