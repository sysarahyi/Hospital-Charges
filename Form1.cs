using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalcStayCharges(double days) //method
        {
            return days * 350.0;
        }

        private double calcMiscCharges(double medical, double surgical, double lab, double rehab) //method
        {
            return (medical + surgical + lab + rehab);
        }

        private double CalcTotalCharges(double days, double medical, double surgical, double lab, double rehab) //method
        {
            return CalcStayCharges(days) + calcMiscCharges(medical, surgical, lab, rehab);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DaysSpentTxt.Text = "";
            MedChargesTxt.Text = "";
            SurgicalChargesTxt.Text = "";
            LabFeesTxt.Text = "";
            RehabChargesTxt.Text = "";
            TotalCostLabel.Text = "";
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //variables 
            double days, stayTotal, medical, surgical, lab, rehab, totalCharges;

            //get number of days 
            if(!double.TryParse(DaysSpentTxt.Text, out days) || days <= 0.0)
            {
                MessageBox.Show("Invalid Input");
                DaysSpentTxt.Focus();
                return;
            }

            //get medication charges 
            if(!double.TryParse(MedChargesTxt.Text, out medical) || medical < 0.0)
            {
                MessageBox.Show("Invalid Input");
                MedChargesTxt.Focus();
                return;
            }

            //get surgical charges
            if(!double.TryParse(SurgicalChargesTxt.Text, out surgical) || surgical < 0.0)
            {
                MessageBox.Show("Invalid Input");
                SurgicalChargesTxt.Focus();
                return;
            }

            //get lab fees
            if(!double.TryParse(LabFeesTxt.Text, out lab) || lab < 0.0)
            {
                MessageBox.Show("Invalid Input");
                LabFeesTxt.Focus();
                return;
            }

            //get rehab charges 
            if (!double.TryParse(RehabChargesTxt.Text, out rehab) || rehab < 0.0)
            {
                MessageBox.Show("Invalid Input");
                RehabChargesTxt.Focus();
                return;
            }

            stayTotal = CalcStayCharges(days);
            TotalCostLabel.Text = stayTotal.ToString("n");

            //calculate total charge 
            totalCharges = CalcTotalCharges(days, medical, surgical, lab, rehab);

            //display total charge
            TotalCostLabel.Text = totalCharges.ToString("c");
        }

    }
}
