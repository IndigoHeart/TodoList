namespace TodoList
{
    partial class MainForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.listBox = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.removeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.updateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.closeBtn);
            this.layoutControl1.Controls.Add(this.updateBtn);
            this.layoutControl1.Controls.Add(this.removeBtn);
            this.layoutControl1.Controls.Add(this.addBtn);
            this.layoutControl1.Controls.Add(this.listBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(290, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(290, 268);
            this.Root.TextVisible = false;
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(186, 244);
            this.listBox.StyleController = this.layoutControl1;
            this.listBox.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 248);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(202, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 22);
            this.addBtn.StyleController = this.layoutControl1;
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.addBtn;
            this.layoutControlItem2.Location = new System.Drawing.Point(190, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(202, 38);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(76, 22);
            this.removeBtn.StyleController = this.layoutControl1;
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.removeBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(190, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(202, 64);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 22);
            this.updateBtn.StyleController = this.layoutControl1;
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.updateBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(190, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(202, 234);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(76, 22);
            this.closeBtn.StyleController = this.layoutControl1;
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close App";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.closeBtn;
            this.layoutControlItem5.Location = new System.Drawing.Point(190, 222);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(190, 78);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(80, 144);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ListBoxControl listBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        private DevExpress.XtraEditors.SimpleButton removeBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}