using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            const double PCT_CHANGE = 1.04;
            double inputSalary;
            double outputSalary;

            Double.TryParse(txtInput.Text, out inputSalary);
            outputSalary = inputSalary * PCT_CHANGE;

            txtOutput.Text = outputSalary.ToString();
        }
    }
}
