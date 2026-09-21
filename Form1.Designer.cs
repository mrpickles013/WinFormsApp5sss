namespace WinFormsApp5
{
    partial class Form1
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            rdbMasc = new RadioButton();
            rdbFem = new RadioButton();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(94, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 46);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite seu nome aqui";
            txtNome.Size = new Size(206, 31);
            txtNome.TabIndex = 2;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu nome aqui";
            txtEmail.Size = new Size(206, 31);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 223);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 3;
            label1.Text = "E-mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 153);
            textBox2.MaxLength = 14;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Digite seu nome aqui";
            textBox2.Size = new Size(206, 31);
            textBox2.TabIndex = 6;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 115);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 5;
            label2.Text = "Telefone:";
            // 
            // button1
            // 
            button1.Location = new Point(284, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rdbMasc
            // 
            rdbMasc.AutoSize = true;
            rdbMasc.Location = new Point(374, 45);
            rdbMasc.Name = "rdbMasc";
            rdbMasc.Size = new Size(117, 29);
            rdbMasc.TabIndex = 8;
            rdbMasc.Text = "Masculino";
            rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            rdbFem.AutoSize = true;
            rdbFem.Checked = true;
            rdbFem.Location = new Point(374, 89);
            rdbFem.Name = "rdbFem";
            rdbFem.Size = new Size(110, 29);
            rdbFem.TabIndex = 9;
            rdbFem.TabStop = true;
            rdbFem.Text = "Feminino";
            rdbFem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 8);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 10;
            label3.Text = "Sexo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(374, 182);
            maskedTextBox1.Mask = "999.999.999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(374, 295);
            maskedTextBox2.Mask = "99999-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(150, 31);
            maskedTextBox2.TabIndex = 12;
//            maskedTextBox2.KeyPress += null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 249);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 13;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 138);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 14;
            label5.Text = "CPF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 537);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(rdbFem);
            Controls.Add(rdbMasc);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private RadioButton rdbMasc;
        private RadioButton rdbFem;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private Label label5;
    }
}
