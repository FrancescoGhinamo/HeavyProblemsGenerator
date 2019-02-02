using HeavyProblemsGenerator.Heavy.Backend.Bean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeavyProblemsGenerator.Heavy.Frontend.MainForm
{
    public partial class HeavyProblemsGenerator : Form, IObserver
    {

        private HeavyFile file;

        public HeavyProblemsGenerator()
        {
            InitializeComponent();
        }

        private void itemDestination_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "prblm"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                file = new HeavyFile(saveDialog.FileName, this);
                txtSize.Enabled = true;
                Console.WriteLine("Selected file: " + file.Path);
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            if (!txtSize.Text.Equals(""))
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            long size = long.Parse(txtSize.Text);
            file.Size = size;
            DialogResult confirmResult = MessageBox.Show(this, "Create file with these features?\n\nSize: " + file.Size + "\nSize on disk: " + file.SizeOnDisk + "\nSectors: " + file.Sectors, "Confirm creation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Console.WriteLine("\nCreating file...");
                file.CreateFile();
                Console.WriteLine("\n\nCreated file: " + file.Path);
                Console.WriteLine("Size: " + file.Size + "\nSize on disk: " + file.SizeOnDisk + "\nSectors: " + file.Sectors + "\n\n");
            }
            file = null;
            txtSize.Text = "";
            txtSize.Enabled = false;
            btnCreate.Enabled = false;
            progress.Value = 0;
        }

        public void UpdateFromObservable(int o)
        {

            progress.Value = o;
            Console.WriteLine("Status: " + o);
            //Thread.Sleep(1);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeavyProblemsGenerator());
        }

        
    }
}
