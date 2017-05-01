using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace NetCopy32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CopyButton.Click += new EventHandler(this.CopyOppie_Click);
        }
        
        //public void Form1_Load(object sender, EventArgs e)
        //{

            
        //}

        void CopyOppie_Click(Object sender, EventArgs c)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = true;
            od.InitialDirectory = "C:\\";
            od.Filter = "All files (*) | *.*";
            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FolderBrowserDialog sd = new FolderBrowserDialog();
                    if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        
                        string dirName = sd.SelectedPath;
                        
                        foreach (string fileName in od.FileNames)
                        {
                                                        
                            try
                            {
                                // System.IO.File.Copy(fileName, od2 + @"\" + System.IO.Path.GetFileName(fileName));
                                System.IO.File.Copy(fileName, dirName + "\\" + fileName);
                                MessageBox.Show("File(s) Copied from " + fileName + " to " + dirName + " Hopefully?");
                            }
                            catch(Exception copyErrors)
                            {
                                Console.WriteLine("Failed to copy 1 file " + copyErrors);
                                Console.ReadLine();
                            }
                        }
                    }
                }
                catch(Exception FFFatalErrors)
                {
                    Console.WriteLine("Bupkiss - savedialog and system.filecopy " + FFFatalErrors);
                    Console.ReadLine();
                }

            }
            }
        }
    }

// and this is where it gets cut short, this project is supposed to use a standard windows form, 
// have two options, one for copy and one for move, and only complete the copies or moving of files if the CRC32 of the source
// matches the CRC32 checksum of the destination, so essentially it will always copy and then delete the originals one at a time for 
// a move operation.
