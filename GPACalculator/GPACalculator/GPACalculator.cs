using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 4;
        private string name = "";
        private string name1 = "";
        private string name2 = "";
        private string alldata = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gpa"></param>
        public void addGPA(double gpa,string name )
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa + Environment.NewLine;

            if(this.max < gpa)
            {
                this.max = gpa;
                this.name1 = name;
            }
            if (this.min > gpa)
            {
                this.min = gpa;
                this.name2 = name;

            }
        }
        public double getGPA()
        {
            double result = this.sum / this.n;
            return result;

        }
        public double getmin()
        {
            return this.min;
        }
        public double getmax()
        {
            return this.max;
        }
        public string getmaxname()
        {
            return name1;
        }
        public string getalldata()
        {
            return alldata;
        }
        public string getminname()
        {
            return name2;
        }
    }
}
