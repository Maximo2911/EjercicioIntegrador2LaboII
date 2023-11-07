namespace TurnoLicencia
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            lblBienvenido = new Label();
            lblTextoBienvenida = new Label();
            btnBienvenido = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(213, 67);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(257, 37);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "¡Bienvenido!";
            // 
            // lblTextoBienvenida
            // 
            lblTextoBienvenida.AutoSize = true;
            lblTextoBienvenida.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextoBienvenida.Location = new Point(76, 127);
            lblTextoBienvenida.Name = "lblTextoBienvenida";
            lblTextoBienvenida.Size = new Size(535, 15);
            lblTextoBienvenida.TabIndex = 1;
            lblTextoBienvenida.Text = "Al mejor sitio donde puedes reservar tu turno para sacar ó renovar";
            // 
            // btnBienvenido
            // 
            btnBienvenido.Location = new Point(273, 215);
            btnBienvenido.Name = "btnBienvenido";
            btnBienvenido.Size = new Size(137, 43);
            btnBienvenido.TabIndex = 2;
            btnBienvenido.Text = "Acceder";
            btnBienvenido.UseVisualStyleBackColor = true;
            btnBienvenido.Click += btnBienvenido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 152);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 3;
            label1.Text = "la licencia de conducir";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(703, 347);
            Controls.Add(label1);
            Controls.Add(btnBienvenido);
            Controls.Add(lblTextoBienvenida);
            Controls.Add(lblBienvenido);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turno Licencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblTextoBienvenida;
        private Button btnBienvenido;
        private Label label1;
    }
}