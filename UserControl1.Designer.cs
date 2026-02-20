namespace pz4
{
    partial class UserControl1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            pictureBoxPhoto = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelRight = new TableLayoutPanel();
            lblCategoryTitle = new Label();
            lblCategory = new Label();
            lblNameTitle = new Label();
            lblName = new Label();
            lblDescriptionTitle = new Label();
            lblDescription = new Label();
            lblManufacturerTitle = new Label();
            lblManufacturer = new Label();
            lblSupplierTitle = new Label();
            lblSupplier = new Label();
            lblPriceTitle = new Label();
            lblPrice = new Label();
            lblUnitTitle = new Label();
            lblUnit = new Label();
            lblStockTitle = new Label();
            lblStock = new Label();
            lblDiscountTitle = new Label();
            lblDiscount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelRight.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Dock = DockStyle.Fill;
            pictureBoxPhoto.Location = new Point(3, 3);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(144, 224);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 10);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(443, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 233);
            panel2.TabIndex = 12;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(pictureBoxPhoto, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelRight, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(443, 233);
            tableLayoutPanelMain.TabIndex = 13;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.ColumnCount = 2;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Controls.Add(lblCategoryTitle, 0, 0);
            tableLayoutPanelRight.Controls.Add(lblCategory, 1, 0);
            tableLayoutPanelRight.Controls.Add(lblNameTitle, 0, 1);
            tableLayoutPanelRight.Controls.Add(lblName, 1, 1);
            tableLayoutPanelRight.Controls.Add(lblDescriptionTitle, 0, 2);
            tableLayoutPanelRight.Controls.Add(lblDescription, 1, 2);
            tableLayoutPanelRight.Controls.Add(lblManufacturerTitle, 0, 3);
            tableLayoutPanelRight.Controls.Add(lblManufacturer, 1, 3);
            tableLayoutPanelRight.Controls.Add(lblSupplierTitle, 0, 4);
            tableLayoutPanelRight.Controls.Add(lblSupplier, 1, 4);
            tableLayoutPanelRight.Controls.Add(lblPriceTitle, 0, 5);
            tableLayoutPanelRight.Controls.Add(lblPrice, 1, 5);
            tableLayoutPanelRight.Controls.Add(lblUnitTitle, 0, 6);
            tableLayoutPanelRight.Controls.Add(lblUnit, 1, 6);
            tableLayoutPanelRight.Controls.Add(lblStockTitle, 0, 7);
            tableLayoutPanelRight.Controls.Add(lblStock, 1, 7);
            tableLayoutPanelRight.Controls.Add(lblDiscountTitle, 0, 8);
            tableLayoutPanelRight.Controls.Add(lblDiscount, 1, 8);
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(153, 3);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 9;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // для описания (можно больше)
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelRight.Size = new Size(287, 227);
            tableLayoutPanelRight.TabIndex = 0;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Dock = DockStyle.Fill;
            lblCategoryTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoryTitle.Location = new Point(3, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(114, 20);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Категория товара:";
            lblCategoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(123, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(161, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "label1";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Dock = DockStyle.Fill;
            lblNameTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNameTitle.Location = new Point(3, 20);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(114, 20);
            lblNameTitle.TabIndex = 2;
            lblNameTitle.Text = "Наименование:";
            lblNameTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(123, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 20);
            lblName.TabIndex = 3;
            lblName.Text = "label2";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Dock = DockStyle.Top;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescriptionTitle.Location = new Point(3, 40);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(114, 15);
            lblDescriptionTitle.TabIndex = 4;
            lblDescriptionTitle.Text = "Описание:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(123, 40);
            lblDescription.MaximumSize = new Size(0, 40);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(161, 40);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "label3";
            // 
            // lblManufacturerTitle
            // 
            lblManufacturerTitle.AutoSize = true;
            lblManufacturerTitle.Dock = DockStyle.Fill;
            lblManufacturerTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblManufacturerTitle.Location = new Point(3, 80);
            lblManufacturerTitle.Name = "lblManufacturerTitle";
            lblManufacturerTitle.Size = new Size(114, 20);
            lblManufacturerTitle.TabIndex = 6;
            lblManufacturerTitle.Text = "Производитель:";
            lblManufacturerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Dock = DockStyle.Fill;
            lblManufacturer.Location = new Point(123, 80);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(161, 20);
            lblManufacturer.TabIndex = 7;
            lblManufacturer.Text = "label4";
            lblManufacturer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSupplierTitle
            // 
            lblSupplierTitle.AutoSize = true;
            lblSupplierTitle.Dock = DockStyle.Fill;
            lblSupplierTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupplierTitle.Location = new Point(3, 100);
            lblSupplierTitle.Name = "lblSupplierTitle";
            lblSupplierTitle.Size = new Size(114, 20);
            lblSupplierTitle.TabIndex = 8;
            lblSupplierTitle.Text = "Поставщик:";
            lblSupplierTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Dock = DockStyle.Fill;
            lblSupplier.Location = new Point(123, 100);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(161, 20);
            lblSupplier.TabIndex = 9;
            lblSupplier.Text = "label5";
            lblSupplier.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPriceTitle
            // 
            lblPriceTitle.AutoSize = true;
            lblPriceTitle.Dock = DockStyle.Fill;
            lblPriceTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriceTitle.Location = new Point(3, 120);
            lblPriceTitle.Name = "lblPriceTitle";
            lblPriceTitle.Size = new Size(114, 20);
            lblPriceTitle.TabIndex = 10;
            lblPriceTitle.Text = "Цена:";
            lblPriceTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(123, 120);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(161, 20);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "label6";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUnitTitle
            // 
            lblUnitTitle.AutoSize = true;
            lblUnitTitle.Dock = DockStyle.Fill;
            lblUnitTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnitTitle.Location = new Point(3, 140);
            lblUnitTitle.Name = "lblUnitTitle";
            lblUnitTitle.Size = new Size(114, 20);
            lblUnitTitle.TabIndex = 12;
            lblUnitTitle.Text = "Ед. измерения:";
            lblUnitTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Dock = DockStyle.Fill;
            lblUnit.Location = new Point(123, 140);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(161, 20);
            lblUnit.TabIndex = 13;
            lblUnit.Text = "label7";
            lblUnit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStockTitle
            // 
            lblStockTitle.AutoSize = true;
            lblStockTitle.Dock = DockStyle.Fill;
            lblStockTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStockTitle.Location = new Point(3, 160);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(114, 20);
            lblStockTitle.TabIndex = 14;
            lblStockTitle.Text = "Кол-во на складе:";
            lblStockTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Location = new Point(123, 160);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(161, 20);
            lblStock.TabIndex = 15;
            lblStock.Text = "label8";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscountTitle
            // 
            lblDiscountTitle.AutoSize = true;
            lblDiscountTitle.Dock = DockStyle.Fill;
            lblDiscountTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiscountTitle.Location = new Point(3, 180);
            lblDiscountTitle.Name = "lblDiscountTitle";
            lblDiscountTitle.Size = new Size(114, 20);
            lblDiscountTitle.TabIndex = 16;
            lblDiscountTitle.Text = "Скидка:";
            lblDiscountTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Dock = DockStyle.Fill;
            lblDiscount.Location = new Point(123, 180);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(161, 20);
            lblDiscount.TabIndex = 17;
            lblDiscount.Text = "label9";
            lblDiscount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(453, 243); // чуть увеличена высота
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelRight.ResumeLayout(false);
            tableLayoutPanelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPhoto;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelRight;
        private Label lblCategoryTitle;
        private Label lblCategory;
        private Label lblNameTitle;
        private Label lblName;
        private Label lblDescriptionTitle;
        private Label lblDescription;
        private Label lblManufacturerTitle;
        private Label lblManufacturer;
        private Label lblSupplierTitle;
        private Label lblSupplier;
        private Label lblPriceTitle;
        private Label lblPrice;
        private Label lblUnitTitle;
        private Label lblUnit;
        private Label lblStockTitle;
        private Label lblStock;
        private Label lblDiscountTitle;
        private Label lblDiscount;
    }
}