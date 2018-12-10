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
            maitreHotelSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController, 
                Properties.Resources.perso6sprite, 16, 30, 200, 4);
            maitreHotelSprite.SetName("Maître d'hôtel");

            squareSupervisorSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso5sprite, 16, 30, 200, 4);
            squareSupervisorSprite.SetName("Chef de section");

            squareSupervisor2Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso5sprite, 16, 30, 200, 4);
            squareSupervisor2Sprite.SetName("Chef de section 2");

            waiterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 27, 200, 4);
            waiterSprite.SetName("Serveur");

            waiter2Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 27, 200, 4);
            waiter2Sprite.SetName("Serveur");

            waiter3Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 27, 200, 4);
            waiter3Sprite.SetName("Serveur");

            waiter4Sprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 16, 27, 200, 4);
            waiter4Sprite.SetName("Serveur");

            masterChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso1sprite, 16, 30, 200, 4);
            masterChefSprite.SetName("Chef de cuisine");

            sectionChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso11sprite, 16, 28, 500, 3);
            sectionChefSprite.SetName("Chef de section");

            kitchenAssistantSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso11sprite, 16, 28, 200, 3);
            kitchenAssistantSprite.SetName("Commis de cuisine");

            kitchenPorterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso7sprite, 16, 30, 200, 4);
            kitchenPorterSprite.SetName("Plongeur");

            groupClientSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso10sprite, 16, 30, 200, 4);
            groupClientSprite.SetName("Groupe de client");
        }

        public void IdleAnimation(SpriteLibrary.Sprite sprite, int width, int height)
        {
            sprite.AddAnimation(new Point(0, 0), sprite.GetImage(), width, height, 500, 1);
            sprite.ChangeAnimation(1);
        }

        public void UpAnimation(SpriteLibrary.Sprite sprite, int width, int height)
        {

        }

        public void DownAnimation(SpriteLibrary.Sprite sprite, int width, int height)
        {

        }

        public void LeftAnimation(SpriteLibrary.Sprite sprite, int width, int height)
        {

        }

        public void RightAnimation(SpriteLibrary.Sprite sprite, Point point, int width, int height)
        {

        }

    }
}
