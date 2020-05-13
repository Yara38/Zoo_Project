namespace Zoo_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenSuppliers = new System.Windows.Forms.Button();
            this.buttonOpenProducts = new System.Windows.Forms.Button();
            this.buttonOpenAccountings = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.Color.White;
            this.buttonOpenAgents.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAgents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenAgents.Location = new System.Drawing.Point(17, 197);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(228, 48);
            this.buttonOpenAgents.TabIndex = 4;
            this.buttonOpenAgents.Text = "Сотрудники";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.White;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Location = new System.Drawing.Point(17, 263);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(228, 48);
            this.buttonOpenClients.TabIndex = 3;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenSuppliers
            // 
            this.buttonOpenSuppliers.BackColor = System.Drawing.Color.White;
            this.buttonOpenSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSuppliers.Location = new System.Drawing.Point(17, 330);
            this.buttonOpenSuppliers.Name = "buttonOpenSuppliers";
            this.buttonOpenSuppliers.Size = new System.Drawing.Size(228, 48);
            this.buttonOpenSuppliers.TabIndex = 5;
            this.buttonOpenSuppliers.Text = "Поставщики";
            this.buttonOpenSuppliers.UseVisualStyleBackColor = false;
            this.buttonOpenSuppliers.Click += new System.EventHandler(this.buttonOpenSuppliers_Click);
            // 
            // buttonOpenProducts
            // 
            this.buttonOpenProducts.BackColor = System.Drawing.Color.White;
            this.buttonOpenProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProducts.Location = new System.Drawing.Point(17, 395);
            this.buttonOpenProducts.Name = "buttonOpenProducts";
            this.buttonOpenProducts.Size = new System.Drawing.Size(228, 48);
            this.buttonOpenProducts.TabIndex = 6;
            this.buttonOpenProducts.Text = "Товар";
            this.buttonOpenProducts.UseVisualStyleBackColor = false;
            this.buttonOpenProducts.Click += new System.EventHandler(this.buttonOpenProducts_Click);
            // 
            // buttonOpenAccountings
            // 
            this.buttonOpenAccountings.BackColor = System.Drawing.Color.White;
            this.buttonOpenAccountings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAccountings.Location = new System.Drawing.Point(17, 461);
            this.buttonOpenAccountings.Name = "buttonOpenAccountings";
            this.buttonOpenAccountings.Size = new System.Drawing.Size(228, 48);
            this.buttonOpenAccountings.TabIndex = 7;
            this.buttonOpenAccountings.Text = "Учет товара";
            this.buttonOpenAccountings.UseVisualStyleBackColor = false;
            this.buttonOpenAccountings.Click += new System.EventHandler(this.buttonOpenAccountings_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(14, 20);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(10, 14);
            this.labelHello.TabIndex = 8;
            this.labelHello.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zoo_Project.Properties.Resources._44441;
            this.pictureBox1.Location = new System.Drawing.Point(17, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(261, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenAccountings);
            this.Controls.Add(this.buttonOpenProducts);
            this.Controls.Add(this.buttonOpenSuppliers);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenSuppliers;
        private System.Windows.Forms.Button buttonOpenProducts;
        private System.Windows.Forms.Button buttonOpenAccountings;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

