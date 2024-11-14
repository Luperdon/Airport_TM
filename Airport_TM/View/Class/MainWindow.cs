using Airport_TM.Presenter;
using Airport_TM.Model;
using Airport_TM.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;

namespace Airport_TM.View.Class
{
    public partial class MainWindow : Form, IView
    {
        public IView _view { get; set; }
        public Chart _chart { get; set; }
        public Button InputButton { set => Controls.Add(value); }
        public RadioButton[] radioButtons { get; set; }
        public TextBox[] getValue { get; set; }
        public string stop { set => StopLabel.Text = value; }
        private MainPresenter _presenter;
        public MainWindow(SaveLoad load)
        {
            InitializeComponent();
            chart1.Series.Add("Количество конвейеров");
            radioButtons = new RadioButton[] { Uniform, Exp };
            getValue = new TextBox[] { WeightOne, WeightTwo, StopWeight, NumberConveyor, NumberBaggageOne, NumberBaggageTwo };
            load.Load(getValue, "C:\\Users\\ilcat\\source\\repos\\Airport_TM\\Airport_TM\\Save\\savethis.json");
            _presenter = new MainPresenter(this, load);
        }

        public event EventHandler Start;
        public event EventHandler Save;
        public event EventHandler Load;

        public void Message(string message)
        {
            SaveWindow messageForm = new SaveWindow(message);
            messageForm.ShowDialog();
        }

        public void ClearPoints()
        {
            chart1.Series["Количество конвейеров"].Points.Clear();
        }
        public void AddPoint(int i, double time)
        {
            chart1.Series["Количество конвейеров"].Points.AddXY(i, time);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Load?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start?.Invoke(this, EventArgs.Empty);
        }
    }
}
