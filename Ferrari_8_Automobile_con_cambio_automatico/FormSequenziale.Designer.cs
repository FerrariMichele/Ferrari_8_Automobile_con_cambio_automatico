namespace Ferrari_8_Automobile_con_cambio_automatico
{
    partial class FormSequenziale
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
            this.labelVelocita = new System.Windows.Forms.Label();
            this.labelGiri = new System.Windows.Forms.Label();
            this.buttonFreno = new System.Windows.Forms.Button();
            this.buttonAcceleratore = new System.Windows.Forms.Button();
            this.labelMarcia = new System.Windows.Forms.Label();
            this.buttonUpShift = new System.Windows.Forms.Button();
            this.buttonDownShift = new System.Windows.Forms.Button();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.buttonAccensione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVelocita
            // 
            this.labelVelocita.AutoSize = true;
            this.labelVelocita.Location = new System.Drawing.Point(12, 9);
            this.labelVelocita.Name = "labelVelocita";
            this.labelVelocita.Size = new System.Drawing.Size(13, 13);
            this.labelVelocita.TabIndex = 0;
            this.labelVelocita.Text = "0";
            // 
            // labelGiri
            // 
            this.labelGiri.AutoSize = true;
            this.labelGiri.Location = new System.Drawing.Point(90, 9);
            this.labelGiri.Name = "labelGiri";
            this.labelGiri.Size = new System.Drawing.Size(13, 13);
            this.labelGiri.TabIndex = 1;
            this.labelGiri.Text = "0";
            // 
            // buttonFreno
            // 
            this.buttonFreno.Location = new System.Drawing.Point(12, 37);
            this.buttonFreno.Name = "buttonFreno";
            this.buttonFreno.Size = new System.Drawing.Size(75, 23);
            this.buttonFreno.TabIndex = 2;
            this.buttonFreno.Text = "Freno";
            this.buttonFreno.UseVisualStyleBackColor = true;
            this.buttonFreno.Click += new System.EventHandler(this.buttonFreno_Click);
            // 
            // buttonAcceleratore
            // 
            this.buttonAcceleratore.Location = new System.Drawing.Point(93, 37);
            this.buttonAcceleratore.Name = "buttonAcceleratore";
            this.buttonAcceleratore.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceleratore.TabIndex = 3;
            this.buttonAcceleratore.Text = "Acceleratore";
            this.buttonAcceleratore.UseVisualStyleBackColor = true;
            this.buttonAcceleratore.Click += new System.EventHandler(this.buttonAcceleratore_Click);
            // 
            // labelMarcia
            // 
            this.labelMarcia.AutoSize = true;
            this.labelMarcia.Location = new System.Drawing.Point(262, 9);
            this.labelMarcia.Name = "labelMarcia";
            this.labelMarcia.Size = new System.Drawing.Size(13, 13);
            this.labelMarcia.TabIndex = 4;
            this.labelMarcia.Text = "0";
            // 
            // buttonUpShift
            // 
            this.buttonUpShift.Location = new System.Drawing.Point(281, 12);
            this.buttonUpShift.Name = "buttonUpShift";
            this.buttonUpShift.Size = new System.Drawing.Size(75, 23);
            this.buttonUpShift.TabIndex = 5;
            this.buttonUpShift.Text = "Marcia Su";
            this.buttonUpShift.UseVisualStyleBackColor = true;
            this.buttonUpShift.Click += new System.EventHandler(this.buttonUpShift_Click);
            // 
            // buttonDownShift
            // 
            this.buttonDownShift.Location = new System.Drawing.Point(281, 37);
            this.buttonDownShift.Name = "buttonDownShift";
            this.buttonDownShift.Size = new System.Drawing.Size(75, 23);
            this.buttonDownShift.TabIndex = 6;
            this.buttonDownShift.Text = "Marcia Giu";
            this.buttonDownShift.UseVisualStyleBackColor = true;
            this.buttonDownShift.Click += new System.EventHandler(this.buttonDownShift_Click);
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Location = new System.Drawing.Point(439, 9);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(21, 13);
            this.labelOnOff.TabIndex = 7;
            this.labelOnOff.Text = "Off";
            // 
            // buttonAccensione
            // 
            this.buttonAccensione.Location = new System.Drawing.Point(442, 37);
            this.buttonAccensione.Name = "buttonAccensione";
            this.buttonAccensione.Size = new System.Drawing.Size(75, 23);
            this.buttonAccensione.TabIndex = 8;
            this.buttonAccensione.Text = "Engine On";
            this.buttonAccensione.UseVisualStyleBackColor = true;
            this.buttonAccensione.Click += new System.EventHandler(this.buttonAccensione_Click);
            // 
            // FormSequenziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAccensione);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.buttonDownShift);
            this.Controls.Add(this.buttonUpShift);
            this.Controls.Add(this.labelMarcia);
            this.Controls.Add(this.buttonAcceleratore);
            this.Controls.Add(this.buttonFreno);
            this.Controls.Add(this.labelGiri);
            this.Controls.Add(this.labelVelocita);
            this.Name = "FormSequenziale";
            this.Text = "FormSequenziale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVelocita;
        private System.Windows.Forms.Label labelGiri;
        private System.Windows.Forms.Button buttonFreno;
        private System.Windows.Forms.Button buttonAcceleratore;
        private System.Windows.Forms.Label labelMarcia;
        private System.Windows.Forms.Button buttonUpShift;
        private System.Windows.Forms.Button buttonDownShift;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Button buttonAccensione;
    }
}