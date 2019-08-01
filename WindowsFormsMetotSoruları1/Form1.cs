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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1) Dışarıdan iki sayı alana ve toplamını döndüren metot
        int SayilariTopla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }


        // 2) Dışarıdan üç sayı alan ve ortalamasını döndüren metot
        double OrtalamaHesapla(double sayi1, double sayi2, double sayi3)
        {
            return (sayi1 + sayi2 + sayi3) / 3;
        }


        // 3) Mevcut tarihi döndüren metot
        DateTime TarihiGoster()
        {
            return DateTime.Now;
        }


        // 4) Dışarıdan aldığı iki metni aralarında boşluk bırakarıp, baş harflerini büyültüp döndüren metot
        string MetinEkle(string metin1, string metin2)
        {
            return metin1 + ' ' + metin2;
        }


        // 5) Text i “Gojira” name i 1 olan yüksekliği ve genişliği 50 olan butonu dışarıya döndüren metot
        Button ButonEkle()
        {
            Button btn = new Button();
            btn.Name = "1";
            btn.Text = "Gojira";
            btn.Width = 50;
            btn.Height = 50;
            return btn;
        }


        // 6) Dışarıdan aldığı metni char[] dizisi şeklinde harflerini döndüren metot
        char[] HarfDondur(string metin)
        {
            string[] harfdizi = new string[metin.Length];

            for (int i = 0; i < metin.Length; i++)
            {
                harfdizi[i] = metin.Substring(i, 1);
            }

            return harfdizi.ToString().ToCharArray();
        }


        // 7) Dışarıdan aldığı metni ikili harfler şeklinde string dizi olarak döndüren metot.
        // Örneğin “Machine Head" metnin “Ma”,”ch”,”in” gibi.

        string[] IkiliDiziDondur(string veri)
        {
            string[] metindizi = new string[veri.Length];

            for (int i = 0; i < veri.Length; i += 2)
            {
                try
                {
                    metindizi[i / 2] = veri.Substring(i, 2);
                }
                catch (Exception)
                {
                    metindizi[i / 2] = veri.Substring(i, 1);

                }
            }

            return metindizi;

        }
    }
}
