using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Taxi
{
    interface IView
    {
        ComboBox DistanceFrom { get; set; }
        ComboBox DistanceTo { get; set; }
        // event DragEventHandler Something;

    }
}
