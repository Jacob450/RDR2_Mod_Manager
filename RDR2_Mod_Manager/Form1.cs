using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Environment;

namespace RDR2_Mod_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            ListView lv = lv_test;
            
            foreach(string s in GetFolderNames())
            {
                lv.Items.Add(s);
               
                
            }
            







        }

        private string[] GetFolderNames()
        {
            string drivePath = @"C:\Program Files\Rockstar Games\";

            try
            {
                // Get all files in the directory
                string[] files = Directory.GetDirectories(drivePath, "*", SearchOption.TopDirectoryOnly);
                if (files.Length.Equals(0))
                {
                    Console.WriteLine("Files Could not be accessed");
                    return null;
                }
                else
                {
                    Console.WriteLine(drivePath + "Was accessed");
                    return files;
                }
                
            }

            //execptions
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        private void btn_changeDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult = fbd.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                Console.WriteLine(fbd.SelectedPath);
            }
           
        }
    }
}
