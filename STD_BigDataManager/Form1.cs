using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STD_BigDataManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnImportData_Click(object sender, EventArgs e)
        {
            if (ofdImportFile.ShowDialog() == DialogResult.OK)
            {
                Process process = new Process(ofdImportFile.InitialDirectory + ofdImportFile.FileName);
                process.splitFile();
            }
        }
    }
}
