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
            // Initialise le son
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Ambiance);
            simpleSound.Play();
            //Défini la zone de jeu
            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            //Défini la map comme controlleur
            mySpriteController = new SpriteController(MainDrawingArea);
            Sprite sprite = new Sprite(mySpriteController);
            // Maitre d'hôtel
            sprite.maitreHotelSprite.AutomaticallyMoves = true;
            sprite.maitreHotelSprite.CannotMoveOutsideBox = true;
            sprite.maitreHotelSprite.SetSpriteDirectionDegrees(180);
            sprite.maitreHotelSprite.PutBaseImageLocation(ConstantPosition.maitreHotel);
            sprite.maitreHotelSprite.MoveTo(ConstantPosition.maitreHotel);
            sprite.maitreHotelSprite.SetSize(new Size(16, 32));
            sprite.maitreHotelSprite.MovementSpeed = 2;

            // Le superviseur de carré 1
            sprite.squareSupervisorSprite.AutomaticallyMoves = true;
            sprite.squareSupervisorSprite.CannotMoveOutsideBox = true;
            sprite.squareSupervisorSprite.SetSpriteDirectionDegrees(-90);
            sprite.squareSupervisorSprite.PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
            sprite.squareSupervisorSprite.MoveTo(ConstantPosition.initialSquare1Supervisor);
            sprite.squareSupervisorSprite.SetSize(new Size(16, 32));
            sprite.squareSupervisorSprite.MovementSpeed = 2;

            // Le superviseur de carré 2
            sprite.squareSupervisor2Sprite.AutomaticallyMoves = true;
            sprite.squareSupervisor2Sprite.CannotMoveOutsideBox = true;
            sprite.squareSupervisor2Sprite.SetSpriteDirectionDegrees(-90);
            sprite.squareSupervisor2Sprite.PutBaseImageLocation(ConstantPosition.initialSquare2Supervisor);
            sprite.squareSupervisor2Sprite.MoveTo(ConstantPosition.initialSquare2Supervisor);
            sprite.squareSupervisor2Sprite.SetSize(new Size(16, 32));
            sprite.squareSupervisor2Sprite.MovementSpeed = 2;

            //Serveur 1
            sprite.waiterSprite.AutomaticallyMoves = true;
            sprite.waiterSprite.CannotMoveOutsideBox = true;
            sprite.waiterSprite.SetSpriteDirectionDegrees(-90);
            sprite.waiterSprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            sprite.waiterSprite.MoveTo(ConstantPosition.initialWaiter);
            sprite.waiterSprite.SetSize(new Size(16, 32));
            sprite.waiterSprite.MovementSpeed = 2;

            //Serveur 2
            sprite.waiter2Sprite.AutomaticallyMoves = true;
            sprite.waiter2Sprite.CannotMoveOutsideBox = true;
            sprite.waiter2Sprite.SetSpriteDirectionDegrees(-90);
            sprite.waiter2Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            sprite.waiter2Sprite.MoveTo(ConstantPosition.initialWaiter);
            sprite.waiter2Sprite.SetSize(new Size(16, 32));
            sprite.waiter2Sprite.MovementSpeed = 2;

            //Serveur 3
            sprite.waiter3Sprite.AutomaticallyMoves = true;
            sprite.waiter3Sprite.CannotMoveOutsideBox = true;
            sprite.waiter3Sprite.SetSpriteDirectionDegrees(-90);
            sprite.waiter3Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            sprite.waiter3Sprite.MoveTo(ConstantPosition.initialWaiter);
            sprite.waiter3Sprite.SetSize(new Size(16, 32));
            sprite.waiter3Sprite.MovementSpeed = 2;

            //Serveur 4
            sprite.waiter4Sprite.AutomaticallyMoves = true;
            sprite.waiter4Sprite.CannotMoveOutsideBox = true;
            sprite.waiter4Sprite.SetSpriteDirectionDegrees(-90);
            sprite.waiter4Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            sprite.waiter4Sprite.MoveTo(ConstantPosition.initialWaiter);
            sprite.waiter4Sprite.SetSize(new Size(16, 32));
            sprite.waiter4Sprite.MovementSpeed = 2;


            //Chef de la cuisine
            sprite.masterChefSprite.AutomaticallyMoves = true;
            sprite.masterChefSprite.CannotMoveOutsideBox = true;
            sprite.masterChefSprite.SetSpriteDirectionDegrees(-90);
            sprite.masterChefSprite.PutBaseImageLocation(ConstantPosition.masterChef);
            sprite.masterChefSprite.MoveTo(ConstantPosition.masterChef);
            sprite.masterChefSprite.SetSize(new Size(16, 32));
            sprite.masterChefSprite.MovementSpeed = 2;

            //Plogneur
            sprite.kitchenPorterSprite.AutomaticallyMoves = true;
            sprite.kitchenPorterSprite.CannotMoveOutsideBox = true;
            sprite.kitchenPorterSprite.SetSpriteDirectionDegrees(-90);
            sprite.kitchenPorterSprite.PutBaseImageLocation(ConstantPosition.kitchenPorter);
            sprite.kitchenPorterSprite.MoveTo(ConstantPosition.kitchenPorter);
            sprite.kitchenPorterSprite.SetSize(new Size(16, 32));
            sprite.kitchenPorterSprite.MovementSpeed = 2;

            //// Le commis
            //sprite.kitchenAssistantSprite.AutomaticallyMoves = true;
            //sprite.kitchenAssistantSprite.CannotMoveOutsideBox = true;
            //sprite.kitchenAssistantSprite.SetSpriteDirectionDegrees(-90);
            //sprite.kitchenAssistantSprite.PutBaseImageLocation(ConstantPosition.commis);
            //sprite.kitchenAssistantSprite.SetSize(new Size(30, 30));
            //sprite.kitchenAssistantSprite.MovementSpeed = 2;

            //Chef de section
            sprite.sectionChefSprite.AutomaticallyMoves = true;
            sprite.sectionChefSprite.CannotMoveOutsideBox = true;
            sprite.sectionChefSprite.SetSpriteDirectionDegrees(-90);
            sprite.sectionChefSprite.PutBaseImageLocation(ConstantPosition.sectionChef);
            sprite.sectionChefSprite.MoveTo(ConstantPosition.sectionChef);
            sprite.sectionChefSprite.SetSize(new Size(25, 25));
            sprite.sectionChefSprite.MovementSpeed = 2;
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
