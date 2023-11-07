namespace TurnoLicencia
{
    partial class FrmMostrarInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarInformacion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 16);
            label1.TabIndex = 0;
            label1.Text = "Informacion del Turno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(199, 76);
            label2.Name = "label2";
            label2.Size = new Size(63, 13);
            label2.TabIndex = 1;
            label2.Text = "Persona:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(316, 76);
            label3.Name = "label3";
            label3.Size = new Size(98, 13);
            label3.TabIndex = 2;
            label3.Text = "(aqui nombre)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(443, 76);
            label4.Name = "label4";
            label4.Size = new Size(112, 13);
            label4.TabIndex = 3;
            label4.Text = "(aqui apellido)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(199, 137);
            label5.Name = "label5";
            label5.Size = new Size(91, 13);
            label5.TabIndex = 4;
            label5.Text = "Fecha Turno:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(316, 137);
            label6.Name = "label6";
            label6.Size = new Size(154, 13);
            label6.TabIndex = 5;
            label6.Text = "(DateTime Calendario)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(199, 202);
            label7.Name = "label7";
            label7.Size = new Size(70, 13);
            label7.TabIndex = 6;
            label7.Text = "Vehiculo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(316, 202);
            label8.Name = "label8";
            label8.Size = new Size(112, 13);
            label8.TabIndex = 7;
            label8.Text = "(tipo vehiculo)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(443, 202);
            label9.Name = "label9";
            label9.Size = new Size(70, 13);
            label9.TabIndex = 8;
            label9.Text = "(patente)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(45, 283);
            label10.Name = "label10";
            label10.Size = new Size(217, 13);
            label10.TabIndex = 9;
            label10.Text = "Si desea cancelar el turno -->";
            // 
            // button1
            // 
            button1.Location = new Point(282, 278);
            button1.Name = "button1";
            button1.Size = new Size(146, 23);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmMostrarInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(703, 347);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMostrarInformacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turno Licencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
    }
}