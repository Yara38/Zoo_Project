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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Здравствуй, " + FormAuthorization.users.login + "!";
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenSuppliers_Click(object sender, EventArgs e)
        {
            Form formSuppliers = new FormSupplier();
            formSuppliers.Show();
        }

        private void buttonOpenProducts_Click(object sender, EventArgs e)
        {
            Form formProducts = new FormProduct();
            formProducts.Show();
        }

        private void buttonOpenAccountings_Click(object sender, EventArgs e)
        {
            Form formAccountings = new FormAccounting();
            formAccountings.Show();
        }
    }
}
