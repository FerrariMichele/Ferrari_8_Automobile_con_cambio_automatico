namespace Ferrari_8_Automobile_con_cambio_automatico
{
    partial class FormAutomatico
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
            this.buttonAccensione = new System.Windows.Forms.Button();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.labelMarcia = new System.Windows.Forms.Label();
            this.buttonAcceleratore = new System.Windows.Forms.Button();
            this.buttonFreno = new System.Windows.Forms.Button();
            this.labelGiri = new System.Windows.Forms.Label();
            this.labelVelocita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAccensione
            // 
            this.buttonAccensione.Location = new System.Drawing.Point(442, 37);
            this.buttonAccensione.Name = "buttonAccensione";
            this.buttonAccensione.Size = new System.Drawing.Size(75, 23);
            this.buttonAccensione.TabIndex = 17;
            this.buttonAccensione.Text = "Engine On";
            this.buttonAccensione.UseVisualStyleBackColor = true;
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Location = new System.Drawing.Point(439, 9);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(21, 13);
            this.labelOnOff.TabIndex = 16;
            this.labelOnOff.Text = "Off";
            // 
            // labelMarcia
            // 
            this.labelMarcia.AutoSize = true;
            this.labelMarcia.Location = new System.Drawing.Point(262, 9);
            this.labelMarcia.Name = "labelMarcia";
            this.labelMarcia.Size = new System.Drawing.Size(13, 13);
            this.labelMarcia.TabIndex = 13;
            this.labelMarcia.Text = "0";
            // 
            // buttonAcceleratore
            // 
            this.buttonAcceleratore.Location = new System.Drawing.Point(93, 37);
            this.buttonAcceleratore.Name = "buttonAcceleratore";
            this.buttonAcceleratore.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceleratore.TabIndex = 12;
            this.buttonAcceleratore.Text = "Acceleratore";
            this.buttonAcceleratore.UseVisualStyleBackColor = true;
            // 
            // buttonFreno
            // 
            this.buttonFreno.Location = new System.Drawing.Point(12, 37);
            this.buttonFreno.Name = "buttonFreno";
            this.buttonFreno.Size = new System.Drawing.Size(75, 23);
            this.buttonFreno.TabIndex = 11;
            this.buttonFreno.Text = "Freno";
            this.buttonFreno.UseVisualStyleBackColor = true;
            // 
            // labelGiri
            // 
            this.labelGiri.AutoSize = true;
            this.labelGiri.Location = new System.Drawing.Point(90, 9);
            this.labelGiri.Name = "labelGiri";
            this.labelGiri.Size = new System.Drawing.Size(13, 13);
            this.labelGiri.TabIndex = 10;
            this.labelGiri.Text = "0";
            // 
            // labelVelocita
            // 
            this.labelVelocita.AutoSize = true;
            this.labelVelocita.Location = new System.Drawing.Point(12, 9);
            this.labelVelocita.Name = "labelVelocita";
            this.labelVelocita.Size = new System.Drawing.Size(13, 13);
            this.labelVelocita.TabIndex = 9;
            this.labelVelocita.Text = "0";
            // 
            // FormAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAccensione);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.labelMarcia);
            this.Controls.Add(this.buttonAcceleratore);
            this.Controls.Add(this.buttonFreno);
            this.Controls.Add(this.labelGiri);
            this.Controls.Add(this.labelVelocita);
            this.Name = "FormAutomatico";
            this.Text = "FormAutomatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccensione;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Label labelMarcia;
        private System.Windows.Forms.Button buttonAcceleratore;
        private System.Windows.Forms.Button buttonFreno;
        private System.Windows.Forms.Label labelGiri;
        private System.Windows.Forms.Label labelVelocita;
    }
}