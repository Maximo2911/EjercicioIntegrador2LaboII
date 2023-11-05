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
            lblTextoBienvenida.Location = new Point(68, 128);
            lblTextoBienvenida.Name = "lblTextoBienvenida";
            lblTextoBienvenida.Size = new Size(559, 15);
            lblTextoBienvenida.TabIndex = 1;
            lblTextoBienvenida.Text = "Al mejor sitio donde puedes reserver tu turno para sacar  la licencia";
            // 
            // btnBienvenido
            // 
            btnBienvenido.Location = new Point(267, 215);
            btnBienvenido.Name = "btnBienvenido";
            btnBienvenido.Size = new Size(137, 43);
            btnBienvenido.TabIndex = 2;
            btnBienvenido.Text = "Acceder";
            btnBienvenido.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(703, 347);
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
    }
}