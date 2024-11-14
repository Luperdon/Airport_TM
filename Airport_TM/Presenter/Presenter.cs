using Airport_TM.Model;
using Airport_TM.View.Class;
using Airport_TM.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Airport_TM.Presenter
{
    public class MainPresenter
    {
        public IView _view { get; set; }
        public Conveyor[] conveyors { get; set; }
        public Queue<Baggage> _baggage { get; set; } = new Queue<Baggage>();
        public TextBox[] values { get; set; }
        public Randoms rand { get; set; }
        public SaveLoad saveLoad { get; set; }
        public MainPresenter(IView view, SaveLoad save)
        {
            saveLoad = save;
            _view = view;
            values = _view.getValue;
            _view.Start += StartButton;
            _view.Save += SaveButton;
            _view.Load += LoadButton;
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            rand = new Randoms(_view.radioButtons);
        }
        private void StartButton(object args, EventArgs e)
        {
            bool isRadioButtonSelected = false;

            foreach (RadioButton radioButton in _view.radioButtons)
            {
                if (radioButton.Checked)
                {
                    isRadioButtonSelected = true;
                    break;
                }
            }

            if (!isRadioButtonSelected)
            {
                MessageBox.Show($"Не выбрано распределение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //_view.Message("Не выбрано распределение.");
            }
            else if (!Check())
            {
                MessageBox.Show($"Данные введены неправильно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //_view.Message("Данные введены неправильно.");
            }
            else
            {
                CreateConveyors();
                CreateBaggageQueue();
                StartChart();
            }
        }
        private void SaveButton(object args, EventArgs e) 
        {
            if (!Check()) 
            {
                MessageBox.Show($"Данные введены неправильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    if (File.Exists(filePath))
                    {
                        DialogResult overwriteResult = MessageBox.Show($"Файл {Path.GetFileName(filePath)} уже существует. Перезаписать?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (overwriteResult != DialogResult.Yes)
                        {
                            _view.Message("Отмена операции!");
                            return;
                        }
                    }
                    saveLoad.Save(values, filePath);
                    _view.Message("Данные сохранены!");
                }
            }
        }
        private void LoadButton(object args, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                saveLoad.Load(values, filePath);
                if (!Check())
                {
                    saveLoad.Load(values, "C:\\Users\\ilcat\\source\\repos\\Airport_TM\\Airport_TM\\Save\\savethis.json");
                    MessageBox.Show($"Данные в загружаемом файле неверны, была загружена стандартная конфигурация!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    _view.Message("Данные загружены!");
            }
        }
        private void StartChart()
        {
            int counter = 0;
            while (_baggage.Count > 0)
            {
                if (conveyors.Length == counter)
                    counter = 0;
                conveyors[counter].Handler(_baggage.Dequeue());
                counter++;
            }
            GraphOutput();
        }
        public void GraphOutput()
        {
            int tmp = 0;
            _view.ClearPoints();
            for (int i = 0; i < conveyors.Length; i++)
            {
                tmp += conveyors[i].number;
                _view.AddPoint(i, conveyors[i].time);
            }
            _view.stop = tmp.ToString();            
        }
        public void CreateBaggageQueue()
        {
            float tmpSize = rand.Random(Convert.ToInt32(values[4].Text), Convert.ToInt32(values[5].Text));
            for (int i = 0; i < tmpSize; i++)
            {
                float tmpWigth = rand.Random(Convert.ToInt32(values[0].Text), Convert.ToInt32(values[1].Text));
                _baggage.Enqueue(new Baggage(i, tmpWigth));
            }
        }
        public void CreateConveyors()
        {
            int tmp = Convert.ToInt32(values[3].Text);
            conveyors = new Conveyor[(int)tmp];
            for (int i = 0; i < tmp; i++)
            {
                conveyors[i] = new Conveyor(rand._rand, Convert.ToInt32(values[2].Text));
            }
        }
        public bool Check()
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (!int.TryParse(values[i].Text, out int result))
                {
                    return false;
                }
            }

            if (int.Parse(values[0].Text) <= 0 || int.Parse(values[0].Text) > int.Parse(values[1].Text) || int.Parse(values[1].Text) > 40)
                return false;
            if (int.Parse(values[2].Text) <= 0 || int.Parse(values[2].Text) > 32)
                return false;
            if (int.Parse(values[3].Text) <= 0 || int.Parse(values[3].Text) > 100)
                return false;
            if (int.Parse(values[4].Text) <= 0 || int.Parse(values[4].Text) > int.Parse(values[5].Text) || int.Parse(values[5].Text) > 1000)
                return false;
            if (int.Parse(values[2].Text) <= 0 || int.Parse(values[2].Text) < int.Parse(values[0].Text))
                return false;
            return true;
        }
    }
}
