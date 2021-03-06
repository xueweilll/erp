﻿namespace CZZD.ERP.Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.Panel();
            this.menuMain_right = new System.Windows.Forms.Panel();
            this.menuMain_fill = new System.Windows.Forms.Panel();
            this.menuNotify = new System.Windows.Forms.Button();
            this.menuUserRoles = new System.Windows.Forms.Button();
            this.menuImportManage = new System.Windows.Forms.Button();
            this.menuMasterManage = new System.Windows.Forms.Button();
            this.menuInvoiceManage = new System.Windows.Forms.Button();
            this.menuStockManage = new System.Windows.Forms.Button();
            this.menuFinanceManage = new System.Windows.Forms.Button();
            this.menuPurchaseManage = new System.Windows.Forms.Button();
            this.menuDesk = new System.Windows.Forms.Button();
            this.menuSalesManage = new System.Windows.Forms.Button();
            this.menuMain_top = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mdiTabStrip1 = new MdiTabStrip.MdiTabStrip();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseCurrentWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAllWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperationManual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenuTop = new System.Windows.Forms.ToolStripMenuItem();
            this.showMenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.menuMain_fill.SuspendLayout();
            this.menuMain_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabStrip1)).BeginInit();
            this.menuTop.SuspendLayout();
            this.cmsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.Transparent;
            this.menuMain.Controls.Add(this.menuMain_right);
            this.menuMain.Controls.Add(this.menuMain_fill);
            this.menuMain.Controls.Add(this.menuMain_top);
            this.menuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMain.Location = new System.Drawing.Point(0, 35);
            this.menuMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(183, 695);
            this.menuMain.TabIndex = 2;
            // 
            // menuMain_right
            // 
            this.menuMain_right.BackColor = System.Drawing.Color.Transparent;
            this.menuMain_right.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.line;
            this.menuMain_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuMain_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuMain_right.Location = new System.Drawing.Point(178, 82);
            this.menuMain_right.Name = "menuMain_right";
            this.menuMain_right.Size = new System.Drawing.Size(5, 613);
            this.menuMain_right.TabIndex = 1;
            // 
            // menuMain_fill
            // 
            this.menuMain_fill.BackColor = System.Drawing.Color.Transparent;
            this.menuMain_fill.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.lefttop;
            this.menuMain_fill.Controls.Add(this.menuNotify);
            this.menuMain_fill.Controls.Add(this.menuUserRoles);
            this.menuMain_fill.Controls.Add(this.menuImportManage);
            this.menuMain_fill.Controls.Add(this.menuMasterManage);
            this.menuMain_fill.Controls.Add(this.menuInvoiceManage);
            this.menuMain_fill.Controls.Add(this.menuStockManage);
            this.menuMain_fill.Controls.Add(this.menuFinanceManage);
            this.menuMain_fill.Controls.Add(this.menuPurchaseManage);
            this.menuMain_fill.Controls.Add(this.menuDesk);
            this.menuMain_fill.Controls.Add(this.menuSalesManage);
            this.menuMain_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuMain_fill.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.menuMain_fill.Location = new System.Drawing.Point(0, 82);
            this.menuMain_fill.Name = "menuMain_fill";
            this.menuMain_fill.Size = new System.Drawing.Size(183, 613);
            this.menuMain_fill.TabIndex = 0;
            // 
            // menuNotify
            // 
            this.menuNotify.BackColor = System.Drawing.Color.Transparent;
            this.menuNotify.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.buttonup;
            this.menuNotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuNotify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuNotify.FlatAppearance.BorderSize = 0;
            this.menuNotify.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuNotify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuNotify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuNotify.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuNotify.Location = new System.Drawing.Point(1, 407);
            this.menuNotify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuNotify.Name = "menuNotify";
            this.menuNotify.Size = new System.Drawing.Size(175, 43);
            this.menuNotify.TabIndex = 0;
            this.menuNotify.Text = "提醒服务";
            this.menuNotify.UseVisualStyleBackColor = false;
            this.menuNotify.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuUserRoles
            // 
            this.menuUserRoles.BackColor = System.Drawing.Color.Transparent;
            this.menuUserRoles.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.buttonup;
            this.menuUserRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuUserRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuUserRoles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuUserRoles.FlatAppearance.BorderSize = 0;
            this.menuUserRoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuUserRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuUserRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuUserRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuUserRoles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuUserRoles.Location = new System.Drawing.Point(1, 362);
            this.menuUserRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuUserRoles.Name = "menuUserRoles";
            this.menuUserRoles.Size = new System.Drawing.Size(175, 43);
            this.menuUserRoles.TabIndex = 0;
            this.menuUserRoles.Text = "用户权限";
            this.menuUserRoles.UseVisualStyleBackColor = false;
            this.menuUserRoles.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuImportManage
            // 
            this.menuImportManage.BackColor = System.Drawing.Color.Transparent;
            this.menuImportManage.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.buttonup;
            this.menuImportManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuImportManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuImportManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuImportManage.FlatAppearance.BorderSize = 0;
            this.menuImportManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuImportManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuImportManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuImportManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuImportManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuImportManage.Location = new System.Drawing.Point(1, 272);
            this.menuImportManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuImportManage.Name = "menuImportManage";
            this.menuImportManage.Size = new System.Drawing.Size(175, 43);
            this.menuImportManage.TabIndex = 7;
            this.menuImportManage.Text = "数据导入";
            this.menuImportManage.UseVisualStyleBackColor = false;
            this.menuImportManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuMasterManage
            // 
            this.menuMasterManage.BackColor = System.Drawing.Color.Transparent;
            this.menuMasterManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuMasterManage.BackgroundImage")));
            this.menuMasterManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuMasterManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuMasterManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuMasterManage.FlatAppearance.BorderSize = 0;
            this.menuMasterManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuMasterManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuMasterManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuMasterManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMasterManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuMasterManage.Location = new System.Drawing.Point(1, 317);
            this.menuMasterManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuMasterManage.Name = "menuMasterManage";
            this.menuMasterManage.Size = new System.Drawing.Size(175, 43);
            this.menuMasterManage.TabIndex = 6;
            this.menuMasterManage.Text = "基础数据";
            this.menuMasterManage.UseVisualStyleBackColor = false;
            this.menuMasterManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuInvoiceManage
            // 
            this.menuInvoiceManage.BackColor = System.Drawing.Color.Transparent;
            this.menuInvoiceManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuInvoiceManage.BackgroundImage")));
            this.menuInvoiceManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuInvoiceManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuInvoiceManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuInvoiceManage.FlatAppearance.BorderSize = 0;
            this.menuInvoiceManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuInvoiceManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuInvoiceManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuInvoiceManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuInvoiceManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuInvoiceManage.Location = new System.Drawing.Point(1, 227);
            this.menuInvoiceManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuInvoiceManage.Name = "menuInvoiceManage";
            this.menuInvoiceManage.Size = new System.Drawing.Size(175, 43);
            this.menuInvoiceManage.TabIndex = 5;
            this.menuInvoiceManage.Text = "报　　表";
            this.menuInvoiceManage.UseVisualStyleBackColor = false;
            this.menuInvoiceManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuStockManage
            // 
            this.menuStockManage.BackColor = System.Drawing.Color.Transparent;
            this.menuStockManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStockManage.BackgroundImage")));
            this.menuStockManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStockManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStockManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuStockManage.FlatAppearance.BorderSize = 0;
            this.menuStockManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuStockManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuStockManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuStockManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuStockManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuStockManage.Location = new System.Drawing.Point(1, 182);
            this.menuStockManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuStockManage.Name = "menuStockManage";
            this.menuStockManage.Size = new System.Drawing.Size(175, 43);
            this.menuStockManage.TabIndex = 4;
            this.menuStockManage.Text = "仓库管理";
            this.menuStockManage.UseVisualStyleBackColor = false;
            this.menuStockManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuFinanceManage
            // 
            this.menuFinanceManage.BackColor = System.Drawing.Color.Transparent;
            this.menuFinanceManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuFinanceManage.BackgroundImage")));
            this.menuFinanceManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuFinanceManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuFinanceManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuFinanceManage.FlatAppearance.BorderSize = 0;
            this.menuFinanceManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuFinanceManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuFinanceManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuFinanceManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuFinanceManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuFinanceManage.Location = new System.Drawing.Point(1, 137);
            this.menuFinanceManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuFinanceManage.Name = "menuFinanceManage";
            this.menuFinanceManage.Size = new System.Drawing.Size(175, 43);
            this.menuFinanceManage.TabIndex = 3;
            this.menuFinanceManage.Text = "财务管理";
            this.menuFinanceManage.UseVisualStyleBackColor = false;
            this.menuFinanceManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuPurchaseManage
            // 
            this.menuPurchaseManage.BackColor = System.Drawing.Color.Transparent;
            this.menuPurchaseManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPurchaseManage.BackgroundImage")));
            this.menuPurchaseManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPurchaseManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPurchaseManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuPurchaseManage.FlatAppearance.BorderSize = 0;
            this.menuPurchaseManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuPurchaseManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuPurchaseManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuPurchaseManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuPurchaseManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuPurchaseManage.Location = new System.Drawing.Point(1, 92);
            this.menuPurchaseManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPurchaseManage.Name = "menuPurchaseManage";
            this.menuPurchaseManage.Size = new System.Drawing.Size(175, 43);
            this.menuPurchaseManage.TabIndex = 2;
            this.menuPurchaseManage.Text = "采购管理";
            this.menuPurchaseManage.UseVisualStyleBackColor = false;
            this.menuPurchaseManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuDesk
            // 
            this.menuDesk.BackColor = System.Drawing.Color.Transparent;
            this.menuDesk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuDesk.BackgroundImage")));
            this.menuDesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuDesk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDesk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuDesk.FlatAppearance.BorderSize = 0;
            this.menuDesk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuDesk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuDesk.Location = new System.Drawing.Point(1, 2);
            this.menuDesk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuDesk.Name = "menuDesk";
            this.menuDesk.Size = new System.Drawing.Size(175, 43);
            this.menuDesk.TabIndex = 1;
            this.menuDesk.Text = "我的桌面";
            this.menuDesk.UseVisualStyleBackColor = false;
            this.menuDesk.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuSalesManage
            // 
            this.menuSalesManage.BackColor = System.Drawing.Color.Transparent;
            this.menuSalesManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuSalesManage.BackgroundImage")));
            this.menuSalesManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSalesManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSalesManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuSalesManage.FlatAppearance.BorderSize = 0;
            this.menuSalesManage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menuSalesManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuSalesManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuSalesManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSalesManage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuSalesManage.Location = new System.Drawing.Point(1, 47);
            this.menuSalesManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuSalesManage.Name = "menuSalesManage";
            this.menuSalesManage.Size = new System.Drawing.Size(175, 43);
            this.menuSalesManage.TabIndex = 1;
            this.menuSalesManage.Text = "销售管理";
            this.menuSalesManage.UseVisualStyleBackColor = false;
            this.menuSalesManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuMain_top
            // 
            this.menuMain_top.BackColor = System.Drawing.SystemColors.Control;
            this.menuMain_top.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.lefttop;
            this.menuMain_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuMain_top.Controls.Add(this.lblCompanyName);
            this.menuMain_top.Controls.Add(this.lblDepartmentName);
            this.menuMain_top.Controls.Add(this.lblUserName);
            this.menuMain_top.Controls.Add(this.label3);
            this.menuMain_top.Controls.Add(this.label2);
            this.menuMain_top.Controls.Add(this.label1);
            this.menuMain_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuMain_top.Location = new System.Drawing.Point(0, 0);
            this.menuMain_top.Name = "menuMain_top";
            this.menuMain_top.Size = new System.Drawing.Size(183, 82);
            this.menuMain_top.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblCompanyName.Location = new System.Drawing.Point(68, 57);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(0, 20);
            this.lblCompanyName.TabIndex = 0;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblDepartmentName.Location = new System.Drawing.Point(68, 32);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(0, 20);
            this.lblDepartmentName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblUserName.Location = new System.Drawing.Point(68, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 20);
            this.lblUserName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "公　司：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "部　门：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "担当者：";
            // 
            // mdiTabStrip1
            // 
            this.mdiTabStrip1.ActiveTabColor = System.Drawing.SystemColors.ActiveCaption;
            this.mdiTabStrip1.ActiveTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mdiTabStrip1.AllowDrop = true;
            this.mdiTabStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.mdiTabStrip1.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.top02;
            this.mdiTabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdiTabStrip1.ForeColor = System.Drawing.Color.Black;
            this.mdiTabStrip1.InactiveTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mdiTabStrip1.Location = new System.Drawing.Point(183, 35);
            this.mdiTabStrip1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mdiTabStrip1.MdiNewTabImage = null;
            this.mdiTabStrip1.MdiWindowState = MdiTabStrip.MdiChildWindowState.Maximized;
            this.mdiTabStrip1.MinimumSize = new System.Drawing.Size(58, 40);
            this.mdiTabStrip1.MouseOverTabColor = System.Drawing.Color.LightSkyBlue;
            this.mdiTabStrip1.MouseOverTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mdiTabStrip1.Name = "mdiTabStrip1";
            this.mdiTabStrip1.NewTabToolTipText = "New Tab";
            this.mdiTabStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 23, 7);
            this.mdiTabStrip1.Size = new System.Drawing.Size(1025, 40);
            this.mdiTabStrip1.TabIndex = 0;
            this.mdiTabStrip1.Text = "mdiTabStrip1";
            this.mdiTabStrip1.MdiTabRemoved += new MdiTabStrip.MdiTabStrip.MdiTabRemovedEventHandler(this.mdiTabStrip1_MdiTabRemoved);
            // 
            // menuTop
            // 
            this.menuTop.AutoSize = false;
            this.menuTop.BackColor = System.Drawing.Color.Transparent;
            this.menuTop.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.top;
            this.menuTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuTop.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuWindow,
            this.menuTools,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuTop.Size = new System.Drawing.Size(1208, 35);
            this.menuTop.TabIndex = 1;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReLogin,
            this.menuClose});
            this.menuFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(66, 29);
            this.menuFile.Text = "退出(&F)";
            // 
            // menuReLogin
            // 
            this.menuReLogin.Name = "menuReLogin";
            this.menuReLogin.Size = new System.Drawing.Size(134, 24);
            this.menuReLogin.Text = "重新登录";
            this.menuReLogin.Click += new System.EventHandler(this.menuReLogin_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(134, 24);
            this.menuClose.Text = "退　　出";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCloseCurrentWindow,
            this.menuCloseAllWindow});
            this.menuWindow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(73, 29);
            this.menuWindow.Text = "窗口(&W)";
            // 
            // menuCloseCurrentWindow
            // 
            this.menuCloseCurrentWindow.Name = "menuCloseCurrentWindow";
            this.menuCloseCurrentWindow.Size = new System.Drawing.Size(162, 24);
            this.menuCloseCurrentWindow.Text = "关闭当前窗口";
            this.menuCloseCurrentWindow.Click += new System.EventHandler(this.menuCloseCurrentWindow_Click);
            // 
            // menuCloseAllWindow
            // 
            this.menuCloseAllWindow.Name = "menuCloseAllWindow";
            this.menuCloseAllWindow.Size = new System.Drawing.Size(162, 24);
            this.menuCloseAllWindow.Text = "关闭所有窗口";
            this.menuCloseAllWindow.Click += new System.EventHandler(this.menuCloseAllWindow_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPwd,
            this.menuDB});
            this.menuTools.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(67, 29);
            this.menuTools.Text = "工具(&T)";
            // 
            // menuPwd
            // 
            this.menuPwd.Name = "menuPwd";
            this.menuPwd.Size = new System.Drawing.Size(148, 24);
            this.menuPwd.Text = "修改密码";
            this.menuPwd.Click += new System.EventHandler(this.menuPwd_Click);
            // 
            // menuDB
            // 
            this.menuDB.Name = "menuDB";
            this.menuDB.Size = new System.Drawing.Size(148, 24);
            this.menuDB.Text = "数据库配置";
            this.menuDB.Click += new System.EventHandler(this.menuDB_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOperationManual,
            this.menuUpdate,
            this.menuAbout});
            this.menuHelp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(70, 29);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuOperationManual
            // 
            this.menuOperationManual.Name = "menuOperationManual";
            this.menuOperationManual.Size = new System.Drawing.Size(134, 24);
            this.menuOperationManual.Text = "操作手册";
            this.menuOperationManual.Click += new System.EventHandler(this.menuOperationManual_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(134, 24);
            this.menuUpdate.Text = "检查更新";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(134, 24);
            this.menuAbout.Text = "关于";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.BalloonTipClosed += new System.EventHandler(this.notify_BalloonTipClosed);
            this.notify.BalloonTipClicked += new System.EventHandler(this.notify_BalloonTipClicked);
            // 
            // cmsTools
            // 
            this.cmsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuTop,
            this.showMenuMain});
            this.cmsTools.Name = "cmsTools";
            this.cmsTools.Size = new System.Drawing.Size(190, 74);
            this.cmsTools.Text = "显示/隐藏左侧菜单栏";
            // 
            // showMenuTop
            // 
            this.showMenuTop.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.showMenuTop.Name = "showMenuTop";
            this.showMenuTop.Size = new System.Drawing.Size(189, 24);
            this.showMenuTop.Text = "显示/隐藏菜单栏";
            this.showMenuTop.Click += new System.EventHandler(this.showMenuTop_Click);
            // 
            // showMenuMain
            // 
            this.showMenuMain.Name = "showMenuMain";
            this.showMenuMain.Size = new System.Drawing.Size(189, 24);
            this.showMenuMain.Text = "显示/隐藏左侧菜单栏";
            this.showMenuMain.Click += new System.EventHandler(this.showMenuMain_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.BackgroundImage = global::CZZD.ERP.Main.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 730);
            this.ContextMenuStrip = this.cmsTools;
            this.Controls.Add(this.mdiTabStrip1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.menuTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "泷泽商贸 ERP [V1.0.1]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain_fill.ResumeLayout(false);
            this.menuMain_top.ResumeLayout(false);
            this.menuMain_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabStrip1)).EndInit();
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.cmsTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.Panel menuMain;
        private MdiTabStrip.MdiTabStrip mdiTabStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Button menuImportManage;
        private System.Windows.Forms.Button menuInvoiceManage;
        private System.Windows.Forms.Button menuMasterManage;
        private System.Windows.Forms.Button menuFinanceManage;
        private System.Windows.Forms.Button menuStockManage;
        private System.Windows.Forms.Button menuPurchaseManage;
        private System.Windows.Forms.Button menuSalesManage;
        private System.Windows.Forms.Panel menuMain_right;
        private System.Windows.Forms.Panel menuMain_top;
        private System.Windows.Forms.Panel menuMain_fill;
        private System.Windows.Forms.Button menuUserRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button menuDesk;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.Button menuNotify;
        private System.Windows.Forms.ToolStripMenuItem menuReLogin;
        private System.Windows.Forms.ToolStripMenuItem menuCloseCurrentWindow;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAllWindow;
        private System.Windows.Forms.ToolStripMenuItem menuPwd;
        private System.Windows.Forms.ToolStripMenuItem menuDB;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuOperationManual;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsTools;
        private System.Windows.Forms.ToolStripMenuItem showMenuTop;
        private System.Windows.Forms.ToolStripMenuItem showMenuMain;
    }
}