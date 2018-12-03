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
            this.MenuTitle = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(592, 23);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(160, 41);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CarListPanel
            // 
            this.CarListPanel.AutoScroll = true;
            this.CarListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CarListPanel.Location = new System.Drawing.Point(12, 83);
            this.CarListPanel.Name = "CarListPanel";
            this.CarListPanel.Size = new System.Drawing.Size(740, 445);
            this.CarListPanel.TabIndex = 1;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.Location = new System.Drawing.Point(12, 22);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(259, 42);
            this.MenuTitle.TabIndex = 2;
            this.MenuTitle.Text = "Available Cars";
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(592, 548);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(160, 41);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_CarAvailability);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 611);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.MenuTitle);
            this.Controls.Add(this.CarListPanel);
            this.Controls.Add(this.LogoutButton);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Car Rental System - Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.FlowLayoutPanel CarListPanel;
        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.Button Refresh;
    }
}