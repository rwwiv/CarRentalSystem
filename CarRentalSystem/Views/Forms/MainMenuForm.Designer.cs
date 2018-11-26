namespace CarRentalSystem
{
    partial class MainMenu
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CarListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.carListItem1 = new CarRentalSystem.Views.UserControls.CarListItem();
            this.CarListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(592, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(160, 41);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // CarListPanel
            // 
            this.CarListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CarListPanel.Controls.Add(this.carListItem1);
            this.CarListPanel.Location = new System.Drawing.Point(12, 12);
            this.CarListPanel.Name = "CarListPanel";
            this.CarListPanel.Size = new System.Drawing.Size(568, 587);
            this.CarListPanel.TabIndex = 1;
            // 
            // carListItem1
            // 
            this.carListItem1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.carListItem1.Location = new System.Drawing.Point(3, 3);
            this.carListItem1.Name = "carListItem1";
            this.carListItem1.Size = new System.Drawing.Size(561, 118);
            this.carListItem1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 611);
            this.Controls.Add(this.CarListPanel);
            this.Controls.Add(this.LogoutButton);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Car Rental System - Main Menu";
            this.CarListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.FlowLayoutPanel CarListPanel;
        private Views.UserControls.CarListItem carListItem1;
    }
}