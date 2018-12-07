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
        public ClientGeneratorController clientGeneratorController;
        public ViewController viewController;
        public Form1 form;

        public Controller()
        {
            model = new Model();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1(model);
            Application.Run(form);

            dinnerRoomController = new DinnerRoomController(model, form);
        }
    }

}
