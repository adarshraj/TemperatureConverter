using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class TempConverter : Form
    {
        //varables
        double celTemp, farTemp, kelTemp, ranTemp, reauTemp;

        //Eqations
        //  °F = (1.8 x °C) +32
        //  °C = (°F-32) x 0.555
        //  Kelvin = °C + 273.2
        // °Rankin = °F + 459.67

        public TempConverter()
        {
            InitializeComponent();
        }

        private void TempConverter_Load(object sender, EventArgs e)
        {
            txtCelsius.ReadOnly = false;
            txtFahren.ReadOnly = true;
            txtKelvin.ReadOnly = true;
            txtRankin.ReadOnly = true;
            txtReamur.ReadOnly = true;
        }

        private void txtCelsius_MouseDown(object sender, MouseEventArgs e)
        {
            txtCelsius.ReadOnly = false;
            txtFahren.ReadOnly = true;
            txtKelvin.ReadOnly = true;
            txtRankin.ReadOnly = true;
            txtReamur.ReadOnly = true;
        }

        private void txtFahren_MouseDown(object sender, MouseEventArgs e)
        {
            txtCelsius.ReadOnly = true;
            txtFahren.ReadOnly = false;
            txtKelvin.ReadOnly = true;
            txtRankin.ReadOnly = true;
            txtReamur.ReadOnly = true;
        }

        private void txtKelvin_MouseDown(object sender, MouseEventArgs e)
        {
            txtCelsius.ReadOnly = true;
            txtFahren.ReadOnly = true;
            txtKelvin.ReadOnly = false;
            txtRankin.ReadOnly = true;
            txtReamur.ReadOnly = true;     
        }

        private void txtRankin_MouseDown(object sender, MouseEventArgs e)
        {
            txtCelsius.ReadOnly = true;
            txtFahren.ReadOnly = true;
            txtKelvin.ReadOnly = true;
            txtRankin.ReadOnly = false;
            txtReamur.ReadOnly = true;    
        }

        private void txtReamur_MouseDown(object sender, MouseEventArgs e)
        {
            txtCelsius.ReadOnly = true;
            txtFahren.ReadOnly = true;
            txtKelvin.ReadOnly = true;
            txtRankin.ReadOnly = true;
            txtReamur.ReadOnly = false;   
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCelsius.Focused == true)
                {
                    celTemp = Convert.ToDouble(txtCelsius.Text);

                    farTemp = (9 * celTemp + 160) / 5;
                    kelTemp = celTemp + 273.15;
                    ranTemp = farTemp + 459.67;
                    reauTemp = celTemp * 0.8;

                    txtFahren.Text = Convert.ToString(farTemp);
                    txtKelvin.Text = Convert.ToString(kelTemp);
                    txtRankin.Text = Convert.ToString(ranTemp);
                    txtReamur.Text = Convert.ToString(reauTemp);

                }
            }
            catch (Exception)
            { }


        }

        private void txtFahren_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFahren.Focused == true)
                {
                    farTemp = Convert.ToDouble(txtFahren.Text);

                    celTemp = ((farTemp - 32) * 5) / 9;
                    kelTemp = celTemp + 273.15;
                    ranTemp = farTemp + 459.67;
                    reauTemp = celTemp * 0.8;

                    txtCelsius.Text = Convert.ToString(celTemp);
                    txtKelvin.Text = Convert.ToString(kelTemp);
                    txtRankin.Text = Convert.ToString(ranTemp);
                    txtReamur.Text = Convert.ToString(reauTemp);

                }
            }
            catch (Exception)
            { }
        }

        private void txtKelvin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtKelvin.Focused == true)
                {
                    kelTemp = Convert.ToDouble(txtKelvin.Text);

                    // Kelvin = °C + 273.2

                    celTemp = kelTemp - 273.15;
                    farTemp = (9 * celTemp + 160) / 5;
                    ranTemp = farTemp + 459.67;
                    reauTemp = celTemp * 0.8;

                    txtCelsius.Text = Convert.ToString(celTemp);
                    txtFahren.Text = Convert.ToString(farTemp);
                    txtRankin.Text = Convert.ToString(ranTemp);
                    txtReamur.Text = Convert.ToString(reauTemp);

                }
            }
            catch (Exception)
            { }
        }

        private void txtRankin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRankin.Focused == true)
                {
                    ranTemp = Convert.ToDouble(txtRankin.Text);

                    // °Rankin = °F + 459.67

                    farTemp = ranTemp - 459.67;
                    celTemp = ((farTemp - 32) * 5) / 9;
                    kelTemp = celTemp + 273.15;
                    reauTemp = celTemp * 0.8;

                    txtCelsius.Text = Convert.ToString(celTemp);
                    txtFahren.Text = Convert.ToString(farTemp);
                    txtKelvin.Text = Convert.ToString(kelTemp);
                    txtReamur.Text = Convert.ToString(reauTemp);

                }
            }
            catch (Exception)
            { }
        }

        private void txtReamur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtReamur.Focused == true)
                {
                    reauTemp = Convert.ToDouble(txtReamur.Text);

                    // °Reaumur = °C * 0.8;

                    celTemp = reauTemp  /  0.8;
                    farTemp = (9 * celTemp + 160) / 5;
                    kelTemp = celTemp + 273.15;
                    ranTemp = farTemp + 459.67;

                    txtCelsius.Text = Convert.ToString(celTemp);
                    txtFahren.Text = Convert.ToString(farTemp);
                    txtKelvin.Text = Convert.ToString(kelTemp);
                    txtRankin.Text = Convert.ToString(ranTemp);

                }
            }
            catch (Exception)
            { }

        }



    }
}
