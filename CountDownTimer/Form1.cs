using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CountDownTimer
{
    public partial class Form1 : Form
    {
        public int detik;
        public int menit;
        public int jam;
        public bool  pause;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtJam.Focus();
            txtJam.Text = Convert.ToString(0);
            txtMenit.Text = Convert.ToString(0);
            txtDetik.Text = Convert.ToString(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pause != true)
            {
                if ((txtJam.Text != string.Empty) && (txtMenit.Text != string.Empty) && (txtDetik.Text != string.Empty))
                {
                    tmrWaktu.Enabled = true;
                    btnPause.Enabled = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    txtJam.Enabled = false;
                    txtMenit.Enabled = false;
                    txtDetik.Enabled = false;
                    txtPesan.Enabled = false;

                    try
                    {
                        menit = System.Convert.ToInt32(txtMenit.Text);
                        detik = System.Convert.ToInt32(txtDetik.Text);
                        jam = System.Convert.ToInt32(txtJam.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox .Show ("Terjadi Masalah Pada Aplikasi","Technocorner 2016",MessageBoxButtons .OK , MessageBoxIcon .Error );
                }
            }
            else {
                tmrWaktu.Enabled = true;
                pause = false;
                btnStart .Enabled = false;
                btnPause.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // melakukan pengecekan jika waktu tidak sesuai
            if ((menit  == 0) && (jam == 0) && (detik == 0))
            {

                // jika waktu yang ditentukan telah selesai, kosongkan field
                // juga menampilkan pesan bahwa waktu telah selesai
                tmrWaktu.Enabled = false;
                Console.Beep();
                MessageBox.Show(txtPesan.Text, "Peringatan");
                btnPause.Enabled = false;
                btnStop.Enabled = false;
                btnStart .Enabled = true;
                txtPesan.Clear();
                txtJam.Text = Convert.ToString(0);
                txtMenit.Text = Convert.ToString(0);
                txtDetik.Text = Convert.ToString(0);
                txtJam.Enabled = true;
                txtPesan.Enabled = true;
                txtDetik.Enabled = true;
                txtMenit.Enabled = true;
                txtJam.Enabled = true;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
            }
            else
            {
                // lanjutkan waktu 
                if (detik < 1)
                {
                    detik = 59;
                    if (menit == 0)
                    {
                        menit = 59;
                        if (jam != 0)
                            jam -= 1;

                    }
                    else
                    {
                        menit -= 1;
                    }
                }
                else
                    detik -= 1;
                
                    lblHr.Text = jam.ToString();
                    lblMin.Text = menit.ToString();
                    lblSec.Text = detik.ToString();
            }
            if ((menit == 5) && (jam == 0) && (detik == 0))
            {
                // memberikan peringatan kepada user jika waktu tersisa tinggal 5 menit
                MessageBox.Show("5 menit tersisa.\n Silahkan selesaikan segera pekerjaan anda dan pastikan semuanya sudah terkoreksi. ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           /* if ((menit == 10) && (jam == 0) && (detik == 0))
            {
                memberikan peringatan kepada user jika waktu tersisa tinggal 10 menit
                messagebox.show("10 menit tersisa.\n silahkan selesaikan segera pekerjaan anda dan pastikan semuanya sudah terkoreksi ", "perigatan", messageboxbuttons.ok, messageboxicon.warning);

            }*/
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // pause waktu
          //if (MessageBox.Show("Apakah anda yakin ingin melakukan pause waktu ?.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            //{
                tmrWaktu.Enabled = false;
                pause = true;
                btnPause .Enabled = false;
                btnStart .Enabled = true;
         //   }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghentikan waktu ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                // hentikan waktu
                pause = false;
                tmrWaktu.Enabled = false;
                btnPause .Enabled = false;
                btnStop .Enabled = false;
                btnStart .Enabled = true;
                txtPesan.Clear();
                txtJam.Text = Convert.ToString(0);
                txtMenit.Text = Convert.ToString(0);
                txtDetik.Text = Convert.ToString(0);
                txtJam.Enabled = true;
                txtPesan.Enabled = true;
                txtDetik.Enabled = true;
                txtMenit.Enabled = true;
                txtJam.Enabled = true;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
                
            }
        }
        //tombol rekam kecil kecil per tim
        private void buttonA_Click(object sender, EventArgs e)
        {
            //team A
            String getDetikA, getMenitA, getJamA;
            getJamA = jam.ToString();
            getMenitA = menit.ToString();
            getDetikA = detik.ToString();

            labelA.Text = jam.ToString()+" : "+menit.ToString()+" : "+detik.ToString();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            //team B
            String getDetikB, getMenitB, getJamB;
            getJamB = jam.ToString();
            getMenitB = menit.ToString();
            getDetikB = detik.ToString();

            labelB.Text = jam.ToString() + " : " + menit.ToString() + " : " + detik.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //team C
            String getDetikC, getMenitC, getJamC;
            getJamC = jam.ToString();
            getMenitC = menit.ToString();
            getDetikC = detik.ToString();

            labelC.Text = jam.ToString() + " : " + menit.ToString() + " : " + detik.ToString();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            //team D
            String getDetikD, getMenitD, getJamD;
            getJamD = jam.ToString();
            getMenitD = menit.ToString();
            getDetikD = detik.ToString();

            labelD.Text = jam.ToString() + " : " + menit.ToString() + " : " + detik.ToString();
        }
        //label untuk hasil catatan waktu
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //team A

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDetik_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSec_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPesan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        private void lblHr_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWarming_Click(object sender, EventArgs e)
        {

            txtJam.Text = "0";
            txtMenit.Text = "15";
            txtDetik.Text = "0";
            txtPesan.Text = "Warming Up";
        }

        private void txtJam_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            txtJam.Text = "0";
            txtMenit.Text = "30";
            txtDetik.Text = "0";
            txtPesan.Text = "Mulai Perlombaan";
        }

        private void buttonPemanggil_Click(object sender, EventArgs e)
        {
            txtJam.Text = "0";
            txtMenit.Text = "10";
            txtDetik.Text = "0";
            txtPesan.Text = "Pemanggilan Team";
        }

        

        

        

        
    }
}
