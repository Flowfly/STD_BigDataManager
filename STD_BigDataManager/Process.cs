using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace STD_BigDataManager
{
    class Process
    {
        public delegate void ParameterizedThreadStart(IEnumerator<string> line, int chunk);
        public string FileUrl { get; set; }

        public Process(string pFileUrl)
        {
            this.FileUrl = pFileUrl;
        }

        public void splitFile()
        {
            Thread[] threads = new Thread[8];
            int splitSize = File.ReadLines(this.FileUrl).Count() / 8;
            using (var line = File.ReadLines(this.FileUrl).GetEnumerator())
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < splitSize; j++)
                    {

                    }
                    //var th = new Thread();
                    //ImportData(line, splitSize, i);
                }
            }

        }
        /*private static void ImportData(IEnumerator<string> line, int chunk)
        {
            
            for (int i = 0; i < splitSize; i++)
            {
                

                if (!line.MoveNext())
                {
                }

                //INSERT
            }
        }*/
    }
}
