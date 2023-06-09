namespace CORE.Views
{
    partial class Frm_Login
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
            btn_logar = new Button();
            btn_sair = new Button();
            lbl_usuario = new Label();
            label2 = new Label();
            txt_user = new TextBox();
            txt_password = new MaskedTextBox();
            SuspendLayout();
            // 
            // btn_logar
            // 
            btn_logar.Location = new Point(227, 162);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(93, 30);
            btn_logar.TabIndex = 0;
            btn_logar.Text = "ENTRAR";
            btn_logar.UseVisualStyleBackColor = true;
            btn_logar.Click += btn_logar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(24, 162);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(93, 30);
            btn_sair.TabIndex = 1;
            btn_sair.Text = "SAIR";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click_1;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(151, 31);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(59, 15);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 97);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "SENHA:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(102, 49);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(141, 23);
            txt_user.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(99, 115);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(144, 23);
            txt_password.TabIndex = 5;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 211);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_sair);
            Controls.Add(btn_logar);
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logar;
        private Button btn_sair;
        private Label lbl_usuario;
        private Label label2;
        private TextBox txt_user;
        private MaskedTextBox txt_password;
    }
}