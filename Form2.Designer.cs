namespace pz4
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            ПунктыВыдачиBindingSource = new BindingSource(components);
            ЗаказBindingSource = new BindingSource(components);
            bt_Save = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox11 = new TextBox();
            label12 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            textBox13 = new TextBox();
            label14 = new Label();
            textBox14 = new TextBox();
            label15 = new Label();
            textBox15 = new TextBox();
            label16 = new Label();
            textBox16 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ПунктыВыдачиBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ЗаказBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "НомерЗаказа", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "НомерЗаказа", true));
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // ПунктыВыдачиBindingSource
            // 
            ПунктыВыдачиBindingSource.DataSource = typeof(Models.ПунктыВыдачиImport);
            // 
            // ЗаказBindingSource
            // 
            ЗаказBindingSource.DataSource = typeof(Models.ЗаказImport);
            // 
            // bt_Save
            // 
            bt_Save.Location = new Point(12, 415);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(75, 23);
            bt_Save.TabIndex = 1;
            bt_Save.Text = "Save";
            bt_Save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Номер Заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Артикул";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "АртикулЗаказа", true));
            textBox2.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "АртикулЗаказа", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "Дата Доставки";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "ДатаДоставки", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "ДатаДоставки", true));
            textBox3.Location = new Point(12, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Дата Заказа";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "ДатаЗаказа", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "ДатаЗаказа", true));
            textBox4.Location = new Point(12, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 12;
            label5.Text = "ФИО";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "ФиоАвторизированногоКлиента", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "ФиоАвторизированногоКлиента", true));
            textBox5.Location = new Point(12, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 185);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 10;
            label6.Text = "Адрес";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "АдресПунктаВыдачи", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox6.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "АдресПунктаВыдачи", true));
            textBox6.Location = new Point(12, 203);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 317);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 16;
            label7.Text = "Статус заказа";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "СтатусЗаказа", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox7.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "СтатусЗаказа", true));
            textBox7.Location = new Point(12, 335);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 273);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 14;
            label8.Text = "Код для получения";
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", ЗаказBindingSource, "КодДляПолучения", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox8.DataBindings.Add(new Binding("DataContext", ЗаказBindingSource, "КодДляПолучения", true));
            textBox8.Location = new Point(12, 291);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(155, 317);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 32;
            label9.Text = "Статус заказа";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(155, 335);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(155, 273);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 30;
            label10.Text = "Код для получения";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(155, 291);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(155, 229);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 28;
            label11.Text = "ФИО";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(155, 247);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(155, 185);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 26;
            label12.Text = "Адрес";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(155, 203);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(155, 141);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 24;
            label13.Text = "Дата Доставки";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(155, 159);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(155, 97);
            label14.Name = "label14";
            label14.Size = new Size(71, 15);
            label14.TabIndex = 22;
            label14.Text = "Дата Заказа";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(155, 115);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(155, 53);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 20;
            label15.Text = "Дом";
            // 
            // textBox15
            // 
            textBox15.DataBindings.Add(new Binding("Text", ПунктыВыдачиBindingSource, "Дом", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox15.Location = new Point(155, 71);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(100, 23);
            textBox15.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(155, 9);
            label16.Name = "label16";
            label16.Size = new Size(41, 15);
            label16.TabIndex = 18;
            label16.Text = "Улица";
            // 
            // textBox16
            // 
            textBox16.DataBindings.Add(new Binding("Text", ПунктыВыдачиBindingSource, "Улица", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox16.Location = new Point(155, 27);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(100, 23);
            textBox16.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(textBox11);
            Controls.Add(label12);
            Controls.Add(textBox12);
            Controls.Add(label13);
            Controls.Add(textBox13);
            Controls.Add(label14);
            Controls.Add(textBox14);
            Controls.Add(label15);
            Controls.Add(textBox15);
            Controls.Add(label16);
            Controls.Add(textBox16);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(bt_Save);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)ПунктыВыдачиBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ЗаказBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        public BindingSource ПунктыВыдачиBindingSource;
        public BindingSource ЗаказBindingSource;
        public Button bt_Save;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
        private TextBox textBox13;
        private Label label14;
        private TextBox textBox14;
        private Label label15;
        private TextBox textBox15;
        private Label label16;
        private TextBox textBox16;
    }
}