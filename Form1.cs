using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using pz4.Models;

namespace pz4
{
    public partial class Form1 : Form
    {
        Ispr2525AvetisyanAaLazarev1Context context;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new Ispr2525AvetisyanAaLazarev1Context();
            context.ЗаказImports.Include(x => x.АдресПунктаВыдачиNavigation).Load();
            context.ПунктыВыдачиImports.Load();
            context.Database.EnsureCreated();
            ЗаказBindingSource.DataSource = context.ЗаказImports.Local.ToBindingList();
            ПунктыВыдачиBindingSource.DataSource = context.ПунктыВыдачиImports.Local.ToBindingList();

            context.Tovars.Load();
            _tovarBindingSource = new BindingSource
            {
                DataSource = context.Tovars.Local.ToBindingList()
            };
            PopulateCards();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ЗаказBindingSource.EndEdit();
            }
            catch(ValidationException error)
            {
                MessageBox.Show(error.Message);
                ЗаказBindingSource.CancelEdit();
            }
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ПунктыВыдачиBindingSource.DataSource = ПунктыВыдачиBindingSource.DataSource;
            form.ЗаказBindingSource.DataSource = ЗаказBindingSource.Current;
            form.bt_Save.Click += bt_Save_Click;
            form.Show();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ПунктыВыдачиBindingSource.DataSource = ПунктыВыдачиBindingSource.DataSource;
            form.ЗаказBindingSource.DataSource = ЗаказBindingSource.AddNew();
            form.bt_Save.Click += (o, e) =>
            {
                try
                {
                    ЗаказBindingSource.EndEdit();
                }
                catch (ValidationException error)
                {
                    MessageBox.Show(error.Message);
                }
            };
            form.Show();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            ЗаказBindingSource.RemoveCurrent();
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void PopulateCards()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Tovar product in _tovarBindingSource.List)
            {
                var card = new UserControl1
                {
                    Product = product,
                    Margin = new Padding(5),
                    Width = flowLayoutPanel1.Width - 25 // с учётом скролла
                };
                card.AddToCartClicked += (s, e) =>
                {
                    // Логика добавления в корзину
                    MessageBox.Show($"Товар '{product.НаименованиеТовара}' добавлен в корзину");
                };
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
