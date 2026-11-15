using SuTahsilat.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuTahsilat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SUTAHSILATEntities1 sb =new SUTAHSILATEntities1();

        void dgAbone_Doldur() 
        {
            dgAbone.DataSource = sb.sp_AboneListe();
            dgAbone.Columns[0].Visible = false;

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int aboneid;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgAbone_Doldur();
            if (dgAbone.RowCount == 0) aboneid = 0;
            else aboneid=(int)dgAbone.Rows[0].Cells[0].Value;
            dgTuketim_Doldur(aboneid);
            temizle();
        }
        void dgTuketim_Doldur(int id)
        {
            dgTuketim.DataSource = sb.sp_TuketimListele(id);
            dgTuketim.Columns[0].Visible = false;
            dgTuketim.Columns[1].Visible = false;
            dgTuketim.Columns[5].Visible = false;
  
        }
        void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtSeri.Clear();
            txtTC.Clear();
            txtTel.Clear();
            txtMarka.Clear();
            txtNumara.Clear();
        }

        private void dgAbone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aboneid=(int)dgAbone.CurrentRow.Cells[0].Value;
            dgTuketim_Doldur(aboneid);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            sb.sp_AboneKaydet(txtAd.Text, txtSoyad.Text, txtTC.Text, txtAdres.Text, txtTel.Text,
                txtMarka.Text, txtSeri.Text, txtNumara.Text);
            dgAbone_Doldur();
            aboneid = (int)dgAbone.Rows[0].Cells[0].Value;
        }
        int endeks;
        private void btnEKaydet_Click(object sender, EventArgs e)
        {
            endeks = int.Parse(txtEndeks.Text);
            sb.sp_TuketimKaydet(aboneid,endeks);
            dgTuketim_Doldur(aboneid);
        }

        
        private void btnTuketimDuzenle_Click(object sender, EventArgs e)
        {
            sb.spTumTuketimDuzenle();
            dgTuketim_Doldur(aboneid);
        }
    }
}
