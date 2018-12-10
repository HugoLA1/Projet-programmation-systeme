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

        public Sprite waiterSprite;
        public Point waiter1SpriteLastPos;
        public Sprite waiter2Sprite;
        public Point waiter2SpriteLastPos;
        public Sprite waiter3Sprite;
        public Point waiter3SpriteLastPos;
        public Sprite waiter4Sprite;
        public Point waiter4SpriteLastPos;

        public Sprite squareSupervisor1Sprite;
        public Point squareSupervisor1SpriteLastPos;
        public Sprite squareSupervisor2Sprite;
        public Point squareSupervisor2SpriteLastPos;

        public Sprite sectionChef1Sprite;
        public Point sectionChef1SpriteLastPos;
        public Sprite sectionChef2Sprite;
        public Point sectionChef2SpriteLastPos;

        public Sprite maitreHotelSprite;
        public Sprite masterChefSprite;

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

            Image MH = Properties.Resources.perso6sprite;

            Image MC = Properties.Resources.perso1sprite;

            Image SS1 = Properties.Resources.perso5sprite;
            Image SS2 = Properties.Resources.perso5sprite;

            Image W1 = Properties.Resources.perso4sprite;
            Image W2 = Properties.Resources.perso4sprite;
            Image W3 = Properties.Resources.perso4sprite;
            Image W4 = Properties.Resources.perso4sprite;

            Image SC1 = Properties.Resources.perso11sprite;
            Image SC2 = Properties.Resources.perso11sprite;

            squareSupervisor1SpriteLastPos = ConstantPosition.initialSquare1Supervisor;
            squareSupervisor2SpriteLastPos = ConstantPosition.initialSquare2Supervisor;

            waiter1SpriteLastPos = ConstantPosition.initialWaiter;
            waiter2SpriteLastPos = ConstantPosition.initialWaiter;
            waiter3SpriteLastPos = ConstantPosition.initialWaiter;
            waiter4SpriteLastPos = ConstantPosition.initialWaiter;

            sectionChef1SpriteLastPos = ConstantPosition.sectionChef;
            sectionChef2SpriteLastPos = ConstantPosition.sectionChef;

            maitreHotelSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                MH, 16, 32, 200, 4);
            maitreHotelSprite.SetName("Maître d'hôtel");

            squareSupervisor1Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                SS1, 16, 32, 200, 4);
            squareSupervisor1Sprite.SetName("Chef de rang 1");

            squareSupervisor2Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                SS2, 16, 32, 200, 4);
            squareSupervisor2Sprite.SetName("Chef de rang 2");

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

            masterChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                MC, 16, 32, 200, 4);
            masterChefSprite.SetName("Chef de cuisine");

            sectionChef1Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                SC1, 16, 32, 500, 3);
            sectionChef1Sprite.SetName("Chef de section 1");

            sectionChef2Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                SC2, 16, 32, 500, 3);
            sectionChef2Sprite.SetName("Chef de section 2");

            // Maitre d'hôtel
            maitreHotelSprite.CannotMoveOutsideBox = true;
            maitreHotelSprite.SetSpriteDirectionDegrees(180);
            maitreHotelSprite.PutBaseImageLocation(ConstantPosition.maitreHotel);
            maitreHotelSprite.SetSize(new Size(16, 32));
            maitreHotelSprite.MovementSpeed = 2;

            // Le superviseur de carré 1
            squareSupervisor1Sprite.CannotMoveOutsideBox = true;
            squareSupervisor1Sprite.SetSpriteDirectionDegrees(-90);
            squareSupervisor1Sprite.PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
            squareSupervisor1Sprite.SetSize(new Size(16, 32));
            squareSupervisor1Sprite.MovementSpeed = 15;

            // Le superviseur de carré 2
            squareSupervisor2Sprite.CannotMoveOutsideBox = true;
            squareSupervisor2Sprite.SetSpriteDirectionDegrees(-90);
            squareSupervisor2Sprite.PutBaseImageLocation(ConstantPosition.initialSquare1Supervisor);
            squareSupervisor2Sprite.SetSize(new Size(16, 32));
            squareSupervisor2Sprite.MovementSpeed = 15;

            //Serveur 1
            waiterSprite.CannotMoveOutsideBox = true;
            waiterSprite.SetSpriteDirectionDegrees(-90);
            waiterSprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            waiterSprite.SetSize(new Size(16, 32));
            waiterSprite.MovementSpeed = 15;

            //Serveur 2
            waiter2Sprite.CannotMoveOutsideBox = true;
            waiter2Sprite.SetSpriteDirectionDegrees(-90);
            waiter2Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            waiter2Sprite.SetSize(new Size(16, 32));
            waiter2Sprite.MovementSpeed = 15;

            //Serveur 3
            waiter3Sprite.CannotMoveOutsideBox = true;
            waiter3Sprite.SetSpriteDirectionDegrees(-90);
            waiter3Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            waiter3Sprite.SetSize(new Size(16, 32));
            waiter3Sprite.MovementSpeed = 15;

            //Serveur 4
            waiter4Sprite.CannotMoveOutsideBox = true;
            waiter4Sprite.SetSpriteDirectionDegrees(-90);
            waiter4Sprite.PutBaseImageLocation(ConstantPosition.initialWaiter);
            waiter4Sprite.SetSize(new Size(16, 32));
            waiter4Sprite.MovementSpeed = 15;

            //Chef de section 1
            sectionChef1Sprite.CannotMoveOutsideBox = true;
            sectionChef1Sprite.SetSpriteDirectionDegrees(-90);
            sectionChef1Sprite.PutBaseImageLocation(ConstantPosition.sectionChef);
            sectionChef1Sprite.SetSize(new Size(16, 32));
            sectionChef1Sprite.MovementSpeed = 15;

            //Chef de section 2
            sectionChef2Sprite.CannotMoveOutsideBox = true;
            sectionChef2Sprite.SetSpriteDirectionDegrees(-90);
            sectionChef2Sprite.PutBaseImageLocation(ConstantPosition.sectionChef);
            sectionChef2Sprite.SetSize(new Size(16, 32));
            sectionChef2Sprite.MovementSpeed = 15;

            
            //Chef de la cuisine
            masterChefSprite.CannotMoveOutsideBox = true;
            masterChefSprite.SetSpriteDirectionDegrees(-90);
            masterChefSprite.PutBaseImageLocation(ConstantPosition.masterChef);
            masterChefSprite.MoveTo(ConstantPosition.masterChef);
            masterChefSprite.SetSize(new Size(16, 32));
            masterChefSprite.MovementSpeed = 5;

            /*
            //Plogneur
            //sprite.kitchenPorterSprite.AutomaticallyMoves = true;
            kitchenPorterSprite.CannotMoveOutsideBox = true;
            kitchenPorterSprite.SetSpriteDirectionDegrees(-90);
            kitchenPorterSprite.PutBaseImageLocation(ConstantPosition.kitchenPorter);
            //sprite.kitchenPorterSprite.MoveTo(ConstantPosition.kitchenPorter);
            kitchenPorterSprite.SetSize(new Size(16, 32));
            kitchenPorterSprite.MovementSpeed = 5;
            //sprite.IdleAnimation(sprite.kitchenPorterSprite, 16, 32);

            //// Le commis
            //sprite.kitchenAssistantSprite.AutomaticallyMoves = true;
            //sprite.kitchenAssistantSprite.CannotMoveOutsideBox = true;
            //sprite.kitchenAssistantSprite.SetSpriteDirectionDegrees(-90);
            //sprite.kitchenAssistantSprite.PutBaseImageLocation(ConstantPosition.commis);
            //sprite.kitchenAssistantSprite.SetSize(new Size(16, 32));
            //sprite.kitchenAssistantSprite.MovementSpeed = 2;
            //sprite.IdleAnimation(sprite.kitchenAssistantSprite, 16, 32);

            
            */

            SS1.Dispose();
            SS2.Dispose();
            W1.Dispose();
            W2.Dispose();
            W3.Dispose();
            W4.Dispose();
            SC1.Dispose();
            SC2.Dispose();
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
            Sprite NewSprite;

            switch (name)
            {

                case "Waiter1":

                    NewSprite = mySpriteController.DuplicateSprite("Serveur 1");

                    NewSprite.PutBaseImageLocation(waiter1SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);
                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                        {
                            try
                            {
                            lock (waiterSprite)
                            {
                                
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
                    NewSprite = mySpriteController.DuplicateSprite("Serveur 2");
                    NewSprite.PutBaseImageLocation(waiter2SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);
                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (waiter2Sprite)
                            {
                                
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
                    NewSprite = mySpriteController.DuplicateSprite("Serveur 3");
                    NewSprite.PutBaseImageLocation(waiter3SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);
                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (waiter3Sprite)
                            {
                                
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
                    NewSprite = mySpriteController.DuplicateSprite("Serveur 4");

                    NewSprite.PutBaseImageLocation(waiter4SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);
                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (waiter4Sprite)
                            {
                                
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

                case "KitchenPorter":
                    NewSprite = mySpriteController.DuplicateSprite("Serveur 4");

                    NewSprite.PutBaseImageLocation(waiter4SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);
                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (waiter4Sprite)
                            {

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
                    NewSprite = mySpriteController.DuplicateSprite("Chef de rang 1");

                    NewSprite.PutBaseImageLocation(squareSupervisor1SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);

                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (squareSupervisor1Sprite)
                            {
                                
                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    squareSupervisor1SpriteLastPos = track[cpt - 1];
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
                    NewSprite = mySpriteController.DuplicateSprite("Chef de rang 2");

                    NewSprite.PutBaseImageLocation(squareSupervisor2SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);
                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (squareSupervisor2Sprite)
                            {

                                
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

                case "SC1":
                    NewSprite = mySpriteController.DuplicateSprite("Chef de section 1");

                    NewSprite.PutBaseImageLocation(sectionChef1SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);

                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (sectionChef1Sprite)
                            {
                                
                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    sectionChef1SpriteLastPos = track[cpt - 1];
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

                case "SC2":
                    NewSprite = mySpriteController.DuplicateSprite("Chef de section 2");

                    NewSprite.PutBaseImageLocation(sectionChef2SpriteLastPos);
                    NewSprite.MovementSpeed = 15;

                    NewSprite.AutomaticallyMoves = true;
                    NewSprite.MoveTo(track);

                    while (!NewSprite.SpriteReachedEndPoint) { }

                    Thread.Sleep(1000);
                    do
                    {
                        try
                        {
                            lock (sectionChef2Sprite)
                            {
                                
                                NewSprite.Destroy();
                                NewSprite = null;
                                if (track.Count > 0)
                                {
                                    int cpt = track.Count;
                                    sectionChef2SpriteLastPos = track[cpt - 1];
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
