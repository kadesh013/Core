namespace CORE.Views.Clientes
{
    partial class Cad_Cliente
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
            btn_cancelar = new Button();
            btn_confirmar = new Button();
            btn_excluir = new Button();
            btn_editar = new Button();
            btn_adicionar = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtg_cad_fabricante = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_cad_fabricante).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(683, 280);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(100, 50);
            btn_cancelar.TabIndex = 19;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(683, 224);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(100, 50);
            btn_confirmar.TabIndex = 18;
            btn_confirmar.Text = "CONFIRMAR";
            btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(683, 109);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(100, 50);
            btn_excluir.TabIndex = 17;
            btn_excluir.Text = "EXCLUIR";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(683, 165);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(100, 50);
            btn_editar.TabIndex = 16;
            btn_editar.Text = "EDITAR";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(683, 53);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(100, 50);
            btn_adicionar.TabIndex = 15;
            btn_adicionar.Text = "ADICIONAR";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 343);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(581, 23);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 378);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 12;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 346);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 11;
            label1.Text = "Codigo:";
            // 
            // dtg_cad_fabricante
            // 
            dtg_cad_fabricante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_cad_fabricante.Location = new Point(17, 53);
            dtg_cad_fabricante.Name = "dtg_cad_fabricante";
            dtg_cad_fabricante.RowTemplate.Height = 25;
            dtg_cad_fabricante.Size = new Size(659, 277);
            dtg_cad_fabricante.TabIndex = 10;
            // 
            // Cad_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_confirmar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_editar);
            Controls.Add(btn_adicionar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_cad_fabricante);
            Name = "Cad_Cliente";
            Text = "Cad_Cliente";
            Load += Cad_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_cad_fabricante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_confirmar;
        private Button btn_excluir;
        private Button btn_editar;
        private Button btn_adicionar;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dtg_cad_fabricante;
    }
}