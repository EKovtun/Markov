namespace Markov
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Number1 = new System.Windows.Forms.Label();
            this.End1 = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Out1 = new System.Windows.Forms.TextBox();
            this.In1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InputWord = new System.Windows.Forms.RichTextBox();
            this.box1 = new System.Windows.Forms.GroupBox();
            this.MainConsole = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подстановки";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Начать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.Number1);
            this.panel.Controls.Add(this.End1);
            this.panel.Controls.Add(this.Label1);
            this.panel.Controls.Add(this.Out1);
            this.panel.Controls.Add(this.In1);
            this.panel.Location = new System.Drawing.Point(7, 19);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(463, 371);
            this.panel.TabIndex = 0;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(4, 5);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(28, 13);
            this.Number1.TabIndex = 4;
            this.Number1.Text = "1:";
            // 
            // End1
            // 
            this.End1.AutoSize = true;
            this.End1.Location = new System.Drawing.Point(397, 6);
            this.End1.Name = "End1";
            this.End1.Size = new System.Drawing.Size(48, 17);
            this.End1.TabIndex = 3;
            this.End1.Text = "Final";
            this.End1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(204, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(19, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "→";
            // 
            // Out1
            // 
            this.Out1.Location = new System.Drawing.Point(241, 3);
            this.Out1.Name = "Out1";
            this.Out1.Size = new System.Drawing.Size(150, 20);
            this.Out1.TabIndex = 1;
            this.Out1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // In1
            // 
            this.In1.Location = new System.Drawing.Point(38, 3);
            this.In1.Name = "In1";
            this.In1.Size = new System.Drawing.Size(150, 20);
            this.In1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InputWord);
            this.groupBox2.Location = new System.Drawing.Point(494, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Входное слово";
            // 
            // InputWord
            // 
            this.InputWord.BackColor = System.Drawing.SystemColors.Window;
            this.InputWord.Location = new System.Drawing.Point(6, 15);
            this.InputWord.Name = "InputWord";
            this.InputWord.Size = new System.Drawing.Size(328, 113);
            this.InputWord.TabIndex = 0;
            this.InputWord.Text = "";
            // 
            // box1
            // 
            this.box1.Controls.Add(this.MainConsole);
            this.box1.Location = new System.Drawing.Point(494, 154);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(340, 284);
            this.box1.TabIndex = 2;
            this.box1.TabStop = false;
            this.box1.Text = "Консоль";
            // 
            // MainConsole
            // 
            this.MainConsole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainConsole.Location = new System.Drawing.Point(7, 20);
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.ReadOnly = true;
            this.MainConsole.Size = new System.Drawing.Size(327, 229);
            this.MainConsole.TabIndex = 0;
            this.MainConsole.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Алгорифмы Маркова";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.box1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Out1;
        private System.Windows.Forms.TextBox In1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox InputWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox End1;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.RichTextBox MainConsole;
    }
}

