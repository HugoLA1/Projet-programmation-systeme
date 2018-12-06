using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SpriteController MySpriteController;


            InitializeComponent();

            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            MySpriteController = new SpriteController(MainDrawingArea);

            Sprite Serveur = new Sprite(new Point(0, 100), MySpriteController,
                    Properties.Resources.cop_in_overalls_cr_pineda_and_grandmadeb_zpswv0etgbb, 30, 30, 200, 3);
            Serveur.SetName("Serveur");

            Serveur.AutomaticallyMoves = true;
            Serveur.CannotMoveOutsideBox = true;
            //Serveur.SpriteHitsPictureBox += SpriteBounces;
            // 0 vers le haut, 90 droite, 180 gauche
            Serveur.SetSpriteDirectionDegrees(180);
            Serveur.PutBaseImageLocation(new Point(300, 600));
            Serveur.SetSize(new Size(32, 32));
            Serveur.MovementSpeed = 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
