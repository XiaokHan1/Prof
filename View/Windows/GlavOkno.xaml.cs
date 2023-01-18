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

namespace ProfRabot.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для GlavOkno.xaml
    /// </summary>
    public partial class GlavOkno : Window
    {
        public GlavOkno()
        {
            InitializeComponent();
        }

        private void Jour_Click(object sender, RoutedEventArgs e)
        {
            Journal journal = new Journal();
            journal.Show();
            Close();
        }

        private void RabSta_Click(object sender, RoutedEventArgs e)
        {
            RabotaStatus rabotaStatus = new RabotaStatus();
            rabotaStatus.Show();
            Close();
        }

        private void Uchet_Click(object sender, RoutedEventArgs e)
        {
            Uch uch = new Uch();
            uch.Show();
            Close();
        }
    }
}
