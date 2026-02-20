using System;
using System.IO;
using System.Windows.Forms;
using pz4.Models;
using pz4.Properties;

namespace pz4
{
    public partial class UserControl1 : UserControl
    {
        private Tovar _product;

        public Tovar Product
        {
            get => _product;
            set
            {
                _product = value;
                UpdateUI();
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            if (_product == null) return;

            lblCategory.Text = _product.КатегорияТовара ?? "";
            lblName.Text = _product.НаименованиеТовара ?? "";
            lblDescription.Text = _product.ОписаниеТовара ?? "";
            lblManufacturer.Text = _product.Производитель ?? "";
            lblSupplier.Text = _product.Поставщик ?? "";
            lblPrice.Text = _product.Цена?.ToString("C") ?? "0";
            lblUnit.Text = _product.ЕдиницаИзмерения ?? "";
            lblStock.Text = _product.КолВоНаСкладе?.ToString() ?? "0";
            lblDiscount.Text = _product.ДействующаяСкидка?.ToString() + "%";

            Image newImage = null;
            if (_product.Фото != null && _product.Фото.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(_product.Фото))
                    {
                        newImage = Image.FromStream(ms);
                    }
                }
                catch
                {
                    newImage = null;
                }
            }

            if (pictureBoxPhoto.Image != null)
            {
                pictureBoxPhoto.Image.Dispose();
                pictureBoxPhoto.Image = null;
            }

            if (newImage != null)
            {
                pictureBoxPhoto.Image = newImage;
            }
            else
            {
                pictureBoxPhoto.Image = Properties.Resources.no_image;
            }
        }

        public event EventHandler AddToCartClicked;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, e);
        }
    }
}