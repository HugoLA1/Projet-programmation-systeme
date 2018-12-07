using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    partial class Form1 : Form
    {
        Model model;
        SpriteController mySpriteController;
        public Form1(Model model)
        {
            this.model = model;
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Ambiance);
            simpleSound.Play();
            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            mySpriteController = new SpriteController(MainDrawingArea);
            Sprite sprite = new Sprite(mySpriteController);
            // Maitre d'hôtel
            sprite.maitreHotelSprite.AutomaticallyMoves = true;
            sprite.maitreHotelSprite.CannotMoveOutsideBox = true;
            // 0 vers le haut, 90 droite, 180 gauche
            sprite.maitreHotelSprite.SetSpriteDirectionDegrees(180);
            sprite.maitreHotelSprite.PutBaseImageLocation(new Point(300, 600));
            sprite.maitreHotelSprite.SetSize(new Size(16, 32));
            sprite.maitreHotelSprite.MovementSpeed = 2;

            // squareSupervisorSprite
            sprite.squareSupervisorSprite.AutomaticallyMoves = true;
            sprite.squareSupervisorSprite.CannotMoveOutsideBox = true;
            // 0 vers le haut, 90 droite, 180 gauche, -90 bas
            sprite.squareSupervisorSprite.SetSpriteDirectionDegrees(-90);
            sprite.squareSupervisorSprite.PutBaseImageLocation(new Point(300, -600));
            sprite.squareSupervisorSprite.SetSize(new Size(16, 32));
            sprite.squareSupervisorSprite.MovementSpeed = 2;

            // squareSupervisorSprite
            sprite.kitchenAssistantSprite.AutomaticallyMoves = true;
            sprite.kitchenAssistantSprite.CannotMoveOutsideBox = true;
            // 0 vers le haut, 90 droite, 180 gauche, -90 bas
            sprite.kitchenAssistantSprite.SetSpriteDirectionDegrees(-90);
            sprite.kitchenAssistantSprite.PutBaseImageLocation(new Point(100, -400));
            sprite.kitchenAssistantSprite.SetSize(new Size(30, 30));
            sprite.kitchenAssistantSprite.MovementSpeed = 2;


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
