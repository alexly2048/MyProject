namespace FileManagement.UI
{
    partial class FrmMain
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
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barItemUserId = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barItemUserName = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barContract = new DevExpress.XtraBars.BarSubItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemQM = new DevExpress.XtraNavBar.NavBarItem();
            this.itemCourse = new DevExpress.XtraNavBar.NavBarItem();
            this.itemGrade = new DevExpress.XtraNavBar.NavBarItem();
            this.itemExamBank = new DevExpress.XtraNavBar.NavBarItem();
            this.itemUserExam = new DevExpress.XtraNavBar.NavBarItem();
            this.itemSelectExam = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup8 = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemUserManagement = new DevExpress.XtraNavBar.NavBarItem();
            this.itemAuthorities = new DevExpress.XtraNavBar.NavBarItem();
            this.itemContract = new DevExpress.XtraNavBar.NavBarItem();
            this.itemSubConstructionCost = new DevExpress.XtraNavBar.NavBarItem();
            this.itemStartOperation = new DevExpress.XtraNavBar.NavBarItem();
            this.itemProcessMaterial = new DevExpress.XtraNavBar.NavBarItem();
            this.itemASupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.itemBSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.itemCompletionMaterial = new DevExpress.XtraNavBar.NavBarItem();
            this.itemArchiveMaterial = new DevExpress.XtraNavBar.NavBarItem();
            this.itemConstructionCost = new DevExpress.XtraNavBar.NavBarItem();
            this.itemUserMaterial = new DevExpress.XtraNavBar.NavBarItem();
            this.itemMaterialCost = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.MenuManager = this.barManager;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockManager = this.dockManager;
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barContract,
            this.barHeaderItem1,
            this.barStaticItem1,
            this.barItemUserId,
            this.barStaticItem2,
            this.barItemUserName});
            this.barManager.MaxItemId = 7;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 2";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemUserId),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barItemUserName)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "用户ID:";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barItemUserId
            // 
            this.barItemUserId.Caption = "barItemUserID";
            this.barItemUserId.Id = 4;
            this.barItemUserId.Name = "barItemUserId";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "用户名：";
            this.barStaticItem2.Id = 5;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barItemUserName
            // 
            this.barItemUserName.Caption = "barStaticItem3";
            this.barItemUserName.Id = 6;
            this.barItemUserName.Name = "barItemUserName";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(811, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(811, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(811, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "基本信息";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barContract)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barContract
            // 
            this.barContract.Caption = "合同文件管理";
            this.barContract.Id = 1;
            this.barContract.Name = "barContract";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "用户ID:";
            this.barHeaderItem1.Id = 2;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 3";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.AllowDrop = false;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup8,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.itemContract,
            this.itemSubConstructionCost,
            this.itemStartOperation,
            this.itemProcessMaterial,
            this.itemASupplier,
            this.itemBSupplier,
            this.itemCompletionMaterial,
            this.itemArchiveMaterial,
            this.itemConstructionCost,
            this.itemUserMaterial,
            this.itemUserManagement,
            this.itemAuthorities,
            this.itemMaterialCost,
            this.itemQM,
            this.itemCourse,
            this.itemGrade,
            this.itemExamBank,
            this.itemUserExam,
            this.itemSelectExam});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 143;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.ShowGroupHint = false;
            this.navBarControl1.Size = new System.Drawing.Size(143, 444);
            this.navBarControl1.TabIndex = 5;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "试卷系统";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemQM),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemCourse),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemGrade),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemExamBank),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemUserExam),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemSelectExam)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // itemQM
            // 
            this.itemQM.Caption = "题库管理";
            this.itemQM.Name = "itemQM";
            this.itemQM.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemQM_LinkClicked);
            // 
            // itemCourse
            // 
            this.itemCourse.Caption = "科目管理";
            this.itemCourse.Name = "itemCourse";
            this.itemCourse.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemCourse_LinkClicked);
            // 
            // itemGrade
            // 
            this.itemGrade.Caption = "年级管理";
            this.itemGrade.Name = "itemGrade";
            this.itemGrade.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemGrade_LinkClicked);
            // 
            // itemExamBank
            // 
            this.itemExamBank.Caption = "试卷库管理";
            this.itemExamBank.Name = "itemExamBank";
            this.itemExamBank.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemExamBank_LinkClicked);
            // 
            // itemUserExam
            // 
            this.itemUserExam.Caption = "用户考试分配";
            this.itemUserExam.Name = "itemUserExam";
            this.itemUserExam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemUserExam_LinkClicked);
            // 
            // itemSelectExam
            // 
            this.itemSelectExam.Caption = "用户考试";
            this.itemSelectExam.Name = "itemSelectExam";
            this.itemSelectExam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itemSelectExam_LinkClicked);
            // 
            // navBarGroup8
            // 
            this.navBarGroup8.Caption = "系统管理";
            this.navBarGroup8.Expanded = true;
            this.navBarGroup8.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemUserManagement),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemAuthorities)});
            this.navBarGroup8.Name = "navBarGroup8";
            // 
            // itemUserManagement
            // 
            this.itemUserManagement.Caption = "用户管理";
            this.itemUserManagement.Name = "itemUserManagement";
            this.itemUserManagement.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // itemAuthorities
            // 
            this.itemAuthorities.Caption = "权限管理";
            this.itemAuthorities.Name = "itemAuthorities";
            this.itemAuthorities.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem11_LinkClicked);
            // 
            // itemContract
            // 
            this.itemContract.Caption = "合同";
            this.itemContract.Name = "itemContract";
            // 
            // itemSubConstructionCost
            // 
            this.itemSubConstructionCost.Caption = "分包费";
            this.itemSubConstructionCost.Name = "itemSubConstructionCost";
            // 
            // itemStartOperation
            // 
            this.itemStartOperation.Caption = "开工资料";
            this.itemStartOperation.Name = "itemStartOperation";
            // 
            // itemProcessMaterial
            // 
            this.itemProcessMaterial.Caption = "过程资料";
            this.itemProcessMaterial.Name = "itemProcessMaterial";
            // 
            // itemASupplier
            // 
            this.itemASupplier.Caption = "材料-甲方";
            this.itemASupplier.Name = "itemASupplier";
            // 
            // itemBSupplier
            // 
            this.itemBSupplier.Caption = "材料-乙方";
            this.itemBSupplier.Name = "itemBSupplier";
            // 
            // itemCompletionMaterial
            // 
            this.itemCompletionMaterial.Caption = "竣工资料";
            this.itemCompletionMaterial.Name = "itemCompletionMaterial";
            // 
            // itemArchiveMaterial
            // 
            this.itemArchiveMaterial.Caption = "归档资料";
            this.itemArchiveMaterial.Name = "itemArchiveMaterial";
            // 
            // itemConstructionCost
            // 
            this.itemConstructionCost.Caption = "造价";
            this.itemConstructionCost.Name = "itemConstructionCost";
            // 
            // itemUserMaterial
            // 
            this.itemUserMaterial.Caption = "用户资料";
            this.itemUserMaterial.Name = "itemUserMaterial";
            // 
            // itemMaterialCost
            // 
            this.itemMaterialCost.Caption = "材料费";
            this.itemMaterialCost.Name = "itemMaterialCost";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager.Controller = this.barAndDockingController1;
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Custom 2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 468);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MdiChildCaptionFormatString = "{0} - {1}";
            this.Name = "FrmMain";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "考试管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barContract;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraNavBar.NavBarItem itemArchiveMaterial;
        private DevExpress.XtraNavBar.NavBarItem itemContract;
        private DevExpress.XtraNavBar.NavBarItem itemSubConstructionCost;
        private DevExpress.XtraNavBar.NavBarItem itemStartOperation;
        private DevExpress.XtraNavBar.NavBarItem itemProcessMaterial;
        private DevExpress.XtraNavBar.NavBarItem itemASupplier;
        private DevExpress.XtraNavBar.NavBarItem itemBSupplier;
        private DevExpress.XtraNavBar.NavBarItem itemCompletionMaterial;
        private DevExpress.XtraNavBar.NavBarItem itemConstructionCost;
        private DevExpress.XtraNavBar.NavBarItem itemUserMaterial;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup8;
        private DevExpress.XtraNavBar.NavBarItem itemUserManagement;
        private DevExpress.XtraNavBar.NavBarItem itemAuthorities;
        private DevExpress.XtraNavBar.NavBarItem itemMaterialCost;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem itemQM;
        private DevExpress.XtraNavBar.NavBarItem itemCourse;
        private DevExpress.XtraNavBar.NavBarItem itemGrade;
        private DevExpress.XtraNavBar.NavBarItem itemExamBank;
        private DevExpress.XtraNavBar.NavBarItem itemUserExam;
        private DevExpress.XtraNavBar.NavBarItem itemSelectExam;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barItemUserId;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barItemUserName;
    }
}