using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airport_TM.Model
{
    public class SaveLoad
    {
        public string[] textSave { get; set; } = new string[6];
        public void Save(TextBox[] text, string filepath)
        {
            textSave[0] = text[0].Text;
            textSave[1] = text[1].Text;
            textSave[2] = text[2].Text;
            textSave[3] = text[3].Text;
            textSave[4] = text[4].Text;
            textSave[5] = text[5].Text;
            StreamWriter writer = new StreamWriter(filepath, false);
            string json = JsonConvert.SerializeObject(this);
            writer.WriteAsync(json);
            writer.Dispose();
        }
        public TextBox[] Load(TextBox[] text, string filepath)
        {
            StreamReader reader = new StreamReader(filepath);
            string json = reader.ReadToEnd();
            reader.Dispose();
            SaveLoad tmp = JsonConvert.DeserializeObject<SaveLoad>(json);
            for (int i = 0; i < tmp.textSave.Length; i++)
            {
                text[i].Text = tmp.textSave[i];
            }
            return text;
        }
    }
}