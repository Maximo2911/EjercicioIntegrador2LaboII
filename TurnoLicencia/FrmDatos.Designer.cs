﻿namespace TurnoLicencia
{
    partial class FrmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatos));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnSiguiente = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 16);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los siguientes datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 13);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 302);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Contacto";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 268);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 17);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Es Titular";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 150);
            label7.Name = "label7";
            label7.Size = new Size(70, 13);
            label7.TabIndex = 12;
            label7.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 150);
            label6.Name = "label6";
            label6.Size = new Size(63, 13);
            label6.TabIndex = 11;
            label6.Text = "Cod.Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 207);
            label5.Name = "label5";
            label5.Size = new Size(133, 13);
            label5.TabIndex = 10;
            label5.Text = "Correo electrónico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 150);
            label4.Name = "label4";
            label4.Size = new Size(35, 13);
            label4.TabIndex = 9;
            label4.Text = "DNI:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(422, 168);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 22);
            textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(286, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(56, 22);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 22);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 22);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 22);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(70, 13);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 22);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(679, 264);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información del Titular";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(422, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 198);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(232, 22);
            textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 120);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(232, 22);
            textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 50);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(232, 22);
            textBox7.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 180);
            label10.Name = "label10";
            label10.Size = new Size(63, 13);
            label10.TabIndex = 2;
            label10.Text = "DNI/CUIT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 102);
            label9.Name = "label9";
            label9.Size = new Size(70, 13);
            label9.TabIndex = 1;
            label9.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 32);
            label8.Name = "label8";
            label8.Size = new Size(56, 13);
            label8.TabIndex = 0;
            label8.Text = "Nombre:";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(580, 645);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(111, 32);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 645);
            button1.Name = "button1";
            button1.Size = new Size(111, 32);
            button1.TabIndex = 5;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(703, 686);
            Controls.Add(button1);
            Controls.Add(btnSiguiente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turno Licencia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private CheckBox checkBox1;
        private Label label7;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox1;
        private Button btnSiguiente;
        private Button button1;
    }
}