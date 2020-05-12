using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_Project
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
            ShowSupplier();
            ShowProduct();
        }
        void ShowSupplier()
        {
            listViewSupplier.Items.Clear();
            foreach (SuppliersSet suppliersSet in Program.zooDb.SuppliersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        suppliersSet.Id.ToString(), suppliersSet.Name, suppliersSet.Phone, suppliersSet.Email, suppliersSet.IdProduct.ToString()
                    });
                item.Tag = suppliersSet;
                listViewSupplier.Items.Add(item);

            }
            listViewSupplier.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowProduct()
        {
            comboBoxType.Items.Clear();
            foreach (ProductsSet productsSet in Program.zooDb.ProductsSet)
            {
                string[] item = { productsSet.Id.ToString() + ".", productsSet.Name };
                comboBoxType.Items.Add(string.Join(" ", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem != null)
            {
                SuppliersSet suppliersSet = new SuppliersSet();
                suppliersSet.IdProduct = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                suppliersSet.Name = textBoxName.Text;
                suppliersSet.Phone = textBoxPhone.Text;
                suppliersSet.Email = textBoxEmail.Text;
                Program.zooDb.SuppliersSet.Add(suppliersSet);
                Program.zooDb.SaveChanges();
                ShowSupplier();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count == 1)
            {
                SuppliersSet suppliersSet = listViewSupplier.SelectedItems[0].Tag as SuppliersSet;
                suppliersSet.IdProduct = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                suppliersSet.Name = textBoxName.Text;
                suppliersSet.Phone = textBoxPhone.Text;
                suppliersSet.Email = textBoxEmail.Text;
                Program.zooDb.SaveChanges();
                ShowSupplier();
            }
        }

        private void listViewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count == 1)
            {
                SuppliersSet suppliersSet = listViewSupplier.SelectedItems[0].Tag as SuppliersSet;
                comboBoxType.SelectedIndex = comboBoxType.FindString(suppliersSet.IdProduct.ToString());
                textBoxName.Text = suppliersSet.Name;
                textBoxPhone.Text = suppliersSet.Phone;
                textBoxEmail.Text = suppliersSet.Email;
            }
            else
            {
                comboBoxType.SelectedItem = null;
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplier.SelectedItems.Count == 1)
                {
                    SuppliersSet suppliersSet = listViewSupplier.SelectedItems[0].Tag as SuppliersSet;
                    Program.zooDb.SuppliersSet.Remove(suppliersSet);
                    Program.zooDb.SaveChanges();
                    ShowSupplier();
                }
                comboBoxType.SelectedItem = null;
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
              
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}