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
            DynamicUpdate();
        }

        private void nBvar_ValueChanged(object sender, EventArgs e)
        {
            BinputVar = this.nBvar.Value;
            DynamicUpdate();
        }

        private void nCvar_ValueChanged(object sender, EventArgs e)
        {
            СinputVar = this.nCvar.Value;
            DynamicUpdate();
        }


        private void DynamicUpdate()
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

                string UpStr;
                string DownStr;

                this.lOutput.Text = "";

                if (DiscrState == 2)
                {
                    this.lOutput.Text += $" \nD = {Math.Pow(BinEqua, 2)} - 4 * {AinEqua} * {CinEqua} = {Discriminant}\n \n";
                }
                else
                {
                    this.lOutput.Text += $"\nD = {Math.Pow(BinEqua, 2)} - 4 * {AinEqua} * {CinEqua} = {Discriminant}  =  {Math.Round(Math.Sqrt(Discriminant), 2)}\n \n";
                }
                this.lOutput.Text += "Дискриминант = " + Discriminant + WeightDiscr;
                switch (DiscrState)
                {
                    case 0:
                        double outputVarx = (-BinEqua + Math.Sqrt(Discriminant)) / (2 * AinEqua);

                        UpStr =  $"{-BinEqua}" + " + " + $"{Math.Round(Math.Sqrt(Discriminant), 2)}";
                        DownStr = $"2 * {AinEqua}";

                        this.lOutput.Text += "\n" + UpStr + "\n";
                        this.lOutput.Text += $"{LineRender(UpStr, DownStr)} = {Math.Round(outputVarx, 2)} (x1)\n";
                        this.lOutput.Text += DownStr;


                        outputVarx = (-BinEqua - Math.Sqrt(Discriminant)) / (2 * AinEqua);

                        UpStr = $"{-BinEqua}" + " - " + $"{Math.Round(Math.Sqrt(Discriminant), 2)}";
                        DownStr = $"2 * {AinEqua}";

                        this.lOutput.Text += "\n \n" + UpStr + "\n";
                        this.lOutput.Text += $"{LineRender(UpStr,DownStr)} = {Math.Round(outputVarx, 2)} (x2)\n";
                        this.lOutput.Text += DownStr;

                        break;
                    case 1:
                        outputVarx = -BinEqua / (2 * AinEqua);

                        UpStr = $"{-BinEqua}";
                        DownStr = $"2 * {AinEqua}";

                        this.lOutput.Text += "\n" + UpStr + "\n";
                        this.lOutput.Text += $"{LineRender(UpStr, DownStr)} = {Math.Round(outputVarx, 2)} (x)\n";
                        this.lOutput.Text += DownStr;
                        break;
                    case 2:
                        this.lOutput.Text += "\nНет Корней";
                        break;
                }
            }
        }

        private string LineRender(string UpString, string DownString)
        {
            string LineOutput = "";
            int MaxLenght = 0;

            if (UpString.Length >= DownString.Length)
            {
                MaxLenght += UpString.Length + 5;
            }
            else
            {
                MaxLenght += DownString.Length + 5;
            }

            for (int linelenght = 0; linelenght <= MaxLenght; linelenght++)
            {
                LineOutput += "-";
            }
            return LineOutput;
        }


        /*
        private void RoodsOutput(byte typeEq, double AValue, double BValue = 0,
                                double CValue = 0, double outputX1 = 0, double outputX2 = 0)
        {
            switch (typeEq)
            {
                // if 2 roods
                case 0:
                    {

                    }
                    break;
                // if 1 rood
                case 1:
                    {

                    }
                    break;
                // if no roods
                case 2:
                    {

                    }
                    break;
                //
                case 3:
                    {

                    }
                    break;
                //
                case 4:
                    {

                    }
                    break;
                default:
                    break;
            }

        }*/


        private void button2_Click(object sender, EventArgs e)
        {
            this.lUserError.Text = "";
        }
    }
}
