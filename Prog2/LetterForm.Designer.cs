namespace UPVApp
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.originLbl = new System.Windows.Forms.Label();
            this.destLbl = new System.Windows.Forms.Label();
            this.originAddCbo = new System.Windows.Forms.ComboBox();
            this.costLbl = new System.Windows.Forms.Label();
            this.destAddCbo = new System.Windows.Forms.ComboBox();
            this.fixedCostTxt = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originLbl
            // 
            this.originLbl.AutoSize = true;
            this.originLbl.Location = new System.Drawing.Point(52, 11);
            this.originLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originLbl.Name = "originLbl";
            this.originLbl.Size = new System.Drawing.Size(106, 17);
            this.originLbl.TabIndex = 0;
            this.originLbl.Text = "Origin Address:";
            // 
            // destLbl
            // 
            this.destLbl.AutoSize = true;
            this.destLbl.Location = new System.Drawing.Point(17, 52);
            this.destLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destLbl.Name = "destLbl";
            this.destLbl.Size = new System.Drawing.Size(139, 17);
            this.destLbl.TabIndex = 1;
            this.destLbl.Text = "Destination Address:";
            // 
            // originAddCbo
            // 
            this.originAddCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddCbo.FormattingEnabled = true;
            this.originAddCbo.Location = new System.Drawing.Point(164, 7);
            this.originAddCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.originAddCbo.Name = "originAddCbo";
            this.originAddCbo.Size = new System.Drawing.Size(160, 24);
            this.originAddCbo.TabIndex = 2;
            this.originAddCbo.Validating += new System.ComponentModel.CancelEventHandler(this.addressCbo_Validating);
            this.originAddCbo.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(77, 84);
            this.costLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(77, 17);
            this.costLbl.TabIndex = 3;
            this.costLbl.Text = "Fixed Cost:";
            // 
            // destAddCbo
            // 
            this.destAddCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destAddCbo.FormattingEnabled = true;
            this.destAddCbo.Location = new System.Drawing.Point(164, 48);
            this.destAddCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destAddCbo.Name = "destAddCbo";
            this.destAddCbo.Size = new System.Drawing.Size(160, 24);
            this.destAddCbo.TabIndex = 4;
            this.destAddCbo.Validating += new System.ComponentModel.CancelEventHandler(this.addressCbo_Validating);
            this.destAddCbo.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // fixedCostTxt
            // 
            this.fixedCostTxt.Location = new System.Drawing.Point(164, 80);
            this.fixedCostTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fixedCostTxt.Name = "fixedCostTxt";
            this.fixedCostTxt.Size = new System.Drawing.Size(160, 22);
            this.fixedCostTxt.TabIndex = 5;
            this.fixedCostTxt.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTxt_Validating);
            this.fixedCostTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(21, 134);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(100, 28);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(225, 134);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(352, 183);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.fixedCostTxt);
            this.Controls.Add(this.destAddCbo);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.originAddCbo);
            this.Controls.Add(this.destLbl);
            this.Controls.Add(this.originLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LetterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Letter";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLbl;
        private System.Windows.Forms.Label destLbl;
        private System.Windows.Forms.ComboBox originAddCbo;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.ComboBox destAddCbo;
        private System.Windows.Forms.TextBox fixedCostTxt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}