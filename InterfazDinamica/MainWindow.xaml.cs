using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfazDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbNueva_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametros.Children.Clear();
            switch (cbNueva.SelectedIndex)
            {
                case 0: grdParametros.Children.Add(new ParametrosAlumno());
                    break;
                case 1:
                    grdParametros.Children.Add(new ParametrosMaestro());
                    break;
                default:
                    break;

            }
        }

        private void BtnGuardar1_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbNueva.SelectedIndex)
            {
                case 0:
                    ((ParametrosAlumno)(grdParametros.Children[0])).ParaNombreAlu.Text = "";
                    ((ParametrosAlumno)(grdParametros.Children[0])).ParaMatriculaAlu.Text = "";
                    ((ParametrosAlumno)(grdParametros.Children[0])).ParaPrepaAlu.Text = "";
                    break;
              case 1:
                    ((ParametrosMaestro)(grdParametros.Children[0])).ParaNombreMae.Text = "";
                    ((ParametrosMaestro)(grdParametros.Children[0])).ParaCodigoMae.Text = "";
                    ((ParametrosMaestro)(grdParametros.Children[0])).ParaMateriaMae.Text = "";
                    ((ParametrosMaestro)(grdParametros.Children[0])).ParaTituloMae.Text = "";

                    break;
                default:
                    break;
            }
            btnGuardar1.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
        }
    }
}
