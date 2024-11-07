namespace УП_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            deleteBut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addBut = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            changeBut = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            searchBut = new Button();
            textBox5 = new TextBox();
            exitBut = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(542, 384);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += IndexChanged;
            // 
            // deleteBut
            // 
            deleteBut.Location = new Point(133, 409);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(296, 29);
            deleteBut.TabIndex = 1;
            deleteBut.Text = "Удалить контакт";
            deleteBut.UseVisualStyleBackColor = true;
            deleteBut.Click += DeleteContact;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 24);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите имя";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Номер (000)000-00-00";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 3;
            // 
            // addBut
            // 
            addBut.Location = new Point(6, 90);
            addBut.Name = "addBut";
            addBut.Size = new Size(215, 29);
            addBut.TabIndex = 4;
            addBut.Text = "Добавить контакт";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += AddContact;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addBut);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(560, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 135);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(changeBut);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(560, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 135);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Редактирование";
            // 
            // changeBut
            // 
            changeBut.Location = new Point(6, 90);
            changeBut.Name = "changeBut";
            changeBut.Size = new Size(215, 29);
            changeBut.TabIndex = 4;
            changeBut.Text = "Изменить";
            changeBut.UseVisualStyleBackColor = true;
            changeBut.Click += ChangeContact;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 24);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите имя";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 57);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Номер (000)000-00-00";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(searchBut);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Location = new Point(560, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(228, 95);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поиск по имени";
            // 
            // searchBut
            // 
            searchBut.Location = new Point(6, 57);
            searchBut.Name = "searchBut";
            searchBut.Size = new Size(215, 29);
            searchBut.TabIndex = 4;
            searchBut.Text = "Поиск";
            searchBut.UseVisualStyleBackColor = true;
            searchBut.Click += SearchForContact;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 24);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Введите имя";
            textBox5.Size = new Size(215, 27);
            textBox5.TabIndex = 2;
            // 
            // exitBut
            // 
            exitBut.Location = new Point(560, 409);
            exitBut.Name = "exitBut";
            exitBut.Size = new Size(228, 29);
            exitBut.TabIndex = 8;
            exitBut.Text = "Выход";
            exitBut.UseVisualStyleBackColor = true;
            exitBut.Click += Exit;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBut);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(deleteBut);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Записная книга";
            Load += FormLoading;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button deleteBut;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addBut;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button changeBut;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private Button searchBut;
        private TextBox textBox5;
        private Button exitBut;
    }
}
