namespace CheckRibbon
{
    partial class Form1
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
            this.check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteresource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addresource = new System.Windows.Forms.Button();
            this.resourcefiles = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonfile = new System.Windows.Forms.TextBox();
            this.browseribbon = new System.Windows.Forms.Button();
            this.showwarnings = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(537, 202);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 20);
            this.check.TabIndex = 0;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.deleteresource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addresource);
            this.groupBox1.Controls.Add(this.resourcefiles);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deleteresource
            // 
            this.deleteresource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteresource.Location = new System.Drawing.Point(409, 107);
            this.deleteresource.Name = "deleteresource";
            this.deleteresource.Size = new System.Drawing.Size(90, 20);
            this.deleteresource.TabIndex = 3;
            this.deleteresource.Text = "Delete";
            this.deleteresource.UseVisualStyleBackColor = true;
            this.deleteresource.Click += new System.EventHandler(this.deleteresource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Don\'t forget to include resource.h and afxres.h";
            // 
            // addresource
            // 
            this.addresource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addresource.Location = new System.Drawing.Point(501, 107);
            this.addresource.Name = "addresource";
            this.addresource.Size = new System.Drawing.Size(90, 20);
            this.addresource.TabIndex = 1;
            this.addresource.Text = "Add";
            this.addresource.UseVisualStyleBackColor = true;
            this.addresource.Click += new System.EventHandler(this.addresource_Click);
            // 
            // resourcefiles
            // 
            this.resourcefiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourcefiles.FormattingEnabled = true;
            this.resourcefiles.Location = new System.Drawing.Point(14, 19);
            this.resourcefiles.Name = "resourcefiles";
            this.resourcefiles.Size = new System.Drawing.Size(577, 82);
            this.resourcefiles.TabIndex = 0;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(21, 252);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(591, 199);
            this.status.TabIndex = 2;
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ribbon XM:";
            // 
            // ribbonfile
            // 
            this.ribbonfile.Location = new System.Drawing.Point(21, 202);
            this.ribbonfile.Name = "ribbonfile";
            this.ribbonfile.Size = new System.Drawing.Size(477, 20);
            this.ribbonfile.TabIndex = 4;
            // 
            // browseribbon
            // 
            this.browseribbon.Location = new System.Drawing.Point(504, 202);
            this.browseribbon.Name = "browseribbon";
            this.browseribbon.Size = new System.Drawing.Size(24, 20);
            this.browseribbon.TabIndex = 5;
            this.browseribbon.Text = "...";
            this.browseribbon.UseVisualStyleBackColor = true;
            this.browseribbon.Click += new System.EventHandler(this.browseribbon_Click);
            // 
            // showwarnings
            // 
            this.showwarnings.AutoSize = true;
            this.showwarnings.Location = new System.Drawing.Point(23, 227);
            this.showwarnings.Name = "showwarnings";
            this.showwarnings.Size = new System.Drawing.Size(101, 17);
            this.showwarnings.TabIndex = 6;
            this.showwarnings.Text = "Show Warnings";
            this.showwarnings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 463);
            this.Controls.Add(this.showwarnings);
            this.Controls.Add(this.browseribbon);
            this.Controls.Add(this.ribbonfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.check);
            this.Name = "Form1";
            this.Text = "BCG Ribbon XML Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addresource;
        private System.Windows.Forms.ListBox resourcefiles;
        private System.Windows.Forms.ListBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ribbonfile;
        private System.Windows.Forms.Button browseribbon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteresource;
        private System.Windows.Forms.CheckBox showwarnings;
    }
}

