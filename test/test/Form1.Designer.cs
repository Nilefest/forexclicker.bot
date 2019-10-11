namespace test
{
    partial class Form1
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
            this.b_up = new System.Windows.Forms.Button();
            this.b_down = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_green = new System.Windows.Forms.Panel();
            this.p_red = new System.Windows.Forms.Panel();
            this.p_this = new System.Windows.Forms.Panel();
            this.l_up = new System.Windows.Forms.Label();
            this.l_down = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_up
            // 
            this.b_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_up.Location = new System.Drawing.Point(12, 121);
            this.b_up.Name = "b_up";
            this.b_up.Size = new System.Drawing.Size(82, 61);
            this.b_up.TabIndex = 0;
            this.b_up.Text = "UP";
            this.b_up.UseVisualStyleBackColor = false;
            this.b_up.Click += new System.EventHandler(this.b_up_Click);
            // 
            // b_down
            // 
            this.b_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.b_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_down.Location = new System.Drawing.Point(12, 188);
            this.b_down.Name = "b_down";
            this.b_down.Size = new System.Drawing.Size(82, 61);
            this.b_down.TabIndex = 0;
            this.b_down.Text = "DOWN";
            this.b_down.UseVisualStyleBackColor = false;
            this.b_down.Click += new System.EventHandler(this.b_down_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.p_this);
            this.panel1.Controls.Add(this.p_red);
            this.panel1.Controls.Add(this.p_green);
            this.panel1.Location = new System.Drawing.Point(106, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 237);
            this.panel1.TabIndex = 1;
            // 
            // p_green
            // 
            this.p_green.BackColor = System.Drawing.Color.Lime;
            this.p_green.Location = new System.Drawing.Point(28, 8);
            this.p_green.Name = "p_green";
            this.p_green.Size = new System.Drawing.Size(40, 102);
            this.p_green.TabIndex = 0;
            // 
            // p_red
            // 
            this.p_red.BackColor = System.Drawing.Color.Red;
            this.p_red.Location = new System.Drawing.Point(74, 98);
            this.p_red.Name = "p_red";
            this.p_red.Size = new System.Drawing.Size(40, 102);
            this.p_red.TabIndex = 1;
            // 
            // p_this
            // 
            this.p_this.BackColor = System.Drawing.Color.Silver;
            this.p_this.Location = new System.Drawing.Point(179, 50);
            this.p_this.Name = "p_this";
            this.p_this.Size = new System.Drawing.Size(39, 102);
            this.p_this.TabIndex = 1;
            // 
            // l_up
            // 
            this.l_up.AutoSize = true;
            this.l_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_up.ForeColor = System.Drawing.Color.Green;
            this.l_up.Location = new System.Drawing.Point(12, 38);
            this.l_up.Name = "l_up";
            this.l_up.Size = new System.Drawing.Size(57, 20);
            this.l_up.TabIndex = 0;
            this.l_up.Text = "--------";
            // 
            // l_down
            // 
            this.l_down.AutoSize = true;
            this.l_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_down.ForeColor = System.Drawing.Color.Red;
            this.l_down.Location = new System.Drawing.Point(12, 61);
            this.l_down.Name = "l_down";
            this.l_down.Size = new System.Drawing.Size(57, 20);
            this.l_down.TabIndex = 0;
            this.l_down.Text = "--------";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.l_up);
            this.Controls.Add(this.l_down);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_down);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_up;
        private System.Windows.Forms.Button b_down;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_this;
        private System.Windows.Forms.Panel p_red;
        private System.Windows.Forms.Panel p_green;
        private System.Windows.Forms.Label l_up;
        private System.Windows.Forms.Label l_down;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

