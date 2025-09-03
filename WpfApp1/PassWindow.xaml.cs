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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PassWindow.xaml
    /// </summary>
    public partial class PassWindow : Window
    {
        string Pass = "1234";
        int PassCount = 0;

        public PassWindow()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            
              
                if (txtPass.Text != Pass)
                {
               
                MessageBox.Show("رمز اشتباه است", "اخطار", MessageBoxButton.OK);
                txtPass.Text = "";
                PassCount++;
                if (PassCount >=3)
                {
                    MessageBox.Show("کارت شما سوخت", "اخطار", MessageBoxButton.OK);
                    Application.Current.Shutdown();
                }
                   
                }
                else
                {
                
                    this.Close();
                }
            
        }

        private void btnTashih_Click(object sender, RoutedEventArgs e)
        {
            txtPass.Text = "";
        }
    }
}
