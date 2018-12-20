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
            int limitFile = 0;
            Thread[] threads = new Thread[8];
            int splitSize = File.ReadLines(this.FileUrl).Count() / 8;
            using (var lines = File.ReadLines(this.FileUrl).GetEnumerator())
            {
                for (int i = 0; i < 8; i++)
                {
                    if(i == 0)
                    {
                        limitFile = splitSize;
                    }
                    else
                    {
                        limitFile = (i+1) * splitSize;
                    }

                    var th = new Thread(ImportData);

                    /*for (int j = i*splitSize; j < limitFile; j++)
                    {
                        
                        // insertData
                    }

                    //var th = new Thread();*/
                }
            }

        }
        private static void ImportData(IEnumerator<string> lines, int beginLine, int limitFile)
        {
            
            for (int i = beginLine; i < limitFile; i++)
            {


                //InsertData((string)lines.Current);

            }
        }
    }
}
