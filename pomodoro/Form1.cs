using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private TimeSpan kalanSure;

        public Form1()
        {
            InitializeComponent();
            
            // Timer'ı ayarla
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += timer1_Tick;
        }

        

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void baslatButton_Click(object sender, EventArgs e)
        {
            kalanSure = TimeSpan.FromMinutes(20);
            sureLabel.Text = kalanSure.ToString(@"mm\:ss");
            timer.Start();
            baslatButton.Visible = false;
            durdurbutton.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalanSure.TotalSeconds > 0)
            {
                kalanSure = kalanSure.Subtract(TimeSpan.FromSeconds(1));
                sureLabel.Text = kalanSure.ToString(@"mm\:ss");
            }
            else
            {
                timer.Stop();
                sureLabel.Text = "Süre doldu!";
                MessageBox.Show("Pomodoro süresi doldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void durdurbutton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            durdurbutton.Visible = false;
            devamet.Visible = true;
            sifirla.Visible = true;
        }

        private void devamet_Click(object sender, EventArgs e)
        {
            timer.Start();
            devamet.Visible = false;
            durdurbutton.Visible = true;
            sifirla.Visible = false;

        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            // Timer'ı durdur
            timer.Stop();

            // Kalan süreyi başlangıç değerine sıfırla
            kalanSure = TimeSpan.FromMinutes(20);
            sureLabel.Text = kalanSure.ToString(@"mm\:ss");
            baslatButton.Visible = true;
            durdurbutton.Visible = false;
            devamet.Visible = false;
            sifirla.Visible = false;
        }
    }
}
