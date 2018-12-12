using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    static class ConstantPosition
    {
        public const int pixelSizeOfBlock = 24;

        public const int maitreHotelPosX = pixelSizeOfBlock * 33;
        public const int maitreHotelPosY = pixelSizeOfBlock * 15;

        public const int entryPosX = pixelSizeOfBlock * 34;
        public const int entryPosY = pixelSizeOfBlock * 17;

        public const int initialWaiterPosX = pixelSizeOfBlock * 12;
        public const int initialWaiterPosY = pixelSizeOfBlock * 15;

        public const int initialSquareSupervisor1PosX = pixelSizeOfBlock * 34;
        public const int initialSquareSupervisor1PosY = pixelSizeOfBlock * 2;

        public const int initialSquareSupervisor2PosX = pixelSizeOfBlock * 34;
        public const int initialSquareSupervisor2PosY = pixelSizeOfBlock * 2;

        public const int accessibleCounterDinnerRoomPosX = pixelSizeOfBlock * 12;
        public const int accessibleCounterDinnerRoomPosY = pixelSizeOfBlock * 15;

        public const int masterChefPosX = pixelSizeOfBlock * 4;
        public const int masterChefPosY = pixelSizeOfBlock * 17;

        public const int sectionChefPosX = pixelSizeOfBlock * 6;
        public const int sectionChefPosY = pixelSizeOfBlock * 16;

        public const int accessibleBakeryPosX = pixelSizeOfBlock * 2;
        public const int accessibleBakeryPosY = pixelSizeOfBlock * 15;

        public const int accessibleWorkSurfacePosX = pixelSizeOfBlock * 3;
        public const int accessibleWorkSurfacePosY = pixelSizeOfBlock * 15;

        public const int accessibleCounterKitchenPosX = pixelSizeOfBlock * 10;
        public const int accessibleCounterKitchenPosY = pixelSizeOfBlock * 15;

        public const int startPointLine1PosX = pixelSizeOfBlock * 12;
        public const int startPointLine1PosY = pixelSizeOfBlock * 6;

        public const int startPointLine2PosX = pixelSizeOfBlock * 12;
        public const int startPointLine2PosY = pixelSizeOfBlock * 10;

        public const int startPointLine3PosX = pixelSizeOfBlock * 12;
        public const int startPointLine3PosY = pixelSizeOfBlock * 16;

        public const int kitchenPorterPosX = pixelSizeOfBlock * 3;
        public const int kitchenPorterPosY = pixelSizeOfBlock * 8;

        public const int washingMachinePosX = pixelSizeOfBlock * 1;
        public const int washingMachinePosY = pixelSizeOfBlock * 8;

        public const int initialClientPosX = pixelSizeOfBlock * 35;
        public const int initialClientPosY = pixelSizeOfBlock * 18;


        public static Point maitreHotel = new Point(maitreHotelPosX, maitreHotelPosY);
        public static Point entry = new Point(entryPosX, entryPosY);
        public static Point initialWaiter = new Point(initialWaiterPosX, initialWaiterPosY);
        public static Point initialSquare1Supervisor = new Point(initialSquareSupervisor1PosX, initialSquareSupervisor1PosY);
        public static Point initialSquare2Supervisor = new Point(initialSquareSupervisor2PosX, initialSquareSupervisor2PosY);
        public static Point accessibleCounterDinnerRoom = new Point(accessibleCounterDinnerRoomPosX, accessibleCounterDinnerRoomPosY);
        public static Point masterChef = new Point(masterChefPosX, masterChefPosY);
        public static Point sectionChef = new Point(sectionChefPosX, sectionChefPosY);
        public static Point accessibleBakery = new Point(accessibleBakeryPosX, accessibleBakeryPosY);
        public static Point accessibleWorkSurface = new Point(accessibleWorkSurfacePosX, accessibleWorkSurfacePosY);
        public static Point kitchenPorter = new Point(kitchenPorterPosX, kitchenPorterPosY);
        public static Point accessibleCounterKitchen = new Point(accessibleCounterKitchenPosX, accessibleCounterKitchenPosY);
        public static Point washingMachine = new Point(washingMachinePosX, washingMachinePosY);
        public static Point dishWasher = new Point(kitchenPorterPosX, kitchenPorterPosY);
        public static Point initialClient = new Point(initialClientPosX, initialClientPosY);

        public static Point startPointLine1 = new Point(startPointLine1PosX, startPointLine1PosY);
        public static Point startPointLine2 = new Point(startPointLine2PosX, startPointLine2PosY);
        public static Point startPointLine3 = new Point(startPointLine3PosX, startPointLine3PosY);
    }
}
