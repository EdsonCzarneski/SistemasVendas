namespace SistemasVendas
{
    partial class frmUsuarioPainel
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
            usuarioMenTop = new MenuStrip();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            inventárioToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label2 = new Label();
            usuarioMenTop.SuspendLayout();
            SuspendLayout();
            // 
            // usuarioMenTop
            // 
            usuarioMenTop.Items.AddRange(new ToolStripItem[] { comprasToolStripMenuItem, vendasToolStripMenuItem, inventárioToolStripMenuItem });
            usuarioMenTop.Location = new Point(0, 0);
            usuarioMenTop.Name = "usuarioMenTop";
            usuarioMenTop.Size = new Size(800, 24);
            usuarioMenTop.TabIndex = 0;
            usuarioMenTop.Text = "menuStrip1";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(67, 20);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(56, 20);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // inventárioToolStripMenuItem
            // 
            inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            inventárioToolStripMenuItem.Size = new Size(72, 20);
            inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(670, 47);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome do Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(614, 47);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuário:";
            // 
            // usuarioPain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(usuarioMenTop);
            MainMenuStrip = usuarioMenTop;
            Name = "usuarioPain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel do Usuário";
            WindowState = FormWindowState.Maximized;
            Load += usuarioPain_Load;
            usuarioMenTop.ResumeLayout(false);
            usuarioMenTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip usuarioMenTop;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem inventárioToolStripMenuItem;
        private Label label3;
        private Label label2;
    }
}