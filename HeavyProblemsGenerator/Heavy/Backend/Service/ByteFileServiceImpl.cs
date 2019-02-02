using HeavyProblemsGenerator.Heavy.Backend.Bean;
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
        private readonly IObserver Obs;
        internal ByteFileServiceImpl(IObserver obs)
        {
            Obs = obs;
        }

        public void WriteBytes(string path, long n)
        {
            Stream write = null;
            try
            {
                write = File.Create(path);
                for (int i = 0; i < n; i++)
                {
                    write.WriteByte(1);
                    write.Flush();
                    Obs.UpdateFromObservable((int) ((i + 1) * 100 / n));
                }
            }
            catch (Exception) { }
            finally
            {
                if(write != null)
                {
                    
                    write.Close();
                }
            }
        }
    }
}
