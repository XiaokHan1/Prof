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
    /// Логика взаимодействия для Journal.xaml
    /// </summary>
    public partial class Journal : Window
    {
        public Journal()
        {
            InitializeComponent();
            BoksCmb.SelectedValuePath = "Id";
            BoksCmb.DisplayMemberPath = "Status";
            BoksCmb.ItemsSource = Helpers.ClassConnect.family.Boks.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NumVag.Text))
                mes += "Выберите номер вагона\n";
            if (string.IsNullOrWhiteSpace(BoksCmb.Text))
                mes += "Выберите этажность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.Vagon vagon = new Models.Vagon()
            {
                Number = int.Parse(NumVag.Text),
                Boks = BoksCmb.SelectedItem as Models.Boks
            };
            Helpers.ClassConnect.family.Vagon.Add(vagon);
            Helpers.ClassConnect.family.SaveChanges();
            MessageBox.Show("Запись добавлена");

            NumVag.Text = "";
            BoksCmb.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavOkno glavOkno = new GlavOkno();
            Close();
            glavOkno.Show();
        }
    }
}
