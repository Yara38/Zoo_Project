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
    public partial class FormAccounting : Form
    {
        public FormAccounting()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowProduct();
            ShowSupplier();
            ShowAccounting();
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentSet in Program.zooDb.AgentsSet)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.zooDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
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
        void ShowSupplier()
        {
            comboBoxSupplier.Items.Clear();
            foreach (SuppliersSet suppliersSet in Program.zooDb.SuppliersSet)
            {
                string[] item = { suppliersSet.Id.ToString() + ".", suppliersSet.Name };
                comboBoxSupplier.Items.Add(string.Join(" ", item));
            }
        }
        void ShowAccounting()
        {
            listViewAccounting.Items.Clear();
            foreach (AccountingsSet accountingsSet in Program.zooDb.AccountingsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   accountingsSet.IdAgent.ToString(),
                   accountingsSet.AgentsSet.LastName + " " + accountingsSet.AgentsSet.FirstName + " " + accountingsSet.AgentsSet.MiddleName,
                   accountingsSet.IdClient.ToString(),
                   accountingsSet.ClientsSet.LastName + " " + accountingsSet.ClientsSet.FirstName + " " + accountingsSet.ClientsSet.MiddleName,
                   accountingsSet.IdSupplier.ToString(),
                   accountingsSet.SuppliersSet.Name,
                    accountingsSet.IdProduct.ToString(),
                   accountingsSet.ProductsSet.Name,
                   accountingsSet.Balance.ToString()
                });
                item.Tag = accountingsSet;
                listViewAccounting.Items.Add(item);
            }
            listViewAccounting.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewAccounting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccounting.SelectedItems.Count == 1)
            {
                AccountingsSet accountingsSet = listViewAccounting.SelectedItems[0].Tag as AccountingsSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(accountingsSet.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(accountingsSet.IdClient.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(accountingsSet.IdProduct.ToString());
                comboBoxSupplier.SelectedIndex = comboBoxSupplier.FindString(accountingsSet.IdSupplier.ToString());
                textBoxBalance.Text = accountingsSet.Balance.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxSupplier.SelectedItem = null;
                textBoxBalance.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAccounting.SelectedItems.Count == 1)
            {
                AccountingsSet accountingsSet = listViewAccounting.SelectedItems[0].Tag as AccountingsSet;
                accountingsSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.IdSupplier = Convert.ToInt32(comboBoxSupplier.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.IdProduct = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.Balance = Convert.ToInt32(textBoxBalance.Text);
                Program.zooDb.SaveChanges();
                ShowAccounting();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAccounting.SelectedItems.Count == 1)
                {
                    AccountingsSet accountingsSet = listViewAccounting.SelectedItems[0].Tag as AccountingsSet;
                    Program.zooDb.AccountingsSet.Remove(accountingsSet);
                    Program.zooDb.SaveChanges();
                    ShowAccounting();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxSupplier.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                textBoxBalance.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxType != null && comboBoxSupplier != null)
            {
                AccountingsSet accountingsSet = new AccountingsSet();
                accountingsSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.IdProduct = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.IdSupplier = Convert.ToInt32(comboBoxSupplier.SelectedItem.ToString().Split('.')[0]);
                accountingsSet.Balance = Convert.ToInt32(textBoxBalance.Text);
                Program.zooDb.AccountingsSet.Add(accountingsSet);
                Program.zooDb.SaveChanges();
                ShowAccounting();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
