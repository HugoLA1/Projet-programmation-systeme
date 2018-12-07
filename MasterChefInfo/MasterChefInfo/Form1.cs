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
        SpriteController mySpriteController;

        public Form1()
        {
            InitializeComponent();

            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            mySpriteController = new SpriteController(MainDrawingArea);

            SpriteLibrary.Sprite sectionChef = new SpriteLibrary.Sprite(new Point(0, 50), mySpriteController,
                Properties.Resources.ChefMale, 50, 50, 500, 3);
            sectionChef.SetName("Chef de section");
            sectionChef.SetSize(new Size(24, 24));
            sectionChef.PutBaseImageLocation(new Point(240, 240));
            sectionChef.AutomaticallyMoves = true;
            sectionChef.CannotMoveOutsideBox = true;
            //sectionChef.SetSpriteDirectionDegrees(180);
            sectionChef.MovementSpeed = 2;
            sectionChef.MoveTo(new Point(72, 239));
            sectionChef.MoveTo(new Point(72, 192));
            sectionChef.ChangeAnimation(3);
            sectionChef.AddAnimation(new Point(50, 150), Properties.Resources.ChefMale, 50, 50, 500, 1);
            sectionChef.ChangeAnimation(1);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void MainDrawingArea_Click(object sender, EventArgs e)
        {

        }
    }
}
