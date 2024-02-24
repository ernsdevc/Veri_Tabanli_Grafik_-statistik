using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanli_Grafik_İstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MACHINEX;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void btnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtA.Text);
            komut.Parameters.AddWithValue("@P3", txtB.Text);
            komut.Parameters.AddWithValue("@P4", txtC.Text);
            komut.Parameters.AddWithValue("@P5", txtD.Text);
            komut.Parameters.AddWithValue("@P6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
