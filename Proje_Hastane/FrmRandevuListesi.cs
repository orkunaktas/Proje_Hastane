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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();


        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Randevular ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }
    }
}
