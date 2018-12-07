using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SpriteLibrary;

namespace MasterChefInfo
{
    class Sprite
    {
        public SpriteLibrary.Sprite maitreHotelSprite;
        public SpriteLibrary.Sprite squareSupervisorSprite;
        public SpriteLibrary.Sprite waiterSprite;
        public SpriteLibrary.Sprite masterChefSprite;
        public SpriteLibrary.Sprite sectionChefSprite;
        public SpriteLibrary.Sprite kitchenAssistantSprite;
        public SpriteLibrary.Sprite kitchenPorterSprite;
        public SpriteLibrary.Sprite groupClientSprite;

        public Sprite(SpriteController mySpriteController)
        {
            maitreHotelSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController, 
                Properties.Resources.perso6sprite, 15, 32, 200, 4);
            maitreHotelSprite.SetName("Maître d'hôtel");

            squareSupervisorSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso5sprite, 15, 32, 200, 4);
            squareSupervisorSprite.SetName("Chef de section");

            waiterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 15, 32, 200, 4);
            waiterSprite.SetName("Serveur");

            masterChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso1sprite, 15, 32, 200, 4);
            masterChefSprite.SetName("Chef de cuisine");

            sectionChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.ChefFemale, 50, 50, 200, 3);
            sectionChefSprite.SetName("Chef de section");

            kitchenAssistantSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.ChefMale, 50, 50, 200, 3);
            kitchenAssistantSprite.SetName("Commis de cuisine");

            kitchenPorterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso7sprite, 15, 32, 200, 4);
            kitchenPorterSprite.SetName("Plongeur");

            groupClientSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso10sprite, 15, 32, 200, 4);
            groupClientSprite.SetName("Groupe de client");

        }


    }
}
