using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadraticEquator
{
    public partial class MainForm : Form
    {
        private decimal AinputVar = 0;
        private decimal BinputVar = 0;
        private decimal СinputVar = 0;
        private double Discriminant = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private void nMaxVar_ValueChanged(object sender, EventArgs e)
        {
            this.nAvar.Maximum = this.nMaxVar.Value;
            this.nBvar.Maximum = this.nMaxVar.Value;
            this.nCvar.Maximum = this.nMaxVar.Value;
        }

        private void nMinVar_ValueChanged(object sender, EventArgs e)
        {
            this.nAvar.Minimum = this.nMinVar.Value;
            this.nBvar.Minimum = this.nMinVar.Value;
            this.nCvar.Minimum = this.nMinVar.Value;
        }

        private void nAvar_ValueChanged(object sender, EventArgs e)
        {
            AinputVar = this.nAvar.Value;
        }

        private void nBvar_ValueChanged(object sender, EventArgs e)
        {
            BinputVar = this.nBvar.Value;
        }

        private void nCvar_ValueChanged(object sender, EventArgs e)
        {
            СinputVar = this.nCvar.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AinputVar == 0)
            {
                this.lUserError.Text += "Число A не должно являтся нулём!\n";
            }
            else
            {
                byte DiscrState = 0;
                string WeightDiscr = ". ";
                double AinEqua = Convert.ToDouble(AinputVar);
                double BinEqua = Convert.ToDouble(BinputVar);
                double CinEqua = Convert.ToDouble(СinputVar);
                Discriminant = Math.Pow(BinEqua, 2) - 4 * AinEqua * CinEqua;
                if (Discriminant > 0)
                {
                    DiscrState = 0;
                    WeightDiscr += " D > 0 \n";
                }
                else if (Discriminant == 0)
                {
                    DiscrState = 1;
                    WeightDiscr += "D = 0 \n";
                }
                else if (Discriminant < 0)
                {
                    DiscrState = 2;
                    WeightDiscr += "D < 0 \n";
                }
                this.lOutput.Text = "Дискриминант = " + Discriminant + WeightDiscr;
                switch(DiscrState)
                {
                    case 0:
                        double outputVarx = (-BinEqua + Math.Sqrt(Discriminant)) / (2 * AinEqua);
                        this.lOutput.Text += "\n" + $"{-BinEqua}" + " + " + $"{Math.Round(Math.Sqrt(Discriminant), 2)} \n";
                        this.lOutput.Text += $"------------ = {Math.Round(outputVarx, 2)} (x1)\n";
                        this.lOutput.Text += $"2 * {AinEqua}";


                        outputVarx = (-BinEqua - Math.Sqrt(Discriminant)) / (2 * AinEqua);
                        this.lOutput.Text += "\n \n" + $"{-BinEqua}" + " - " + $"{Math.Round(Math.Sqrt(Discriminant),2)}\n";
                        this.lOutput.Text += $"----------- = {Math.Round(outputVarx, 2)} (x2)\n";
                        this.lOutput.Text += $"2 * {AinEqua}";
                        break;
                    case 1:
                        outputVarx = -BinEqua / (2 * AinEqua);
                        this.lOutput.Text += "\n" + $"{-BinEqua}\n";
                        this.lOutput.Text += $"------------ = {Math.Round(outputVarx, 2)} (x)\n";
                        this.lOutput.Text += $"2 * {AinEqua}";
                        break;
                    case 2:
                        this.lOutput.Text += "\nНет Корней";
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lUserError.Text = "";
        }
    }
}
