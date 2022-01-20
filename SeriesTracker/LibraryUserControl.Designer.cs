namespace SeriesTracker
{
    partial class LibraryUserControl
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
            this.listFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.itemsTable = new System.Windows.Forms.TableLayoutPanel();
            this.serialeLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.listFlowPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFlowPnl
            // 
            this.listFlowPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFlowPnl.AutoScroll = true;
            this.listFlowPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listFlowPnl.Controls.Add(this.itemsTable);
            this.listFlowPnl.Location = new System.Drawing.Point(325, 32);
            this.listFlowPnl.Name = "listFlowPnl";
            this.listFlowPnl.Size = new System.Drawing.Size(606, 574);
            this.listFlowPnl.TabIndex = 1;
            // 
            // itemsTable
            // 
            this.itemsTable.AutoSize = true;
            this.itemsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemsTable.ColumnCount = 1;
            this.itemsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.itemsTable.Location = new System.Drawing.Point(3, 3);
            this.itemsTable.Name = "itemsTable";
            this.itemsTable.RowCount = 2;
            this.itemsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemsTable.Size = new System.Drawing.Size(0, 0);
            this.itemsTable.TabIndex = 0;
            // 
            // serialeLb
            // 
            this.serialeLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serialeLb.FormattingEnabled = true;
            this.serialeLb.ItemHeight = 15;
            this.serialeLb.Location = new System.Drawing.Point(3, 32);
            this.serialeLb.Name = "serialeLb";
            this.serialeLb.Size = new System.Drawing.Size(316, 574);
            this.serialeLb.TabIndex = 2;
            this.serialeLb.SelectedIndexChanged += new System.EventHandler(this.serialeLb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seriale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Episoade";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Location = new System.Drawing.Point(856, 5);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // LibraryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialeLb);
            this.Controls.Add(this.listFlowPnl);
            this.Name = "LibraryUserControl";
            this.Size = new System.Drawing.Size(934, 619);
            this.listFlowPnl.ResumeLayout(false);
            this.listFlowPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel listFlowPnl;
        private TableLayoutPanel itemsTable;
        private ListBox serialeLb;
        private Label label1;
        private Label label2;
        private Button refreshBtn;
    }
}
