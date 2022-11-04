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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }



        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();



        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;


            //AD SOYAD ÇEKME

            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);              //LBLTC de yazan değere eşit olan Adı soyadı getiriyor
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();




            //Randevu Geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);                //data adapter in içini tablodan gelen değerle doldur demek
            dataGridView1.DataSource = dt;



            //Branşları Çekme

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);     // burada dr2[0] daki 0 ın anlamı tüm sütunu seçmesi
            }
            bgl.baglanti().Close();



        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);     //burada 0 ilk sütun 1 2.ci sütunu temsil ediyor
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "' and RandevuDoktor='" + cmbDoktor.Text + "' and RandevuDurum=0", bgl.baglanti());      //BURADA RANDEVUDOKTOR u eklememizin sebebi brans secince herhangi bir doktoru sectiğimizde diğer doktorlarda gözüküyordu ama and kullanıp randevudoktor eklediğimiz için düzeldi
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = LblTC.Text;      //FrmBilgiDüzenle Formunda tanımladığımız TCno yu buraya çagırdık Fr.show dan önce yazdığımız için önce tcno geldi sonra açıldı
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Alındı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGirisler frg = new FrmGirisler();
            frg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frg = new FrmHastaGiris();
            frg.Show();
            this.Hide();
        }
    }
}
