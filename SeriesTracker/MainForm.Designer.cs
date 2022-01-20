namespace SeriesTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.itemsTable = new System.Windows.Forms.TableLayoutPanel();
            this.filterList = new System.Windows.Forms.ListBox();
            this.filterContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFilterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.libraryUserControl1 = new SeriesTracker.LibraryUserControl();
            this.listFlowPnl.SuspendLayout();
            this.filterContextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.listFlowPnl.Location = new System.Drawing.Point(6, 36);
            this.listFlowPnl.Name = "listFlowPnl";
            this.listFlowPnl.Size = new System.Drawing.Size(1002, 637);
            this.listFlowPnl.TabIndex = 0;
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
            // filterList
            // 
            this.filterList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterList.ContextMenuStrip = this.filterContextMenu;
            this.filterList.FormattingEnabled = true;
            this.filterList.ItemHeight = 15;
            this.filterList.Location = new System.Drawing.Point(1014, 76);
            this.filterList.Name = "filterList";
            this.filterList.Size = new System.Drawing.Size(217, 559);
            this.filterList.TabIndex = 1;
            this.filterList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterList_KeyUp);
            // 
            // filterContextMenu
            // 
            this.filterContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFilterItem});
            this.filterContextMenu.Name = "filterContextMenu";
            this.filterContextMenu.Size = new System.Drawing.Size(165, 26);
            // 
            // removeFilterItem
            // 
            this.removeFilterItem.Name = "removeFilterItem";
            this.removeFilterItem.Size = new System.Drawing.Size(164, 22);
            this.removeFilterItem.Text = "Remove Selected";
            this.removeFilterItem.Click += new System.EventHandler(this.removeFilterItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Episoade Recente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtre";
            // 
            // filterTxt
            // 
            this.filterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTxt.Location = new System.Drawing.Point(1014, 36);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(151, 23);
            this.filterTxt.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(1171, 36);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(60, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(106, 7);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(60, 23);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rezolutie";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "720p",
            "1080p"});
            this.comboBox1.Location = new System.Drawing.Point(233, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(1171, 648);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(60, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 707);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listFlowPnl);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.saveBtn);
            this.tabPage2.Controls.Add(this.refreshBtn);
            this.tabPage2.Controls.Add(this.addBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.filterTxt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.filterList);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1243, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Torrents";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.libraryUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1243, 654);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Library";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // libraryUserControl1
            // 
            this.libraryUserControl1.Config = null;
            this.libraryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryUserControl1.Location = new System.Drawing.Point(3, 3);
            this.libraryUserControl1.Name = "libraryUserControl1";
            this.libraryUserControl1.Size = new System.Drawing.Size(1237, 648);
            this.libraryUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 731);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Series Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.listFlowPnl.ResumeLayout(false);
            this.listFlowPnl.PerformLayout();
            this.filterContextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel listFlowPnl;
        private ListBox filterList;
        private Label label1;
        private Label label2;
        private ContextMenuStrip filterContextMenu;
        private ToolStripMenuItem removeFilterItem;
        private TextBox filterTxt;
        private Button addBtn;
        private Button refreshBtn;
        private TableLayoutPanel itemsTable;
        private Label label3;
        private ComboBox comboBox1;
        private Button saveBtn;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private LibraryUserControl libraryUserControl1;
    }
}