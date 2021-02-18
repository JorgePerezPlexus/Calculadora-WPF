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
        List<double> memoria = new List<double>();
        bool sumClicked = false;
        bool restClicked = false;
        bool multClicked = false;
        bool divClicked = false;
        bool calcAvan = false;


        public MainWindow()
        {
            InitializeComponent();
            TextBoxResultado.Text = "0";
            calcSimple();
        }

        private void calcSimple()
        {
            BotonCuadrado.Visibility = Visibility.Hidden;
            BotonCubo.Visibility = Visibility.Hidden;
            BotonRaiz.Visibility = Visibility.Hidden;
            BotonPi.Visibility = Visibility.Hidden;
        }

        private void calcAvanzada()
        {
            BotonCuadrado.Visibility = Visibility.Visible;
            BotonCubo.Visibility = Visibility.Visible;
            BotonRaiz.Visibility = Visibility.Visible;
            BotonPi.Visibility = Visibility.Visible;

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

        
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TextBoxResultado.Text = "0";
            LabelOperaciones.Content = "";
            memoria.Clear();
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = false;
        }

        private void MenuAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcercaDeWindow w = new AcercaDeWindow();
            w.Show();
        }

        private void SubMenúAvanzada_Click(object sender, RoutedEventArgs e)
        {
            if (calcAvan)
            {
                calcSimple();
                calcAvan = false;
                SubMenúAvanzada.Header = "Calc Simple";
            } else
            {
                calcAvanzada();
                calcAvan = true;
                SubMenúAvanzada.Header = "Calc Simple";
            }
            
            
        }

        private void BotonCuadrado_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            double cuadrado = Math.Pow(numero, 2);
            TextBoxResultado.Text = cuadrado.ToString();
            memoria.Add(cuadrado);
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "x²";
        }

        private void BotonCubo_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            double cuadrado = Math.Pow(numero, 3);
            TextBoxResultado.Text = cuadrado.ToString();
            memoria.Add(cuadrado);
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "x³";
        }

        private void BotonRaiz_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(TextBoxResultado.Text);
            double cuadrado = Math.Sqrt(numero);
            TextBoxResultado.Text = cuadrado.ToString();
            memoria.Add(cuadrado);
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "√";
        }

        private void BotonPi_Click(object sender, RoutedEventArgs e)
        {
            TextBoxResultado.Text = "3,1415926535";
            LabelOperaciones.Content = "π";
        }
    }
}
