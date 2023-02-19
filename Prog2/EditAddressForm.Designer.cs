
namespace UPVApp
{
    partial class EditAddress
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
            this.editAddressCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkEditAddress = new System.Windows.Forms.Button();
            this.CancelEditAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editAddressCombo
            // 
            this.editAddressCombo.FormattingEnabled = true;
            this.editAddressCombo.Location = new System.Drawing.Point(159, 94);
            this.editAddressCombo.Name = "editAddressCombo";
            this.editAddressCombo.Size = new System.Drawing.Size(121, 24);
            this.editAddressCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an Address to Edit";
            // 
            // OkEditAddress
            // 
            this.OkEditAddress.Location = new System.Drawing.Point(71, 187);
            this.OkEditAddress.Name = "OkEditAddress";
            this.OkEditAddress.Size = new System.Drawing.Size(124, 44);
            this.OkEditAddress.TabIndex = 2;
            this.OkEditAddress.Text = "Edit";
            this.OkEditAddress.UseVisualStyleBackColor = true;
            this.OkEditAddress.Click += new System.EventHandler(this.OkEditAddress_Click);
            // 
            // CancelEditAddress
            // 
            this.CancelEditAddress.Location = new System.Drawing.Point(252, 187);
            this.CancelEditAddress.Name = "CancelEditAddress";
            this.CancelEditAddress.Size = new System.Drawing.Size(115, 44);
            this.CancelEditAddress.TabIndex = 3;
            this.CancelEditAddress.Text = "Cancel";
            this.CancelEditAddress.UseVisualStyleBackColor = true;
            this.CancelEditAddress.Click += new System.EventHandler(this.CancelEditAddress_Click);
            // 
            // EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 255);
            this.Controls.Add(this.CancelEditAddress);
            this.Controls.Add(this.OkEditAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editAddressCombo);
            this.Name = "EditAddress";
            this.Text = "Edit Address";
            this.Load += new System.EventHandler(this.EditAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox editAddressCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkEditAddress;
        private System.Windows.Forms.Button CancelEditAddress;
    }
}