using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_TM.View.Class;
using Airport_TM;
using Airport_TM.Model;
using Airport_TM.Presenter;

namespace Airport_TM
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SaveLoad saveLoad = new SaveLoad();
            MainWindow view = new MainWindow(saveLoad);
            //MainPresenter presenter = new MainPresenter(view, saveLoad);
            Application.Run(view);
        }
    }
}
