namespace LaboratoryNumber_3WinForms
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
            this.labelInputElement = new System.Windows.Forms.Label();
            this.textBoxInputElement = new System.Windows.Forms.TextBox();
            this.buttonInputElement = new System.Windows.Forms.Button();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cозданиеДереваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаДереваВСоответствииСЗаданиемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрушениеДереваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеДереваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInputElement
            // 
            this.labelInputElement.AutoSize = true;
            this.labelInputElement.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputElement.Location = new System.Drawing.Point(12, 35);
            this.labelInputElement.Name = "labelInputElement";
            this.labelInputElement.Size = new System.Drawing.Size(149, 26);
            this.labelInputElement.TabIndex = 1;
            this.labelInputElement.Text = "Input Element:";
            // 
            // textBoxInputElement
            // 
            this.textBoxInputElement.Location = new System.Drawing.Point(12, 64);
            this.textBoxInputElement.Name = "textBoxInputElement";
            this.textBoxInputElement.Size = new System.Drawing.Size(69, 22);
            this.textBoxInputElement.TabIndex = 2;
            // 
            // buttonInputElement
            // 
            this.buttonInputElement.Location = new System.Drawing.Point(87, 64);
            this.buttonInputElement.Name = "buttonInputElement";
            this.buttonInputElement.Size = new System.Drawing.Size(74, 23);
            this.buttonInputElement.TabIndex = 3;
            this.buttonInputElement.Text = "Add";
            this.buttonInputElement.UseVisualStyleBackColor = true;
            this.buttonInputElement.Click += new System.EventHandler(this.buttonInputElement_Click);
            // 
            // listBoxElements
            // 
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.ItemHeight = 16;
            this.listBoxElements.Location = new System.Drawing.Point(12, 92);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(149, 164);
            this.listBoxElements.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cозданиеДереваToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cозданиеДереваToolStripMenuItem
            // 
            this.cозданиеДереваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеДереваToolStripMenuItem,
            this.обработкаДереваВСоответствииСЗаданиемToolStripMenuItem,
            this.разрушениеДереваToolStripMenuItem});
            this.cозданиеДереваToolStripMenuItem.Name = "cозданиеДереваToolStripMenuItem";
            this.cозданиеДереваToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.cозданиеДереваToolStripMenuItem.Text = "Menu";
            // 
            // обработкаДереваВСоответствииСЗаданиемToolStripMenuItem
            // 
            this.обработкаДереваВСоответствииСЗаданиемToolStripMenuItem.Name = "обработкаДереваВСоответствииСЗаданиемToolStripMenuItem";
            this.обработкаДереваВСоответствииСЗаданиемToolStripMenuItem.Size = new System.Drawing.Size(412, 26);
            this.обработкаДереваВСоответствииСЗаданиемToolStripMenuItem.Text = "Обработка дерева в соответствии с заданием";
            // 
            // разрушениеДереваToolStripMenuItem
            // 
            this.разрушениеДереваToolStripMenuItem.Name = "разрушениеДереваToolStripMenuItem";
            this.разрушениеДереваToolStripMenuItem.Size = new System.Drawing.Size(412, 26);
            this.разрушениеДереваToolStripMenuItem.Text = "Разрушение дерева";
            // 
            // созданиеДереваToolStripMenuItem
            // 
            this.созданиеДереваToolStripMenuItem.Name = "созданиеДереваToolStripMenuItem";
            this.созданиеДереваToolStripMenuItem.Size = new System.Drawing.Size(412, 26);
            this.созданиеДереваToolStripMenuItem.Text = "Создание дерева";
            this.созданиеДереваToolStripMenuItem.Click += new System.EventHandler(this.созданиеДереваToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "KLP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(457, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "LPK";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(457, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "LKP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 277);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxElements);
            this.Controls.Add(this.buttonInputElement);
            this.Controls.Add(this.textBoxInputElement);
            this.Controls.Add(this.labelInputElement);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInputElement;
        public System.Windows.Forms.TextBox textBoxInputElement;
        private System.Windows.Forms.Button buttonInputElement;
        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cозданиеДереваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеДереваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаДереваВСоответствииСЗаданиемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрушениеДереваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

