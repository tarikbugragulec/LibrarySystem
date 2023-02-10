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
using System.Data.SqlClient;

namespace Library
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
        sqlconnection baglan = new sqlconnection();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from kullanici where KullaniciAdi=@a1 and Sifre=@a2", baglan.baglanti());
            komut.Parameters.AddWithValue("@a1", kullanici.Text);
            komut.Parameters.AddWithValue("@a2", password.Password);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Window1 w1 = new Window1();
                w1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Kullanıcı Adı");
            }
            baglan.baglanti().Close();
        }
    }
}
