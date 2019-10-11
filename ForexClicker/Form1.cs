using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using System.Media;

namespace ForexClicker
{
    public partial class FormMain : Form
    {
        #region Vars
        // Cursor point
        Point p_loc = new Point(0, 0);
        Point p_screen = new Point(0, 0);

        SettingClass set = new SettingClass();

        int last_sec = 0;
        bool is_open_set = false;
        settingType set_type;
        
        enum settingType
        {
            colgup, colgdown, posg1, posg2, posbup, posbdown, setview
        };
        #endregion

        public FormMain()
        {
            InitializeComponent();
            cb_typep.SelectedIndex = 0;
            SettingRefresh();
        }
        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            // Get positions
            p_loc = e.Location;
            p_screen = Cursor.Position;

            // Setting
            SettingNew();
            SettingWinToggle();
        }

        #region Save / Load
        private void b_saveset_Click(object sender, EventArgs e)
        {
            saveSetting();
        }
        private void b_loadset_Click(object sender, EventArgs e)
        {
            openSetting();
        }
        #endregion

        #region Setting Graph
        // Color Up / Down
        private void b_colgup_Click(object sender, EventArgs e)
        {
            set_type = settingType.colgup;
            SettingWinToggle();
        }
        private void b_colgdown_Click(object sender, EventArgs e)
        {
            set_type = settingType.colgdown;
            SettingWinToggle();
        }

        // Position Graph
        private void b_posg1_Click(object sender, EventArgs e)
        {
            set_type = settingType.posg1;
            SettingWinToggle();
        }
        private void b_posg2_Click(object sender, EventArgs e)
        {
            set_type = settingType.posg2;
            SettingWinToggle();
        }
        #endregion
        #region Position buttons
        private void b_posbup_Click(object sender, EventArgs e)
        {
            set_type = settingType.posbup;
            SettingWinToggle();
        }
        private void b_posbdown_Click(object sender, EventArgs e)
        {
            set_type = settingType.posbdown;
            SettingWinToggle();
        }
        #endregion
        #region View setting
        private void b_viewset_Click(object sender, EventArgs e)
        {
            set_type = settingType.setview;
            SettingWinToggle();
        }
        #endregion
        #region Bot working
        private void b_start_Click(object sender, EventArgs e)
        {
            timer_bot.Start();
        }
        private void b_stop_Click(object sender, EventArgs e)
        {
            timer_bot.Stop();
        }
        private void timer_bot_Tick(object sender, EventArgs e)
        {
            if (last_sec == 1)
            {
                botWorking();
                SystemSounds.Beep.Play();
            }
            if (last_sec <= 0)
            {
                last_sec = set.period_min * 60;
                last_sec = 10;
                l_lasttime.BackColor = Color.White;
            }
            if(last_sec < 6)
            {
                l_lasttime.BackColor = Color.Green;
            }
            l_lasttime.Text = last_sec.ToString();
            last_sec--;
        }
        private void botWorking()
        {
        }
        #endregion
        #region Setting Timer
        private void num_p_ValueChanged(object sender, EventArgs e)
        {
            set.period_min = (int)num_p.Value;
        }
        private void cb_typep_SelectedIndexChanged(object sender, EventArgs e)
        {
            set.type_period = cb_typep.SelectedIndex;
        }
        #endregion

        #region Setting ALL
        private void SettingWinToggle()
        {
            if (is_open_set)
            {
                p_setting.Dock = DockStyle.Fill;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Opacity = 1;
            }
            else
            {
                this.Opacity = 0.7;
                p_setting.Dock = DockStyle.None;
                p_setting.Width = 5;
                p_setting.Location = new Point(-25, 0);
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            is_open_set = !is_open_set;
        }
        private void SettingNew()
        {
            if (is_open_set)
            {
                switch (set_type)
                {
                    case settingType.colgup:
                        this.Opacity = 0;
                        set.colup = getPixelColorScreen(p_loc);
                        break;
                    case settingType.colgdown:
                        this.Opacity = 0;
                        set.coldown = getPixelColorScreen(p_loc);
                        break;
                    case settingType.posg1:
                        set.gpos1 = p_screen;
                        break;
                    case settingType.posg2:
                        set.gpos2 = p_screen;
                        break;
                    case settingType.posbup:
                        set.bup = p_screen;
                        break;
                    case settingType.posbdown:
                        set.bdown = p_screen;
                        break;
                    case settingType.setview:
                        SettingView();
                        MessageBox.Show(set.ToString());
                        break;
                    default: MessageBox.Show("Не получилось. Попробуйте снова"); break;
                }
                SettingRefresh();
            }
        }
        private void saveSetting() {
            sfd.FileName = "forexclicker_setting" + DateTime.Now.ToShortDateString();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingClass));
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                    serializer.Serialize(fs, set);
            }
        }
        private void openSetting()
        {
            ofd.FileName = "forexclicker_setting";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingClass));
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    set = (SettingClass)serializer.Deserialize(fs);
                    SettingRefresh();
                }
            }
        }
        private void SettingRefresh()
        {

            // Data refresh
            l_bdown.Text = set.bdown.ToString();
            l_bup.Text = set.bup.ToString();
            l_colgdown.Text = set.coldown.ToString();
            l_colgup.Text = set.colup.ToString();

            l_colgdown.BackColor = set.coldown;
            l_colgup.BackColor = set.colup;


            l_posg1.Text = set.gpos1.ToString();
            l_posg2.Text = set.gpos2.ToString();
            num_p.Value = set.period_min;
            cb_typep.SelectedIndex = set.type_period;
        }
        private void SettingView()
        {
            Graphics g = this.CreateGraphics();

            // Graph
            g.FillRectangle(Brushes.Blue, new RectangleF(set.gpos1.X, set.gpos1.Y, (set.gpos2.X - set.gpos1.X), (set.gpos2.Y - set.gpos1.Y)));

            // Buttons
            g.FillEllipse(Brushes.Green, new RectangleF(new Point(set.bup.X - 5, set.bup.Y - 5), new Size(10, 10)));
            g.FillEllipse(Brushes.Red, new RectangleF(new Point(set.bdown.X - 5, set.bdown.Y - 5), new Size(10, 10)));
            
        }
        #endregion

        #region Color pixel : Color getPixelColorScreen(Point)
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int x, int y);
        private Color getPixelColorScreen(Point p)
        {
            IntPtr hDC = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hDC, p.X, p.Y);
            ReleaseDC(IntPtr.Zero, hDC);

            byte r = (byte)(pixel & 0x000000FF);
            byte g = (byte)((pixel & 0x0000FF00) >> 8);
            byte b = (byte)((pixel & 0x00FF0000) >> 16);

            return Color.FromArgb(r, g, b);
        }
        #endregion
        #region Screen Click : void MakeClick(int x, int y)
        [DllImport("User32.dll")]
        static extern void mouse_event(MouseFlags dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);
        [Flags]
        enum MouseFlags
        {
            Move = 0x0001, LeftDown = 0x0002, LeftUp = 0x0004, RightDown = 0x0008,
            RightUp = 0x0010, Absolute = 0x8000
        };
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public void MakeClick(int x, int y)
        {
            SetCursorPos(x, y);
            Thread.Sleep(100);

            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        #endregion


    }
}
