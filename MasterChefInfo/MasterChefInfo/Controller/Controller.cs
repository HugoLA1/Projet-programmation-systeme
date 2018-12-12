using MasterChefInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du controlleur
    /// </summary>
    class Controller
    {
        public Model model;
        public DinnerRoomController dinnerRoomController;
        public Form1 form;

        public Controller()
        {
            model = new Model();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new Form1(model);

            dinnerRoomController = new DinnerRoomController(model, form);

            SetObserver();

            Application.Run(form);
        }

        public void SetObserver()
        {
            foreach (Waiter waiter in model.dinnerRoom.waiters)
            {
                waiter.RegisterObserver(form);
            }

            foreach (Square square in model.dinnerRoom.squares)
            {
                foreach( SquareSupervisor squareSupervisor in square.squareSupervisors)
                {
                    squareSupervisor.RegisterObserver(form);
                }
            }

            foreach (SectionChef sectionChef in model.kitchen.cookingRoom.masterChef.sectionChefs)
            {
                sectionChef.RegisterObserver(form);
            }

            model.dinnerRoom.maitreHotel.RegisterObserver(form);
        }
    }

}
