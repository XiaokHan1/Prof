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
    /// Логика взаимодействия для RabotaStatus.xaml
    /// </summary>
    public partial class RabotaStatus : Window
    {
        public RabotaStatus()
        {
            InitializeComponent();
            StatCmb.SelectedValuePath = "Id";
            StatCmb.DisplayMemberPath = "Name";
            StatCmb.ItemsSource = Helpers.ClassConnect.family.Status.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameRab.Text))
                mes += "Выберите номер вагона\n";
            if (string.IsNullOrWhiteSpace(StatCmb.Text))
                mes += "Выберите этажность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.Vagon vagon = new Models.Vagon()
            {
                Number = int.Parse(NameRab.Text),
                Boks = StatCmb.SelectedItem as Models.Boks
            };
            Helpers.ClassConnect.family.Vagon.Add(vagon);
            Helpers.ClassConnect.family.SaveChanges();
            MessageBox.Show("Запись добавлена");

            NameRab.Text = "";
            StatCmb.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavOkno glavOkno = new GlavOkno();
            glavOkno.Show();
            Close();
        }
    }
}
