namespace pz4
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            номерЗаказаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            артикулЗаказаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            датаЗаказаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            датаДоставкиDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            адресПунктаВыдачиDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            фиоАвторизированногоКлиентаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            кодДляПолученияDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            статусЗаказаDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            ПунктыВыдачиBindingSource = new BindingSource(components);
            Column1 = new DataGridViewComboBoxColumn();
            ЗаказBindingSource = new BindingSource(components);
            bt_Save = new Button();
            bt_Edit = new Button();
            bt_Add = new Button();
            bt_Delete = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userControl11 = new UserControl1();
            _tovarBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ПунктыВыдачиBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ЗаказBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_tovarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { номерЗаказаDataGridViewTextBoxColumn, артикулЗаказаDataGridViewTextBoxColumn, датаЗаказаDataGridViewTextBoxColumn, датаДоставкиDataGridViewTextBoxColumn, адресПунктаВыдачиDataGridViewTextBoxColumn, фиоАвторизированногоКлиентаDataGridViewTextBoxColumn, кодДляПолученияDataGridViewTextBoxColumn, статусЗаказаDataGridViewTextBoxColumn, Column2, Column1 });
            dataGridView1.DataSource = ЗаказBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 244);
            dataGridView1.TabIndex = 0;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "НомерЗаказа";
            номерЗаказаDataGridViewTextBoxColumn.HeaderText = "НомерЗаказа";
            номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            // 
            // артикулЗаказаDataGridViewTextBoxColumn
            // 
            артикулЗаказаDataGridViewTextBoxColumn.DataPropertyName = "АртикулЗаказа";
            артикулЗаказаDataGridViewTextBoxColumn.HeaderText = "АртикулЗаказа";
            артикулЗаказаDataGridViewTextBoxColumn.Name = "артикулЗаказаDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗаказа";
            датаЗаказаDataGridViewTextBoxColumn.HeaderText = "ДатаЗаказа";
            датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // датаДоставкиDataGridViewTextBoxColumn
            // 
            датаДоставкиDataGridViewTextBoxColumn.DataPropertyName = "ДатаДоставки";
            датаДоставкиDataGridViewTextBoxColumn.HeaderText = "ДатаДоставки";
            датаДоставкиDataGridViewTextBoxColumn.Name = "датаДоставкиDataGridViewTextBoxColumn";
            // 
            // адресПунктаВыдачиDataGridViewTextBoxColumn
            // 
            адресПунктаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "АдресПунктаВыдачи";
            адресПунктаВыдачиDataGridViewTextBoxColumn.HeaderText = "АдресПунктаВыдачи";
            адресПунктаВыдачиDataGridViewTextBoxColumn.Name = "адресПунктаВыдачиDataGridViewTextBoxColumn";
            // 
            // фиоАвторизированногоКлиентаDataGridViewTextBoxColumn
            // 
            фиоАвторизированногоКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФиоАвторизированногоКлиента";
            фиоАвторизированногоКлиентаDataGridViewTextBoxColumn.HeaderText = "ФиоАвторизированногоКлиента";
            фиоАвторизированногоКлиентаDataGridViewTextBoxColumn.Name = "фиоАвторизированногоКлиентаDataGridViewTextBoxColumn";
            // 
            // кодДляПолученияDataGridViewTextBoxColumn
            // 
            кодДляПолученияDataGridViewTextBoxColumn.DataPropertyName = "КодДляПолучения";
            кодДляПолученияDataGridViewTextBoxColumn.HeaderText = "КодДляПолучения";
            кодДляПолученияDataGridViewTextBoxColumn.Name = "кодДляПолученияDataGridViewTextBoxColumn";
            // 
            // статусЗаказаDataGridViewTextBoxColumn
            // 
            статусЗаказаDataGridViewTextBoxColumn.DataPropertyName = "СтатусЗаказа";
            статусЗаказаDataGridViewTextBoxColumn.HeaderText = "СтатусЗаказа";
            статусЗаказаDataGridViewTextBoxColumn.Name = "статусЗаказаDataGridViewTextBoxColumn";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "АдресПунктаВыдачи";
            Column2.DataSource = ПунктыВыдачиBindingSource;
            Column2.DisplayMember = "Улица";
            Column2.HeaderText = "Улица";
            Column2.Name = "Column2";
            Column2.ValueMember = "Id";
            // 
            // ПунктыВыдачиBindingSource
            // 
            ПунктыВыдачиBindingSource.DataSource = typeof(Models.ПунктыВыдачиImport);
            // 
            // Column1
            // 
            Column1.DataPropertyName = "АдресПунктаВыдачи";
            Column1.DataSource = ПунктыВыдачиBindingSource;
            Column1.DisplayMember = "Дом";
            Column1.HeaderText = "Дом";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            Column1.ValueMember = "Id";
            // 
            // ЗаказBindingSource
            // 
            ЗаказBindingSource.DataSource = typeof(Models.ЗаказImport);
            // 
            // bt_Save
            // 
            bt_Save.Location = new Point(12, 12);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(75, 23);
            bt_Save.TabIndex = 1;
            bt_Save.Text = "Save";
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // bt_Edit
            // 
            bt_Edit.Location = new Point(174, 12);
            bt_Edit.Name = "bt_Edit";
            bt_Edit.Size = new Size(75, 23);
            bt_Edit.TabIndex = 2;
            bt_Edit.Text = "Edit";
            bt_Edit.UseVisualStyleBackColor = true;
            bt_Edit.Click += bt_Edit_Click;
            // 
            // bt_Add
            // 
            bt_Add.Location = new Point(93, 12);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new Size(75, 23);
            bt_Add.TabIndex = 3;
            bt_Add.Text = "Add";
            bt_Add.UseVisualStyleBackColor = true;
            bt_Add.Click += bt_Add_Click;
            // 
            // bt_Delete
            // 
            bt_Delete.Location = new Point(255, 12);
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Size = new Size(75, 23);
            bt_Delete.TabIndex = 4;
            bt_Delete.Text = "Delete";
            bt_Delete.UseVisualStyleBackColor = true;
            bt_Delete.Click += bt_Delete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(userControl11);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 264);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // userControl11
            // 
            userControl11.AutoSize = true;
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Product = null;
            userControl11.Size = new Size(409, 187);
            userControl11.TabIndex = 0;
            // 
            // _tovarBindingSource
            // 
            _tovarBindingSource.DataSource = typeof(Models.Tovar);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(bt_Delete);
            Controls.Add(bt_Add);
            Controls.Add(bt_Edit);
            Controls.Add(bt_Save);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ПунктыВыдачиBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ЗаказBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_tovarBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewComboBoxColumn Column1;
        private Button bt_Edit;
        private Button bt_Add;
        private Button bt_Delete;
        public BindingSource ЗаказBindingSource;
        public BindingSource ПунктыВыдачиBindingSource;
        private DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn артикулЗаказаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn датаДоставкиDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn адресПунктаВыдачиDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn фиоАвторизированногоКлиентаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn кодДляПолученияDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn статусЗаказаDataGridViewTextBoxColumn;
        public Button bt_Save;
        private FlowLayoutPanel flowLayoutPanel1;
        private BindingSource _tovarBindingSource;
        private UserControl1 userControl11;
    }
}
