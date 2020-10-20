using System;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicio_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random generador;
        int contador = 0;
        int numeroElegido;

        public MainWindow()
        {
            InitializeComponent();
        }

        void GenerarNumero()
        {
            generador = new Random();
            numeroElegido = generador.Next(0, 100);
        }
        private void ComprobarBoton_Click(object sender, RoutedEventArgs e)
        {
            if(contador == 0)
            {
                GenerarNumero();
                contador++;
            }
            if (numeroElegido > Convert.ToInt32(EscribirTextBox.Text))
            {
                PistaTextBlock.Text = "Te has quedado corto";
            }
            else if (numeroElegido < Convert.ToInt32(EscribirTextBox.Text))
            {
                PistaTextBlock.Text = "Te has pasado";
            }
            else
            {
                PistaTextBlock.Text = "Has acertado!";
                contador = 0;
            }

        }

        private void ReiniciarBoton_Click(object sender, RoutedEventArgs e)
        {
            EscribirTextBox.Text = "";
            GenerarNumero();
            contador++;
        }
    }
}
