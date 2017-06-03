using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace WFAMayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Global Değişken Tanımlamaları
        Random Mayinlar = new Random();
        Button Tiklanan = new Button();
        SoundPlayer ses = new SoundPlayer();
        int Bos = 0;
        int dolu = 0;
        int Kazanma = 0;
        #endregion
       
        #region Yeni Oyun Metodu
        /// <summary>
        /// Yeni oyunu başlatmak için
        /// </summary>
        void YeniOyun()
        {
            #region Defaul Değerler

            btnYeniOyun.BackgroundImage = Image.FromFile("../../images/gülen.png");
            btnYeniOyun.BackgroundImageLayout = ImageLayout.Stretch;
            Bos = 0;
            dolu = 0;
            #endregion

            int MayinEkle = Mayinlar.Next(0, 35);
            int a = 9 * 9;
            

            fltTarla.Controls.Clear();
            for (int i = 0; i <= a - 2; i++)
            {
                Button btnMayin = new Button();
                btnMayin.Width = 25;
                btnMayin.Height = 25;
                btnMayin.Margin = new System.Windows.Forms.Padding(0);
                fltTarla.Controls.Add(btnMayin);
                btnMayin.Click += btnMayin_Click;
            }

            foreach (Control Oku in fltTarla.Controls)
            {
                Button Mekle = Oku as Button;
                Mekle.Tag = Mayinlar.Next(1, 45);
            }
            foreach (Control k in fltTarla.Controls)
            {
                Button deger = k as Button;
                int sayi = int.Parse(deger.Tag.ToString());
                if (sayi % 2 == 0)
                {
                    Bos++;
                }
                else
                {
                    dolu++;
                }
            }
            lblMayinSayisi.Text = "M:" + " " + dolu + " " + "B:" + " " + Bos;
        } 
        #endregion

        #region Form Yüklenmesindeki Olaylar
        private void Form1_Load(object sender, EventArgs e)
        {
            lblYeniOyun.Visible = false;
            YeniOyun();
        } 
        #endregion

        #region Mayın Var mı yok mu Kontrol 
       
        void btnMayin_Click(object sender, EventArgs e)
        {
            Button Tiklanan = sender as Button;
            int GelenDeger = int.Parse(Tiklanan.Tag.ToString());

            #region Kazanma Olayı
            if (GelenDeger % 2 == 0)
            {
                Tiklanan.BackColor = Color.Green;
                Tiklanan.Enabled = false;
                Kazanma++;
                #region Tık Sesi
                ses.SoundLocation = "../../sesler/tıklayınca.wav";
                ses.Play();
               
                #endregion

                if (Kazanma==Bos)
                {
                    #region Kazanma Sesi
                    ses.SoundLocation = "../../sesler/kazandı.wav";
                    ses.Play();  
                    #endregion

                    DialogResult oku = MessageBox.Show("Oyunu Kazandınız Yeni Oyun için EVET, Oyunu Kapatmak için HAYIR'ı seçiniz.", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    switch (oku)
                    {
                        case DialogResult.No: Application.Exit();
                            break;
                        case DialogResult.Yes: YeniOyun();
                            break;
                        default:
                            break;
                    }
                }
            } 
            #endregion
            
            #region Kaybetme Olayı
            else
            {
                btnYeniOyun.BackgroundImage = Image.FromFile("../../images/üzgün.png");
                btnYeniOyun.BackgroundImageLayout = ImageLayout.Stretch;
                
                        Tiklanan.BackColor = Color.Red;
                        Tiklanan.BackgroundImage = Image.FromFile("../../images/mayin.png");
                        Tiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                
                #region Kaybetme sesi
                ses.SoundLocation = "../../sesler/ağlama.wav";
                ses.Play(); 
                #endregion
                
                DialogResult oku = MessageBox.Show("Oyunu Kaybettiniz Yeni Oyun için EVET, Oyunu Kapatmak için HAYIR'ı seçiniz.", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch (oku)
                {
                    case DialogResult.No: Application.Exit();
                        break;
                    case DialogResult.Yes: YeniOyun();
                        break;
                    default:
                        break;
                }
            } 
            #endregion
        } 

        #endregion

        #region YeniOyun Butonu
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            YeniOyun();
        } 
        #endregion

        #region Yeni Oyun Butonu Açıklama
        private void btnYeniOyun_MouseEnter(object sender, EventArgs e)
        {
            lblYeniOyun.Visible = true;
        }

        private void btnYeniOyun_MouseLeave(object sender, EventArgs e)
        {
            lblYeniOyun.Visible = false;
        }
        
        #endregion

        #region EMRE SANDIKÇI
        
        #endregion
    }
}
