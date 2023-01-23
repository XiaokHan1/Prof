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
    /// Логика взаимодействия для DobUch.xaml
    /// </summary>
    public partial class DobUch : Window
    {
        public DobUch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uch uch = new Uch();
            Close();
            uch.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(VagTb.Text))
                mes += "Выберите номер вагона\n";
            if (string.IsNullOrWhiteSpace(RabTb.Text))
                mes += "Выберите этажность\n";
            if (string.IsNullOrWhiteSpace(Dtg1.Text))
                mes += "Выберите этажность\n";
            if (string.IsNullOrWhiteSpace(Dtg2.Text))
                mes += "Выберите этажность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Models.Journal journal = new Models.Journal()
            {
                IdVagon = int.Parse(VagTb.Text),
                IdRabota = int.Parse(RabTb.Text),
                DateAdd = (DateTime)Dtg1.SelectedDate,
                DateEnd = (DateTime)Dtg2.SelectedDate
            };
            Helpers.ClassConnect.family.Journal.Add(journal);
            Helpers.ClassConnect.family.SaveChanges();
            MessageBox.Show("Запись добавлена");

            VagTb.Text = "";
            RabTb.Text = "";
            Dtg1.Text = "";
            Dtg2.Text = "";
        }
    }
}
