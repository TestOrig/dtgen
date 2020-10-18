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

namespace DeviceTreeGenerator
{
    public partial class Form1 : Form
    {
        public void Abort()
        {
            MessageBox.Show("Aborting due to previous errors...", "Aborting", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Form1()
        {
            InitializeComponent();
            Dictionary<string, string> BoardFlags = new Dictionary<string, string>();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Console.WriteLine(openFileDialog1.FileName);
                    ImageLocationBox.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String imagesPath = Path.GetDirectoryName(ImageLocationBox.Text);
            string[] imagesUsed = new string [3];
            bool imagesFound = false;

            imagesUsed[0] = @"boot.img";
            imagesUsed[1] = @"system.img";
            imagesUsed[2] = @"vendor.img";

            foreach (string s in imagesUsed){
                if (!File.Exists(imagesPath + @"\" + s)) {
                    Console.WriteLine(imagesPath + @"\" + s);
                    MessageBox.Show(s + " was not found!, Verify your images path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    imagesFound = false;
                    break;
                }
                else
                {
                    Console.WriteLine(@"kk passed");
                    imagesFound = true;
                }
            }
            if (imagesFound == false)
            {
                Console.WriteLine(@"Calling abort!");
                Abort();
            }
        }


    }
}
