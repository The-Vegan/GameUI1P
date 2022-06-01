using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameUI1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }



        short[] screenSize = new short[5];  //[longueur][hauteur][gauche][haut][taille] 
        private void Form1_Resize(object sender, EventArgs e)
        {
            

            
            if ((this.ClientSize.Width / this.ClientSize.Height) >= (11/7))
            {
                screenSize[1] = (short)this.ClientSize.Height;
                screenSize[0] = (short)((screenSize[1] / 7) * 11);
                screenSize[2] = (short)((this.ClientSize.Width - screenSize[0]) / 2);
                screenSize[3] = 0;
            }
            else
            {
                screenSize[0] = (short)this.ClientSize.Width;
                screenSize[1] = (short)((screenSize[0] / 11) * 7);
                screenSize[2] = 0;
                screenSize[3] = (short)((this.ClientSize.Height - screenSize[1]) / 2);
            }

            screenSize[4] = (short)(screenSize[0] / 11);

            progressBar1.Width = (int)(screenSize[0] * 0.34);
            progressBar1.Left = (int)(screenSize[0] * 0.33);
            progressBar1.Height = (int)(screenSize[1] * 0.05);
            progressBar1.Top = (int)(screenSize[1] * 0.9);



            pictureBox1.Width = screenSize[4];pictureBox1.Height = screenSize[4];
            pictureBox2.Width = screenSize[4];pictureBox2.Height = screenSize[4];
            pictureBox3.Width = screenSize[4];pictureBox3.Height = screenSize[4];
            pictureBox4.Width = screenSize[4];pictureBox4.Height = screenSize[4];
            pictureBox5.Width = screenSize[4];pictureBox5.Height = screenSize[4];
            pictureBox6.Width = screenSize[4];pictureBox6.Height = screenSize[4];
            pictureBox7.Width = screenSize[4];pictureBox7.Height = screenSize[4];
            pictureBox8.Width = screenSize[4];pictureBox8.Height = screenSize[4];
            pictureBox9.Width = screenSize[4]; pictureBox9.Height = screenSize[4];
            pictureBox10.Width = screenSize[4]; pictureBox10.Height = screenSize[4];
            pictureBox11.Width = screenSize[4]; pictureBox11.Height = screenSize[4];

            pictureBox12.Width = screenSize[4]; pictureBox12.Height = screenSize[4];
            pictureBox13.Width = screenSize[4]; pictureBox13.Height = screenSize[4];
            pictureBox14.Width = screenSize[4]; pictureBox14.Height = screenSize[4];
            pictureBox15.Width = screenSize[4]; pictureBox15.Height = screenSize[4];
            pictureBox16.Width = screenSize[4]; pictureBox16.Height = screenSize[4];
            pictureBox17.Width = screenSize[4]; pictureBox17.Height = screenSize[4];
            pictureBox18.Width = screenSize[4]; pictureBox18.Height = screenSize[4];
            pictureBox19.Width = screenSize[4]; pictureBox19.Height = screenSize[4];
            pictureBox20.Width = screenSize[4]; pictureBox20.Height = screenSize[4];
            pictureBox21.Width = screenSize[4]; pictureBox21.Height = screenSize[4];
            pictureBox22.Width = screenSize[4]; pictureBox22.Height = screenSize[4];

            pictureBox23.Width = screenSize[4]; pictureBox23.Height = screenSize[4];
            pictureBox24.Width = screenSize[4]; pictureBox24.Height = screenSize[4];
            pictureBox25.Width = screenSize[4]; pictureBox25.Height = screenSize[4];
            pictureBox26.Width = screenSize[4]; pictureBox26.Height = screenSize[4];
            pictureBox27.Width = screenSize[4]; pictureBox27.Height = screenSize[4];
            pictureBox28.Width = screenSize[4]; pictureBox28.Height = screenSize[4];
            pictureBox29.Width = screenSize[4]; pictureBox29.Height = screenSize[4];
            pictureBox30.Width = screenSize[4]; pictureBox30.Height = screenSize[4];
            pictureBox31.Width = screenSize[4]; pictureBox31.Height = screenSize[4];
            pictureBox32.Width = screenSize[4]; pictureBox32.Height = screenSize[4];
            pictureBox33.Width = screenSize[4]; pictureBox33.Height = screenSize[4];

            pictureBox34.Width = screenSize[4]; pictureBox34.Height = screenSize[4];
            pictureBox35.Width = screenSize[4]; pictureBox35.Height = screenSize[4];
            pictureBox36.Width = screenSize[4]; pictureBox36.Height = screenSize[4];
            pictureBox37.Width = screenSize[4]; pictureBox37.Height = screenSize[4];
            pictureBox38.Width = screenSize[4]; pictureBox38.Height = screenSize[4];
            pictureBox39.Width = screenSize[4]; pictureBox39.Height = screenSize[4];
            pictureBox40.Width = screenSize[4]; pictureBox40.Height = screenSize[4];
            pictureBox41.Width = screenSize[4]; pictureBox41.Height = screenSize[4];
            pictureBox42.Width = screenSize[4]; pictureBox42.Height = screenSize[4];
            pictureBox43.Width = screenSize[4]; pictureBox43.Height = screenSize[4];
            pictureBox44.Width = screenSize[4]; pictureBox44.Height = screenSize[4];
            
            pictureBox45.Width = screenSize[4]; pictureBox45.Height = screenSize[4];
            pictureBox46.Width = screenSize[4]; pictureBox46.Height = screenSize[4];
            pictureBox47.Width = screenSize[4]; pictureBox47.Height = screenSize[4];
            pictureBox48.Width = screenSize[4]; pictureBox48.Height = screenSize[4];
            pictureBox49.Width = screenSize[4]; pictureBox49.Height = screenSize[4];
            pictureBox50.Width = screenSize[4]; pictureBox50.Height = screenSize[4];
            pictureBox51.Width = screenSize[4]; pictureBox51.Height = screenSize[4];
            pictureBox52.Width = screenSize[4]; pictureBox52.Height = screenSize[4];
            pictureBox53.Width = screenSize[4]; pictureBox53.Height = screenSize[4];
            pictureBox54.Width = screenSize[4]; pictureBox54.Height = screenSize[4];
            
            pictureBox55.Width = screenSize[4]; pictureBox55.Height = screenSize[4];
            pictureBox56.Width = screenSize[4]; pictureBox56.Height = screenSize[4];
            pictureBox57.Width = screenSize[4]; pictureBox57.Height = screenSize[4];
            pictureBox58.Width = screenSize[4]; pictureBox58.Height = screenSize[4];
            pictureBox59.Width = screenSize[4]; pictureBox59.Height = screenSize[4];
            pictureBox60.Width = screenSize[4]; pictureBox60.Height = screenSize[4];
            pictureBox61.Width = screenSize[4]; pictureBox61.Height = screenSize[4];
            pictureBox62.Width = screenSize[4]; pictureBox62.Height = screenSize[4];
            pictureBox63.Width = screenSize[4]; pictureBox63.Height = screenSize[4];
            pictureBox64.Width = screenSize[4]; pictureBox64.Height = screenSize[4];
            pictureBox65.Width = screenSize[4]; pictureBox65.Height = screenSize[4];
            
            pictureBox66.Width = screenSize[4]; pictureBox66.Height = screenSize[4];
            pictureBox67.Width = screenSize[4]; pictureBox67.Height = screenSize[4];
            pictureBox68.Width = screenSize[4]; pictureBox68.Height = screenSize[4];
            pictureBox69.Width = screenSize[4]; pictureBox69.Height = screenSize[4];
            pictureBox70.Width = screenSize[4]; pictureBox70.Height = screenSize[4];
            pictureBox71.Width = screenSize[4]; pictureBox71.Height = screenSize[4];
            pictureBox72.Width = screenSize[4]; pictureBox72.Height = screenSize[4];
            pictureBox73.Width = screenSize[4]; pictureBox73.Height = screenSize[4];
            pictureBox74.Width = screenSize[4]; pictureBox74.Height = screenSize[4];
            pictureBox75.Width = screenSize[4]; pictureBox75.Height = screenSize[4];
            pictureBox76.Width = screenSize[4]; pictureBox76.Height = screenSize[4];
            pictureBox77.Width = screenSize[4]; pictureBox77.Height = screenSize[4];

            pictureBox1.Left = screenSize[2];                           pictureBox1.Top = screenSize[3];
            pictureBox2.Left = screenSize[2] + screenSize[4];           pictureBox2.Top = screenSize[3];
            pictureBox3.Left = screenSize[2] + (screenSize[4] * 2);     pictureBox3.Top = screenSize[3];
            pictureBox4.Left = screenSize[2] + (screenSize[4] * 3);     pictureBox4.Top = screenSize[3];
            pictureBox5.Left = screenSize[2] + (screenSize[4] * 4);     pictureBox5.Top = screenSize[3];
            pictureBox6.Left = screenSize[2] + (screenSize[4] * 5);     pictureBox6.Top = screenSize[3];
            pictureBox7.Left = screenSize[2] + (screenSize[4] * 6);     pictureBox7.Top = screenSize[3];
            pictureBox8.Left = screenSize[2] + (screenSize[4] * 7);     pictureBox8.Top = screenSize[3];
            pictureBox9.Left = screenSize[2] + (screenSize[4] * 8);     pictureBox9.Top = screenSize[3];
            pictureBox10.Left = screenSize[2] + (screenSize[4] * 9);    pictureBox10.Top = screenSize[3];
            pictureBox11.Left = screenSize[2] + (screenSize[4] * 10);   pictureBox11.Top = screenSize[3];

            pictureBox12.Left = screenSize[2];                          pictureBox12.Top = screenSize[3] + screenSize[4];
            pictureBox13.Left = screenSize[2] + screenSize[4];          pictureBox13.Top = screenSize[3] + screenSize[4];
            pictureBox14.Left = screenSize[2] + (screenSize[4] * 2);    pictureBox14.Top = screenSize[3] + screenSize[4];
            pictureBox15.Left = screenSize[2] + (screenSize[4] * 3);    pictureBox15.Top = screenSize[3] + screenSize[4];
            pictureBox16.Left = screenSize[2] + (screenSize[4] * 4);    pictureBox16.Top = screenSize[3] + screenSize[4];
            pictureBox17.Left = screenSize[2] + (screenSize[4] * 5);    pictureBox17.Top = screenSize[3] + screenSize[4];
            pictureBox18.Left = screenSize[2] + (screenSize[4] * 6);    pictureBox18.Top = screenSize[3] + screenSize[4];
            pictureBox19.Left = screenSize[2] + (screenSize[4] * 7);    pictureBox19.Top = screenSize[3] + screenSize[4];
            pictureBox20.Left = screenSize[2] + (screenSize[4] * 8);    pictureBox20.Top = screenSize[3] + screenSize[4];
            pictureBox21.Left = screenSize[2] + (screenSize[4] * 9);    pictureBox21.Top = screenSize[3] + screenSize[4];
            pictureBox22.Left = screenSize[2] + (screenSize[4] * 10);   pictureBox22.Top = screenSize[3] + screenSize[4];

            pictureBox23.Left = screenSize[2]; pictureBox23.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox24.Left = screenSize[2] + screenSize[4]; pictureBox24.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox25.Left = screenSize[2] + (screenSize[4] * 2); pictureBox25.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox26.Left = screenSize[2] + (screenSize[4] * 3); pictureBox26.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox27.Left = screenSize[2] + (screenSize[4] * 4); pictureBox27.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox28.Left = screenSize[2] + (screenSize[4] * 5); pictureBox28.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox29.Left = screenSize[2] + (screenSize[4] * 6); pictureBox29.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox30.Left = screenSize[2] + (screenSize[4] * 7); pictureBox30.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox31.Left = screenSize[2] + (screenSize[4] * 8); pictureBox31.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox32.Left = screenSize[2] + (screenSize[4] * 9); pictureBox32.Top = screenSize[3] + (screenSize[4] * 2);
            pictureBox33.Left = screenSize[2] + (screenSize[4] * 10); pictureBox33.Top = screenSize[3] + (screenSize[4] * 2);

            pictureBox34.Left = screenSize[2]; pictureBox34.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox35.Left = screenSize[2] + screenSize[4]; pictureBox35.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox36.Left = screenSize[2] + (screenSize[4] * 2); pictureBox36.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox37.Left = screenSize[2] + (screenSize[4] * 3); pictureBox37.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox38.Left = screenSize[2] + (screenSize[4] * 4); pictureBox38.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox39.Left = screenSize[2] + (screenSize[4] * 5); pictureBox39.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox40.Left = screenSize[2] + (screenSize[4] * 6); pictureBox40.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox41.Left = screenSize[2] + (screenSize[4] * 7); pictureBox41.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox42.Left = screenSize[2] + (screenSize[4] * 8); pictureBox42.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox43.Left = screenSize[2] + (screenSize[4] * 9); pictureBox43.Top = screenSize[3] + (screenSize[4] * 3);
            pictureBox44.Left = screenSize[2] + (screenSize[4] * 10); pictureBox44.Top = screenSize[3] + (screenSize[4] * 3);

            pictureBox45.Left = screenSize[2]; pictureBox45.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox46.Left = screenSize[2] + screenSize[4]; pictureBox46.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox47.Left = screenSize[2] + (screenSize[4] * 2); pictureBox47.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox48.Left = screenSize[2] + (screenSize[4] * 3); pictureBox48.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox49.Left = screenSize[2] + (screenSize[4] * 4); pictureBox49.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox50.Left = screenSize[2] + (screenSize[4] * 5); pictureBox50.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox51.Left = screenSize[2] + (screenSize[4] * 6); pictureBox51.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox52.Left = screenSize[2] + (screenSize[4] * 7); pictureBox52.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox53.Left = screenSize[2] + (screenSize[4] * 8); pictureBox53.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox54.Left = screenSize[2] + (screenSize[4] * 9); pictureBox54.Top = screenSize[3] + (screenSize[4] * 4);
            pictureBox55.Left = screenSize[2] + (screenSize[4] * 10); pictureBox55.Top = screenSize[3] + (screenSize[4] * 4);

            pictureBox56.Left = screenSize[2]; pictureBox56.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox57.Left = screenSize[2] + screenSize[4]; pictureBox57.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox58.Left = screenSize[2] + (screenSize[4] * 2); pictureBox58.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox59.Left = screenSize[2] + (screenSize[4] * 3); pictureBox59.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox60.Left = screenSize[2] + (screenSize[4] * 4); pictureBox60.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox61.Left = screenSize[2] + (screenSize[4] * 5); pictureBox61.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox62.Left = screenSize[2] + (screenSize[4] * 6); pictureBox62.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox63.Left = screenSize[2] + (screenSize[4] * 7); pictureBox63.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox64.Left = screenSize[2] + (screenSize[4] * 8); pictureBox64.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox65.Left = screenSize[2] + (screenSize[4] * 9); pictureBox65.Top = screenSize[3] + (screenSize[4] * 5);
            pictureBox66.Left = screenSize[2] + (screenSize[4] * 10); pictureBox66.Top = screenSize[3] + (screenSize[4] * 5);

            pictureBox67.Left = screenSize[2]; pictureBox67.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox68.Left = screenSize[2] + screenSize[4]; pictureBox68.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox69.Left = screenSize[2] + (screenSize[4] * 2); pictureBox69.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox70.Left = screenSize[2] + (screenSize[4] * 3); pictureBox70.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox71.Left = screenSize[2] + (screenSize[4] * 4); pictureBox71.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox72.Left = screenSize[2] + (screenSize[4] * 5); pictureBox72.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox73.Left = screenSize[2] + (screenSize[4] * 6); pictureBox73.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox74.Left = screenSize[2] + (screenSize[4] * 7); pictureBox74.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox75.Left = screenSize[2] + (screenSize[4] * 8); pictureBox75.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox76.Left = screenSize[2] + (screenSize[4] * 9); pictureBox76.Top = screenSize[3] + (screenSize[4] * 6);
            pictureBox77.Left = screenSize[2] + (screenSize[4] * 10); pictureBox77.Top = screenSize[3] + (screenSize[4] * 6);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.BringToFront();

        }
    }
}
