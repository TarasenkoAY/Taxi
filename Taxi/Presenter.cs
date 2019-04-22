using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    
    class Presenter
    {
        Model model = null;
        IView mainWindow = null;
        public Presenter(IView mainWindow)
        {

            List<string> cities = new List<string>();
            cities.Add("Kyiv");
            cities.Add("Fastiv");
            cities.Add("Poltava");
            cities.Add("Lviv");

            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.DistanceFrom.ItemsSource = cities;
            this.mainWindow.DistanceTo.ItemsSource = cities;

        }
    }
}
