using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Data_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeInfoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeInfoDataSet.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter.Fill(this.employeeInfoDataSet.EmployeeInfo);

        }

        private void mxPayRateButton_Click(object sender, EventArgs e)
        {
            this.employeeInfoTableAdapter.HiToLowPay(this.employeeInfoDataSet.EmployeeInfo);
        }

        private void minPayRateButton_Click(object sender, EventArgs e)
        {
            this.employeeInfoTableAdapter.LowToHigh(this.employeeInfoDataSet.EmployeeInfo);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void highestPaybutton_Click(object sender, EventArgs e)
        {
            // declare a variable to hold max pay rate
            double maxie;

            // get the max pay rate.
            maxie = (double)this.employeeInfoTableAdapter.maxPayRate();

            // display the max pay rate.
            MessageBox.Show("The highest pay rate is: " + maxie.ToString("c"));
        }

        private void lowestPaybutton_Click(object sender, EventArgs e)
        {
            // declare a variable to hold max pay rate
            double minnie;

            // get the max pay rate.
            minnie = (double)this.employeeInfoTableAdapter.minPayRate();

            // display the max pay rate.
            MessageBox.Show("The lowest pay rate is: " + minnie.ToString("c"));
        }
    }
}
