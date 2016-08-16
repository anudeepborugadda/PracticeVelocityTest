using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeVelocity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

       private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterEvent objReg = new RegisterEvent();

           txtResultDisplay.Text= objReg.GenerateMultiples();
           
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            DiagnoseEvent objDiag = new DiagnoseEvent();

            txtResultDisplay.Text = objDiag.GenerateMultiples();

        }

       
    }
}
