﻿using System;
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
    public partial class Gravitational : Form
    {
        public Gravitational()
        {
            InitializeComponent();
        }

        private void btnCalculateFliuds_Click(object sender, EventArgs e)
        {
            decimal mass = cmbMassUnit.SelectedIndex == 0 ? numMass.Value : numMass.Value / 1000;
            decimal g = numG.Value;
            decimal height = cmbHeightUnit.SelectedIndex == 0 ? numHeight.Value : numHeight.Value / 100;
            decimal u = cmbUUnit.SelectedIndex == 0 ? numU.Value : numU.Value * 1000;

            if (u == 0)
            {
                rd1.Visible = true; rd1.Text = "J (SI واحد)";
                rd2.Visible = true; rd2.Text = "KJ";

                var result = mass * g * height;
                string resultStr;

                if (rd2.Checked) resultStr = String.Format("{0:0.00}", result / 1000) + "KJ";
                else resultStr = String.Format("{0:0.00}", result) + "J";

                lblMass.Text = mass + "Kg";
                lblG.Text = g + "m/s²";
                lblHeight.Text = height + "m";
                lblU.Text = result + "J";

                lblResult.Text = resultStr;
            }
            else if (mass == 0)
            {
                if (u == 0)
                {
                    MessageBox.Show("U (gravitational energy) cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1.Visible = true; rd1.Text = "Kg";
                rd2.Visible = true; rd2.Text = "g";

                var result = u / (g * height);
                string resultStr;

                if (rd2.Checked) resultStr = String.Format("{0:0.00}", result * 1000) + "g";
                else resultStr = String.Format("{0:0.00}", result) + "Kg";

                lblMass.Text = result + "Kg";
                lblG.Text = g + "m/s²";
                lblHeight.Text = height + "m";
                lblU.Text = u + "J";
                lblResult.Text = resultStr;
            }
            else if (g == 0)
            {
                if (u == 0)
                {
                    MessageBox.Show("U (gravitational energy) cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1.Visible = false;
                rd2.Visible = false;

                var result = u / (height * mass);
                string resultStr = String.Format("{0:0.00}", result) + "m/s²";

                lblMass.Text = mass + "Kg";
                lblG.Text = resultStr;
                lblHeight.Text = height + "m";
                lblU.Text = u + "J";
                lblResult.Text = resultStr;
            }
            else if (height == 0)
            {
                if (u == 0)
                {
                    MessageBox.Show("U (gravitational energy) cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1.Visible = true; rd1.Text = "m";
                rd2.Visible = true; rd2.Text = "cm";

                var result = u / (mass * g);
                string resultStr;

                if (rd2.Checked) resultStr = String.Format("{0:0.00}", result * 100) + "cm";
                else resultStr = String.Format("{0:0.00}", result) + "m";

                lblMass.Text = mass + "Kg";
                lblG.Text = g + "m/s²";
                lblHeight.Text = result + "m";
                lblU.Text = u + "J";
                lblResult.Text = resultStr;
            }
        }

        private void Gravitational_Load(object sender, EventArgs e)
        {
            cmbMassUnit.SelectedIndex = 0;
            cmbGUnit.SelectedIndex = 0;
            cmbHeightUnit.SelectedIndex = 0;
            cmbUUnit.SelectedIndex = 0;
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
