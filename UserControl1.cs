using pz4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Заполнение полей
            lblCategory.Text = _product.КатегорияТовара;
            lblName.Text = _product.НаименованиеТовара;
            lblDescription.Text = _product.ОписаниеТовара;
            lblManufacturer.Text = _product.Производитель;
            lblSupplier.Text = _product.Поставщик;
            lblPrice.Text = _product.Цена?.ToString("C") ?? "0";
            lblUnit.Text = _product.ЕдиницаИзмерения;
            lblStock.Text = _product.КолВоНаСкладе?.ToString() ?? "0";
            lblDiscount.Text = _product.ДействующаяСкидка?.ToString() + "%";

            // Загрузка фото (предполагается, что поле Фото содержит путь к файлу)
            if (!string.IsNullOrEmpty(_product.Фото))
            {
                try
                {
                    pictureBoxPhoto.ImageLocation = _product.Фото;
                }
                catch
                {
                    pictureBoxPhoto.Image = null; // или заглушка
                }
            }
        }

        // Событие для кнопки "В корзину"
        public event EventHandler AddToCartClicked;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, e);
        }
    }
}
