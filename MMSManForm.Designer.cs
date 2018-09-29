namespace MMSMan
{
    partial class MMSManForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.m_ebInFile = new System.Windows.Forms.TextBox();
            this.m_ebOutfile = new System.Windows.Forms.TextBox();
            this.m_cbInType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_lbMessages = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 13);
            label1.TabIndex = 0;
            label1.Text = "Input File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 1;
            label2.Text = "Output File";
            // 
            // m_ebInFile
            // 
            this.m_ebInFile.Location = new System.Drawing.Point(69, 10);
            this.m_ebInFile.Name = "m_ebInFile";
            this.m_ebInFile.Size = new System.Drawing.Size(186, 20);
            this.m_ebInFile.TabIndex = 2;
            // 
            // m_ebOutfile
            // 
            this.m_ebOutfile.Location = new System.Drawing.Point(69, 33);
            this.m_ebOutfile.Name = "m_ebOutfile";
            this.m_ebOutfile.Size = new System.Drawing.Size(186, 20);
            this.m_ebOutfile.TabIndex = 3;
            // 
            // m_cbInType
            // 
            this.m_cbInType.FormattingEnabled = true;
            this.m_cbInType.Items.AddRange(new object[] {
            "WP SMS Backup",
            "WP MMS Backup",
            "Syntech Message Backup"});
            this.m_cbInType.Location = new System.Drawing.Point(280, 9);
            this.m_cbInType.Name = "m_cbInType";
            this.m_cbInType.Size = new System.Drawing.Size(121, 21);
            this.m_cbInType.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(482, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(482, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // m_lbMessages
            // 
            this.m_lbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lbMessages.FormattingEnabled = true;
            this.m_lbMessages.Location = new System.Drawing.Point(13, 90);
            this.m_lbMessages.Name = "m_lbMessages";
            this.m_lbMessages.Size = new System.Drawing.Size(544, 303);
            this.m_lbMessages.TabIndex = 7;
            // 
            // MMSMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 467);
            this.Controls.Add(this.m_lbMessages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_cbInType);
            this.Controls.Add(this.m_ebOutfile);
            this.Controls.Add(this.m_ebInFile);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "MMSMan";
            this.Text = "MMS Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_ebInFile;
        private System.Windows.Forms.TextBox m_ebOutfile;
        private System.Windows.Forms.ComboBox m_cbInType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox m_lbMessages;
    }
}

