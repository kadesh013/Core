namespace CORE.Views.Fornecedor
{
    partial class Cad_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Fornecedor));
            btn_cancelar = new Button();
            btn_confirmar = new Button();
            btn_excluir = new Button();
            btn_editar = new Button();
            btn_adicionar = new Button();
            txt_codigo = new TextBox();
            txt_razao_social = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtg_cad_fornecedor = new DataGridView();
            textBox3 = new TextBox();
            label3 = new Label();
            btn_pesquisa = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            chk_isento = new CheckBox();
            txt_nome_fantasia = new TextBox();
            txt_endereco = new TextBox();
            txt_numero = new TextBox();
            txt_CEP = new TextBox();
            txt_complemento = new TextBox();
            txt_bairro = new TextBox();
            txt_estado = new TextBox();
            txt_cidade = new TextBox();
            txt_cnpj = new TextBox();
            txt_ie = new TextBox();
            txt_contato = new TextBox();
            txt_telefone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_cad_fornecedor).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(683, 280);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(100, 50);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(683, 224);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(100, 50);
            btn_confirmar.TabIndex = 5;
            btn_confirmar.Text = "CONFIRMAR";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(683, 109);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(100, 50);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "EXCLUIR";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(683, 165);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(100, 50);
            btn_editar.TabIndex = 4;
            btn_editar.Text = "EDITAR";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(683, 53);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(100, 50);
            btn_adicionar.TabIndex = 2;
            btn_adicionar.Text = "ADICIONAR";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(107, 346);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(110, 23);
            txt_codigo.TabIndex = 7;
            // 
            // txt_razao_social
            // 
            txt_razao_social.Location = new Point(107, 375);
            txt_razao_social.Name = "txt_razao_social";
            txt_razao_social.Size = new Size(569, 23);
            txt_razao_social.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 378);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 23;
            label2.Text = "Razão Social:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 346);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 22;
            label1.Text = "Codigo:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtg_cad_fornecedor
            // 
            dtg_cad_fornecedor.AllowUserToAddRows = false;
            dtg_cad_fornecedor.AllowUserToDeleteRows = false;
            dtg_cad_fornecedor.AllowUserToOrderColumns = true;
            dtg_cad_fornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_cad_fornecedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dtg_cad_fornecedor.CausesValidation = false;
            dtg_cad_fornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_cad_fornecedor.Location = new Point(17, 53);
            dtg_cad_fornecedor.Name = "dtg_cad_fornecedor";
            dtg_cad_fornecedor.ReadOnly = true;
            dtg_cad_fornecedor.RowTemplate.Height = 25;
            dtg_cad_fornecedor.Size = new Size(659, 277);
            dtg_cad_fornecedor.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(659, 23);
            textBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 6);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 21;
            label3.Text = "Pesquisa:";
            label3.Click += label3_Click;
            // 
            // btn_pesquisa
            // 
            btn_pesquisa.BackgroundImage = (Image)resources.GetObject("btn_pesquisa.BackgroundImage");
            btn_pesquisa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_pesquisa.Location = new Point(682, 24);
            btn_pesquisa.Name = "btn_pesquisa";
            btn_pesquisa.Size = new Size(41, 25);
            btn_pesquisa.TabIndex = 1;
            btn_pesquisa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 409);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 24;
            label4.Text = "Nome Fantasia:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 441);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 25;
            label5.Text = "Endereço:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 470);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 26;
            label6.Text = "Complemento:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 497);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 27;
            label7.Text = "Cidade:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 528);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 28;
            label8.Text = "C.N.P.J:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 557);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 29;
            label9.Text = "Contato:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(409, 438);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 31;
            label10.Text = "Número:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(409, 470);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 32;
            label11.Text = "Bairro:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(409, 497);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 33;
            label12.Text = "Estado:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(521, 438);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 36;
            label13.Text = "CEP:";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(410, 525);
            label14.Name = "label14";
            label14.Size = new Size(19, 15);
            label14.TabIndex = 34;
            label14.Text = "IE:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(409, 552);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 35;
            label16.Text = "Telefone:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chk_isento
            // 
            chk_isento.AutoSize = true;
            chk_isento.Location = new Point(327, 528);
            chk_isento.Name = "chk_isento";
            chk_isento.Size = new Size(58, 19);
            chk_isento.TabIndex = 30;
            chk_isento.Text = "Isento";
            chk_isento.UseVisualStyleBackColor = true;
            // 
            // txt_nome_fantasia
            // 
            txt_nome_fantasia.Location = new Point(107, 406);
            txt_nome_fantasia.Name = "txt_nome_fantasia";
            txt_nome_fantasia.Size = new Size(569, 23);
            txt_nome_fantasia.TabIndex = 9;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(107, 435);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(296, 23);
            txt_endereco.TabIndex = 10;
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(461, 435);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(50, 23);
            txt_numero.TabIndex = 11;
            // 
            // txt_CEP
            // 
            txt_CEP.Location = new Point(558, 435);
            txt_CEP.Name = "txt_CEP";
            txt_CEP.Size = new Size(118, 23);
            txt_CEP.TabIndex = 12;
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(107, 467);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(296, 23);
            txt_complemento.TabIndex = 13;
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(460, 464);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(216, 23);
            txt_bairro.TabIndex = 14;
            // 
            // txt_estado
            // 
            txt_estado.Location = new Point(460, 494);
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(216, 23);
            txt_estado.TabIndex = 16;
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(107, 497);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(296, 23);
            txt_cidade.TabIndex = 15;
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(107, 525);
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(162, 23);
            txt_cnpj.TabIndex = 17;
            // 
            // txt_ie
            // 
            txt_ie.Location = new Point(461, 520);
            txt_ie.Name = "txt_ie";
            txt_ie.Size = new Size(215, 23);
            txt_ie.TabIndex = 18;
            // 
            // txt_contato
            // 
            txt_contato.Location = new Point(107, 554);
            txt_contato.Name = "txt_contato";
            txt_contato.Size = new Size(162, 23);
            txt_contato.TabIndex = 19;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(461, 550);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(215, 23);
            txt_telefone.TabIndex = 20;
            // 
            // Cad_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 606);
            Controls.Add(txt_telefone);
            Controls.Add(txt_contato);
            Controls.Add(txt_ie);
            Controls.Add(txt_cnpj);
            Controls.Add(txt_cidade);
            Controls.Add(txt_estado);
            Controls.Add(txt_bairro);
            Controls.Add(txt_complemento);
            Controls.Add(txt_CEP);
            Controls.Add(txt_numero);
            Controls.Add(txt_endereco);
            Controls.Add(txt_nome_fantasia);
            Controls.Add(chk_isento);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_pesquisa);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_confirmar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_editar);
            Controls.Add(btn_adicionar);
            Controls.Add(txt_codigo);
            Controls.Add(txt_razao_social);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_cad_fornecedor);
            Name = "Cad_Fornecedor";
            Text = "Cad_Fornecedor";
            Load += Cad_Fornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_cad_fornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_confirmar;
        private Button btn_excluir;
        private Button btn_editar;
        private Button btn_adicionar;
        private TextBox txt_codigo;
        private TextBox txt_razao_social;
        private Label label2;
        private Label label1;
        private DataGridView dtg_cad_fornecedor;
        private TextBox textBox3;
        private Label label3;
        private Button btn_pesquisa;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private CheckBox chk_isento;
        private TextBox txt_nome_fantasia;
        private TextBox txt_endereco;
        private TextBox txt_numero;
        private TextBox txt_CEP;
        private TextBox txt_complemento;
        private TextBox txt_bairro;
        private TextBox txt_estado;
        private TextBox txt_cidade;
        private TextBox txt_cnpj;
        private TextBox txt_ie;
        private TextBox txt_contato;
        private TextBox txt_telefone;
    }
}