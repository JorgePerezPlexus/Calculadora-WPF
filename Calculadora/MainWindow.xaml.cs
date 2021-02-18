using System;
using System.Collections.Generic;
using System.Windows;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables
        //List<double> listaNumeros = new List<double>();
        //List<string> listaOperaciones = new List<string>();
        List<double> memoria = new List<double>();
        bool sumClicked = false;
        bool restClicked = false;
        bool multClicked = false;
        bool divClicked = false;


        public MainWindow()
        {
            InitializeComponent();
            TextBoxResultado.Text = "0";
        }


        private void BotonBorrarTodo_Click(object sender, RoutedEventArgs e)
        {
            TextBoxResultado.Text = "0";
            LabelOperaciones.Content = "";
            memoria.Clear();
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = false;
        }

        private void BotonUno_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "1";
            } else 
            TextBoxResultado.AppendText("1");
        }

        private void BotonDos_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "2";
            }
            else
                TextBoxResultado.AppendText("2");
        }

        private void BotonTres_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "3";
            }
            else
                TextBoxResultado.AppendText("3");
        }

        private void BotonCuatro_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "4";
            }
            else
                TextBoxResultado.AppendText("4");
        }

        private void BotonCinco_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "5";
            }
            else
                TextBoxResultado.AppendText("5");
        }

        private void BotonSeis_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "6";
            }
            else
                TextBoxResultado.AppendText("6");
        }

        private void BotonSiete_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "7";
            }
            else
                TextBoxResultado.AppendText("7");
        }

        private void BotonOcho_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "8";
            }
            else
                TextBoxResultado.AppendText("8");
        }

        private void BotonNueve_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "9";
            }
            else
                TextBoxResultado.AppendText("9");
        }

        private void BotonCero_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResultado.Text.Equals("0"))
            {
                TextBoxResultado.Text = "0";
            }
            else
                TextBoxResultado.AppendText("0");
        }

        private void BotonPunto_Click(object sender, RoutedEventArgs e)
        {
            if (!TextBoxResultado.Text.Contains(",")) {
                TextBoxResultado.AppendText(",");
            }
            
        }

        private void BotonBorrarAtras_Click(object sender, RoutedEventArgs e)
        {
            string pantalla = TextBoxResultado.Text;

            if (pantalla.Length > 1)
            {
                pantalla = pantalla.Substring(0, pantalla.Length - 1);
            }
            else
            {
                pantalla = "0";
            }

            TextBoxResultado.Text = pantalla;
        }

        private void BotonSumar_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] + numero);
            } else
            {
                memoria.Add(numero);
            }
            sumClicked = true;
            restClicked = false;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "+";
            TextBoxResultado.Text = "0";
        }

       
        private void BotonRestar_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] - numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = false;
            restClicked = true;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "-";
            TextBoxResultado.Text = "0";
        }

        private void BotonMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] * numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = false;
            restClicked = false;
            multClicked = true;
            divClicked = false;
            LabelOperaciones.Content = "*";
            TextBoxResultado.Text = "0";
        }

        private void BotonDividir_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] / numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = true;
            LabelOperaciones.Content = "/";
            TextBoxResultado.Text = "0";
        }

        private void BotonIgual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (memoria.Count > 0)
                {

                    LabelOperaciones.Content = "=";
                    if (sumClicked)
                    {
                        TextBoxResultado.Text = (memoria[memoria.Count - 1] + Double.Parse(TextBoxResultado.Text)).ToString();
                        sumClicked = false;
                    }
                    else if (restClicked)
                    {
                        TextBoxResultado.Text = (memoria[memoria.Count - 1] - Double.Parse(TextBoxResultado.Text)).ToString();
                        restClicked = false;
                    }
                    else if (multClicked)
                    {
                        TextBoxResultado.Text = (memoria[memoria.Count - 1] * Double.Parse(TextBoxResultado.Text)).ToString();
                        multClicked = false;
                    }
                    else if (divClicked)
                    {
                        TextBoxResultado.Text = (memoria[memoria.Count - 1] / Double.Parse(TextBoxResultado.Text)).ToString();
                        divClicked = false;
                    }
                    memoria.Clear();
                }
            } catch (Exception ex)
            {
                LabelOperaciones.Content = "Error";
                memoria.Clear();
                sumClicked = false;
                restClicked = false;
                multClicked = false;
                divClicked = false;
            }
           

        }

        private void BotonMemoria_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            memoria.Add(numero);
            TextBoxResultado.Text = "0";
        }
    }
}
