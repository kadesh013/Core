namespace CORE.Views.Funcionalidades
{
    partial class Cryptog
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
            label1 = new Label();
            label2 = new Label();
            txt_criptografar = new TextBox();
            txt_resultado = new TextBox();
            btn_decrypt = new Button();
            txt_chave = new TextBox();
            lbl_chave = new Label();
            btn_encrypt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 5;
            label1.Text = "Texto a ser convertido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 25);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Resultado";
            label2.Click += label2_Click;
            // 
            // txt_criptografar
            // 
            txt_criptografar.Location = new Point(21, 43);
            txt_criptografar.Multiline = true;
            txt_criptografar.Name = "txt_criptografar";
            txt_criptografar.Size = new Size(108, 236);
            txt_criptografar.TabIndex = 0;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(343, 43);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(113, 236);
            txt_resultado.TabIndex = 2;
            txt_resultado.TextChanged += txt_resultado_TextChanged;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Location = new Point(343, 351);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(100, 31);
            btn_decrypt.TabIndex = 4;
            btn_decrypt.Text = "Descriptografar";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // txt_chave
            // 
            txt_chave.Location = new Point(186, 43);
            txt_chave.Multiline = true;
            txt_chave.Name = "txt_chave";
            txt_chave.Size = new Size(113, 236);
            txt_chave.TabIndex = 1;
            // 
            // lbl_chave
            // 
            lbl_chave.AutoSize = true;
            lbl_chave.Location = new Point(220, 25);
            lbl_chave.Name = "lbl_chave";
            lbl_chave.Size = new Size(40, 15);
            lbl_chave.TabIndex = 6;
            lbl_chave.Text = "Chave";
            // 
            // btn_encrypt
            // 
            btn_encrypt.Location = new Point(37, 351);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(100, 31);
            btn_encrypt.TabIndex = 3;
            btn_encrypt.Text = "Criptografar";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // Cryptog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 408);
            Controls.Add(btn_encrypt);
            Controls.Add(txt_chave);
            Controls.Add(lbl_chave);
            Controls.Add(btn_decrypt);
            Controls.Add(txt_resultado);
            Controls.Add(txt_criptografar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cryptog";
            Text = "Cryptog";
            Load += Cryptog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_criptografar;
        private TextBox txt_resultado;
        private Button btn_encrypt;
        private Button btn_decrypt;
        private TextBox txt_chave;
        private Label lbl_chave;
    }
}