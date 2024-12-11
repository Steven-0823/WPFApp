﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void CreateTask()
        {
            Task T;
            // Que es un Delegado? Apuntador a funciones 
            // Por ejemplo: Action y Func 
            Action Code = new Action(ShowMessage);
            T = new Task(Code);
            Task T2 = new(delegate
            {
                MessageBox.Show("Ejecutando una tarea en un metodo anonimo");            
            }
            );

            Task T3 = new Task(
                    () => ShowMessage());

            //Expresion Lamda:
            //(parametros de entrada ) => Expresion
            //() => Expresion
            // El operador lambda (=>) se lee como "va hacia"

            Task T4 = new Task(() => MessageBox.Show("Ejecutnado"));

            Task T5 = new Task(() =>
            {
                DateTime CurrentDate = DateTime.Today;
                DateTime StartDate = CurrentDate.AddDays(30);
                MessageBox.Show($"Tarea 5. Fecha calculada: {StartDate}");
            });
        }

        void ShowMessage()
        {
            MessageBox.Show("Ejecutando el método ShowMessage");
        }
    }
}