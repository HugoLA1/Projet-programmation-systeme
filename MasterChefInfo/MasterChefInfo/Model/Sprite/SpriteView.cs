using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SpriteLibrary;

namespace MasterChefInfo
{
    class SpriteView
    {
        public Sprite maitreHotelSprite;
        public Sprite squareSupervisorSprite;
        public Sprite waiterSprite;
        public Sprite masterChefSprite;
        public Sprite sectionChefSprite;
        public Sprite kitchenAssistantSprite;
        public Sprite kitchenPorterSprite;
        public Sprite groupClientSprite;
        public Sprite squareSupervisor2Sprite;
        public Sprite waiter2Sprite;
        public Sprite waiter3Sprite;
        public Sprite waiter4Sprite;

        public SpriteView(SpriteController mySpriteController)
        {
            maitreHotelSprite = new Sprite(new Point(0, 0), mySpriteController, 
                Properties.Resources.perso6sprite, 16, 32, 200, 1);
            maitreHotelSprite.SetName("Maître d'hôtel");
            maitreHotelSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso6sprite, 16, 32, 200, 4);
            maitreHotelSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso6sprite, 16, 32, 200, 4);
            maitreHotelSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso6sprite, 16, 32, 200, 4);
            maitreHotelSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso6sprite, 16, 32, 200, 4);

            squareSupervisorSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso5sprite, 16, 32, 200, 1);
            squareSupervisorSprite.SetName("Chef de section");
            squareSupervisorSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso5sprite, 16, 32, 200, 4);
            squareSupervisorSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso5sprite, 16, 32, 200, 4);
            squareSupervisorSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso5sprite, 16, 32, 200, 4);
            squareSupervisorSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso5sprite, 16, 32, 200, 4);

            squareSupervisor2Sprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso5sprite, 16, 32, 200, 1);
            squareSupervisor2Sprite.SetName("Chef de section 2");
            squareSupervisor2Sprite.AddAnimation(new Point(0, 64), Properties.Resources.perso5sprite, 16, 32, 200, 4);
            squareSupervisor2Sprite.AddAnimation(new Point(0, 0), Properties.Resources.perso5sprite, 16, 32, 200, 4);
            squareSupervisor2Sprite.AddAnimation(new Point(0, 96), Properties.Resources.perso5sprite, 16, 32, 200, 4);
            squareSupervisor2Sprite.AddAnimation(new Point(0, 32), Properties.Resources.perso5sprite, 16, 32, 200, 4);

            waiterSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 32, 200, 1);
            waiterSprite.SetName("Serveur");
            waiterSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiterSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiterSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiterSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso4sprite, 16, 32, 200, 4);

            waiter2Sprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 32, 200, 1);
            waiter2Sprite.SetName("Serveur");
            waiter2Sprite.AddAnimation(new Point(0, 64), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter2Sprite.AddAnimation(new Point(0, 0), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter2Sprite.AddAnimation(new Point(0, 96), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter2Sprite.AddAnimation(new Point(0, 32), Properties.Resources.perso4sprite, 16, 32, 200, 4);

            waiter3Sprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 32, 200, 1);
            waiter3Sprite.SetName("Serveur");
            waiter3Sprite.AddAnimation(new Point(0, 64), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter3Sprite.AddAnimation(new Point(0, 0), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter3Sprite.AddAnimation(new Point(0, 96), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter3Sprite.AddAnimation(new Point(0, 32), Properties.Resources.perso4sprite, 16, 32, 200, 4);

            waiter4Sprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 32, 200, 1);
            waiter4Sprite.SetName("Serveur");
            waiter4Sprite.AddAnimation(new Point(0, 64), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter4Sprite.AddAnimation(new Point(0, 0), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter4Sprite.AddAnimation(new Point(0, 96), Properties.Resources.perso4sprite, 16, 32, 200, 4);
            waiter4Sprite.AddAnimation(new Point(0, 32), Properties.Resources.perso4sprite, 16, 32, 200, 4);

            masterChefSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso1sprite, 16, 32, 200, 1);
            masterChefSprite.SetName("Chef de cuisine");
            masterChefSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso1sprite, 16, 32, 200, 4);
            masterChefSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso1sprite, 16, 32, 200, 4);
            masterChefSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso1sprite, 16, 32, 200, 4);
            masterChefSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso1sprite, 16, 32, 200, 4);

            sectionChefSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso11sprite, 16, 32, 200, 1);
            sectionChefSprite.SetName("Chef de section");
            sectionChefSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso11sprite, 16, 32, 200, 4);
            sectionChefSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso11sprite, 16, 32, 200, 4);
            sectionChefSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso11sprite, 16, 32, 200, 4);
            sectionChefSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso11sprite, 16, 32, 200, 4);

            kitchenAssistantSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso11sprite, 16, 32, 200, 1);
            kitchenAssistantSprite.SetName("Commis de cuisine");
            kitchenAssistantSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso11sprite, 16, 32, 200, 4);
            kitchenAssistantSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso11sprite, 16, 32, 200, 4);
            kitchenAssistantSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso11sprite, 16, 32, 200, 4);
            kitchenAssistantSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso11sprite, 16, 32, 200, 4);

            kitchenPorterSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso7sprite, 16, 32, 200, 1);
            kitchenPorterSprite.SetName("Plongeur");
            kitchenPorterSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso7sprite, 16, 32, 200, 4);
            kitchenPorterSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso7sprite, 16, 32, 200, 4);
            kitchenPorterSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso7sprite, 16, 32, 200, 4);
            kitchenPorterSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso7sprite, 16, 32, 200, 4);

            groupClientSprite = new Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso10sprite, 16, 32, 200, 1);
            groupClientSprite.SetName("Groupe de client");
            groupClientSprite.AddAnimation(new Point(0, 64), Properties.Resources.perso10sprite, 16, 32, 200, 4);
            groupClientSprite.AddAnimation(new Point(0, 0), Properties.Resources.perso10sprite, 16, 32, 200, 4);
            groupClientSprite.AddAnimation(new Point(0, 96), Properties.Resources.perso10sprite, 16, 32, 200, 4);
            groupClientSprite.AddAnimation(new Point(0, 32), Properties.Resources.perso10sprite, 16, 32, 200, 4);
        }

        //public void IdleAnimation(Sprite sprite, int width, int height)
        //{
        //    sprite.AddAnimation(new Point(0, 0), sprite.GetImage(), width, height, 500, 1);
        //    sprite.ChangeAnimation(1);
        //}

        //public void UpAnimation(Sprite sprite, int width, int height)
        //{
        //    sprite.AddAnimation(new Point(0, 64), sprite.GetImage(), width, height, 500, 4);
        //    sprite.ChangeAnimation(2);
        //}

        //public void DownAnimation(Sprite sprite, int width, int height)
        //{
        //    sprite.AddAnimation(new Point(0, 0), sprite.GetImage(), width, height, 500, 4);
        //    sprite.ChangeAnimation(3);
        //}

        //public void LeftAnimation(Sprite sprite, int width, int height)
        //{
        //    sprite.AddAnimation(new Point(0, 96), sprite.GetImage(), width, height, 500, 4);
        //    sprite.ChangeAnimation(4);
        //}

        //public void RightAnimation(Sprite sprite, Point point, int width, int height)
        //{
        //    sprite.AddAnimation(new Point(0, 32), sprite.GetImage(), width, height, 500, 4);
        //    sprite.ChangeAnimation(5);
        //}

    }
}
