using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                lines.MoveNext();
                
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

                    //threads[i] = new Thread(() => ImportData(lines, (i * splitSize), limitFile));
                }


                //threads.ToList().ForEach(th => th.Start());
                ImportData(lines, (splitSize), limitFile);
            }
        }
        private static void ImportData(IEnumerator<string> lines, int beginLine, int limitFile)
        {
            DataBase db = new DataBase();
            for (int i = beginLine; i < limitFile; i++)
            {
                db.InsertData(lines.Current.ToString());
                lines.MoveNext();
            }
        }
    }
}
