using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des carrés 
    /// </summary>
    class Square
    {
        public List<Line> lines { get; set; }
        public List<SquareSupervisor> squareSupervisors { get; set; }

        public int posX;

        public Square(int posX)
        {
            this.posX = posX;
            lines = new List<Line>();
            squareSupervisors = new List<SquareSupervisor>();

            lines.Add(new Line(ConstantPosition.pixelSizeOfBlock * posX, ConstantPosition.pixelSizeOfBlock * 6));
            lines.Add(new Line(ConstantPosition.pixelSizeOfBlock * posX, ConstantPosition.pixelSizeOfBlock * 10));

            if (posX < 36){
                for(int i = 0; i < ConstantGeneral.numberOfSSPerSquare; i++)
                {
                    squareSupervisors.Insert(i, new SquareSupervisor(i, 1));
                }
            }
            else{
                for (int i = 0; i < ConstantGeneral.numberOfSSPerSquare; i++)
                {
                    squareSupervisors.Insert(i, new SquareSupervisor(i, 2));
                }
            }
            
        }
    }
}
