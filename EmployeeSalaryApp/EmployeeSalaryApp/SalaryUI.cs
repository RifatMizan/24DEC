using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            EmployeeSalary anEmployeeSalary = new EmployeeSalary();
            anEmployeeSalary.name = employeeNameTextBox.Text;
            anEmployeeSalary.basic = Convert.ToDouble(basicAmountTextBox.Text);
            anEmployeeSalary.houseRentPercent = Convert.ToDouble(houseRentTextBox.Text);
            anEmployeeSalary.medicalAllowancePercent = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double total = anEmployeeSalary.CalculateTotal();
            MessageBox.Show(total.ToString());

        }
    }
}
