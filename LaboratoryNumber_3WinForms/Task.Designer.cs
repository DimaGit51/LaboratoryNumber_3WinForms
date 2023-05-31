namespace LaboratoryNumber_3WinForms
{
    partial class Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(12, 18);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(182, 26);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Введите число N:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(211, 22);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 1;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(317, 21);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(244, 27);
            this.buttonN.TabIndex = 2;
            this.buttonN.Text = "Подсчитать кол-во узлов";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 228);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Узел > N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Остальные узлы";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(170, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 228);
            this.listBox2.TabIndex = 5;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Name = "Task";
            this.Text = "Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
    }
}