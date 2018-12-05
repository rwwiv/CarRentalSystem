namespace CarRentalSystem.Views
{
    partial class UpdateConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.availabilityBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please confirm this vehicle\'s status:";
            // 
            // vehicleName
            // 
            this.vehicleName.AutoSize = true;
            this.vehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleName.Location = new System.Drawing.Point(31, 83);
            this.vehicleName.Name = "vehicleName";
            this.vehicleName.Size = new System.Drawing.Size(95, 20);
            this.vehicleName.TabIndex = 2;
            this.vehicleName.Text = "Make Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // availabilityBox
            // 
            this.availabilityBox.FormattingEnabled = true;
            this.availabilityBox.Items.AddRange(new object[] {
            "Not Available",
            "Available"});
            this.availabilityBox.Location = new System.Drawing.Point(97, 121);
            this.availabilityBox.Name = "availabilityBox";
            this.availabilityBox.Size = new System.Drawing.Size(240, 21);
            this.availabilityBox.TabIndex = 4;
            this.availabilityBox.SelectedIndexChanged += new System.EventHandler(this.availabilityBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(35, 194);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(563, 96);
            this.descriptionBox.TabIndex = 6;
            this.descriptionBox.Text = "";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(401, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 413);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availabilityBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vehicleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox availabilityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}