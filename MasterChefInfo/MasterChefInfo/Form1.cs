using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MasterChefInfo
{
    partial class Form1 : Form, IObserver
    {
        Model model;
        SpriteController mySpriteController;

        List<Sprite> waitersList;

        List<Sprite> square1SupervisorsList;
        List<Sprite> square2SupervisorsList;

        List<Sprite> sectionChefsList;

        public Sprite maitreHotelSprite;
        public Sprite masterChefSprite;
        public Sprite kitchenPorterSprite;

        public Image MH;
        public Image MC;
        public Image SS;
        public Image W;
        public Image SC;
        public Image KP;

        public Form1(Model model)
        {
            this.model = model;
            InitializeComponent();

            //SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Ambiance);
            //simpleSound.Play();

            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            mySpriteController = new SpriteController(MainDrawingArea);

            waitersList = new List<Sprite>();
            square1SupervisorsList = new List<Sprite>();
            square2SupervisorsList = new List<Sprite>();
            sectionChefsList = new List<Sprite>();

            MH = Properties.Resources.perso6sprite;
            MC = Properties.Resources.perso1sprite;
            SS = Properties.Resources.SS1;
            W = Properties.Resources.waiter1;
            SC = Properties.Resources.SC1;
            KP = Properties.Resources.perso7sprite;

            for (int i = 0; i < ConstantGeneral.numberOfWaiter; i++)
            {
                waitersList.Insert(i, new Sprite(new Point(0, 0), mySpriteController,
                W, 16, 32, 200, 4));
                waitersList[i].SetName("Serveur " + (i + 1).ToString());
                waitersList[i].AddAnimation(new Point(0, 64), W, 16, 32, 200, 4);
                waitersList[i].AddAnimation(new Point(0, 0), W, 16, 32, 200, 4);
                waitersList[i].AddAnimation(new Point(0, 96), W, 16, 32, 200, 4);
                waitersList[i].AddAnimation(new Point(0, 32), W, 16, 32, 200, 4);

                waitersList[i].CannotMoveOutsideBox = true;
                waitersList[i].SetSpriteDirectionDegrees(-90);
                waitersList[i].PutBaseImageLocation(ConstantPosition.initialWaiter);
                waitersList[i].SetSize(new Size(16, 32));
                waitersList[i].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
            }

            for(int i = 0; i < ConstantGeneral.numberOfSSPerSquare; i++)
            {
                square1SupervisorsList.Insert(i, new Sprite(new Point(0, 0), mySpriteController,
                SS, 16, 32, 200, 4));
                square2SupervisorsList.Insert(i, new Sprite(new Point(0, 0), mySpriteController,
                SS, 16, 32, 200, 4));
                square1SupervisorsList[i].SetName("Chef " + (i + 1).ToString() + " du rang 1");
                square2SupervisorsList[i].SetName("Chef " + (i + 1).ToString() + " du rang 2");

                square1SupervisorsList[i].AddAnimation(new Point(0, 64), SS, 16, 32, 200, 4);
                square1SupervisorsList[i].AddAnimation(new Point(0, 0), SS, 16, 32, 200, 4);
                square1SupervisorsList[i].AddAnimation(new Point(0, 96), SS, 16, 32, 200, 4);
                square1SupervisorsList[i].AddAnimation(new Point(0, 32), SS, 16, 32, 200, 4);

                square2SupervisorsList[i].AddAnimation(new Point(0, 64), SS, 16, 32, 200, 4);
                square2SupervisorsList[i].AddAnimation(new Point(0, 0), SS, 16, 32, 200, 4);
                square2SupervisorsList[i].AddAnimation(new Point(0, 96), SS, 16, 32, 200, 4);
                square2SupervisorsList[i].AddAnimation(new Point(0, 32), SS, 16, 32, 200, 4);

                square1SupervisorsList[i].CannotMoveOutsideBox = true;
                square1SupervisorsList[i].SetSpriteDirectionDegrees(-90);
                square1SupervisorsList[i].PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
                square1SupervisorsList[i].SetSize(new Size(16, 32));
                square1SupervisorsList[i].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;

                square2SupervisorsList[i].CannotMoveOutsideBox = true;
                square2SupervisorsList[i].SetSpriteDirectionDegrees(-90);
                square2SupervisorsList[i].PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
                square2SupervisorsList[i].SetSize(new Size(16, 32));
                square2SupervisorsList[i].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
            }

            for (int i = 0; i < ConstantGeneral.numberOfSC; i++)
            {

                sectionChefsList.Insert(i, new Sprite(new Point(0, 0), mySpriteController,
                MC, 16, 32, 200, 4));
                sectionChefsList[i].SetName("Chef de section " + (i + 1).ToString());
                sectionChefsList[i].AddAnimation(new Point(0, 64), SC, 16, 32, 200, 4);
                sectionChefsList[i].AddAnimation(new Point(0, 0), SC, 16, 32, 200, 4);
                sectionChefsList[i].AddAnimation(new Point(0, 96), SC, 16, 32, 200, 4);
                sectionChefsList[i].AddAnimation(new Point(0, 32), SC, 16, 32, 200, 4);

                sectionChefsList[i].CannotMoveOutsideBox = true;
                sectionChefsList[i].SetSpriteDirectionDegrees(-90);
                sectionChefsList[i].PutBaseImageLocation(ConstantPosition.sectionChef);
                sectionChefsList[i].SetSize(new Size(16, 32));
                sectionChefsList[i].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
            }

            // Maitre d'hôtel
            maitreHotelSprite = new Sprite(new Point(0, 0), mySpriteController, MH, 16, 32, 200, 4);
            maitreHotelSprite.SetName("Maître d'hôtel");
            maitreHotelSprite.AddAnimation(new Point(0, 64), MH, 16, 32, 200, 4);
            maitreHotelSprite.AddAnimation(new Point(0, 0), MH, 16, 32, 200, 4);
            maitreHotelSprite.AddAnimation(new Point(0, 96), MH, 16, 32, 200, 4);
            maitreHotelSprite.AddAnimation(new Point(0, 32), MH, 16, 32, 200, 4);
            maitreHotelSprite.CannotMoveOutsideBox = true;
            maitreHotelSprite.SetSpriteDirectionDegrees(180);
            maitreHotelSprite.PutBaseImageLocation(ConstantPosition.maitreHotel);
            maitreHotelSprite.SetSize(new Size(16, 32));
            maitreHotelSprite.MovementSpeed = ConstantGeneral.globalSpeedOfSprite;

            //Chef de la cuisine
            masterChefSprite = new Sprite(new Point(0, 0), mySpriteController, MC, 16, 32, 200, 4);
            masterChefSprite.SetName("Chef de cuisine");
            masterChefSprite.AddAnimation(new Point(0, 64), MC, 16, 32, 200, 4);
            masterChefSprite.AddAnimation(new Point(0, 0), MC, 16, 32, 200, 4);
            masterChefSprite.AddAnimation(new Point(0, 96), MC, 16, 32, 200, 4);
            masterChefSprite.AddAnimation(new Point(0, 32), MC, 16, 32, 200, 4);
            masterChefSprite.CannotMoveOutsideBox = true;
            masterChefSprite.SetSpriteDirectionDegrees(-90);
            masterChefSprite.PutBaseImageLocation(ConstantPosition.masterChef);
            masterChefSprite.MoveTo(ConstantPosition.masterChef);
            masterChefSprite.SetSize(new Size(16, 32));
            masterChefSprite.MovementSpeed = ConstantGeneral.globalSpeedOfSprite;

            //Plogneur
            kitchenPorterSprite = new Sprite(new Point(0, 0), mySpriteController,
                KP, 16, 32, 200, 1);
            kitchenPorterSprite.SetName("Plongeur");
            kitchenPorterSprite.AddAnimation(new Point(0, 64), KP, 16, 32, 200, 4);
            kitchenPorterSprite.AddAnimation(new Point(0, 0), KP, 16, 32, 200, 4);
            kitchenPorterSprite.AddAnimation(new Point(0, 96), KP, 16, 32, 200, 4);
            kitchenPorterSprite.AddAnimation(new Point(0, 32), KP, 16, 32, 200, 4);
            kitchenPorterSprite.CannotMoveOutsideBox = true;
            kitchenPorterSprite.SetSpriteDirectionDegrees(-90);
            kitchenPorterSprite.PutBaseImageLocation(ConstantPosition.kitchenPorter);
            kitchenPorterSprite.MoveTo(ConstantPosition.kitchenPorter);
            kitchenPorterSprite.SetSize(new Size(16, 32));
            kitchenPorterSprite.MovementSpeed = ConstantGeneral.globalSpeedOfSprite;

        }

        public void Update(string name, int nb, List<Point> track)
        {
            switch (name)
            {
                case "waiter":
                    waitersList[nb].MoveTo(track);
                    waitersList[nb].AutomaticallyMoves = true;
                    waitersList[nb].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
                    while (!waitersList[nb].SpriteReachedEndPoint) { }
                    break;

                case "squareSupervisor1":
                    square1SupervisorsList[nb].MoveTo(track);
                    square1SupervisorsList[nb].AutomaticallyMoves = true;
                    square1SupervisorsList[nb].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
                    while (!square1SupervisorsList[nb].SpriteReachedEndPoint) { }
                    break;

               
                case "squareSupervisor2":
                    square2SupervisorsList[nb].MoveTo(track);
                    square2SupervisorsList[nb].AutomaticallyMoves = true;
                    square2SupervisorsList[nb].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
                    while (!square2SupervisorsList[nb].SpriteReachedEndPoint) { }
                    break;

                case "sectionChef":
                    sectionChefsList[nb].MoveTo(track);
                    sectionChefsList[nb].AutomaticallyMoves = true;
                    sectionChefsList[nb].MovementSpeed = ConstantGeneral.globalSpeedOfSprite;
                    while (!sectionChefsList[nb].SpriteReachedEndPoint) { }
                    break;
            }
        }

        public void Update(int moneytotal)
        {
            if (money.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    money.Text = moneytotal.ToString();
                }));
            }
            else
            {
                money.Text = moneytotal.ToString();
            }
        }
        //-------------------------------------------------------------























        private void money_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
