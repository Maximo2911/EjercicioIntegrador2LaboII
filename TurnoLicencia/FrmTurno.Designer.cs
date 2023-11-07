namespace TurnoLicencia
{
    partial class FrmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurno));
            lblSacarTurno = new Label();
            lblYaTienesTurno = new Label();
            btnSacarTurno = new Button();
            btnLogearte = new Button();
            SuspendLayout();
            // 
            // lblSacarTurno
            // 
            lblSacarTurno.AutoSize = true;
            lblSacarTurno.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSacarTurno.Location = new Point(280, 89);
            lblSacarTurno.Name = "lblSacarTurno";
            lblSacarTurno.Size = new Size(103, 16);
            lblSacarTurno.TabIndex = 0;
            lblSacarTurno.Text = "Sacar Turno:";
            // 
            // lblYaTienesTurno
            // 
            lblYaTienesTurno.AutoSize = true;
            lblYaTienesTurno.Font = new Font("SimSun", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblYaTienesTurno.Location = new Point(148, 217);
            lblYaTienesTurno.Name = "lblYaTienesTurno";
            lblYaTienesTurno.Size = new Size(259, 13);
            lblYaTienesTurno.TabIndex = 1;
            lblYaTienesTurno.Text = "Ya tienes un turno? Clickea aquí -->";
            // 
            // btnSacarTurno
            // 
            btnSacarTurno.Location = new Point(265, 120);
            btnSacarTurno.Name = "btnSacarTurno";
            btnSacarTurno.Size = new Size(137, 43);
            btnSacarTurno.TabIndex = 2;
            btnSacarTurno.Text = "Ingresar";
            btnSacarTurno.UseVisualStyleBackColor = true;
            btnSacarTurno.Click += btnSacarTurno_Click;
            // 
            // btnLogearte
            // 
            btnLogearte.Location = new Point(427, 209);
            btnLogearte.Name = "btnLogearte";
            btnLogearte.Size = new Size(92, 29);
            btnLogearte.TabIndex = 3;
            btnLogearte.Text = "Logearte";
            btnLogearte.UseVisualStyleBackColor = true;
            btnLogearte.Click += btnLogearte_Click;
            // 
            // FrmTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(703, 347);
            Controls.Add(btnLogearte);
            Controls.Add(btnSacarTurno);
            Controls.Add(lblYaTienesTurno);
            Controls.Add(lblSacarTurno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turno Licencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSacarTurno;
        private Label lblYaTienesTurno;
        private Button btnSacarTurno;
        private Button btnLogearte;
    }
}