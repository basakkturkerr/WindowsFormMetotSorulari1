using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetotSoruları1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 1) Doğduğum günden bugüne kaç gün geçtiğini gösteren metot.

        int GunHesapla()
        {
            DateTime birthdate = new DateTime(1993, 11, 13);
            TimeSpan gecengun = DateTime.Now - birthdate;
            return gecengun.Days;  
        }

        // 2) Yılbaşından bugüne kaç gün geçtiğini gösteren metot

        double GunHesapla2()
        {
            DateTime yilbasi = new DateTime(2019, 01, 01);
            TimeSpan gun = DateTime.Now - yilbasi;
            return gun.Days;
        }


        // 3) 1 Mayıs ile 29 Ekim arasında kaç gün var?

        double GunHesapla3()
        {
            DateTime tarih1 = new DateTime(2019, 05, 01);
            DateTime tarih2 = new DateTime(2019, 10, 29);
            TimeSpan gun = tarih2 - tarih1;
            return gun.Days;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblGun.Text = GunHesapla2().ToString();
        }

        // 4) Doğduğum günden bugüne kaç dakika geçmiş?

        double DakikaHesapla()
        {
            DateTime birthdate = new DateTime(1993, 11, 13);
            TimeSpan gecendakika = DateTime.Now - birthdate;
            return gecendakika.TotalMinutes;
        }

    }







}
