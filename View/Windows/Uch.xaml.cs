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
    /// Логика взаимодействия для Uch.xaml
    /// </summary>
    public partial class Uch : Window
    {
        public Uch()
        {
            InitializeComponent();
            Dtg.ItemsSource = Helpers.ClassConnect.family.Journal.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavOkno glavOkno = new GlavOkno();
            glavOkno.Show();
            Close();
        }
    }
}
