namespace SistemasVendas
{
    partial class frmAdminPainel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFooter = new Panel();
            label1 = new Label();
            menTop = new MenuStrip();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            inventárioToolStripMenuItem = new ToolStripMenuItem();
            transaçãoToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            pnlFooter.SuspendLayout();
            menTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = SystemColors.GradientInactiveCaption;
            pnlFooter.Controls.Add(label1);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 411);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(800, 39);
            pnlFooter.TabIndex = 0;
            pnlFooter.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(100, 8);
            label1.Name = "label1";
            label1.Size = new Size(575, 25);
            label1.TabIndex = 0;
            label1.Text = "Theed Desenvolvimento - Todos os direitos Reservados | 2014-2024";
            // 
            // menTop
            // 
            menTop.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, categoriasToolStripMenuItem, produtosToolStripMenuItem, inventárioToolStripMenuItem, transaçãoToolStripMenuItem });
            menTop.Location = new Point(0, 0);
            menTop.Name = "menTop";
            menTop.Size = new Size(800, 24);
            menTop.TabIndex = 1;
            menTop.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // inventárioToolStripMenuItem
            // 
            inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            inventárioToolStripMenuItem.Size = new Size(72, 20);
            inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // transaçãoToolStripMenuItem
            // 
            transaçãoToolStripMenuItem.Name = "transaçãoToolStripMenuItem";
            transaçãoToolStripMenuItem.Size = new Size(71, 20);
            transaçãoToolStripMenuItem.Text = "Transação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(638, 34);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(694, 34);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome do Usuário";
            label3.Click += label3_Click;
            // 
            // frmAdminPainel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlFooter);
            Controls.Add(menTop);
            MainMenuStrip = menTop;
            Name = "frmAdminPainel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel Administrativo";
            WindowState = FormWindowState.Maximized;
            Load += frmAdminPainel_Load;
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            menTop.ResumeLayout(false);
            menTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFooter;
        private Label label1;
        private MenuStrip menTop;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem inventárioToolStripMenuItem;
        private ToolStripMenuItem transaçãoToolStripMenuItem;
        private Label label2;
        private Label label3;
    }
}
