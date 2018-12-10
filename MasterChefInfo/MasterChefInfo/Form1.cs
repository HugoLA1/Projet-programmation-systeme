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
        public SpriteView sprite;

        public Sprite waiterSprite;
        public Point waiter1SpriteLastPos;
        public Sprite waiter2Sprite;
        public Point waiter2SpriteLastPos;
        public Sprite waiter3Sprite;
        public Point waiter3SpriteLastPos;
        public Sprite waiter4Sprite;
        public Point waiter4SpriteLastPos;

        public Sprite squareSupervisorSprite;
        public Point squareSupervisorSpriteLastPos;
        public Sprite squareSupervisor2Sprite;
        public Point squareSupervisor2SpriteLastPos;

        public Form1(Model model)
        {
            this.model = model;
            InitializeComponent();

            // Initialise le son
            //SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Ambiance);
            //simpleSound.Play();
            //Défini la zone de jeu
            MainDrawingArea.BackgroundImageLayout = ImageLayout.Stretch;
            //Défini la map comme controlleur
            mySpriteController = new SpriteController(MainDrawingArea);

            Image SS = Properties.Resources.perso5sprite;
            Image SS1 = Properties.Resources.perso5sprite;

            Image W1 = Properties.Resources.perso4sprite;
            Image W2 = Properties.Resources.perso4sprite;
            Image W3 = Properties.Resources.perso4sprite;
            Image W4 = Properties.Resources.perso4sprite;

            squareSupervisorSpriteLastPos = ConstantPosition.initialSquare1Supervisor;
            squareSupervisor2SpriteLastPos = ConstantPosition.initialSquare2Supervisor;

            waiter1SpriteLastPos = ConstantPosition.initialWaiter;
            waiter2SpriteLastPos = ConstantPosition.initialWaiter;
            waiter3SpriteLastPos = ConstantPosition.initialWaiter;
            waiter4SpriteLastPos = ConstantPosition.initialWaiter;

            squareSupervisorSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                SS, 16, 32, 200, 4);
            squareSupervisorSprite.SetName("Chef de section 1");

            squareSupervisor2Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                SS1, 16, 32, 200, 4);
            squareSupervisor2Sprite.SetName("Chef de section 2");

            waiterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                W1, 16, 32, 200, 4);
            waiterSprite.SetName("Serveur 1");

            waiter2Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                W2, 16, 32, 200, 4);
            waiter2Sprite.SetName("Serveur 2");

            waiter3Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                W3, 16, 32, 200, 4);
            waiter3Sprite.SetName("Serveur 3");

            waiter4Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                W4, 16, 32, 200, 4);
            waiter4Sprite.SetName("Serveur 4");

            // Maitre d'hôtel
            //sprite.maitreHotelSprite.AutomaticallyMoves = true;
            sprite = new SpriteView(mySpriteController);
            sprite.maitreHotelSprite.CannotMoveOutsideBox = true;
            sprite.maitreHotelSprite.SetSpriteDirectionDegrees(180);
            sprite.maitreHotelSprite.PutBaseImageLocation(ConstantPosition.maitreHotel);
            //sprite.maitreHotelSprite.MoveTo(ConstantPosition.maitreHotel);
            sprite.maitreHotelSprite.SetSize(new Size(16, 32));
            sprite.maitreHotelSprite.MovementSpeed = 2;

            // Le superviseur de carré 1
            //sprite.squareSupervisorSprite.AutomaticallyMoves = true;
            squareSupervisorSprite.CannotMoveOutsideBox = true;
            squareSupervisorSprite.SetSpriteDirectionDegrees(-90);
            squareSupervisorSprite.PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
            //sprite.squareSupervisorSprite.MoveTo(ConstantPosition.initialSquare1Supervisor);
            squareSupervisorSprite.SetSize(new Size(16, 32));
            squareSupervisorSprite.MovementSpeed = 15;

            // Le superviseur de carré 2
            //sprite.squareSupervisor2Sprite.AutomaticallyMoves = true;
            squareSupervisor2Sprite.CannotMoveOutsideBox = true;
            squareSupervisor2Sprite.SetSpriteDirectionDegrees(-90);
            squareSupervisor2Sprite.PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
            //sprite.squareSupervisor2Sprite.MoveTo(ConstantPosition.initialSquare2Supervisor);
            squareSupervisor2Sprite.SetSize(new Size(16, 32));
            squareSupervisor2Sprite.MovementSpeed = 15;

            //Serveur 1
            //sprite.waiterSprite.AutomaticallyMoves = true;
            waiterSprite.CannotMoveOutsideBox = true;
            waiterSprite.SetSpriteDirectionDegrees(-90);
            waiterSprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            //sprite.waiterSprite.MoveTo(ConstantPosition.initialWaiter);
            waiterSprite.SetSize(new Size(16, 32));
            waiterSprite.MovementSpeed = 15;

            //Serveur 2
            sprite.waiter2Sprite.CannotMoveOutsideBox = true;
            sprite.waiter2Sprite.SetSpriteDirectionDegrees(-90);
            sprite.waiter2Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            sprite.waiter2Sprite.SetSize(new Size(16, 32));
            sprite.waiter2Sprite.MovementSpeed = 5;

            //Serveur 3
            //sprite.waiter3Sprite.AutomaticallyMoves = true;
            sprite.waiter3Sprite.CannotMoveOutsideBox = true;
            sprite.waiter3Sprite.SetSpriteDirectionDegrees(-90);
            sprite.waiter3Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            //sprite.waiter3Sprite.MoveTo(ConstantPosition.initialWaiter);
            sprite.waiter3Sprite.SetSize(new Size(16, 32));
            sprite.waiter3Sprite.MovementSpeed = 5;

            //Serveur 4
            //sprite.waiter4Sprite.AutomaticallyMoves = true;
            sprite.waiter4Sprite.CannotMoveOutsideBox = true;
            sprite.waiter4Sprite.SetSpriteDirectionDegrees(-90);
            sprite.waiter4Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            //sprite.waiter4Sprite.MoveTo(ConstantPosition.initialWaiter);
            sprite.waiter4Sprite.SetSize(new Size(16, 32));
            sprite.waiter4Sprite.MovementSpeed = 5;

            //Chef de la cuisine
            //sprite.masterChefSprite.AutomaticallyMoves = true;
            sprite.masterChefSprite.CannotMoveOutsideBox = true;
            sprite.masterChefSprite.SetSpriteDirectionDegrees(-90);
            sprite.masterChefSprite.PutBaseImageLocation(ConstantPosition.masterChef);
            //sprite.masterChefSprite.MoveTo(ConstantPosition.masterChef);
            sprite.masterChefSprite.SetSize(new Size(16, 32));
            sprite.masterChefSprite.MovementSpeed = 5;

            //Plogneur
            //sprite.kitchenPorterSprite.AutomaticallyMoves = true;
            sprite.kitchenPorterSprite.CannotMoveOutsideBox = true;
            sprite.kitchenPorterSprite.SetSpriteDirectionDegrees(-90);
            sprite.kitchenPorterSprite.PutBaseImageLocation(ConstantPosition.kitchenPorter);
            //sprite.kitchenPorterSprite.MoveTo(ConstantPosition.kitchenPorter);
            sprite.kitchenPorterSprite.SetSize(new Size(16, 32));
            sprite.kitchenPorterSprite.MovementSpeed = 5;

            //// Le commis
            //sprite.kitchenAssistantSprite.AutomaticallyMoves = true;
            //sprite.kitchenAssistantSprite.CannotMoveOutsideBox = true;
            //sprite.kitchenAssistantSprite.SetSpriteDirectionDegrees(-90);
            //sprite.kitchenAssistantSprite.PutBaseImageLocation(ConstantPosition.commis);
            //sprite.kitchenAssistantSprite.SetSize(new Size(16, 32));
            //sprite.kitchenAssistantSprite.MovementSpeed = 2;

            //Chef de section
            //sprite.sectionChefSprite.AutomaticallyMoves = true;
            sprite.sectionChefSprite.CannotMoveOutsideBox = true;
            sprite.sectionChefSprite.SetSpriteDirectionDegrees(-90);
            sprite.sectionChefSprite.PutBaseImageLocation(ConstantPosition.sectionChef);
            //sprite.sectionChefSprite.MoveTo(ConstantPosition.sectionChef);
            sprite.sectionChefSprite.SetSize(new Size(16, 32));
            sprite.sectionChefSprite.MovementSpeed = 2;

            SS.Dispose();
            SS1.Dispose();
            W1.Dispose();
            W2.Dispose();
            W3.Dispose();
            W4.Dispose();

            sprite.sectionChefSprite.MoveTo(ConstantPosition.sectionChef);
            sprite.sectionChefSprite.SetSize(new Size(16, 32));
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Update(String name, List<Point> track)
        {

            //MessageBox.Show(name);
            InvalidOperationException e = null;

            switch (name)
            {

                case "Waiter1":
                        do
                        {
                            try
                            {
                            lock (waiterSprite)
                            {
                                Sprite NewSprite = mySpriteController.DuplicateSprite("Serveur 1");

                                NewSprite.PutBaseImageLocation(waiter1SpriteLastPos);
                                NewSprite.MovementSpeed = 15;

                                NewSprite.AutomaticallyMoves = true;
                                NewSprite.MoveTo(track);
                                while (!NewSprite.SpriteReachedEndPoint) { }

                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    waiter1SpriteLastPos = track[cpt - 1];
                                }
                                
                            }
                                e = null;
                            }
                            catch (InvalidOperationException ex)
                            {
                                e = ex;
                            }
                        } while (e != null); 
                    break;

                case "Waiter2":
                    do
                    {
                        try
                        {
                            lock (waiter2Sprite)
                            {
                                Sprite NewSprite = mySpriteController.DuplicateSprite("Serveur 2");
                                NewSprite.PutBaseImageLocation(waiter2SpriteLastPos);
                                NewSprite.MovementSpeed = 15;

                                NewSprite.AutomaticallyMoves = true;
                                NewSprite.MoveTo(track);
                                while (!NewSprite.SpriteReachedEndPoint) { }

                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    waiter2SpriteLastPos = track[cpt - 1];
                                }
                            }
                            e = null;
                        }
                        catch (InvalidOperationException ex)
                        {
                            e = ex;
                        }
                    } while (e != null);
                    break;

                case "Waiter3":
                    do
                    {
                        try
                        {
                            lock (waiter3Sprite)
                            {
                                Sprite NewSprite = mySpriteController.DuplicateSprite("Serveur 3");
                                NewSprite.PutBaseImageLocation(waiter3SpriteLastPos);
                                NewSprite.MovementSpeed = 15;

                                NewSprite.AutomaticallyMoves = true;
                                NewSprite.MoveTo(track);
                                while (!NewSprite.SpriteReachedEndPoint) { }

                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    waiter3SpriteLastPos = track[cpt - 1];
                                }
                            }
                            e = null;
                        }
                        catch (InvalidOperationException ex)
                        {
                            e = ex;
                        }
                    } while (e != null);
                    break;

                case "Waiter4":
                    do
                    {
                        try
                        {
                            lock (waiter4Sprite)
                            {
                                Sprite NewSprite = mySpriteController.DuplicateSprite("Serveur 4");

                                NewSprite.PutBaseImageLocation(waiter4SpriteLastPos);
                                NewSprite.MovementSpeed = 15;

                                NewSprite.AutomaticallyMoves = true;
                                NewSprite.MoveTo(track);
                                while (!NewSprite.SpriteReachedEndPoint) { }

                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    waiter4SpriteLastPos = track[cpt - 1];
                                }
                            }
                            e = null;
                        }
                        catch (InvalidOperationException ex)
                        {
                            e = ex;
                        }
                    } while (e != null);
                    break;

                case "SS1":
                    do
                    {
                        try
                        {
                            lock (squareSupervisorSprite)
                            {
                                Sprite NewSprite = mySpriteController.DuplicateSprite("Chef de section 1");

                                NewSprite.PutBaseImageLocation(squareSupervisorSpriteLastPos);
                                NewSprite.MovementSpeed = 15;

                                NewSprite.AutomaticallyMoves = true;
                                NewSprite.MoveTo(track);

                                while (!NewSprite.SpriteReachedEndPoint) { }

                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    squareSupervisorSpriteLastPos = track[cpt - 1];
                                }

                            }
                            e = null;
                        }
                        catch (InvalidOperationException ex)
                        {
                            e = ex;
                            Console.WriteLine(e);
                        }
                    } while (e != null);
                    break;

                case "SS2":
                    do
                    {
                        try
                        {
                            lock (squareSupervisor2Sprite)
                            {

                                Sprite NewSprite = mySpriteController.DuplicateSprite("Chef de section 2");

                                NewSprite.PutBaseImageLocation(squareSupervisor2SpriteLastPos);
                                NewSprite.MovementSpeed = 15;

                                NewSprite.AutomaticallyMoves = true;
                                NewSprite.MoveTo(track);
                                while (!NewSprite.SpriteReachedEndPoint) { }

                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    squareSupervisor2SpriteLastPos = track[cpt - 1];
                                };
                            }
                            e = null;
                        }
                        catch (InvalidOperationException ex)
                        {
                            e = ex;
                            Console.WriteLine(e);

                        }
                    } while (e != null);
                    break;
            }
        }

        public void Update(int moneytotal)
        {
            money.Text = moneytotal.ToString();
        }

        private void money_Click(object sender, EventArgs e)
        {
            
        }
    }
}
