namespace Car_Parking_System
{
    partial class CarParkingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarParkingSystem));
            this.entrancePanel = new System.Windows.Forms.Panel();
            this.entranceHelpBtn = new System.Windows.Forms.Button();
            this.entranceTakeTicketBtn = new System.Windows.Forms.Button();
            this.entranceDisplay = new System.Windows.Forms.TextBox();
            this.payMachinePanel = new System.Windows.Forms.Panel();
            this.payMachineExitGateBtn = new System.Windows.Forms.Button();
            this.payMachineAdminBtn = new System.Windows.Forms.Button();
            this.payMachineInsertTicketBtn = new System.Windows.Forms.Button();
            this.btnRM10 = new System.Windows.Forms.Button();
            this.btnRM5 = new System.Windows.Forms.Button();
            this.payMachineHelpBtn = new System.Windows.Forms.Button();
            this.btnRM1 = new System.Windows.Forms.Button();
            this.payMachineDisplay = new System.Windows.Forms.TextBox();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.exitPayMachineBtn = new System.Windows.Forms.Button();
            this.exitInsertTicketBtn = new System.Windows.Forms.Button();
            this.exitHelpBtn = new System.Windows.Forms.Button();
            this.exitDisplay = new System.Windows.Forms.TextBox();
            this.AdminLoginPanel = new System.Windows.Forms.Panel();
            this.loginLbl = new System.Windows.Forms.Label();
            this.adminLoginHelpBtn = new System.Windows.Forms.Button();
            this.PWTxt = new System.Windows.Forms.TextBox();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.LoginBanner = new System.Windows.Forms.Label();
            this.adminCancelBtn = new System.Windows.Forms.Button();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.adminChgRateTxt = new System.Windows.Forms.TextBox();
            this.adminRateTxt = new System.Windows.Forms.TextBox();
            this.adminRevenueTxt = new System.Windows.Forms.TextBox();
            this.curentRatelbl = new System.Windows.Forms.Label();
            this.changeRatelbl = new System.Windows.Forms.Label();
            this.revenueLbl = new System.Windows.Forms.Label();
            this.adminPageCancelBtn = new System.Windows.Forms.Button();
            this.adminPageOKBtn = new System.Windows.Forms.Button();
            this.choicePanel = new System.Windows.Forms.Panel();
            this.choiceLbl = new System.Windows.Forms.Label();
            this.goPayMachineBtn = new System.Windows.Forms.Button();
            this.goExitGateBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingDatabaseDataSet = new Car_Parking_System.ParkingDatabaseDataSet();
            this.ticketTableAdapter = new Car_Parking_System.ParkingDatabaseDataSetTableAdapters.TicketTableAdapter();
            this.tableAdapterManager = new Car_Parking_System.ParkingDatabaseDataSetTableAdapters.TableAdapterManager();
            this.entrancePanel.SuspendLayout();
            this.payMachinePanel.SuspendLayout();
            this.exitPanel.SuspendLayout();
            this.AdminLoginPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.choicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // entrancePanel
            // 
            this.entrancePanel.Controls.Add(this.entranceHelpBtn);
            this.entrancePanel.Controls.Add(this.entranceTakeTicketBtn);
            this.entrancePanel.Controls.Add(this.entranceDisplay);
            this.entrancePanel.Location = new System.Drawing.Point(0, 0);
            this.entrancePanel.Name = "entrancePanel";
            this.entrancePanel.Size = new System.Drawing.Size(255, 380);
            this.entrancePanel.TabIndex = 0;
            this.entrancePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.entrancePanel_Paint);
            // 
            // entranceHelpBtn
            // 
            this.entranceHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entranceHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("entranceHelpBtn.Image")));
            this.entranceHelpBtn.Location = new System.Drawing.Point(80, 213);
            this.entranceHelpBtn.Name = "entranceHelpBtn";
            this.entranceHelpBtn.Size = new System.Drawing.Size(97, 70);
            this.entranceHelpBtn.TabIndex = 2;
            this.entranceHelpBtn.Text = "Help";
            this.entranceHelpBtn.UseVisualStyleBackColor = true;
            this.entranceHelpBtn.Click += new System.EventHandler(this.entranceHelpBtn_Click);
            // 
            // entranceTakeTicketBtn
            // 
            this.entranceTakeTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entranceTakeTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceTakeTicketBtn.Image = ((System.Drawing.Image)(resources.GetObject("entranceTakeTicketBtn.Image")));
            this.entranceTakeTicketBtn.Location = new System.Drawing.Point(80, 117);
            this.entranceTakeTicketBtn.Name = "entranceTakeTicketBtn";
            this.entranceTakeTicketBtn.Size = new System.Drawing.Size(97, 70);
            this.entranceTakeTicketBtn.TabIndex = 1;
            this.entranceTakeTicketBtn.Text = "Ticket";
            this.entranceTakeTicketBtn.UseVisualStyleBackColor = true;
            this.entranceTakeTicketBtn.Click += new System.EventHandler(this.entranceTakeTicketBtn_Click);
            // 
            // entranceDisplay
            // 
            this.entranceDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.entranceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceDisplay.Location = new System.Drawing.Point(21, 17);
            this.entranceDisplay.Multiline = true;
            this.entranceDisplay.Name = "entranceDisplay";
            this.entranceDisplay.ReadOnly = true;
            this.entranceDisplay.ShortcutsEnabled = false;
            this.entranceDisplay.Size = new System.Drawing.Size(211, 78);
            this.entranceDisplay.TabIndex = 0;
            this.entranceDisplay.TabStop = false;
            this.entranceDisplay.Text = "Please press the button for ticket";
            this.entranceDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entranceDisplay.TextChanged += new System.EventHandler(this.entranceDisplay_TextChanged);
            // 
            // payMachinePanel
            // 
            this.payMachinePanel.Controls.Add(this.payMachineExitGateBtn);
            this.payMachinePanel.Controls.Add(this.payMachineAdminBtn);
            this.payMachinePanel.Controls.Add(this.payMachineInsertTicketBtn);
            this.payMachinePanel.Controls.Add(this.btnRM10);
            this.payMachinePanel.Controls.Add(this.btnRM5);
            this.payMachinePanel.Controls.Add(this.payMachineHelpBtn);
            this.payMachinePanel.Controls.Add(this.btnRM1);
            this.payMachinePanel.Controls.Add(this.payMachineDisplay);
            this.payMachinePanel.Location = new System.Drawing.Point(0, 0);
            this.payMachinePanel.Name = "payMachinePanel";
            this.payMachinePanel.Size = new System.Drawing.Size(255, 380);
            this.payMachinePanel.TabIndex = 1;
            // 
            // payMachineExitGateBtn
            // 
            this.payMachineExitGateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payMachineExitGateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMachineExitGateBtn.Image = ((System.Drawing.Image)(resources.GetObject("payMachineExitGateBtn.Image")));
            this.payMachineExitGateBtn.Location = new System.Drawing.Point(135, 283);
            this.payMachineExitGateBtn.Name = "payMachineExitGateBtn";
            this.payMachineExitGateBtn.Size = new System.Drawing.Size(97, 23);
            this.payMachineExitGateBtn.TabIndex = 6;
            this.payMachineExitGateBtn.Text = "Exit Gate";
            this.payMachineExitGateBtn.UseVisualStyleBackColor = true;
            this.payMachineExitGateBtn.Click += new System.EventHandler(this.payMachineExitGateBtn_Click);
            // 
            // payMachineAdminBtn
            // 
            this.payMachineAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payMachineAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMachineAdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("payMachineAdminBtn.Image")));
            this.payMachineAdminBtn.Location = new System.Drawing.Point(21, 283);
            this.payMachineAdminBtn.Name = "payMachineAdminBtn";
            this.payMachineAdminBtn.Size = new System.Drawing.Size(97, 23);
            this.payMachineAdminBtn.TabIndex = 5;
            this.payMachineAdminBtn.Text = "Administrator";
            this.payMachineAdminBtn.UseVisualStyleBackColor = true;
            this.payMachineAdminBtn.Click += new System.EventHandler(this.payMachineAdminBtn_Click);
            // 
            // payMachineInsertTicketBtn
            // 
            this.payMachineInsertTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payMachineInsertTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMachineInsertTicketBtn.Image = ((System.Drawing.Image)(resources.GetObject("payMachineInsertTicketBtn.Image")));
            this.payMachineInsertTicketBtn.Location = new System.Drawing.Point(21, 188);
            this.payMachineInsertTicketBtn.Name = "payMachineInsertTicketBtn";
            this.payMachineInsertTicketBtn.Size = new System.Drawing.Size(97, 70);
            this.payMachineInsertTicketBtn.TabIndex = 3;
            this.payMachineInsertTicketBtn.Text = "Ticket";
            this.payMachineInsertTicketBtn.UseVisualStyleBackColor = true;
            this.payMachineInsertTicketBtn.Click += new System.EventHandler(this.payMachineInsertTicketBtn_Click);
            // 
            // btnRM10
            // 
            this.btnRM10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRM10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRM10.Image = ((System.Drawing.Image)(resources.GetObject("btnRM10.Image")));
            this.btnRM10.Location = new System.Drawing.Point(170, 117);
            this.btnRM10.Name = "btnRM10";
            this.btnRM10.Size = new System.Drawing.Size(62, 53);
            this.btnRM10.TabIndex = 4;
            this.btnRM10.Text = "RM 10";
            this.btnRM10.UseVisualStyleBackColor = true;
            this.btnRM10.Click += new System.EventHandler(this.btnRM10_Click);
            // 
            // btnRM5
            // 
            this.btnRM5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRM5.Image = ((System.Drawing.Image)(resources.GetObject("btnRM5.Image")));
            this.btnRM5.Location = new System.Drawing.Point(91, 117);
            this.btnRM5.Name = "btnRM5";
            this.btnRM5.Size = new System.Drawing.Size(62, 53);
            this.btnRM5.TabIndex = 3;
            this.btnRM5.Text = "RM 5";
            this.btnRM5.UseVisualStyleBackColor = true;
            this.btnRM5.Click += new System.EventHandler(this.btnRM5_Click);
            // 
            // payMachineHelpBtn
            // 
            this.payMachineHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payMachineHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMachineHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("payMachineHelpBtn.Image")));
            this.payMachineHelpBtn.Location = new System.Drawing.Point(135, 188);
            this.payMachineHelpBtn.Name = "payMachineHelpBtn";
            this.payMachineHelpBtn.Size = new System.Drawing.Size(97, 70);
            this.payMachineHelpBtn.TabIndex = 2;
            this.payMachineHelpBtn.Text = "Help";
            this.payMachineHelpBtn.UseVisualStyleBackColor = true;
            this.payMachineHelpBtn.Click += new System.EventHandler(this.payMachineHelpBtn_Click);
            // 
            // btnRM1
            // 
            this.btnRM1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRM1.Image = ((System.Drawing.Image)(resources.GetObject("btnRM1.Image")));
            this.btnRM1.Location = new System.Drawing.Point(12, 117);
            this.btnRM1.Name = "btnRM1";
            this.btnRM1.Size = new System.Drawing.Size(62, 53);
            this.btnRM1.TabIndex = 1;
            this.btnRM1.Text = "RM 1";
            this.btnRM1.UseVisualStyleBackColor = true;
            this.btnRM1.Click += new System.EventHandler(this.btnRM1_Click);
            // 
            // payMachineDisplay
            // 
            this.payMachineDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.payMachineDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payMachineDisplay.Location = new System.Drawing.Point(21, 17);
            this.payMachineDisplay.Multiline = true;
            this.payMachineDisplay.Name = "payMachineDisplay";
            this.payMachineDisplay.ReadOnly = true;
            this.payMachineDisplay.Size = new System.Drawing.Size(211, 78);
            this.payMachineDisplay.TabIndex = 0;
            this.payMachineDisplay.TabStop = false;
            this.payMachineDisplay.Text = "Please insert your ticket";
            this.payMachineDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitPanel
            // 
            this.exitPanel.Controls.Add(this.exitBtn);
            this.exitPanel.Controls.Add(this.exitPayMachineBtn);
            this.exitPanel.Controls.Add(this.exitInsertTicketBtn);
            this.exitPanel.Controls.Add(this.exitHelpBtn);
            this.exitPanel.Controls.Add(this.exitDisplay);
            this.exitPanel.Location = new System.Drawing.Point(0, 0);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(255, 380);
            this.exitPanel.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Enabled = false;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(80, 321);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(97, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // exitPayMachineBtn
            // 
            this.exitPayMachineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitPayMachineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitPayMachineBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitPayMachineBtn.Image")));
            this.exitPayMachineBtn.Location = new System.Drawing.Point(81, 283);
            this.exitPayMachineBtn.Name = "exitPayMachineBtn";
            this.exitPayMachineBtn.Size = new System.Drawing.Size(97, 23);
            this.exitPayMachineBtn.TabIndex = 6;
            this.exitPayMachineBtn.Text = "Pay Machine";
            this.exitPayMachineBtn.UseVisualStyleBackColor = true;
            this.exitPayMachineBtn.Click += new System.EventHandler(this.exitPayMachineBtn_Click);
            // 
            // exitInsertTicketBtn
            // 
            this.exitInsertTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitInsertTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitInsertTicketBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitInsertTicketBtn.Image")));
            this.exitInsertTicketBtn.Location = new System.Drawing.Point(81, 108);
            this.exitInsertTicketBtn.Name = "exitInsertTicketBtn";
            this.exitInsertTicketBtn.Size = new System.Drawing.Size(97, 70);
            this.exitInsertTicketBtn.TabIndex = 3;
            this.exitInsertTicketBtn.Text = "Ticket";
            this.exitInsertTicketBtn.UseVisualStyleBackColor = true;
            this.exitInsertTicketBtn.Click += new System.EventHandler(this.exitInsertTicketBtn_Click);
            // 
            // exitHelpBtn
            // 
            this.exitHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitHelpBtn.Image")));
            this.exitHelpBtn.Location = new System.Drawing.Point(81, 188);
            this.exitHelpBtn.Name = "exitHelpBtn";
            this.exitHelpBtn.Size = new System.Drawing.Size(97, 70);
            this.exitHelpBtn.TabIndex = 2;
            this.exitHelpBtn.Text = "Help";
            this.exitHelpBtn.UseVisualStyleBackColor = true;
            this.exitHelpBtn.Click += new System.EventHandler(this.exitHelpBtn_Click);
            // 
            // exitDisplay
            // 
            this.exitDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitDisplay.Location = new System.Drawing.Point(21, 17);
            this.exitDisplay.Multiline = true;
            this.exitDisplay.Name = "exitDisplay";
            this.exitDisplay.ReadOnly = true;
            this.exitDisplay.ShortcutsEnabled = false;
            this.exitDisplay.Size = new System.Drawing.Size(211, 78);
            this.exitDisplay.TabIndex = 0;
            this.exitDisplay.TabStop = false;
            this.exitDisplay.Text = "Please insert your ticket";
            this.exitDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminLoginPanel
            // 
            this.AdminLoginPanel.Controls.Add(this.loginLbl);
            this.AdminLoginPanel.Controls.Add(this.adminLoginHelpBtn);
            this.AdminLoginPanel.Controls.Add(this.PWTxt);
            this.AdminLoginPanel.Controls.Add(this.IDTxt);
            this.AdminLoginPanel.Controls.Add(this.label3);
            this.AdminLoginPanel.Controls.Add(this.idLabel);
            this.AdminLoginPanel.Controls.Add(this.LoginBanner);
            this.AdminLoginPanel.Controls.Add(this.adminCancelBtn);
            this.AdminLoginPanel.Controls.Add(this.adminLoginBtn);
            this.AdminLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminLoginPanel.Name = "AdminLoginPanel";
            this.AdminLoginPanel.Size = new System.Drawing.Size(255, 380);
            this.AdminLoginPanel.TabIndex = 3;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(12, 321);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(238, 13);
            this.loginLbl.TabIndex = 14;
            this.loginLbl.Text = "Username or password is wrong! Please try again";
            // 
            // adminLoginHelpBtn
            // 
            this.adminLoginHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminLoginHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminLoginHelpBtn.Image")));
            this.adminLoginHelpBtn.Location = new System.Drawing.Point(95, 273);
            this.adminLoginHelpBtn.Name = "adminLoginHelpBtn";
            this.adminLoginHelpBtn.Size = new System.Drawing.Size(58, 30);
            this.adminLoginHelpBtn.TabIndex = 13;
            this.adminLoginHelpBtn.Text = "Help";
            this.adminLoginHelpBtn.UseVisualStyleBackColor = true;
            this.adminLoginHelpBtn.Click += new System.EventHandler(this.adminLoginHelpBtn_Click);
            // 
            // PWTxt
            // 
            this.PWTxt.Location = new System.Drawing.Point(21, 207);
            this.PWTxt.Name = "PWTxt";
            this.PWTxt.PasswordChar = '*';
            this.PWTxt.Size = new System.Drawing.Size(211, 20);
            this.PWTxt.TabIndex = 12;
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(21, 150);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(211, 20);
            this.IDTxt.TabIndex = 11;
            this.IDTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(18, 134);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "ID";
            // 
            // LoginBanner
            // 
            this.LoginBanner.AutoSize = true;
            this.LoginBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBanner.Location = new System.Drawing.Point(15, 44);
            this.LoginBanner.Name = "LoginBanner";
            this.LoginBanner.Size = new System.Drawing.Size(217, 40);
            this.LoginBanner.TabIndex = 8;
            this.LoginBanner.Text = "Welcome to \r\nParking Management System";
            this.LoginBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminCancelBtn
            // 
            this.adminCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminCancelBtn.Image")));
            this.adminCancelBtn.Location = new System.Drawing.Point(135, 244);
            this.adminCancelBtn.Name = "adminCancelBtn";
            this.adminCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.adminCancelBtn.TabIndex = 7;
            this.adminCancelBtn.Text = "Cancel";
            this.adminCancelBtn.UseVisualStyleBackColor = true;
            this.adminCancelBtn.Click += new System.EventHandler(this.adminCancelBtn_Click);
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminLoginBtn.Image")));
            this.adminLoginBtn.Location = new System.Drawing.Point(45, 244);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(73, 23);
            this.adminLoginBtn.TabIndex = 6;
            this.adminLoginBtn.Text = "Login";
            this.adminLoginBtn.UseVisualStyleBackColor = true;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.adminChgRateTxt);
            this.AdminPanel.Controls.Add(this.adminRateTxt);
            this.AdminPanel.Controls.Add(this.adminRevenueTxt);
            this.AdminPanel.Controls.Add(this.curentRatelbl);
            this.AdminPanel.Controls.Add(this.changeRatelbl);
            this.AdminPanel.Controls.Add(this.revenueLbl);
            this.AdminPanel.Controls.Add(this.adminPageCancelBtn);
            this.AdminPanel.Controls.Add(this.adminPageOKBtn);
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(255, 380);
            this.AdminPanel.TabIndex = 4;
            // 
            // adminChgRateTxt
            // 
            this.adminChgRateTxt.Location = new System.Drawing.Point(105, 160);
            this.adminChgRateTxt.Multiline = true;
            this.adminChgRateTxt.Name = "adminChgRateTxt";
            this.adminChgRateTxt.Size = new System.Drawing.Size(105, 20);
            this.adminChgRateTxt.TabIndex = 15;
            this.adminChgRateTxt.TabStop = false;
            // 
            // adminRateTxt
            // 
            this.adminRateTxt.Location = new System.Drawing.Point(105, 121);
            this.adminRateTxt.Multiline = true;
            this.adminRateTxt.Name = "adminRateTxt";
            this.adminRateTxt.ReadOnly = true;
            this.adminRateTxt.Size = new System.Drawing.Size(105, 20);
            this.adminRateTxt.TabIndex = 14;
            // 
            // adminRevenueTxt
            // 
            this.adminRevenueTxt.Location = new System.Drawing.Point(105, 79);
            this.adminRevenueTxt.Multiline = true;
            this.adminRevenueTxt.Name = "adminRevenueTxt";
            this.adminRevenueTxt.ReadOnly = true;
            this.adminRevenueTxt.Size = new System.Drawing.Size(105, 20);
            this.adminRevenueTxt.TabIndex = 13;
            this.adminRevenueTxt.TextChanged += new System.EventHandler(this.adminRevenueTxt_TextChanged);
            // 
            // curentRatelbl
            // 
            this.curentRatelbl.AutoSize = true;
            this.curentRatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curentRatelbl.Location = new System.Drawing.Point(28, 124);
            this.curentRatelbl.Name = "curentRatelbl";
            this.curentRatelbl.Size = new System.Drawing.Size(70, 13);
            this.curentRatelbl.TabIndex = 13;
            this.curentRatelbl.Text = "Current Rate:";
            this.curentRatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeRatelbl
            // 
            this.changeRatelbl.AutoSize = true;
            this.changeRatelbl.Location = new System.Drawing.Point(28, 163);
            this.changeRatelbl.Name = "changeRatelbl";
            this.changeRatelbl.Size = new System.Drawing.Size(58, 13);
            this.changeRatelbl.TabIndex = 9;
            this.changeRatelbl.Text = "New Rate:";
            // 
            // revenueLbl
            // 
            this.revenueLbl.AutoSize = true;
            this.revenueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueLbl.Location = new System.Drawing.Point(28, 82);
            this.revenueLbl.Name = "revenueLbl";
            this.revenueLbl.Size = new System.Drawing.Size(54, 13);
            this.revenueLbl.TabIndex = 8;
            this.revenueLbl.Text = "Revenue:";
            this.revenueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revenueLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // adminPageCancelBtn
            // 
            this.adminPageCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminPageCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPageCancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminPageCancelBtn.Image")));
            this.adminPageCancelBtn.Location = new System.Drawing.Point(126, 223);
            this.adminPageCancelBtn.Name = "adminPageCancelBtn";
            this.adminPageCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.adminPageCancelBtn.TabIndex = 7;
            this.adminPageCancelBtn.Text = "Cancel";
            this.adminPageCancelBtn.UseVisualStyleBackColor = true;
            this.adminPageCancelBtn.Click += new System.EventHandler(this.adminPageCancelBtn_Click);
            // 
            // adminPageOKBtn
            // 
            this.adminPageOKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminPageOKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPageOKBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminPageOKBtn.Image")));
            this.adminPageOKBtn.Location = new System.Drawing.Point(47, 223);
            this.adminPageOKBtn.Name = "adminPageOKBtn";
            this.adminPageOKBtn.Size = new System.Drawing.Size(73, 23);
            this.adminPageOKBtn.TabIndex = 6;
            this.adminPageOKBtn.Text = "OK";
            this.adminPageOKBtn.UseVisualStyleBackColor = true;
            this.adminPageOKBtn.Click += new System.EventHandler(this.adminPageOKBtn_Click);
            // 
            // choicePanel
            // 
            this.choicePanel.Controls.Add(this.choiceLbl);
            this.choicePanel.Controls.Add(this.goPayMachineBtn);
            this.choicePanel.Controls.Add(this.goExitGateBtn);
            this.choicePanel.Location = new System.Drawing.Point(0, 0);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(255, 380);
            this.choicePanel.TabIndex = 7;
            // 
            // choiceLbl
            // 
            this.choiceLbl.AutoSize = true;
            this.choiceLbl.Location = new System.Drawing.Point(63, 35);
            this.choiceLbl.Name = "choiceLbl";
            this.choiceLbl.Size = new System.Drawing.Size(133, 13);
            this.choiceLbl.TabIndex = 4;
            this.choiceLbl.Text = "Where do you want to go?";
            // 
            // goPayMachineBtn
            // 
            this.goPayMachineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goPayMachineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goPayMachineBtn.Image = ((System.Drawing.Image)(resources.GetObject("goPayMachineBtn.Image")));
            this.goPayMachineBtn.Location = new System.Drawing.Point(78, 82);
            this.goPayMachineBtn.Name = "goPayMachineBtn";
            this.goPayMachineBtn.Size = new System.Drawing.Size(97, 70);
            this.goPayMachineBtn.TabIndex = 3;
            this.goPayMachineBtn.Text = "Pay Machine";
            this.goPayMachineBtn.UseVisualStyleBackColor = true;
            this.goPayMachineBtn.Click += new System.EventHandler(this.goPayMachineBtn_Click);
            // 
            // goExitGateBtn
            // 
            this.goExitGateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goExitGateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goExitGateBtn.Image = ((System.Drawing.Image)(resources.GetObject("goExitGateBtn.Image")));
            this.goExitGateBtn.Location = new System.Drawing.Point(78, 188);
            this.goExitGateBtn.Name = "goExitGateBtn";
            this.goExitGateBtn.Size = new System.Drawing.Size(97, 70);
            this.goExitGateBtn.TabIndex = 2;
            this.goExitGateBtn.Text = "Exit Gate";
            this.goExitGateBtn.UseVisualStyleBackColor = true;
            this.goExitGateBtn.Click += new System.EventHandler(this.goExitGateBtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "enterTimestamp";
            this.dataGridViewTextBoxColumn2.HeaderText = "enterTimestamp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "exitTimestamp";
            this.dataGridViewTextBoxColumn3.HeaderText = "exitTimestamp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "payStatus";
            this.dataGridViewCheckBoxColumn1.HeaderText = "payStatus";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.parkingDatabaseDataSet;
            // 
            // parkingDatabaseDataSet
            // 
            this.parkingDatabaseDataSet.DataSetName = "ParkingDatabaseDataSet";
            this.parkingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager.UpdateOrder = Car_Parking_System.ParkingDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CarParkingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 362);
            this.Controls.Add(this.choicePanel);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.payMachinePanel);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.entrancePanel);
            this.Controls.Add(this.AdminLoginPanel);
            this.Name = "CarParkingSystem";
            this.Text = "Car Parking System";
            this.Load += new System.EventHandler(this.CarParkingSystem_Load);
            this.entrancePanel.ResumeLayout(false);
            this.entrancePanel.PerformLayout();
            this.payMachinePanel.ResumeLayout(false);
            this.payMachinePanel.PerformLayout();
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            this.AdminLoginPanel.ResumeLayout(false);
            this.AdminLoginPanel.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.choicePanel.ResumeLayout(false);
            this.choicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entrancePanel;
        private System.Windows.Forms.Button entranceHelpBtn;
        private System.Windows.Forms.Button entranceTakeTicketBtn;
        private System.Windows.Forms.TextBox entranceDisplay;
        private System.Windows.Forms.Panel payMachinePanel;
        private System.Windows.Forms.Button payMachineExitGateBtn;
        private System.Windows.Forms.Button payMachineAdminBtn;
        private System.Windows.Forms.Button payMachineInsertTicketBtn;
        private System.Windows.Forms.Button btnRM10;
        private System.Windows.Forms.Button btnRM5;
        private System.Windows.Forms.Button payMachineHelpBtn;
        private System.Windows.Forms.Button btnRM1;
        private System.Windows.Forms.TextBox payMachineDisplay;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Button exitPayMachineBtn;
        private System.Windows.Forms.Button exitInsertTicketBtn;
        private System.Windows.Forms.Button exitHelpBtn;
        private System.Windows.Forms.TextBox exitDisplay;
        private System.Windows.Forms.Panel AdminLoginPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label LoginBanner;
        private System.Windows.Forms.Button adminCancelBtn;
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.TextBox PWTxt;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Button adminLoginHelpBtn;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.TextBox adminChgRateTxt;
        private System.Windows.Forms.TextBox adminRateTxt;
        private System.Windows.Forms.TextBox adminRevenueTxt;
        private System.Windows.Forms.Label curentRatelbl;
        private System.Windows.Forms.Label changeRatelbl;
        private System.Windows.Forms.Label revenueLbl;
        private System.Windows.Forms.Button adminPageCancelBtn;
        private System.Windows.Forms.Button adminPageOKBtn;
        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.Label choiceLbl;
        private System.Windows.Forms.Button goPayMachineBtn;
        private System.Windows.Forms.Button goExitGateBtn;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Button exitBtn;
        private ParkingDatabaseDataSet parkingDatabaseDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private ParkingDatabaseDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private ParkingDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Timer timer1;
    }
}

