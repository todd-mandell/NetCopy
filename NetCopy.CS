using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetCopy32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = true;
            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenFileDialog od2 = new OpenFileDialog();
                od2.Multiselect = false;

                foreach (string fileName in od.FileNames)
                {
                   // System.IO.File.Copy(fileName, od2 + @"\" + System.IO.Path.GetFileName(fileName));
                    System.IO.File.Copy(fileName, fileName2);



// and this is where it gets cut short, this project is supposed to use a standard windows form, 
// have two options, one for copy and one for move, and only complete the copies or moving of files if the CRC32 of the source
// matches the CRC32 checksum of the destination, so essentially it will always copy and then delete the originals one at a time for 
// a move operation.
                }
            }
            
        }
    }
}
