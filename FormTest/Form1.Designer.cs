namespace FormTest
{
    partial class Form1
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
            this.Generate = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.ke = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(12, 44);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(100, 23);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Генерация";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(120, -2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(164, 256);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // ke
            // 
            this.ke.Location = new System.Drawing.Point(12, 105);
            this.ke.Name = "ke";
            this.ke.Size = new System.Drawing.Size(100, 20);
            this.ke.TabIndex = 2;
            this.ke.Text = "Ключ";
            this.ke.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ke_MouseClick);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(12, 144);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(102, 23);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Добавление";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 173);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Удаление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Вывод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.ke);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "BSTForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.TextBox ke;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

