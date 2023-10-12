namespace SitemaPagamento.Viewes.Forms
{
    partial class CreateEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserOwner = new System.Windows.Forms.Label();
            this.txtUserOwner = new System.Windows.Forms.TextBox();
            this.lblBeens = new System.Windows.Forms.Label();
            this.txtBeens = new System.Windows.Forms.TextBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.dateEvent = new System.Windows.Forms.DateTimePicker();
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.dataGridSearchClient = new System.Windows.Forms.DataGridView();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchClient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.criarNovoToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // criarNovoToolStripMenuItem
            // 
            this.criarNovoToolStripMenuItem.Name = "criarNovoToolStripMenuItem";
            this.criarNovoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.criarNovoToolStripMenuItem.Text = "Criar Novo";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome do agendamento";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 151);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 167);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(359, 85);
            this.txtDescription.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 401);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoria";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 421);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Data do Agendamento";
            // 
            // lblUserOwner
            // 
            this.lblUserOwner.AutoSize = true;
            this.lblUserOwner.Location = new System.Drawing.Point(388, 41);
            this.lblUserOwner.Name = "lblUserOwner";
            this.lblUserOwner.Size = new System.Drawing.Size(60, 13);
            this.lblUserOwner.TabIndex = 10;
            this.lblUserOwner.Text = "Proprietário";
            // 
            // txtUserOwner
            // 
            this.txtUserOwner.Location = new System.Drawing.Point(391, 60);
            this.txtUserOwner.Name = "txtUserOwner";
            this.txtUserOwner.Size = new System.Drawing.Size(221, 20);
            this.txtUserOwner.TabIndex = 9;
            // 
            // lblBeens
            // 
            this.lblBeens.AutoSize = true;
            this.lblBeens.Location = new System.Drawing.Point(230, 401);
            this.lblBeens.Name = "lblBeens";
            this.lblBeens.Size = new System.Drawing.Size(45, 13);
            this.lblBeens.TabIndex = 12;
            this.lblBeens.Text = "Moedas";
            // 
            // txtBeens
            // 
            this.txtBeens.Location = new System.Drawing.Point(233, 421);
            this.txtBeens.Name = "txtBeens";
            this.txtBeens.Size = new System.Drawing.Size(42, 20);
            this.txtBeens.TabIndex = 11;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(15, 266);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(101, 13);
            this.lblClients.TabIndex = 14;
            this.lblClients.Text = "Quem irá participar?";
            // 
            // txtClients
            // 
            this.txtClients.Location = new System.Drawing.Point(15, 285);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(356, 101);
            this.txtClients.TabIndex = 13;
            // 
            // dateEvent
            // 
            this.dateEvent.Location = new System.Drawing.Point(15, 113);
            this.dateEvent.Name = "dateEvent";
            this.dateEvent.Size = new System.Drawing.Size(359, 20);
            this.dateEvent.TabIndex = 15;
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.dataGridSearchClient);
            this.groupClient.Controls.Add(this.txtSearchClient);
            this.groupClient.Location = new System.Drawing.Point(391, 97);
            this.groupClient.Name = "groupClient";
            this.groupClient.Size = new System.Drawing.Size(227, 317);
            this.groupClient.TabIndex = 16;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Cliente";
            // 
            // dataGridSearchClient
            // 
            this.dataGridSearchClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchClient.Location = new System.Drawing.Point(7, 54);
            this.dataGridSearchClient.Name = "dataGridSearchClient";
            this.dataGridSearchClient.Size = new System.Drawing.Size(214, 313);
            this.dataGridSearchClient.TabIndex = 1;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(7, 18);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(214, 20);
            this.txtSearchClient.TabIndex = 0;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 494);
            this.Controls.Add(this.groupClient);
            this.Controls.Add(this.dateEvent);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.lblBeens);
            this.Controls.Add(this.txtBeens);
            this.Controls.Add(this.lblUserOwner);
            this.Controls.Add(this.txtUserOwner);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateEvent";
            this.Text = "Cadastro de Agendamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupClient.ResumeLayout(false);
            this.groupClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUserOwner;
        private System.Windows.Forms.TextBox txtUserOwner;
        private System.Windows.Forms.Label lblBeens;
        private System.Windows.Forms.TextBox txtBeens;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.DateTimePicker dateEvent;
        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.DataGridView dataGridSearchClient;
        private System.Windows.Forms.TextBox txtSearchClient;
    }
}