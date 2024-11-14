using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airport_TM.View.Interface
{
    public interface IView
    {
        Chart _chart { get; set; }
        Button InputButton { set; }
        RadioButton[] radioButtons { get; set; }
        TextBox[] getValue { get; set; }
        string stop { set; }
        event EventHandler Start;
        event EventHandler Save;
        event EventHandler Load;

        void ClearPoints();
        void AddPoint(int i, double time);
        void Message(string message);

    }
}
