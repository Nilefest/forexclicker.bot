using System;
using System.Drawing;
using System.Xml.Serialization;

namespace ForexClicker
{
    [Serializable]
    public class SettingClass
    {
        // Color Up / Down
        Color col_up = Color.White;
        Color col_down = Color.White;

        // Positions Graph
        public Point gpos1 = new Point(0, 0);
        public Point gpos2 = new Point(0, 0);

        // Positions Buttons Up / Down
        public Point bup = new Point(0, 0);
        public Point bdown = new Point(0, 0);

        // Time work
        public int period_min = 1;
        public int type_period = 0;


        [XmlIgnore]
        public Color colup { get { return col_up; } set { col_up = value; } }
        [XmlIgnore]
        public Color coldown { get { return col_down; } set { col_down = value; } }

        [XmlElement("colup")]
        public int Сol_up
        {
            get { return col_up.ToArgb(); }
            set { col_up = Color.FromArgb(value); }
        }

        [XmlElement("coldown")]
        public int Col_down
        {
            get { return col_down.ToArgb(); }
            set { col_down = Color.FromArgb(value); }
        }
        public override string ToString()
        {
            string setting = "";
            setting += "Color UP: " + col_up + "\n";
            setting += "Color DOWN: " + col_up + "\n\n";
            setting += "Position Button UP: " + bup + "\n";
            setting += "Position Button DOWN: " + bdown + "\n\n";
            setting += "Graph ang. 1: " + gpos1 + "\n";
            setting += "Graph ang. 2: " + gpos2 + "\n\n";
            setting += "Period by min.: " + period_min + "\n";
            setting += "Period type: " + type_period + "\n\n";
            return setting;
        }
    }
}
