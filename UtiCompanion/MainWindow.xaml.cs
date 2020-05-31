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
using UtiCompanion.Model;

namespace UtiCompanion
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

        Uti uti = new Uti("Тестовая утилита");

        public void UpdateInfo()
        {
            lblSpecName.Content = uti.ReturnCurrentSpec().SpecName;
            lblSpecDescr.Content = uti.ReturnCurrentSpec().SpecDescr;
        }
        private void addSpec_Click(object sender, RoutedEventArgs e)
        {
            
            uti.AddSpec();
            uti.AddSpec("вторая спек", "описание второй спек");
            

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            uti.PlusCurrentSpec();
            UpdateInfo();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            uti.MinusCurrentSpec();
            UpdateInfo();
        }

        private void btnChangeSpecName_Click(object sender, RoutedEventArgs e)
        {
            uti.ReturnCurrentSpec().RenameSpec(tbSpecName.Text);
        }
    }
}
