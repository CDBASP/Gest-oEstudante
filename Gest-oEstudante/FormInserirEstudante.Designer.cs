namespace Gest_oEstudante
{
    partial class FormInserirEstudante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxNome = new System.Windows.Forms.TextBox();
            this.textboxSobrenome = new System.Windows.Forms.TextBox();
            this.dateTimePickerNacimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMaculino = new System.Windows.Forms.RadioButton();
            this.textboxTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviarFoto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // textboxNome
            // 
            this.textboxNome.Location = new System.Drawing.Point(123, 12);
            this.textboxNome.Name = "textboxNome";
            this.textboxNome.Size = new System.Drawing.Size(202, 20);
            this.textboxNome.TabIndex = 2;
            // 
            // textboxSobrenome
            // 
            this.textboxSobrenome.Location = new System.Drawing.Point(123, 54);
            this.textboxSobrenome.Name = "textboxSobrenome";
            this.textboxSobrenome.Size = new System.Drawing.Size(202, 20);
            this.textboxSobrenome.TabIndex = 3;
            // 
            // dateTimePickerNacimento
            // 
            this.dateTimePickerNacimento.CustomFormat = "dd/mm/aaaa";
            this.dateTimePickerNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNacimento.Location = new System.Drawing.Point(123, 91);
            this.dateTimePickerNacimento.Name = "dateTimePickerNacimento";
            this.dateTimePickerNacimento.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickerNacimento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de nacimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMaculino);
            this.groupBox1.Location = new System.Drawing.Point(123, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(97, 19);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaculino
            // 
            this.radioButtonMaculino.AutoSize = true;
            this.radioButtonMaculino.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMaculino.Name = "radioButtonMaculino";
            this.radioButtonMaculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMaculino.TabIndex = 0;
            this.radioButtonMaculino.TabStop = true;
            this.radioButtonMaculino.Text = "Masculino";
            this.radioButtonMaculino.UseVisualStyleBackColor = true;
            this.radioButtonMaculino.CheckedChanged += new System.EventHandler(this.radioButtonMaculino_CheckedChanged);
            // 
            // textboxTelefone
            // 
            this.textboxTelefone.Location = new System.Drawing.Point(123, 192);
            this.textboxTelefone.Name = "textboxTelefone";
            this.textboxTelefone.Size = new System.Drawing.Size(202, 20);
            this.textboxTelefone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // textboxEndereco
            // 
            this.textboxEndereco.Location = new System.Drawing.Point(123, 233);
            this.textboxEndereco.Multiline = true;
            this.textboxEndereco.Name = "textboxEndereco";
            this.textboxEndereco.Size = new System.Drawing.Size(202, 50);
            this.textboxEndereco.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endereço";
            // 
            // btnEnviarFoto
            // 
            this.btnEnviarFoto.Location = new System.Drawing.Point(150, 405);
            this.btnEnviarFoto.Name = "btnEnviarFoto";
            this.btnEnviarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarFoto.TabIndex = 12;
            this.btnEnviarFoto.Text = "Enviar Foto";
            this.btnEnviarFoto.UseVisualStyleBackColor = true;
            this.btnEnviarFoto.Click += new System.EventHandler(this.btnEnviarFoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Foto";
            // 
            // pictureFoto
            // 
            this.pictureFoto.Location = new System.Drawing.Point(123, 298);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(120, 101);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFoto.TabIndex = 14;
            this.pictureFoto.TabStop = false;
            this.pictureFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(337, 455);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(33, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 490);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEnviarFoto);
            this.Controls.Add(this.textboxEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerNacimento);
            this.Controls.Add(this.textboxSobrenome);
            this.Controls.Add(this.textboxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInserirEstudante";
            this.Text = "FormInserirEstudante";
            this.Load += new System.EventHandler(this.FormInserirEstudante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxNome;
        private System.Windows.Forms.TextBox textboxSobrenome;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMaculino;
        private System.Windows.Forms.TextBox textboxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviarFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}