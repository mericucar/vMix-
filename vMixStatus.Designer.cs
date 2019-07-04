namespace vMixStatusGetter
{
    /// <summary>
    /// This application is made by Meriç Uçar, 500801785, IC103
    /// </summary>
    partial class vMixStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.lblstatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.previewLabel = new System.Windows.Forms.Label();
            this.liveLabel = new System.Windows.Forms.Label();
            this.previewCamera = new System.Windows.Forms.Label();
            this.liveCamera = new System.Windows.Forms.Label();
            this.lblnaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(50, 50);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(100, 17);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "vMix Status: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.Location = new System.Drawing.Point(200, 100);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(65, 15);
            this.previewLabel.TabIndex = 4;
            this.previewLabel.Text = "Preview: ";
            // 
            // liveLabel
            // 
            this.liveLabel.AutoSize = true;
            this.liveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveLabel.Location = new System.Drawing.Point(50, 100);
            this.liveLabel.Name = "liveLabel";
            this.liveLabel.Size = new System.Drawing.Size(41, 15);
            this.liveLabel.TabIndex = 5;
            this.liveLabel.Text = "Live: ";
            // 
            // previewCamera
            // 
            this.previewCamera.AutoSize = true;
            this.previewCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewCamera.Location = new System.Drawing.Point(200, 150);
            this.previewCamera.Name = "previewCamera";
            this.previewCamera.Size = new System.Drawing.Size(41, 15);
            this.previewCamera.TabIndex = 6;
            this.previewCamera.Text = "None";
            // 
            // liveCamera
            // 
            this.liveCamera.AutoSize = true;
            this.liveCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveCamera.Location = new System.Drawing.Point(50, 150);
            this.liveCamera.Name = "liveCamera";
            this.liveCamera.Size = new System.Drawing.Size(41, 15);
            this.liveCamera.TabIndex = 7;
            this.liveCamera.Text = "None";
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnaam.Location = new System.Drawing.Point(50, 250);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(200, 25);
            this.lblnaam.TabIndex = 11;
            this.lblnaam.Text = "Created by Meriç Uçar, 500801785, IC103";
            // 
            // vMixStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.liveCamera);
            this.Controls.Add(this.previewCamera);
            this.Controls.Add(this.liveLabel);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.lblstatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "vMixStatus";
            this.Text = "vMix Live/Preview ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.Label liveLabel;
        private System.Windows.Forms.Label previewCamera;
        private System.Windows.Forms.Label liveCamera;
        private System.Windows.Forms.Label lblnaam;
    }
}

