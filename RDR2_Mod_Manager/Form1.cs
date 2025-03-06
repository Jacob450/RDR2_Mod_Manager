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
            
            updateSaveData();
            //default game directory for rockstar launcher
            //C:\Program Files\Rockstar Games\

            updateListView(SavedData.gamePath);
            
            
            
           
            







        }
        private void setSavedData(string path)
        {
            StreamWriter sw = new StreamWriter("saved.txt");
            sw.WriteLine(path);
            
            sw.Close();
        }

        private void updateSaveData()
        {
            StreamReader sr = new StreamReader("saved.txt");
            SavedData.gamePath = sr.ReadLine();
            Console.WriteLine("From Saved: " + SavedData.gamePath);
            sr.Close();
        }

        private void updateListView(string path)
        {
            ListView lv = lv_test;
            lbl_directory.Text = path;
            lv.Items.Clear();
            foreach (string s in GetFolderNames(path))
            {
                lv.Items.Add(s);


            }

        }

        private string[] GetFolderNames(string drivePath)
        {
            string[] error = {"No files Found Or Directory Does Not exist" };

            try
            {
                // Get all files in the directory
                string[] folders = Directory.GetDirectories(drivePath, "*", SearchOption.TopDirectoryOnly);
                if (folders.Length.Equals(0))
                {
                    Console.WriteLine("Files Could not be accessed");
                    
                    
                    return error;
                }
                else
                {
                    Console.WriteLine(drivePath + "Was accessed");
                    return folders;
                }
                
            }

            //execptions
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return error;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return error;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Error: " +ex.Message);
                MessageBox.Show("directoy not found");
                return error;
            }
        }

        private void btn_changeDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult = fbd.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                Console.WriteLine("Directory changed: " + fbd.SelectedPath);
                setSavedData(fbd.SelectedPath);
                updateListView(fbd.SelectedPath);
            }
           
        }
    }
}
