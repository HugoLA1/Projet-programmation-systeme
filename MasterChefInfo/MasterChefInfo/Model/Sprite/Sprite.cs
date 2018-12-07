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
        SpriteLibrary.Sprite maitreHotelSprite;
        SpriteLibrary.Sprite squareSupervisorSprite;
        SpriteLibrary.Sprite waiterSprite;
        SpriteLibrary.Sprite masterChefSprite;
        SpriteLibrary.Sprite sectionChefSprite;
        SpriteLibrary.Sprite kitchenAssistantSprite;
        SpriteLibrary.Sprite kitchenPorterSprite;
        SpriteLibrary.Sprite groupClientSprite;

        public Sprite(SpriteController mySpriteController)
        {
            maitreHotelSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController, 
                Properties.Resources.perso6sprite, 10, 10, 500, 1);
            maitreHotelSprite.SetName("Maître d'hôtel");

            squareSupervisorSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso5sprite, 10, 10, 500, 1);
            squareSupervisorSprite.SetName("Chef de section");

            waiterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso4sprite, 10, 10, 500, 1);
            waiterSprite.SetName("Serveur");

            masterChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso1sprite, 10, 10, 500, 1);
            masterChefSprite.SetName("Chef de cuisine");

            sectionChefSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.ChefFemale, 10, 10, 500, 1);
            sectionChefSprite.SetName("Chef de section");

            kitchenAssistantSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.ChefMale, 10, 10, 500, 1);
            kitchenAssistantSprite.SetName("Commis de cuisine");

            kitchenPorterSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso7sprite, 10, 10, 500, 1);
            kitchenPorterSprite.SetName("Plongeur");

            groupClientSprite = new SpriteLibrary.Sprite(new Point(0, 0), mySpriteController,
                Properties.Resources.perso10sprite, 10, 10, 500, 1);
            groupClientSprite.SetName("Groupe de client");

        }


    }
}
