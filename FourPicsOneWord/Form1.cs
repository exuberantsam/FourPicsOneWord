using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourPicsOneWord
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image letter_a = global::FourPicsOneWord.Properties.Resources.a;
        Image letter_b = global::FourPicsOneWord.Properties.Resources.b;
        Image letter_c = global::FourPicsOneWord.Properties.Resources.c;
        Image letter_d = global::FourPicsOneWord.Properties.Resources.d;
        Image letter_e = global::FourPicsOneWord.Properties.Resources.e;
        Image letter_f = global::FourPicsOneWord.Properties.Resources.f;
        Image letter_g = global::FourPicsOneWord.Properties.Resources.g;
        Image letter_h = global::FourPicsOneWord.Properties.Resources.h;
        Image letter_i = global::FourPicsOneWord.Properties.Resources.i;
        Image letter_j = global::FourPicsOneWord.Properties.Resources.J;
        Image letter_k = global::FourPicsOneWord.Properties.Resources.k;
        Image letter_l = global::FourPicsOneWord.Properties.Resources.L;
        Image letter_m = global::FourPicsOneWord.Properties.Resources.m;
        Image letter_n = global::FourPicsOneWord.Properties.Resources.n;
        Image letter_o = global::FourPicsOneWord.Properties.Resources.O;
        Image letter_p = global::FourPicsOneWord.Properties.Resources.p;
        Image letter_q = global::FourPicsOneWord.Properties.Resources.Q;
        Image letter_r = global::FourPicsOneWord.Properties.Resources.R;
        Image letter_s = global::FourPicsOneWord.Properties.Resources.s;
        Image letter_t = global::FourPicsOneWord.Properties.Resources.T;
        Image letter_u = global::FourPicsOneWord.Properties.Resources.U;
        Image letter_v = global::FourPicsOneWord.Properties.Resources.V;
        Image letter_w = global::FourPicsOneWord.Properties.Resources.W;
        Image letter_x = global::FourPicsOneWord.Properties.Resources.X;
        Image letter_y = global::FourPicsOneWord.Properties.Resources.Y;
        Image letter_z = global::FourPicsOneWord.Properties.Resources.Z;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            box_9.IdleIconLeftImage = letter_c;
            box_1.IdleIconLeftImage = letter_o;
            box_10.IdleIconLeftImage = letter_d;
            box_7.IdleIconLeftImage = letter_i;
            box_12.IdleIconLeftImage = letter_n;
            box_3.IdleIconLeftImage = letter_g;
        }

        // LETTER IMAGES

        

        private Image PlaceImage(Image assign)
        {   
            Bunifu.UI.WinForms.BunifuButton.BunifuButton[] pictureBoxes = { box1, box2, box3, box4, box5, box6 };

                for (int i = 0; i <= 5; i++)
                {
                    if (pictureBoxes[i].IdleIconLeftImage == null)
                    {
                        pictureBoxes[i].IdleFillColor = Color.DodgerBlue;
                        pictureBoxes[i].IdleIconLeftImage = assign;
                        break;
                    }
                }
            return null;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timerbar.Value -= 1;
            
            if (timerbar.Value < 1)
            {
                Bunifu.UI.WinForms.BunifuButton.BunifuButton[] pictureBoxes = { box1, box2, box3, box4, box5, box6 };

                for (int i = 0; i <= 5; i++)
                {
                        pictureBoxes[i].Enabled = false;
                }

                timer1.Stop();
                MessageBox.Show("Time is Up!");

            }
            
        }


        private void resettimer_Click(object sender, EventArgs e)
        {
                retryLetters();        
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (timerbar.Value < 1)
            {
                MessageBox.Show("Time is up already!");
            } else
            {
                if (box1.IdleIconLeftImage == letter_c &&
                box2.IdleIconLeftImage == letter_o &&
                box3.IdleIconLeftImage == letter_d &&
                box4.IdleIconLeftImage == letter_i &&
                box5.IdleIconLeftImage == letter_n &&
                box6.IdleIconLeftImage == letter_g)

                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Wrong!");
                }
            }

            
        }

        private void box_1_Click(object sender, EventArgs e)
        {
            PlaceImage(box_1.IdleIconLeftImage);
        }

        private void box_2_Click(object sender, EventArgs e)
        {
            PlaceImage(box_1.IdleIconLeftImage);
        }

        private void box_3_Click(object sender, EventArgs e)
        {
            PlaceImage(box_3.IdleIconLeftImage);
        }

        private void box_4_Click(object sender, EventArgs e)
        {
            PlaceImage(box_4.IdleIconLeftImage);
        }

        private void box_5_Click(object sender, EventArgs e)
        {
            PlaceImage(box_5.IdleIconLeftImage);
        }

        private void box_6_Click(object sender, EventArgs e)
        {
            PlaceImage(box_6.IdleIconLeftImage);
        }

        private void box_7_Click(object sender, EventArgs e)
        {
            PlaceImage(box_7.IdleIconLeftImage);
        }

        private void box_8_Click(object sender, EventArgs e)
        {
            PlaceImage(box_8.IdleIconLeftImage);
        }

        private void box_9_Click(object sender, EventArgs e)
        {
            PlaceImage(box_9.IdleIconLeftImage);
        }

        private void box_10_Click(object sender, EventArgs e)
        {
            PlaceImage(box_10.IdleIconLeftImage);
        }

        private void box_11_Click(object sender, EventArgs e)
        {
            PlaceImage(box_11.IdleIconLeftImage);
        }

        private void box_12_Click(object sender, EventArgs e)
        {
            PlaceImage(box_12.IdleIconLeftImage);
        }

        private void box_13_Click(object sender, EventArgs e)
        {
            PlaceImage(box_13.IdleIconLeftImage);
        }

        private void box_14_Click(object sender, EventArgs e)
        {
            PlaceImage(box_14.IdleIconLeftImage);
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            resetLetters();
        }

        public void resetLetters()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton[] pictureBoxes = { box1, box2, box3, box4, box5, box6 };

            Boolean available = timerbar.Value > 1;

            if (available)
            {
                for (int i = 0; i <= 5; i++)
                {
                    pictureBoxes[i].IdleFillColor = Color.Transparent;
                    pictureBoxes[i].IdleIconLeftImage = null;
                }
            }
            else
            {
                MessageBox.Show("Time is up already!");
            }
        }

        public void retryLetters()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton[] pictureBoxes = { box1, box2, box3, box4, box5, box6 };

            Boolean available = timerbar.Value < 1;

            if (available)
            {
                //for (int i = 0; i <= 5; i++)
                //{
                //    pictureBoxes[i].IdleFillColor = Color.Transparent;
                //    pictureBoxes[i].IdleIconLeftImage = null;
                //}
                box1.IdleIconLeftImage = null;
                box2.IdleIconLeftImage = null;
                box3.IdleIconLeftImage = null;
                box4.IdleIconLeftImage = null;
                box5.IdleIconLeftImage = null;
                box6.IdleIconLeftImage = null;

                box1.IdleFillColor = Color.Transparent;
                box2.IdleFillColor = Color.Transparent;
                box3.IdleFillColor = Color.Transparent;
                box4.IdleFillColor = Color.Transparent;
                box5.IdleFillColor = Color.Transparent;
                box6.IdleFillColor = Color.Transparent;

                timerbar.Value = 75;
                timer1.Start();
            }
        }
    }
}
