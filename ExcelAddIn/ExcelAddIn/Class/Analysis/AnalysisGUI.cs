using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn.Class
{
    public partial class AnalysisGUI : Form
    {
        string[] analysis;
        string[,] numberOfVectors;
        string[,] nameOfVectors;
        string[,] nameOfFunctions;
        public AnalysisGUI(string title, string description, string[] analysis, string[,] nameOfVectors, string [,] numberOfVectors, string[,] nameOfFunctions)
        {
            InitializeComponent();
            loadCustomData(title,description,analysis);
            this.analysis = analysis;
            this.numberOfVectors = numberOfVectors;
            this.nameOfVectors = nameOfVectors;
            this.nameOfFunctions = nameOfFunctions;
        }
        private void loadCustomData(string title, string description, string[] analysis)
        {
            this.Text = title;
            this.lbl_description.Text = description;
            this.cb_AnalysisChooser.DataSource = analysis;

            this.cb_AnalysisChooser.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TopMost = true;
            this.Show();
            this.CenterToScreen();
        }
        private void AnalysisGUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_solve_Click(object sender, EventArgs e)
        {
            Class.Validations validations = new Validations();
            int numberOfInputs = validations.getNumberOfVectors(getSelectedAnalysis(), this.numberOfVectors);
            string nameOfTheFunction = validations.getFunctionName(getSelectedAnalysis(), this.nameOfFunctions);
            string[] inputNames = validations.getNameOfVectors(getSelectedAnalysis(), this.nameOfVectors);
            Class.Analysis.Forms.VectorInputs vectorInputForm = new Analysis.Forms.VectorInputs(numberOfInputs, nameOfTheFunction,inputNames);
            vectorInputForm.Show();
        }
        private string getSelectedAnalysis()
        {
            string selectedText = cb_AnalysisChooser.SelectedItem.ToString();
            return selectedText;
        }
    }
}
