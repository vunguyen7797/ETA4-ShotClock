using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacketBall
{
    public partial class screen_form : Form
    {
        private ControlPanel_Manager controlpanel;


        public screen_form(ControlPanel_Manager controlpanel)
        {
            InitializeComponent();
  
            this.controlpanel = controlpanel;

            //abcxyz
            Form1.DownTimeForm2ShotClock += Form1_DownTimeForm2ShotClock;
            Form1.ResetForm2Shot24Clock += Form1_ResetForm2Shot24Clock;
            Form1.ResetForm2Shot14Clock += Form1_ResetForm2Shot14Clock;







        }


        // moveable form
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


       

        // Đếm ngược thời gian Shot ở Form 2
        void Form1_DownTimeForm2ShotClock()
        {
            shotTime_lb.Text = controlpanel.ShotTime_lb.Text;
        }

        // Reset shot clock form 2
        void Form1_ResetForm2Shot24Clock()
        {
            shotTime_lb.Text = controlpanel.ShotTime_lb.Text;

        }

        void Form1_ResetForm2Shot14Clock()
        {
            shotTime_lb.Text = controlpanel.ShotTime_lb.Text;

        }












        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //gọi đệ quy nếu như 1 control nào có chứa các control khác nữa

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }
  

        private void ava_team2_Click(object sender, EventArgs e)
        {
         
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void second_lb_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void minute_lb_Click(object sender, EventArgs e)
        {

        }

        private void minute_lb_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void second_lb_Click_1(object sender, EventArgs e)
        {

        }

        private void screen_form_Load(object sender, EventArgs e)
        {

        }

        private void period_lb_Click(object sender, EventArgs e)
        {

        }

        private void name_t1_lb_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void minute_lb_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void per_num_lb_Click(object sender, EventArgs e)
        {

        }

        private void score_t1_lb_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void foul_t1_lb_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void shotClock_lb_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void score_t1_lb_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void score_t1_lb_Click_2(object sender, EventArgs e)
        {

        }

        private void shotTime_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
