namespace CORE.Views
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            fabricantesToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pnl_menu = new FlowLayoutPanel();
            pnl_cadastros = new Panel();
            btn_fabricantes = new Button();
            btn_fornecedor = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            pnl_menu.SuspendLayout();
            pnl_cadastros.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fornecedoresToolStripMenuItem, fabricantesToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // fabricantesToolStripMenuItem
            // 
            fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            fabricantesToolStripMenuItem.Size = new Size(145, 22);
            fabricantesToolStripMenuItem.Text = "Fabricantes";
            fabricantesToolStripMenuItem.Click += fabricantesToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // pnl_menu
            // 
            pnl_menu.Controls.Add(pnl_cadastros);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Location = new Point(0, 24);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(171, 1017);
            pnl_menu.TabIndex = 6;
            // 
            // pnl_cadastros
            // 
            pnl_cadastros.Controls.Add(button1);
            pnl_cadastros.Controls.Add(btn_fabricantes);
            pnl_cadastros.Controls.Add(btn_fornecedor);
            pnl_cadastros.Location = new Point(3, 3);
            pnl_cadastros.MaximumSize = new Size(162, 346);
            pnl_cadastros.MinimumSize = new Size(162, 31);
            pnl_cadastros.Name = "pnl_cadastros";
            pnl_cadastros.Size = new Size(162, 31);
            pnl_cadastros.TabIndex = 5;
            // 
            // btn_fabricantes
            // 
            btn_fabricantes.Location = new Point(9, 29);
            btn_fabricantes.Name = "btn_fabricantes";
            btn_fabricantes.Size = new Size(130, 23);
            btn_fabricantes.TabIndex = 16;
            btn_fabricantes.Text = "FABRICANTES";
            btn_fabricantes.UseVisualStyleBackColor = true;
            // 
            // btn_fornecedor
            // 
            btn_fornecedor.Location = new Point(9, 58);
            btn_fornecedor.Name = "btn_fornecedor";
            btn_fornecedor.Size = new Size(130, 25);
            btn_fornecedor.TabIndex = 15;
            btn_fornecedor.Text = "FORNECEDORES";
            btn_fornecedor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Expand_Arrow_20px;
            button1.Location = new Point(9, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pnl_menu);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl_menu.ResumeLayout(false);
            pnl_cadastros.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem fabricantesToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel pnl_menu;
        private Panel pnl_cadastros;
        private Button btn_fabricantes;
        private Button btn_fornecedor;
        private Button button1;
    }
}