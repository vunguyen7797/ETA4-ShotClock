using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacketBall
{
    public class ControlPanel_Manager
    {
        #region Properties
        // Name
        private Label name1_lb;
        public Label Name1
        {
            get
            {
                return name1_lb;
            }
            set
            {
                name1_lb = value;
            }
        }
        private Label name2_lb;
        public Label Name2
        {
            get
            {
                return name2_lb;
            }
            set
            {
                name2_lb = value;
            }
        }

        //ava
        private PictureBox ava1_pb;
        public PictureBox Ava1
        {
            get
            {
                return ava1_pb;
            }
            set
            {
                ava1_pb = value;
            }
        }
        private PictureBox ava2_pb;
        public PictureBox Ava2
        {
            get
            {
                return ava2_pb;
            }
            set
            {
                ava2_pb = value;
            }
        }
        // Period
        private Label period_lb;
        public Label Period
        {
            get
            {
                return period_lb
;
            }

            set
            {
                period_lb = value;
            }
        }

  
        // Time
        private int minute;

        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                minute = value;
            }
        }

        private int second;
        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                second = value;               //giây
            }
        }
        // Current Time
        private Label current_min_lb;
        public Label Current_min_lb
        {
            get
            {
                return current_min_lb;
            }

            set
            {
                current_min_lb = value;
            }
        }

        private Label current_se_lb;
        public Label Current_se_lb
        {
            get
            {
                return current_se_lb;
            }

            set
            {
                current_se_lb = value;
            }
        }

        private int current_minute;
        public int Current_minute
        {
            get
            {
                return current_minute;
            }

            set
            {
                current_minute = value;
            }
        }

        private int current_second;
        public int Current_second
        {
            get
            {
                return current_second;
            }

            set
            {
                current_second = value;
            }
        }
        // Shot Time
        private int shotTime;
        public int ShotTime
        {
            get
            {
                return shotTime;
            }

            set
            {
                shotTime = value;
            }
        }
        private Label shotTime_lb;
        public Label ShotTime_lb
        {
            get
            {
                return shotTime_lb;
            }

            set
            {
                shotTime_lb = value;
            }
        }
        // Horn Sound Resource
        private string horn_path;
        public string Horn_path
        {
            get
            {
                return horn_path;
            }

            set
            {
                horn_path = value;
            }
        }

        // Substitution Horn Resource
        private string subHorn_path;
        public string SubHorn_path
        {
            get
            {
                return subHorn_path;
            }

            set
            {
                subHorn_path = value;
            }
        }
        //Timer
        private Timer timer1;
        public Timer Timer1
        {
            get
            {
                return timer1;
            }

            set
            {
                timer1 = value;
            }
        }
        private Timer timer2;
        public Timer Timer2
        {
            get
            {
                return timer2;
            }

            set
            {
                timer2 = value;
            }
        }

        //Score Team 1

        private Label t1_score_lb;
        public Label T1_score_lb
        {
            get
            {
                return t1_score_lb;
            }

            set
            {
                t1_score_lb = value;
            }
        }

        private int t1_score;
        public int T1_score
        {
            get
            {
                return t1_score;
            }

            set
            {
                t1_score = value;
            }
        }

        // Score Team 2
        private Label t2_score_lb;
        public Label T2_score_lb
        {
            get
            {
                return t2_score_lb;
            }

            set
            {
                t2_score_lb = value;
            }
        }

        private int t2_score;
        public int T2_score
        {
            get
            {
                return t2_score;
            }

            set
            {
                t2_score = value;
            }
        }

        // Team Foul 1
        private Label t1_foul_lb;
        public Label T1_foul_lb
        {
            get
            {
                return t1_foul_lb;
            }

            set
            {
                t1_foul_lb = value;
            }
        }

        private int t1_foul;
        public int T1_foul
        {
            get
            {
                return t1_foul;
            }

            set
            {
                t1_foul = value;
            }
        }
        // Team Foul 2
        private Label t2_foul_lb;
        public Label T2_foul_lb
        {
            get
            {
                return t2_foul_lb;
            }

            set
            {
                t2_foul_lb = value;
            }
        }

        private int t2_foul;
        public int T2_foul
        {
            get
            {
                return t2_foul;
            }

            set
            {
                t2_foul = value;
            }
        }

        // Team TmOut 1
        private Label t1_tmOut_lb;
        public Label T1_tmOut_lb
        {
            get
            {
                return t1_tmOut_lb;
            }

            set
            {
                t1_tmOut_lb = value;
            }
        }

        private int t1_tmOut;
        public int T1_tmOut
        {
            get
            {
                return t1_tmOut;
            }

            set
            {
                t1_tmOut = value;
            }
        }
        // Team TmOut 2
        private Label t2_tmOut_lb;
        public Label T2_tmOut_lb
        {
            get
            {
                return t2_tmOut_lb;
            }

            set
            {
                t2_tmOut_lb = value;
            }
        }

        private int t2_tmOut;
        public int T2_tmOut
        {
            get
            {
                return t2_tmOut;
            }

            set
            {
                t2_tmOut = value;
            }
        }

       

        #endregion
        #region Init
        public ControlPanel_Manager(Label shot_Time, Timer time1,Timer time2)
        {
            try
            {
             
                this.ShotTime_lb = shot_Time;
                this.ShotTime = Convert.ToInt32(shot_Time.Text);
                this.Timer1 = time1;
                this.Timer2 = time2;
                // Sound
                //this.Horn_path = horn_path;
               // this.SubHorn_path = subhorn_path;
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Định dạng không hợp lệ - " + ex.Message);
                return;
            }
        }
        #endregion
        #region Methods
        
        #region Time
       
        public void Start_Time()
        {
            if (Timer1 == null)
            {
                MessageBox.Show("NULL");
                return;
            }
            
            Timer1.Start();
            Timer2.Start();
        }

        public void Start_ShotClock()
        {
            if (Timer1 == null)
            {
                MessageBox.Show("NULL");
                return;
            }
          //  Timer1.Start();
            Timer2.Start();
        }

        public void Pause_Time()
        {
            if (Timer1 == null)
            {
                MessageBox.Show("NULL");
                return;
            }
            Timer1.Stop();
            Timer2.Stop();
        }

        public void Pause_ShotClock()
        {
            if (Timer2 == null)
            {
                MessageBox.Show("NULL");
                return;
            }
            Timer2.Stop();
        }

        public void Reset_Timer1()
        {
            if (Timer1 == null)
            {
                MessageBox.Show("NULL");
                return;
            }

            SetTime();
        }

        public void Reset_Timer2()
        {
            if (Timer1 == null)
            {
                MessageBox.Show("NULL");
                return;
            }
            ShotTime = 24;
            ShotTime_lb.Text = "24";
        }

        public void Reset14_Timer2()
        {
            if (Timer1 == null)
            {
                MessageBox.Show("NULL");
                return;
            }
            ShotTime = 14;
            ShotTime_lb.Text = "14";
        }

        public void DownTime_Timer1()
        {
            Second--;
            if (Second <=0)
            {
                if (Minute > 0)
                {
                    Minute--;
                    Second = 59;
                }
                else Check_End_Time();
                
            }
            SetTime();
       //     Check_End_Time();
        }
        public void DownTime_Timer2()
        {
            ShotTime--;
            if (ShotTime < 10)
            {
                ShotTime_lb.Text = "0" + ShotTime.ToString();
            }
            else
            {            
                ShotTime_lb.Text = ShotTime.ToString();
            }
            Check_End_Shot_Time();
        }
        private void SetTime()
        {
            if (Minute < 10)
            {
                Current_min_lb.Text = "0" + Minute.ToString();
            } else
            {
                Current_min_lb.Text = Minute.ToString();
            }
            if (Second < 10)
            {
                Current_se_lb.Text = "0" + Second.ToString();
            }
            else
            {
                Current_se_lb.Text = Second.ToString();
            }
        }

        private void Check_End_Time()
        {
            if (Minute == 0 && Second == 0)
            {
                Play_Sub_Horn();
                Timer1.Stop();
                Timer2.Stop();
               // Reset_Timer1();
               // Reset_Timer2();
                
                             
            }           
        }
        private void Check_End_Shot_Time()
        {
            if (ShotTime <= 0)
            {
                Timer2.Stop();
                Play_horn();
               // Reset_Timer2();
                
            }
        }
        public void Add_Shot_Time()
        {
            ShotTime++;
            if (ShotTime < 10)
            {
                ShotTime_lb.Text = "0" + ShotTime.ToString();
            }
            else
            {
                ShotTime_lb.Text = ShotTime.ToString();
            }
        }
        public void Dec_Shot_Time()
        {
            ShotTime--;
            if (ShotTime < 0) return;
            if (ShotTime < 10)
            {
                ShotTime_lb.Text = "0" + ShotTime.ToString();
            }
            else
            {
                ShotTime_lb.Text = ShotTime.ToString();
            }
        }
        #region Score
        public void Add_Score_T1()
        {
            T1_score++;
            if (T1_score < 10)
            {
                T1_score_lb.Text = "0" + T1_score.ToString();
            }
            else
                T1_score_lb.Text = T1_score.ToString();
        }
        public void Dec_Score_T1()
        {
            if (T1_score <= 0) return;
            T1_score--;
            T1_score_lb.Text = T1_score.ToString();
        }
        public void Add_Score_T2()
        {
            T2_score++;
            if (T2_score < 10)
            {
                T2_score_lb.Text = "0" + T2_score.ToString();
            }
            else
                T2_score_lb.Text = T2_score.ToString();
        }
        public void Dec_Score_T2()
        {
            if (T2_score <= 0) return;
            T2_score--;
            T2_score_lb.Text = T2_score.ToString();
        }
        #endregion
        #region Foul
        public void Add_Foul_T1()
        {
            T1_foul++;
            T1_foul_lb.Text = T1_foul.ToString();
        }
        public void Dec_Foul_T1()
        {
            if (T1_foul <= 0) return;
            T1_foul--;
            T1_foul_lb.Text = T1_foul.ToString();
        }
        public void Add_Foul_T2()
        {
            T2_foul++;
            T2_foul_lb.Text = T2_foul.ToString();
        }
        public void Dec_Foul_T2()
        {
            if (T2_foul <= 0) return;
            T2_foul--;
            T2_foul_lb.Text = T2_foul.ToString();
        }
        #endregion
        #region TmOut
        public void Add_TmOut_T1()
        {
            T1_tmOut++;
            T1_tmOut_lb.Text = T1_tmOut.ToString();
        }
        public void Dec_TmOut_T1()
        {
            if (T1_tmOut <= 0) return;
            T1_tmOut--;
            T1_tmOut_lb.Text = T1_tmOut.ToString();
        }
        public void Add_TmOut_T2()
        {
            T2_tmOut++;
            T2_tmOut_lb.Text = T2_tmOut.ToString();
        }
        public void Dec_TmOut_T2()
        {
            if (T2_tmOut <= 0) return;
            T2_tmOut--;
            T2_tmOut_lb.Text = T2_tmOut.ToString();
        }
        #endregion
        #endregion
        #region Sound
        public void Play_horn()
        {
            SoundPlayer horn = new SoundPlayer(Application.StartupPath + "/Resource/horn.wav");
            horn.Play();
        }
        public void Play_Sub_Horn()
        {
            SoundPlayer Sub_horn = new SoundPlayer(Application.StartupPath + "/Resource/horn2.wav");
            Sub_horn.Play();
        }
        #endregion
        #endregion
        
    }
}
