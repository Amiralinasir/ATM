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
using System.Windows.Shapes;
using static WpfApp1.ClassAtm;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MojodiWindow.xaml
    /// </summary>
    public partial class MojodiWindow : Window
    {
        decimal Mojodi = BankData.mojodi;
        public MojodiWindow()
        {
            InitializeComponent();
            lblMojodi.Content=Mojodi.ToString();
        }

        private void btnBargasht_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnKhoroj_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
