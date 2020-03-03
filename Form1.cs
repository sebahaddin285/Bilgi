using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bilgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList soruList;
        ArrayList dogruList;
        ArrayList yanlis1List;
        ArrayList yanlis2List;

        Random r;
        Random r2;
        int i;
        int deger;
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            eskorText.Text = ayarlar.Default.eskor.ToString();
            r2 = new Random();
            i = r2.Next(4);
            degistir.Visible = false;
            soruList = new ArrayList();
            dogruList = new ArrayList();
            yanlis1List = new ArrayList();
            yanlis2List = new ArrayList();
            r = new Random();
            deger = r.Next(2);
            soruList.Add("türkiyenin başkenti");
            dogruList.Add("ankara");
            yanlis2List.Add("tahran");
            yanlis1List.Add("paris");

            soruList.Add("iranın başkenti");
            dogruList.Add("tahran");
            yanlis2List.Add("ankara");
            yanlis1List.Add("paris");

            soruList.Add("fransa başkenti");
            dogruList.Add("tahran");
            yanlis2List.Add("ankara");
            yanlis1List.Add("paris");

            soruList.Add("amerika başkenti");
            dogruList.Add("tahran");
            yanlis2List.Add("ankara");
            yanlis1List.Add("paris");

            if (deger == 0)
            {
                soruText.Text = soruList[i].ToString();
                cvp1Btn.Text = dogruList[i].ToString();
                cvp2Btn.Text = yanlis1List[i].ToString();
                cvp3Btn.Text = yanlis2List[i].ToString();
            }
            else if (deger == 1)
            {
                soruText.Text = soruList[i].ToString();
                cvp1Btn.Text = yanlis1List[i].ToString();
                cvp2Btn.Text = dogruList[i].ToString();
                cvp3Btn.Text = yanlis2List[i].ToString();
            }
            else if (deger == 2)
            {
                soruText.Text = soruList[i].ToString();
                cvp1Btn.Text = yanlis1List[i].ToString();
                cvp2Btn.Text = yanlis2List[i].ToString();
                cvp3Btn.Text = dogruList[i].ToString();
            }

        }

        private void cvp1Btn_Click(object sender, EventArgs e)
        {
            if(dogruList[i] == cvp1Btn.Text)
            {
                cvp1Btn.BackColor = Color.Green;
                cvp2Btn.BackColor = Color.Red;
                cvp3Btn.BackColor = Color.Red;

                degistir.Visible = true;
            }
            else if(dogruList[i] == cvp2Btn.Text)
            {
                cvp1Btn.BackColor = Color.Red;
                cvp2Btn.BackColor = Color.Green;
                cvp3Btn.BackColor = Color.Red;
                cvp2Btn.Enabled = false;
                if (sayac > ayarlar.Default.eskor)
                {
                    ayarlar.Default.eskor = sayac;
                    ayarlar.Default.Save();
                    eskorText.Text = ayarlar.Default.eskor.ToString(); 
                }
            }
            else if(dogruList[i] == cvp3Btn.Text)
            {
                cvp1Btn.BackColor = Color.Red;
                cvp2Btn.BackColor = Color.Red;
                cvp3Btn.BackColor = Color.Green;
                cvp3Btn.Enabled = false;
                if (sayac > ayarlar.Default.eskor)
                {
                    ayarlar.Default.eskor = sayac;
                    ayarlar.Default.Save();
                    eskorText.Text = ayarlar.Default.eskor.ToString();
                }
            }

        }

        private void cvp2Btn_Click(object sender, EventArgs e)
        {
            if (dogruList[i] == cvp1Btn.Text)
            {
                cvp1Btn.BackColor = Color.Green;
                cvp2Btn.BackColor = Color.Red;
                cvp3Btn.BackColor = Color.Red;
                cvp1Btn.Enabled = false;

                if (sayac > ayarlar.Default.eskor)
                {
                    ayarlar.Default.eskor = sayac;
                    ayarlar.Default.Save();
                    eskorText.Text = ayarlar.Default.eskor.ToString();
                }
            }
            else if (dogruList[i] == cvp2Btn.Text)
            {
                cvp1Btn.BackColor = Color.Red;
                cvp2Btn.BackColor = Color.Green;
                cvp3Btn.BackColor = Color.Red;

                degistir.Visible = true;
            }
            else if (dogruList[i] == cvp3Btn.Text)
            {
                cvp1Btn.BackColor = Color.Red;
                cvp2Btn.BackColor = Color.Red;
                cvp3Btn.BackColor = Color.Green;
                cvp3Btn.Enabled = false;
                if (sayac > ayarlar.Default.eskor)
                {
                    ayarlar.Default.eskor = sayac;
                    ayarlar.Default.Save();
                    eskorText.Text = ayarlar.Default.eskor.ToString();
                }
            }
        }

        private void cvp3Btn_Click(object sender, EventArgs e)
        {
            if (dogruList[i] == cvp1Btn.Text)
            {
                cvp1Btn.BackColor = Color.Green;
                cvp2Btn.BackColor = Color.Red;
                cvp3Btn.BackColor = Color.Red;
                cvp1Btn.Enabled = false;

                if (sayac > ayarlar.Default.eskor)
                {
                    ayarlar.Default.eskor = sayac;
                    ayarlar.Default.Save();
                    eskorText.Text = ayarlar.Default.eskor.ToString();
                }
            }
            else if (dogruList[i] == cvp2Btn.Text)
            {
                cvp1Btn.BackColor = Color.Red;
                cvp2Btn.BackColor = Color.Green;
                cvp3Btn.BackColor = Color.Red;
                cvp2Btn.Enabled = false;
                if (sayac > ayarlar.Default.eskor)
                {
                    ayarlar.Default.eskor = sayac;
                    ayarlar.Default.Save();
                    eskorText.Text = ayarlar.Default.eskor.ToString();
                }
            }
            else if (dogruList[i] == cvp3Btn.Text)
            {
                cvp1Btn.BackColor = Color.Red;
                cvp2Btn.BackColor = Color.Red;
                cvp3Btn.BackColor = Color.Green;

                degistir.Visible = true;
            }
        }

        private void degistir_Click(object sender, EventArgs e)
        {
            cvp1Btn.Enabled = true;
            cvp2Btn.Enabled = true;
            cvp3Btn.Enabled = true;
            sayac++;
            scorText.Text = sayac.ToString();
            cvp1Btn.BackColor = Color.White;
            cvp2Btn.BackColor = Color.White;
            cvp3Btn.BackColor = Color.White;
            
            deger = r.Next(3);
            i = r2.Next(4);
            if (deger == 0)
            {
                soruText.Text = soruList[i].ToString();
                cvp1Btn.Text = dogruList[i].ToString();
                cvp2Btn.Text = yanlis1List[i].ToString();
                cvp3Btn.Text = yanlis2List[i].ToString();
            }
            else if (deger == 1)
            {
                soruText.Text = soruList[i].ToString();
                cvp1Btn.Text = yanlis1List[i].ToString();
                cvp2Btn.Text = dogruList[i].ToString();
                cvp3Btn.Text = yanlis2List[i].ToString();
            }
            else if (deger == 2)
            {
                soruText.Text = soruList[i].ToString();
                cvp1Btn.Text = yanlis1List[i].ToString();
                cvp2Btn.Text = yanlis2List[i].ToString();
                cvp3Btn.Text = dogruList[i].ToString();
            }
            degistir.Visible = false;

        }
    }
}
