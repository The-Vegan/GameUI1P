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
        PictureBox[,] lesBox;

        const int maxColonne = 11;
        const int maxLigne = 7;

        public Form1()
        {
            InitializeComponent();
            CreatePictureBoxes();
            
        }

        private void CreatePictureBoxes()
        {
            lesBox = new PictureBox[11, 11];
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendLayout();
            for (int ligne = 0; ligne < maxLigne; ligne++)
            {
                for (int colonne = 0; colonne < maxColonne; colonne++)
                {
                    var onePictureBox = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(onePictureBox)).BeginInit();

                    // 
                    // onePictureBox
                    // 
                    onePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                    onePictureBox.Location = new System.Drawing.Point(colonne * 64, ligne * 64);
                    onePictureBox.Name = "onePictureBox";
                    onePictureBox.Size = new System.Drawing.Size(64, 64);
                    onePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    onePictureBox.TabIndex = 1;
                    onePictureBox.TabStop = false;
                    //
                    this.Controls.Add(onePictureBox);
                    lesBox[ligne, colonne] = onePictureBox;
                    ((System.ComponentModel.ISupportInitialize)(onePictureBox)).EndInit();
                }
            }
            this.ResumeLayout(true);

        }

        short[] screenSize = new short[5];  //[longueur][hauteur][gauche][haut][taille] 
        private void Form1_Resize(object sender, EventArgs e)
        {

            if ((this.ClientSize.Width != 0) || (this.ClientSize.Height) != 0)
            {

                if ((this.ClientSize.Width / this.ClientSize.Height) >= (maxColonne / maxLigne))
                {
                    screenSize[1] = (short)this.ClientSize.Height;
                    screenSize[0] = (short)((screenSize[1] / maxLigne) * maxColonne);
                    screenSize[2] = (short)((this.ClientSize.Width - screenSize[0]) / 2);
                    screenSize[3] = 0;
                    /*  ╔══╦════════════════════╦══╗
                     *  ║  ║                    ║  ║
                     *  ║  ║                    ║  ║
                     *  ║  ║                    ║  ║
                     *  ║  ║                    ║  ║
                     *  ║  ║                    ║  ║
                     *  ║  ║                    ║  ║
                     *  ╚══╩════════════════════╩══╝
                        Bordures horizontales
                     */


                }
                else
                {
                    screenSize[0] = (short)this.ClientSize.Width;
                    screenSize[1] = (short)((screenSize[0] / maxColonne) * maxLigne);
                    screenSize[2] = 0;
                    screenSize[3] = (short)((this.ClientSize.Height - screenSize[1]) / 2);
                    /*  ╔══════════════════╗
                     *  ╠══════════════════╣
                     *  ║                  ║
                     *  ║                  ║
                     *  ║                  ║
                     *  ║                  ║
                     *  ╠══════════════════╣
                     *  ╚══════════════════╝
                        Bordures verticales
                     */
                }

                screenSize[4] = (short)(screenSize[0] / maxColonne);

                progressBar1.Width = (int)(this.ClientSize.Width * 0.34);
                progressBar1.Left = (int)(this.ClientSize.Width * 0.33);
                progressBar1.Height = (int)(ClientSize.Height * 0.05);
                progressBar1.Top = (int)(ClientSize.Height * 0.9);

                //redevinis les tailles des picturesBox

                for (int ligne = 0; ligne < maxLigne; ligne++)
                {
                    for (int colonne = 0; colonne < maxColonne; colonne++)
                    {
                        var pb = lesBox[ligne, colonne];
                        //
                        pb.Width = screenSize[4];
                        pb.Height = screenSize[4];
                    }
                }

                //repositionne les pictureBox
                for (int ligne = 0; ligne < maxLigne; ligne++)
                {
                    for (int colonne = 0; colonne < maxColonne; colonne++)
                    {
                        var pb = lesBox[ligne, colonne];
                        //
                        pb.Left = screenSize[2] + (colonne * screenSize[4]);
                        pb.Top = screenSize[3] + (ligne * screenSize[4]);

                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.BringToFront();
            this.Refresh();
        }
    }
}
