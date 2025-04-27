using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsSolver
{
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal q = cmbQUnit.SelectedIndex == 0 ? numQ.Value : numQ.Value * 1000;
            decimal time = cmbTimeUnit.SelectedIndex == 0 ? numTime.Value : numTime.Value * 60;
            decimal power = cmbPowerUnit.SelectedIndex == 0 ? numPower.Value : numPower.Value * 745;
            if (power == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "Watt (SI Unit)";
                rd2Solid.Visible = true; rd2Solid.Text = "hp";
                if (time == 0)
                {
                    MessageBox.Show("Time cannot be 0!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return;
                }
                var result = q / time;
                string resultStr;

                if (rd2Solid.Checked) resultStr = String.Format("{0:0.00}", result / (decimal)745.7) + "hp";
                else resultStr = String.Format("{0:0.00}", result) + "Watt";

                lblPower.Text = resultStr;
                lblQ.Text = $"{q}J";
                lblTime.Text = $"{time}s";
                lblResult.Text = resultStr;
            }
            else if (q == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "J";
                rd2Solid.Visible = true; rd2Solid.Text = "KJ";

                var result = power * time;
                string resultStr;
                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "J";
                else resultStr = String.Format("{0:0.00}", result / 1000) + "KJ";

                lblPower.Text = $"{power}Watt";
                lblQ.Text = resultStr;
                lblTime.Text = $"{time}s";
                lblResult.Text = resultStr;
            }
            else if (time == 0)
            {
                rd1Solid.Visible = true; rd1Solid.Text = "s";
                rd2Solid.Visible = true; rd2Solid.Text = "min";
                var result = q / power;
                string resultStr;

                if (rd1Solid.Checked) resultStr = String.Format("{0:0.00}", result) + "s";
                else resultStr = String.Format("{0:0.00}", result / 60) + "min";

                lblPower.Text = $"{power}Watt";
                lblQ.Text = $"{power}J";
                lblTime.Text = resultStr;
                lblResult.Text = resultStr;
            }
            else if (power / time == q)
            {
                MessageBox.Show("The equation is valid.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The eqaution is not valid.", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Power_Load(object sender, EventArgs e)
        {
            cmbQUnit.SelectedIndex = 0;
            cmbTimeUnit.SelectedIndex = 0;
            cmbPowerUnit.SelectedIndex = 0;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string result = Regex.Replace(lblResult.Text, "[a-zA-Z/²³]", "");
            try
            {
                Clipboard.SetText(result);
                MessageBox.Show("Copied!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error copying the result to clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
