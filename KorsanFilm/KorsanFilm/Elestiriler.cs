using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorsanFilm
{
    public partial class Elestiriler : Form
    {
        public Elestiriler()
        {
            InitializeComponent();
        }
        string connStr = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        private void Elestiriler_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connStr))
            {
                baglanti.Open();
                string sorgu = "SELECT filmler.film_ad,elestiriler.elestiri_metin,elestiriler.puan,elestiriler.elestiri_tarihi,elestiriler.elestirmen FROM elestiriler JOIN filmler ON filmler.film_id=elestiriler.elestiri_id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);

                dgvElestiri.DataSource = tablo;

            }
            
        }
    }
}
