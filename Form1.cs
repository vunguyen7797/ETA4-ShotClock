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
    public partial class Form1 : Form
    {
        #region Properties
        ControlPanel_Manager controlPanel;
        private string horn_path;
        private string sub_horn_path;
        #endregion
        public Form1()
        {
            InitializeComponent();

            controlPanel = new ControlPanel_Manager(shot_time_lb, Count_Time,Count_Shot_time);
          
            this.Load += Form1_Load;
        }
        //Delegate TimeClock
        public delegate void DownTimeClock();
        public static event DownTimeClock DownTimeForm2Clock;

        //Delegate ShotClock
        public delegate void DownTimeShotClock();
        public static event DownTimeShotClock DownTimeForm2ShotClock;
        
        //Delegate ResetClock
        public delegate void ResetClock();
        public static event ResetClock ResetForm2Clock;

        //Delegate Nhập Thời gian
        public delegate void EnterClock();
        public static event EnterClock EnterForm2Clock;

        // Delegate Nhập Tên Đội
        public delegate void EnterName();
        public static event EnterName EnterForm2Name;

        private void name_team1_TextChanged(object sender, EventArgs e)
        {
        }
   
        private void name_team2_TextChanged(object sender, EventArgs e)
        {
           
        }




        // Delegate reset shot clock
        public delegate void ResetShotClock();
        public static event ResetShotClock ResetForm2Shot24Clock;
        public delegate void ResetShot14Clock();
        public static event ResetShot14Clock ResetForm2Shot14Clock;

        void Form1_Load(object sender, EventArgs e)
        {
            //Show Form 2 lúc khởi động
            screen_form frmshowClock = new screen_form(controlPanel);
            frmshowClock.Show();
        }

        #region Methods

        
        private void Count_Time_Tick(object sender, EventArgs e)
        {
            //abcxyz
            controlPanel.DownTime_Timer1();
          
            //đồng hồ trận đấu
            //   DownTimeForm2Clock();
            DownTimeForm2ShotClock();           
        }


        private void start_btt_Click(object sender, EventArgs e)            //bắt đầu chạy thời gian
        {
            controlPanel.Start_Time();
      
        }

        private void pause_btt_Click(object sender, EventArgs e)            //tạm dừng thời gian thi đấu
        {
            controlPanel.Pause_Time();

        }

       

        private void sc_gr_start_btt_Click(object sender, EventArgs e)      // start shot clock
        {
            controlPanel.Start_ShotClock();
        }

        private void sc_gr_reset_btt_Click(object sender, EventArgs e)  // reset shot clock
        {
            controlPanel.Reset_Timer2();

            controlPanel.Start_ShotClock();
        }

        private void reset_14s_btt_Click(object sender, EventArgs e)    //reset 14s
        {
            controlPanel.Reset14_Timer2();
            ResetForm2Shot14Clock();
        }

        private void sc_gr_pause_btt_Click(object sender, EventArgs e)  // pause shot clock
        {
            controlPanel.Pause_ShotClock();
        }

     


       

        private void Count_Shot_time_Tick(object sender, EventArgs e)
        {
            controlPanel.DownTime_Timer2();
            DownTimeForm2ShotClock();
            //đồng hồ ném 24s
        }

        private void sc_gr_plus_btt_Click(object sender, EventArgs e)           //cộng thời gian 24s
        {
            controlPanel.Add_Shot_Time();
        }

        private void sc_gr_dec_btt_Click(object sender, EventArgs e)            //trừ thời gian 24s
        {
            controlPanel.Dec_Shot_Time();
        }

        private void Close_btt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void button1_Click(object sender, EventArgs e)          // reo còi
        {
            controlPanel.Play_Sub_Horn();
        }

 

  

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void t1_timeout_lb_Click(object sender, EventArgs e)
        {

        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }



     

        private void second_lb_Click(object sender, EventArgs e)
        {

        }

      

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_ed_gr_Enter(object sender, EventArgs e)
        {

        }

     

        private void period_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void show_btt_Click(object sender, EventArgs e)
        {
            screen_form screen = new screen_form(controlPanel);
            screen.Show();
        }

        private void minute_lb_Click(object sender, EventArgs e)
        {

        }

        private void shot_time_lb_Click(object sender, EventArgs e)
        {

        }

        private void sc_gr_reset_btt_Click_1(object sender, EventArgs e)
        {
            controlPanel.Reset_Timer2();
            ResetForm2Shot24Clock();

        }

        private void sc_gr_pause_btt_Click_1(object sender, EventArgs e)
        {
            controlPanel.Pause_ShotClock();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlPanel.Play_horn();
        }
    }
    #endregion 
}
