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

namespace Proje_Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;


        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;


            //Doktor Ad soyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);     //tc textbox ından gelen terim @p1 e eşit olucak demektir bu
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular Where RandevuDoktor='" + LblAdSoyad.Text + "'", bgl.baglanti()); // burada ad soyadda yazan değerle aynı olan doktorun randevularını getiriyoruz
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frg = new FrmDoktorGiris();
            frg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGirisler frg = new FrmGirisler();
            frg.Show();
            this.Hide();
        }
    }
}
