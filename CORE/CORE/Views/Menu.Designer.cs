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
            btn_fornecedor = new Button();
            btn_fabricantes = new Button();
            SuspendLayout();
            // 
            // btn_fornecedor
            // 
            btn_fornecedor.Location = new Point(21, 42);
            btn_fornecedor.Name = "btn_fornecedor";
            btn_fornecedor.Size = new Size(136, 62);
            btn_fornecedor.TabIndex = 0;
            btn_fornecedor.Text = "FORNECEDORES";
            btn_fornecedor.UseVisualStyleBackColor = true;
            btn_fornecedor.Click += btn_fornecedor_Click;
            // 
            // btn_fabricantes
            // 
            btn_fabricantes.Location = new Point(182, 42);
            btn_fabricantes.Name = "btn_fabricantes";
            btn_fabricantes.Size = new Size(136, 62);
            btn_fabricantes.TabIndex = 1;
            btn_fabricantes.Text = "FABRICANTES";
            btn_fabricantes.UseVisualStyleBackColor = true;
            btn_fabricantes.Click += btn_fabricantes_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 127);
            Controls.Add(btn_fabricantes);
            Controls.Add(btn_fornecedor);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_fornecedor;
        private Button btn_fabricantes;
    }
}