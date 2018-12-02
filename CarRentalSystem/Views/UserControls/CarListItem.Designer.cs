namespace CarRentalSystem.Views.UserControls
{
    partial class CarListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarListItem));
            this.CarPicture = new System.Windows.Forms.PictureBox();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.CarPriceLabel = new System.Windows.Forms.Label();
            this.PerDiemLabel = new System.Windows.Forms.Label();
            this.CarSelectButton = new System.Windows.Forms.Button();
            this.AvailabilityStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CarPicture
            // 
            this.CarPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CarPicture.Image = ((System.Drawing.Image)(resources.GetObject("CarPicture.Image")));
            this.CarPicture.Location = new System.Drawing.Point(18, 22);
            this.CarPicture.Name = "CarPicture";
            this.CarPicture.Size = new System.Drawing.Size(240, 159);
            this.CarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPicture.TabIndex = 0;
            this.CarPicture.TabStop = false;
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLabel.Location = new System.Drawing.Point(295, 22);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(160, 31);
            this.CarNameLabel.TabIndex = 2;
            this.CarNameLabel.Text = "Make Model";
            // 
            // CarPriceLabel
            // 
            this.CarPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarPriceLabel.AutoSize = true;
            this.CarPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPriceLabel.Location = new System.Drawing.Point(294, 53);
            this.CarPriceLabel.Name = "CarPriceLabel";
            this.CarPriceLabel.Size = new System.Drawing.Size(71, 37);
            this.CarPriceLabel.TabIndex = 3;
            this.CarPriceLabel.Text = "$50";
            // 
            // PerDiemLabel
            // 
            this.PerDiemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerDiemLabel.AutoSize = true;
            this.PerDiemLabel.Location = new System.Drawing.Point(298, 88);
            this.PerDiemLabel.Name = "PerDiemLabel";
            this.PerDiemLabel.Size = new System.Drawing.Size(42, 13);
            this.PerDiemLabel.TabIndex = 4;
            this.PerDiemLabel.Text = "per day";
            // 
            // CarSelectButton
            // 
            this.CarSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CarSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarSelectButton.Location = new System.Drawing.Point(301, 141);
            this.CarSelectButton.Name = "CarSelectButton";
            this.CarSelectButton.Size = new System.Drawing.Size(159, 40);
            this.CarSelectButton.TabIndex = 6;
            this.CarSelectButton.Text = "Rent";
            this.CarSelectButton.UseVisualStyleBackColor = true;
            this.CarSelectButton.Click += new System.EventHandler(this.CarSelectButton_Click);
            // 
            // AvailabilityStatusLabel
            // 
            this.AvailabilityStatusLabel.AutoSize = true;
            this.AvailabilityStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityStatusLabel.Location = new System.Drawing.Point(297, 109);
            this.AvailabilityStatusLabel.Name = "AvailabilityStatusLabel";
            this.AvailabilityStatusLabel.Size = new System.Drawing.Size(72, 20);
            this.AvailabilityStatusLabel.TabIndex = 7;
            this.AvailabilityStatusLabel.Text = "Available";
            // 
            // CarListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.AvailabilityStatusLabel);
            this.Controls.Add(this.CarPicture);
            this.Controls.Add(this.CarSelectButton);
            this.Controls.Add(this.PerDiemLabel);
            this.Controls.Add(this.CarPriceLabel);
            this.Controls.Add(this.CarNameLabel);
            this.Name = "CarListItem";
            this.Size = new System.Drawing.Size(720, 204);
            ((System.ComponentModel.ISupportInitialize)(this.CarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CarPicture;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.Label CarPriceLabel;
        private System.Windows.Forms.Label PerDiemLabel;
        private System.Windows.Forms.Button CarSelectButton;
        private System.Windows.Forms.Label AvailabilityStatusLabel;
    }
}
