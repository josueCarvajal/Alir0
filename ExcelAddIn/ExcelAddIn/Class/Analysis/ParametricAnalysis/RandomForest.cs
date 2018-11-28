using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAddIn.Class.Analysis.ParametricAnalysis
{
    class RandomForest
    {
        public string getTitle()
        {
            return "Random Forest";
        }

        public string getDescription()
        {
            return "A set of Random Forest Analysis";
        }
        public string[] getAnalysis()
        {
            return new string[] {
                "Random Forest"
            };
        }

        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               {"Random Forest","2"}
             };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {"Random Forest","Range"},
               {"Random Forest","Species"}
             };
        }
        public string[,] getFunctionName()
        {
            return new string[,]
            {
               {"Random Forest","ML_RandomForrest"}
             };
        }
    }
}
