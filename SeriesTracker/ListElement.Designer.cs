namespace SeriesTracker
{
    partial class ListElement
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
            this.components = new System.ComponentModel.Container();
            this.titleLbl = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.titleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sizeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(65, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "label1";
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBtn.Location = new System.Drawing.Point(643, 38);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(100, 30);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // sizeLbl
            // 
            this.sizeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Location = new System.Drawing.Point(643, 20);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(38, 15);
            this.sizeLbl.TabIndex = 2;
            this.sizeLbl.Text = "label1";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLbl.Location = new System.Drawing.Point(3, 57);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(40, 15);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "label1";
            // 
            // ListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "ListElement";
            this.Size = new System.Drawing.Size(748, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLbl;
        private Button downloadBtn;
        private ToolTip titleToolTip;
        private Label sizeLbl;
        private Label dateLbl;
    }
}
