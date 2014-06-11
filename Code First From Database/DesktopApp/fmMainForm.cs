using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class fmMainForm : Form
    {
        public fmMainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Close the program/form
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Open a form as a dialogue box for viewing Region information
            fmViewRegions frm = new fmViewRegions();
            frm.ShowDialog();  //Execution of this method will PAUSE here until the dialogue box (fmViewRegions) 
                               //  is closed, resume after the dialogue box is closed
        }

        private void fmMainForm_Load(object sender, EventArgs e)
        {
            //Set the application's startup date/time in the status bar
            lbStatusTime.Text = "App started on " + DateTime.Now.ToString("dd-MMM-yyyy HH:mm");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmViewShippers theForm = new fmViewShippers();
            theForm.MdiParent = this;  //Tell fmViewShippers that fmMainForm is the parent
            theForm.WindowState = FormWindowState.Maximized;
            theForm.Show();  //Do NOT pause here as the form is displayed
            MessageBox.Show("Here is the fmViewShipper's form!");
        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void errorLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutThisAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: 1) Open the AboutApp form as a dialogue window
            fmAboutApp theForm = new fmAboutApp();
            theForm.Text = "Glad you asked!";
            theForm.ShowDialog();  //we pause in this method until the fmAboutApp form is closed.
            
            MessageBox.Show("Thanks for asking!");
        }
    }
}
