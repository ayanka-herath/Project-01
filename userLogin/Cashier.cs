using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userLogin
{
    public partial class Cashier : Form
    {
       

        public String bill = "";
        public Cashier()
        {
            InitializeComponent();
        }

        public Cashier(String bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Choose your file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                outputbill.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFile.FileName;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save your file";
            
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputbill.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = saveFile.FileName;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            this.outputbill.Text = bill;
            timer1.Start();
            timelbl.Text = DateTime.Now.ToLongTimeString();
            dtelbl.Text = DateTime.Now.ToLongDateString(); 

        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
             timelbl.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void outputbill_TextChanged(object sender, EventArgs e)
        {
            outputbill.Text="\t------------------------------------------------------------------------------------------\t" + Environment.NewLine +
                            "\t\t\t Treat Restaurant" + Environment.NewLine +
                          "\t------------------------------------------------------------------------------------------\t" + Environment.NewLine + "\t Time: " + timelbl.Text + Environment.NewLine +
                          "\t Date: " + dtelbl.Text + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOrderNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Printbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
