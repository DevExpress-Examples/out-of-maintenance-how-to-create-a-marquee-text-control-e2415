namespace WindowsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMyButtonEdit3 = new WindowsApplication1.RepositoryItemMyButtonEdit();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMyButtonEdit2 = new WindowsApplication1.RepositoryItemMyButtonEdit();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemMyButtonEdit1 = new WindowsApplication1.RepositoryItemMyButtonEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.barEditItem2,
            this.barStaticItem1,
            this.barStaticItem2});
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMyButtonEdit1,
            this.repositoryItemMyButtonEdit2,
            this.repositoryItemMyButtonEdit3});
            this.barManager1.StatusBar = this.bar3;
            this.barManager1.TransparentEditors = true;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.barEditItem2, "", false, true, true, 269)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Weather";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barEditItem2.Appearance.Options.UseFont = true;
            this.barEditItem2.AutoFillWidth = true;
            this.barEditItem2.CanOpenEdit = false;
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemMyButtonEdit3;
            this.barEditItem2.Id = 2;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemMyButtonEdit3
            // 
            this.repositoryItemMyButtonEdit3.AllowFocused = false;
            this.repositoryItemMyButtonEdit3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemMyButtonEdit3.Appearance.Options.UseFont = true;
            this.repositoryItemMyButtonEdit3.AutoHeight = false;
            this.repositoryItemMyButtonEdit3.Name = "repositoryItemMyButtonEdit3";
            this.repositoryItemMyButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemMyButtonEdit3.TextToScroll = null;
            this.repositoryItemMyButtonEdit3.UseParentBackground = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(437, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 176);
            this.barDockControlBottom.Size = new System.Drawing.Size(437, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 176);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(437, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 176);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemMyButtonEdit2;
            this.barEditItem1.EditValue = 6;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemMyButtonEdit2
            // 
            this.repositoryItemMyButtonEdit2.AutoHeight = false;
            this.repositoryItemMyButtonEdit2.Name = "repositoryItemMyButtonEdit2";
            this.repositoryItemMyButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemMyButtonEdit2.TextToScroll = "Hello";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "label";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // repositoryItemMyButtonEdit1
            // 
            this.repositoryItemMyButtonEdit1.AutoHeight = false;
            this.repositoryItemMyButtonEdit1.Name = "repositoryItemMyButtonEdit1";
            this.repositoryItemMyButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemMyButtonEdit1.TextToScroll = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 204);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private RepositoryItemMyButtonEdit repositoryItemMyButtonEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private RepositoryItemMyButtonEdit repositoryItemMyButtonEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private RepositoryItemMyButtonEdit repositoryItemMyButtonEdit3;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}

