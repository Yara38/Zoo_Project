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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ShowProduct();
        }
        void ShowProduct()
        {
            {
                listViewProduct.Items.Clear();
                foreach (ProductsSet productsSet in Program.zooDb.ProductsSet)
                {
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                        productsSet.Id.ToString(), productsSet.Name, productsSet.Type.ToString(), productsSet.Price.ToString(),productsSet.Count.ToString()
                        });
                        item.Tag = productsSet;
                        listViewProduct.Items.Add(item);
                    }
                    listViewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    {
                    }
                }
                }
            }

            private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                    textBoxName.Text = productsSet.Name.ToString();
                    textBoxPrice.Text = productsSet.Price.ToString();
                    textBoxCount.Text = productsSet.Count.ToString();
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxPrice.Text = "";
                    textBoxCount.Text = "";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            {
                ProductsSet productsSet = new ProductsSet();
                productsSet.Name = textBoxName.Text;
                productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    productsSet.Type = 0;
                    productsSet.Name = textBoxName.Text;
                    productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    productsSet.Type = 1;
                    productsSet.Name = textBoxName.Text;
                    productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                }
                else
                {
                    productsSet.Type = 2;
                }
                Program.zooDb.ProductsSet.Add(productsSet);
                Program.zooDb.SaveChanges();
                ShowProduct();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                    productsSet.Name = textBoxName.Text;
                    productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                    Program.zooDb.SaveChanges();
                    ShowProduct();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                    productsSet.Name = textBoxName.Text;
                    productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                    Program.zooDb.SaveChanges();
                    ShowProduct();
                }
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                    productsSet.Name = textBoxName.Text;
                    productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                    Program.zooDb.SaveChanges();
                    ShowProduct();
                }  
            }
            else
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                    productsSet.Name = textBoxName.Text;
                    productsSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productsSet.Count = Convert.ToInt32(textBoxCount.Text);
                    Program.zooDb.SaveChanges();
                    ShowProduct();
                }
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (comboBoxType.SelectedIndex == 0)
                    {
                        if (listViewProduct.SelectedItems.Count == 1)
                        {
                            ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                            Program.zooDb.ProductsSet.Remove(productsSet);
                            Program.zooDb.SaveChanges();
                            ShowProduct();
                        }
                        textBoxName.Text = "";
                        textBoxCount.Text = "";
                        textBoxPrice.Text = "";
                    }
                    else if (comboBoxType.SelectedIndex == 1)
                    {
                        if (listViewProduct.SelectedItems.Count == 1)
                        {
                            ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                            Program.zooDb.ProductsSet.Remove(productsSet);
                            Program.zooDb.SaveChanges();
                            ShowProduct();
                        }
                        textBoxName.Text = "";
                        textBoxCount.Text = "";
                        textBoxPrice.Text = "";
                    }
                    else
                    {
                        if (listViewProduct.SelectedItems.Count == 1)
                        {
                            ProductsSet productsSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                            Program.zooDb.ProductsSet.Remove(productsSet);
                            Program.zooDb.SaveChanges();
                            ShowProduct();
                        }
                        textBoxName.Text = "";
                        textBoxCount.Text = "";
                        textBoxPrice.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


