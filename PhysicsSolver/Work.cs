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
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();
        }

        private void btnCalculateFliuds_Click(object sender, EventArgs e)
        {
            if (numAlpha.Value > 360 || numAlpha.Value < 0)
            {
                MessageBox.Show("Alpha angle must be greater than or equal to 0 and less than 360.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal force = numForce.Value;
            decimal distance = cmbDistanceUnit.SelectedIndex == 0 ? numDistance.Value : numDistance.Value / 100;
            decimal cosAlpha = (decimal)Math.Cos((double)numAlpha.Value * (Math.PI / 180));
            decimal work = cmbWorkUnit.SelectedIndex == 0 ? numWork.Value : numWork.Value * 1000;

            if (work == 0)
            {
                rd1Fliud.Visible = true; rd1Fliud.Text = "J";
                rd2Fliud.Visible = true; rd2Fliud.Text = "KJ";

                var result = force * distance * cosAlpha;
                string resultStr;

                if (rd2Fliud.Checked) resultStr = String.Format("{0:0.00}", result / 1000) + "KJ";
                else resultStr = String.Format("{0:0.00}", result) + "J";

                lblForce.Text = force + "N";
                lblDistance.Text = distance + "m";
                lblAlpha.Text = "Cosα: " + cosAlpha;
                lblWork.Text = result + "J";

                lblResult.Text = resultStr;
            }
            else if (force == 0)
            {
                if (work == 0)
                {
                    MessageBox.Show("Pressure cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1Fliud.Visible = false;
                rd2Fliud.Visible = false;

                var result = distance * cosAlpha / work;
                string resultStr;

                resultStr = String.Format("{0:0.00}", result) + "N";

                lblForce.Text = result + "N";
                lblDistance.Text = distance + "m";
                lblAlpha.Text = "Cosα: " + cosAlpha;
                lblWork.Text = work + "J";
                lblResult.Text = resultStr;
            }
            else if (distance == 0)
            {
                if (work == 0)
                {
                    MessageBox.Show("Pressure cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1Fliud.Visible = true; rd1Fliud.Text = "m";
                rd2Fliud.Visible = true; rd2Fliud.Text = "cm";

                var result = force * cosAlpha / work;
                string resultStr;
                if (rd2Fliud.Checked) resultStr = String.Format("{0:0.00}", result * 100) + "cm";
                else resultStr = String.Format("{0:0.00}", result) + "m";

                lblForce.Text = result + "N";
                lblDistance.Text = resultStr;
                lblAlpha.Text = "Cosα: " + cosAlpha;
                lblWork.Text = work + "J";
                lblResult.Text = resultStr;
            }
            else if (cosAlpha == 0)
            {
                if (work == 0)
                {
                    MessageBox.Show("Pressure cannot be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rd1Fliud.Visible = false;
                rd2Fliud.Visible = false;

                var result = force * distance / work;
                string resultStr = "Cosα: " + String.Format("{0:0.00}", result * 100);

                lblForce.Text = result + "N";
                lblDistance.Text = distance + "m";
                lblAlpha.Text = "Cosα: " + result;
                lblWork.Text = work + "J";
                lblResult.Text = resultStr;
            }
        }

        private void Work_Load(object sender, EventArgs e)
        {
            cmbAlphaUnit.SelectedIndex = 0;
            cmbDistanceUnit.SelectedIndex = 0;
            cmbForceUnit.SelectedIndex = 0;
            cmbWorkUnit.SelectedIndex = 0;
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
