using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn.Class.Analysis.Forms
{
    public partial class VectorInputs : Form
    {
        string selectedAnalsys;
        int numberOfVectors;
        string[] nameOfTheVectors;
        public VectorInputs(int numberOfVectors,string nameOfTheAnalisys, string[] nameOfTheVectors)
        {
            InitializeComponent();
            this.nameOfTheVectors = nameOfTheVectors;
            this.numberOfVectors = numberOfVectors;
            showInputs(numberOfVectors);
            this.TopMost = true;
            this.CenterToScreen();
            this.selectedAnalsys = nameOfTheAnalisys;
        }
        protected override void OnLoad(EventArgs e)
        {
            var btnVector1 = new Button();
            btnVector1.Size = new Size(25, txtVector1.ClientSize.Height + 2);
            btnVector1.Location = new Point(txtVector1.ClientSize.Width - btnVector1.Width, -1);
            btnVector1.Cursor = Cursors.Default;
            btnVector1.Image = Properties.Resources.matrix;
            btnVector1.Click += btnVector1_Click;

            var btnVector2 = new Button();
            btnVector2.Size = new Size(25, txtVector2.ClientSize.Height + 2);
            btnVector2.Location = new Point(txtVector2.ClientSize.Width - btnVector1.Width, -1);
            btnVector2.Cursor = Cursors.Default;
            btnVector2.Image = Properties.Resources.matrix;
            btnVector2.Click += btnVector2_Click;

            var btnVector3 = new Button();
            btnVector3.Size = new Size(25, txtVector3.ClientSize.Height + 2);
            btnVector3.Location = new Point(txtVector3.ClientSize.Width - btnVector1.Width, -1);
            btnVector3.Cursor = Cursors.Default;
            btnVector3.Image = Properties.Resources.matrix;
            btnVector3.Click += btnVector3_Click;

            var btnVector4 = new Button();
            btnVector4.Size = new Size(25, txtVector4.ClientSize.Height + 2);
            btnVector4.Location = new Point(txtVector4.ClientSize.Width - btnVector1.Width, -1);
            btnVector4.Cursor = Cursors.Default;
            btnVector4.Image = Properties.Resources.matrix;
            btnVector4.Click += btnVector4_Click;

            var btnVector5 = new Button();
            btnVector5.Size = new Size(25, txtVector5.ClientSize.Height + 2);
            btnVector5.Location = new Point(txtVector5.ClientSize.Width - btnVector1.Width, -1);
            btnVector5.Cursor = Cursors.Default;
            btnVector5.Image = Properties.Resources.matrix;
            btnVector5.Click += btnVector5_Click;


            var btnVector6 = new Button();
            btnVector6.Size = new Size(25, txtVector6.ClientSize.Height + 2);
            btnVector6.Location = new Point(txtVector6.ClientSize.Width - btnVector1.Width, -1);
            btnVector6.Cursor = Cursors.Default;
            btnVector6.Image = Properties.Resources.matrix;
            btnVector6.Click += btnVector6_Click;


            txtVector1.Controls.Add(btnVector1);
            txtVector2.Controls.Add(btnVector2);
            txtVector3.Controls.Add(btnVector3);
            txtVector4.Controls.Add(btnVector4);
            txtVector5.Controls.Add(btnVector5);
            txtVector6.Controls.Add(btnVector6);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(txtVector1.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnVector1.Width << 16));
            base.OnLoad(e);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (this.check_allowBlanks.Checked)//if checked the user is allowing blank cells
            {
                Class.BertCalls call = new BertCalls();
                string[] range = getRangeSelected(getNumberOfVisibleFields());
                call.bertCalls(selectedAnalsys, range);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Blank cells were found. \nIf you want to ignore them, mark the check box above", "Warning", MessageBoxButtons.OK);
            }
        }

        private string getRange()
        {
            Class.Validations validate = new Validations();
            return validate.getRange();
        }
        private int getNumberOfVisibleFields()
        {
            int contador = 0;
            if (txtVector1.Visible)
                contador++;
            if (txtVector2.Visible)
                contador++;
            if (txtVector3.Visible)
                contador++;
            if (txtVector4.Visible)
                contador++;
            if (txtVector5.Visible)
                contador++;
            if (txtVector6.Visible)
                contador++;
            return contador;
        }
        private string[] getRangeSelected(int numberOfVisibleFields)
        {

            switch (numberOfVisibleFields)
            {
                case 1:
                    return new string[] {
                    txtVector1.Text
                    };
                case 2:
                    return new string[] {
                    txtVector1.Text,
                    txtVector2.Text
                    };
                case 3:
                    return new string[] {
                    txtVector1.Text,
                    txtVector2.Text,
                    txtVector3.Text
                    };
                case 4:
                    return new string[] {
                    txtVector1.Text,
                    txtVector2.Text,
                    txtVector3.Text,
                    txtVector4.Text
                    };
                case 5:
                    return new string[] {
                    txtVector1.Text,
                    txtVector2.Text,
                    txtVector3.Text,
                    txtVector4.Text,
                    txtVector5.Text
                    };
                case 6:
                    return new string[] {
                    txtVector1.Text,
                    txtVector2.Text,
                    txtVector3.Text,
                    txtVector4.Text,
                    txtVector5.Text,
                    txtVector6.Text
                    };
                default:
                    break;
            }
            return null;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnVector1_Click(object sender, EventArgs e)
        {
            txtVector1.Text = getRange();
        }
        private void btnVector2_Click(object sender, EventArgs e)
        {
            txtVector2.Text = getRange();
        }
        private void btnVector3_Click(object sender, EventArgs e)
        {
            txtVector3.Text = getRange();
        }
        private void btnVector4_Click(object sender, EventArgs e)
        {
            txtVector4.Text = getRange();
        }
        private void btnVector5_Click(object sender, EventArgs e)
        {
            txtVector5.Text = getRange();
        }
        private void btnVector6_Click(object sender, EventArgs e)
        {
            txtVector6.Text = getRange();
        }
        private void showInputs(int numberOfInputs)
        {
            switch (numberOfInputs)
            {
                case 1:
                    this.lblVector1.Visible = true;
                    this.txtVector1.Visible = true;
                    this.lblVector1.Text = nameOfTheVectors[0];

                    this.lblVector2.Visible = false;
                    this.txtVector2.Visible = false;

                    this.lblVector3.Visible = false;
                    this.txtVector3.Visible = false;

                    this.lblVector4.Visible = false;
                    this.txtVector4.Visible = false;

                    this.lblVector5.Visible = false;
                    this.txtVector5.Visible = false;

                    this.lblVector6.Visible = false;
                    this.txtVector6.Visible = false;
                    break;
                case 2:
                    this.lblVector1.Visible = true;
                    this.txtVector1.Visible = true;
                    this.lblVector1.Text = nameOfTheVectors[0];

                    this.lblVector2.Visible = true;
                    this.txtVector2.Visible = true;
                    this.lblVector2.Text = nameOfTheVectors[1];

                    this.lblVector3.Visible = false;
                    this.txtVector3.Visible = false;

                    this.lblVector4.Visible = false;
                    this.txtVector4.Visible = false;

                    this.lblVector5.Visible = false;
                    this.txtVector5.Visible = false;

                    this.lblVector6.Visible = false;
                    this.txtVector6.Visible = false;
                    break;
                case 3:
                    this.lblVector1.Visible = true;
                    this.txtVector1.Visible = true;
                    this.lblVector1.Text = nameOfTheVectors[0];


                    this.lblVector2.Visible = true;
                    this.txtVector2.Visible = true;
                    this.lblVector2.Text = nameOfTheVectors[1];


                    this.lblVector3.Visible = true;
                    this.txtVector3.Visible = true;
                    this.lblVector3.Text = nameOfTheVectors[2];

                    this.lblVector4.Visible = false;
                    this.txtVector4.Visible = false;

                    this.lblVector5.Visible = false;
                    this.txtVector5.Visible = false;

                    this.lblVector6.Visible = false;
                    this.txtVector6.Visible = false;
                    break;
                case 4:
                    this.lblVector1.Visible = true;
                    this.txtVector1.Visible = true;
                    this.lblVector1.Text = nameOfTheVectors[0];

                    this.lblVector2.Visible = true;
                    this.txtVector2.Visible = true;
                    this.lblVector2.Text = nameOfTheVectors[1];

                    this.lblVector3.Visible = true;
                    this.txtVector3.Visible = true;
                    this.lblVector3.Text = nameOfTheVectors[2];

                    this.lblVector4.Visible = true;
                    this.txtVector4.Visible = true;
                    this.lblVector4.Text = nameOfTheVectors[3];

                    this.lblVector5.Visible = false;
                    this.txtVector5.Visible = false;

                    this.lblVector6.Visible = false;
                    this.txtVector6.Visible = false;
                    break;
                case 5:
                    this.lblVector1.Visible = true;
                    this.txtVector1.Visible = true;
                    this.lblVector1.Text = nameOfTheVectors[0];

                    this.lblVector2.Visible = true;
                    this.txtVector2.Visible = true;
                    this.lblVector2.Text = nameOfTheVectors[1];

                    this.lblVector3.Visible = true;
                    this.txtVector3.Visible = true;
                    this.lblVector3.Text = nameOfTheVectors[2];

                    this.lblVector4.Visible = true;
                    this.txtVector4.Visible = true;
                    this.lblVector4.Text = nameOfTheVectors[3];

                    this.lblVector5.Visible = true;
                    this.txtVector5.Visible = true;
                    this.lblVector5.Text = nameOfTheVectors[4];

                    this.lblVector6.Visible = false;
                    this.txtVector6.Visible = false;
                    break;
                case 6:
                    this.lblVector1.Visible = true;
                    this.txtVector1.Visible = true;
                    this.lblVector1.Text = nameOfTheVectors[0];

                    this.lblVector2.Visible = true;
                    this.txtVector2.Visible = true;
                    this.lblVector2.Text = nameOfTheVectors[1];

                    this.lblVector3.Visible = true;
                    this.txtVector3.Visible = true;
                    this.lblVector3.Text = nameOfTheVectors[2];

                    this.lblVector4.Visible = true;
                    this.txtVector4.Visible = true;
                    this.lblVector4.Text = nameOfTheVectors[3];

                    this.lblVector5.Visible = true;
                    this.txtVector5.Visible = true;
                    this.lblVector5.Text = nameOfTheVectors[4];

                    this.lblVector6.Visible = true;
                    this.txtVector6.Visible = true;
                    this.lblVector6.Text = nameOfTheVectors[5];
                    break;
                default:
                    break;
            }
        }
    }
}
