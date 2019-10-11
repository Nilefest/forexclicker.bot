namespace ForexClicker
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_setting = new System.Windows.Forms.Panel();
            this.gb_setwork = new System.Windows.Forms.GroupBox();
            this.l_lasttime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.gb_setmore = new System.Windows.Forms.GroupBox();
            this.b_loadset = new System.Windows.Forms.Button();
            this.b_saveset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.b_viewset = new System.Windows.Forms.Button();
            this.gb_setgpos = new System.Windows.Forms.GroupBox();
            this.l_posg2 = new System.Windows.Forms.Label();
            this.b_posg2 = new System.Windows.Forms.Button();
            this.l_posg1 = new System.Windows.Forms.Label();
            this.b_posg1 = new System.Windows.Forms.Button();
            this.gb_setgcol = new System.Windows.Forms.GroupBox();
            this.l_colgdown = new System.Windows.Forms.Label();
            this.b_colgdown = new System.Windows.Forms.Button();
            this.l_colgup = new System.Windows.Forms.Label();
            this.b_colgup = new System.Windows.Forms.Button();
            this.gb_setperiod = new System.Windows.Forms.GroupBox();
            this.cb_typep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.num_p = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_setbpos = new System.Windows.Forms.GroupBox();
            this.l_bdown = new System.Windows.Forms.Label();
            this.b_posbdown = new System.Windows.Forms.Button();
            this.l_bup = new System.Windows.Forms.Label();
            this.b_posbup = new System.Windows.Forms.Button();
            this.timer_bot = new System.Windows.Forms.Timer(this.components);
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.p_setting.SuspendLayout();
            this.gb_setwork.SuspendLayout();
            this.gb_setmore.SuspendLayout();
            this.gb_setgpos.SuspendLayout();
            this.gb_setgcol.SuspendLayout();
            this.gb_setperiod.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_p)).BeginInit();
            this.gb_setbpos.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_setting
            // 
            this.p_setting.BackColor = System.Drawing.Color.White;
            this.p_setting.Controls.Add(this.gb_setwork);
            this.p_setting.Controls.Add(this.gb_setmore);
            this.p_setting.Controls.Add(this.gb_setgpos);
            this.p_setting.Controls.Add(this.gb_setgcol);
            this.p_setting.Controls.Add(this.gb_setperiod);
            this.p_setting.Controls.Add(this.gb_setbpos);
            this.p_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_setting.Location = new System.Drawing.Point(0, 0);
            this.p_setting.Name = "p_setting";
            this.p_setting.Size = new System.Drawing.Size(522, 354);
            this.p_setting.TabIndex = 0;
            // 
            // gb_setwork
            // 
            this.gb_setwork.BackColor = System.Drawing.Color.White;
            this.gb_setwork.Controls.Add(this.l_lasttime);
            this.gb_setwork.Controls.Add(this.label5);
            this.gb_setwork.Controls.Add(this.b_stop);
            this.gb_setwork.Controls.Add(this.b_start);
            this.gb_setwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_setwork.Location = new System.Drawing.Point(264, 242);
            this.gb_setwork.Name = "gb_setwork";
            this.gb_setwork.Size = new System.Drawing.Size(246, 104);
            this.gb_setwork.TabIndex = 3;
            this.gb_setwork.TabStop = false;
            this.gb_setwork.Text = "Работа";
            // 
            // l_lasttime
            // 
            this.l_lasttime.BackColor = System.Drawing.Color.White;
            this.l_lasttime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_lasttime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_lasttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_lasttime.Location = new System.Drawing.Point(124, 62);
            this.l_lasttime.Name = "l_lasttime";
            this.l_lasttime.Size = new System.Drawing.Size(119, 39);
            this.l_lasttime.TabIndex = 4;
            this.l_lasttime.Text = "--";
            this.l_lasttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Следующее срабатывание через:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_stop
            // 
            this.b_stop.BackColor = System.Drawing.Color.DarkGray;
            this.b_stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_stop.ForeColor = System.Drawing.Color.Maroon;
            this.b_stop.Location = new System.Drawing.Point(3, 39);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(240, 23);
            this.b_stop.TabIndex = 2;
            this.b_stop.Text = "Стоп";
            this.b_stop.UseVisualStyleBackColor = false;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_start.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_start.ForeColor = System.Drawing.Color.Green;
            this.b_start.Location = new System.Drawing.Point(3, 16);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(240, 23);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "Старт";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // gb_setmore
            // 
            this.gb_setmore.BackColor = System.Drawing.Color.White;
            this.gb_setmore.Controls.Add(this.b_loadset);
            this.gb_setmore.Controls.Add(this.b_saveset);
            this.gb_setmore.Controls.Add(this.label6);
            this.gb_setmore.Controls.Add(this.b_viewset);
            this.gb_setmore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_setmore.Location = new System.Drawing.Point(12, 242);
            this.gb_setmore.Name = "gb_setmore";
            this.gb_setmore.Size = new System.Drawing.Size(246, 104);
            this.gb_setmore.TabIndex = 2;
            this.gb_setmore.TabStop = false;
            this.gb_setmore.Text = "Дополнительно";
            // 
            // b_loadset
            // 
            this.b_loadset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_loadset.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_loadset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_loadset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_loadset.Location = new System.Drawing.Point(3, 79);
            this.b_loadset.Name = "b_loadset";
            this.b_loadset.Size = new System.Drawing.Size(240, 23);
            this.b_loadset.TabIndex = 11;
            this.b_loadset.Text = "Загрузить параметры";
            this.b_loadset.UseVisualStyleBackColor = false;
            this.b_loadset.Click += new System.EventHandler(this.b_loadset_Click);
            // 
            // b_saveset
            // 
            this.b_saveset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_saveset.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_saveset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_saveset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_saveset.Location = new System.Drawing.Point(3, 56);
            this.b_saveset.Name = "b_saveset";
            this.b_saveset.Size = new System.Drawing.Size(240, 23);
            this.b_saveset.TabIndex = 10;
            this.b_saveset.Text = "Сохранить параметры";
            this.b_saveset.UseVisualStyleBackColor = false;
            this.b_saveset.Click += new System.EventHandler(this.b_saveset_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Чтобы вернуться, кликните по экрану";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_viewset
            // 
            this.b_viewset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_viewset.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_viewset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_viewset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_viewset.Location = new System.Drawing.Point(3, 16);
            this.b_viewset.Name = "b_viewset";
            this.b_viewset.Size = new System.Drawing.Size(240, 23);
            this.b_viewset.TabIndex = 4;
            this.b_viewset.Text = "Показать все параметры на экране";
            this.b_viewset.UseVisualStyleBackColor = false;
            this.b_viewset.Click += new System.EventHandler(this.b_viewset_Click);
            // 
            // gb_setgpos
            // 
            this.gb_setgpos.BackColor = System.Drawing.Color.White;
            this.gb_setgpos.Controls.Add(this.l_posg2);
            this.gb_setgpos.Controls.Add(this.b_posg2);
            this.gb_setgpos.Controls.Add(this.l_posg1);
            this.gb_setgpos.Controls.Add(this.b_posg1);
            this.gb_setgpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_setgpos.Location = new System.Drawing.Point(264, 12);
            this.gb_setgpos.Name = "gb_setgpos";
            this.gb_setgpos.Size = new System.Drawing.Size(246, 104);
            this.gb_setgpos.TabIndex = 1;
            this.gb_setgpos.TabStop = false;
            this.gb_setgpos.Text = "Область графика";
            // 
            // l_posg2
            // 
            this.l_posg2.BackColor = System.Drawing.Color.White;
            this.l_posg2.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_posg2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_posg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_posg2.Location = new System.Drawing.Point(3, 82);
            this.l_posg2.Name = "l_posg2";
            this.l_posg2.Size = new System.Drawing.Size(240, 20);
            this.l_posg2.TabIndex = 7;
            this.l_posg2.Text = "{0;0}";
            this.l_posg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_posg2
            // 
            this.b_posg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_posg2.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_posg2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_posg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_posg2.Location = new System.Drawing.Point(3, 59);
            this.b_posg2.Name = "b_posg2";
            this.b_posg2.Size = new System.Drawing.Size(240, 23);
            this.b_posg2.TabIndex = 6;
            this.b_posg2.Text = "Нижний правый угол";
            this.b_posg2.UseVisualStyleBackColor = false;
            this.b_posg2.Click += new System.EventHandler(this.b_posg2_Click);
            // 
            // l_posg1
            // 
            this.l_posg1.BackColor = System.Drawing.Color.White;
            this.l_posg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_posg1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_posg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_posg1.Location = new System.Drawing.Point(3, 39);
            this.l_posg1.Name = "l_posg1";
            this.l_posg1.Size = new System.Drawing.Size(240, 20);
            this.l_posg1.TabIndex = 5;
            this.l_posg1.Text = "{0;0}";
            this.l_posg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_posg1
            // 
            this.b_posg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_posg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_posg1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_posg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_posg1.Location = new System.Drawing.Point(3, 16);
            this.b_posg1.Name = "b_posg1";
            this.b_posg1.Size = new System.Drawing.Size(240, 23);
            this.b_posg1.TabIndex = 4;
            this.b_posg1.Text = "Верхний левый угол";
            this.b_posg1.UseVisualStyleBackColor = false;
            this.b_posg1.Click += new System.EventHandler(this.b_posg1_Click);
            // 
            // gb_setgcol
            // 
            this.gb_setgcol.BackColor = System.Drawing.Color.White;
            this.gb_setgcol.Controls.Add(this.l_colgdown);
            this.gb_setgcol.Controls.Add(this.b_colgdown);
            this.gb_setgcol.Controls.Add(this.l_colgup);
            this.gb_setgcol.Controls.Add(this.b_colgup);
            this.gb_setgcol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_setgcol.Location = new System.Drawing.Point(12, 12);
            this.gb_setgcol.Name = "gb_setgcol";
            this.gb_setgcol.Size = new System.Drawing.Size(246, 104);
            this.gb_setgcol.TabIndex = 0;
            this.gb_setgcol.TabStop = false;
            this.gb_setgcol.Text = "Цвета графиков";
            // 
            // l_colgdown
            // 
            this.l_colgdown.BackColor = System.Drawing.Color.Red;
            this.l_colgdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_colgdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_colgdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_colgdown.Location = new System.Drawing.Point(3, 82);
            this.l_colgdown.Name = "l_colgdown";
            this.l_colgdown.Size = new System.Drawing.Size(240, 20);
            this.l_colgdown.TabIndex = 3;
            this.l_colgdown.Text = "{0;0;0}";
            this.l_colgdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_colgdown
            // 
            this.b_colgdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b_colgdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_colgdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_colgdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_colgdown.Location = new System.Drawing.Point(3, 59);
            this.b_colgdown.Name = "b_colgdown";
            this.b_colgdown.Size = new System.Drawing.Size(240, 23);
            this.b_colgdown.TabIndex = 2;
            this.b_colgdown.Text = "Выбрать цвет понижения";
            this.b_colgdown.UseVisualStyleBackColor = false;
            this.b_colgdown.Click += new System.EventHandler(this.b_colgdown_Click);
            // 
            // l_colgup
            // 
            this.l_colgup.BackColor = System.Drawing.Color.Lime;
            this.l_colgup.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_colgup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_colgup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_colgup.Location = new System.Drawing.Point(3, 39);
            this.l_colgup.Name = "l_colgup";
            this.l_colgup.Size = new System.Drawing.Size(240, 20);
            this.l_colgup.TabIndex = 1;
            this.l_colgup.Text = "{0;0;0}";
            this.l_colgup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_colgup
            // 
            this.b_colgup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_colgup.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_colgup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_colgup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_colgup.Location = new System.Drawing.Point(3, 16);
            this.b_colgup.Name = "b_colgup";
            this.b_colgup.Size = new System.Drawing.Size(240, 23);
            this.b_colgup.TabIndex = 0;
            this.b_colgup.Text = "Выбрать цвет повышения";
            this.b_colgup.UseVisualStyleBackColor = false;
            this.b_colgup.Click += new System.EventHandler(this.b_colgup_Click);
            // 
            // gb_setperiod
            // 
            this.gb_setperiod.BackColor = System.Drawing.Color.White;
            this.gb_setperiod.Controls.Add(this.cb_typep);
            this.gb_setperiod.Controls.Add(this.label4);
            this.gb_setperiod.Controls.Add(this.panel1);
            this.gb_setperiod.Controls.Add(this.label1);
            this.gb_setperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_setperiod.Location = new System.Drawing.Point(264, 134);
            this.gb_setperiod.Name = "gb_setperiod";
            this.gb_setperiod.Size = new System.Drawing.Size(246, 102);
            this.gb_setperiod.TabIndex = 0;
            this.gb_setperiod.TabStop = false;
            this.gb_setperiod.Text = "График работы";
            // 
            // cb_typep
            // 
            this.cb_typep.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_typep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_typep.FormattingEnabled = true;
            this.cb_typep.Items.AddRange(new object[] {
            "В начале следующей минуты",
            "В начале следующего часа",
            "С момента старта"});
            this.cb_typep.Location = new System.Drawing.Point(3, 79);
            this.cb_typep.Name = "cb_typep";
            this.cb_typep.Size = new System.Drawing.Size(240, 21);
            this.cb_typep.TabIndex = 8;
            this.cb_typep.SelectedIndexChanged += new System.EventHandler(this.cb_typep_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начинать работу:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_p);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 23);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(101, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "минут";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_p
            // 
            this.num_p.AutoSize = true;
            this.num_p.Dock = System.Windows.Forms.DockStyle.Left;
            this.num_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_p.Location = new System.Drawing.Point(48, 0);
            this.num_p.Maximum = new decimal(new int[] {
            10080,
            0,
            0,
            0});
            this.num_p.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_p.Name = "num_p";
            this.num_p.Size = new System.Drawing.Size(53, 20);
            this.num_p.TabIndex = 4;
            this.num_p.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_p.ValueChanged += new System.EventHandler(this.num_p_ValueChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Каждые";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Период срадатывания (в конце периода):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_setbpos
            // 
            this.gb_setbpos.BackColor = System.Drawing.Color.White;
            this.gb_setbpos.Controls.Add(this.l_bdown);
            this.gb_setbpos.Controls.Add(this.b_posbdown);
            this.gb_setbpos.Controls.Add(this.l_bup);
            this.gb_setbpos.Controls.Add(this.b_posbup);
            this.gb_setbpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_setbpos.Location = new System.Drawing.Point(12, 134);
            this.gb_setbpos.Name = "gb_setbpos";
            this.gb_setbpos.Size = new System.Drawing.Size(246, 104);
            this.gb_setbpos.TabIndex = 0;
            this.gb_setbpos.TabStop = false;
            this.gb_setbpos.Text = "Кнопки \"Повышения\" и \"Понижения\"";
            // 
            // l_bdown
            // 
            this.l_bdown.BackColor = System.Drawing.Color.White;
            this.l_bdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_bdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_bdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_bdown.Location = new System.Drawing.Point(3, 82);
            this.l_bdown.Name = "l_bdown";
            this.l_bdown.Size = new System.Drawing.Size(240, 20);
            this.l_bdown.TabIndex = 3;
            this.l_bdown.Text = "{0;0}";
            this.l_bdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_posbdown
            // 
            this.b_posbdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b_posbdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_posbdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_posbdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_posbdown.Location = new System.Drawing.Point(3, 59);
            this.b_posbdown.Name = "b_posbdown";
            this.b_posbdown.Size = new System.Drawing.Size(240, 23);
            this.b_posbdown.TabIndex = 2;
            this.b_posbdown.Text = "Выбрать кнопку понижения";
            this.b_posbdown.UseVisualStyleBackColor = false;
            this.b_posbdown.Click += new System.EventHandler(this.b_posbdown_Click);
            // 
            // l_bup
            // 
            this.l_bup.BackColor = System.Drawing.Color.White;
            this.l_bup.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_bup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_bup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_bup.Location = new System.Drawing.Point(3, 39);
            this.l_bup.Name = "l_bup";
            this.l_bup.Size = new System.Drawing.Size(240, 20);
            this.l_bup.TabIndex = 1;
            this.l_bup.Text = "{0;0}";
            this.l_bup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_posbup
            // 
            this.b_posbup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_posbup.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_posbup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_posbup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_posbup.Location = new System.Drawing.Point(3, 16);
            this.b_posbup.Name = "b_posbup";
            this.b_posbup.Size = new System.Drawing.Size(240, 23);
            this.b_posbup.TabIndex = 0;
            this.b_posbup.Text = "Выбрать кнопку повышения";
            this.b_posbup.UseVisualStyleBackColor = false;
            this.b_posbup.Click += new System.EventHandler(this.b_posbup_Click);
            // 
            // timer_bot
            // 
            this.timer_bot.Interval = 1000;
            this.timer_bot.Tick += new System.EventHandler(this.timer_bot_Tick);
            // 
            // sfd
            // 
            this.sfd.Filter = "XML Files (*.xml)|*.xml";
            this.sfd.Title = "Сохранить файл настроек";
            // 
            // ofd
            // 
            this.ofd.FileName = "forexclicker_setting";
            this.ofd.Filter = "XML Files (*.xml)|*.xml";
            this.ofd.Title = "Сохранить файл настроек";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.Controls.Add(this.p_setting);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "ForexClicker";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            this.p_setting.ResumeLayout(false);
            this.gb_setwork.ResumeLayout(false);
            this.gb_setmore.ResumeLayout(false);
            this.gb_setgpos.ResumeLayout(false);
            this.gb_setgcol.ResumeLayout(false);
            this.gb_setperiod.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_p)).EndInit();
            this.gb_setbpos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_setting;
        private System.Windows.Forms.GroupBox gb_setwork;
        private System.Windows.Forms.Label l_lasttime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.GroupBox gb_setmore;
        private System.Windows.Forms.Button b_loadset;
        private System.Windows.Forms.Button b_saveset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_viewset;
        private System.Windows.Forms.GroupBox gb_setgpos;
        private System.Windows.Forms.Label l_posg2;
        private System.Windows.Forms.Button b_posg2;
        private System.Windows.Forms.Label l_posg1;
        private System.Windows.Forms.Button b_posg1;
        private System.Windows.Forms.GroupBox gb_setgcol;
        private System.Windows.Forms.Label l_colgdown;
        private System.Windows.Forms.Button b_colgdown;
        private System.Windows.Forms.Label l_colgup;
        private System.Windows.Forms.Button b_colgup;
        private System.Windows.Forms.GroupBox gb_setperiod;
        private System.Windows.Forms.ComboBox cb_typep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_setbpos;
        private System.Windows.Forms.Label l_bdown;
        private System.Windows.Forms.Button b_posbdown;
        private System.Windows.Forms.Label l_bup;
        private System.Windows.Forms.Button b_posbup;
        private System.Windows.Forms.Timer timer_bot;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

