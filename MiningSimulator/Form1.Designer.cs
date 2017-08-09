namespace MiningSimulator
{
    partial class MiningSIM
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
            this.lbMain = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbTruckID = new System.Windows.Forms.TextBox();
            this.lblTruckID = new System.Windows.Forms.Label();
            this.tbLoadCapacity = new System.Windows.Forms.TextBox();
            this.lblLoadCapacity = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbService = new System.Windows.Forms.RadioButton();
            this.rbCrushing = new System.Windows.Forms.RadioButton();
            this.rbTransitCrushing = new System.Windows.Forms.RadioButton();
            this.rbLoading = new System.Windows.Forms.RadioButton();
            this.rbTransitLoading = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.btnService = new System.Windows.Forms.Button();
            this.btnInactive = new System.Windows.Forms.Button();
            this.lbService = new System.Windows.Forms.ListBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblTransitCrushing = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblTransitLoading = new System.Windows.Forms.Label();
            this.lblCrushing = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.qlbCrushing = new MiningSimulator.QueueListBox();
            this.qlbTransitCrushing = new MiningSimulator.QueueListBox();
            this.qlbLoading = new MiningSimulator.QueueListBox();
            this.qlbTransitLoading = new MiningSimulator.QueueListBox();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.DisplayMember = "truckInfo";
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(12, 29);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(120, 212);
            this.lbMain.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lbMain, "Select truck to view information and add to queue");
            this.lbMain.SelectedIndexChanged += new System.EventHandler(this.lbMain_SelectedIndexChanged);
            this.lbMain.DoubleClick += new System.EventHandler(this.lbMain_DoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(53, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // tbTruckID
            // 
            this.tbTruckID.Location = new System.Drawing.Point(180, 41);
            this.tbTruckID.Name = "tbTruckID";
            this.tbTruckID.ReadOnly = true;
            this.tbTruckID.Size = new System.Drawing.Size(53, 20);
            this.tbTruckID.TabIndex = 3;
            // 
            // lblTruckID
            // 
            this.lblTruckID.AutoSize = true;
            this.lblTruckID.Location = new System.Drawing.Point(177, 25);
            this.lblTruckID.Name = "lblTruckID";
            this.lblTruckID.Size = new System.Drawing.Size(49, 13);
            this.lblTruckID.TabIndex = 4;
            this.lblTruckID.Text = "Truck ID";
            // 
            // tbLoadCapacity
            // 
            this.tbLoadCapacity.Location = new System.Drawing.Point(180, 92);
            this.tbLoadCapacity.Name = "tbLoadCapacity";
            this.tbLoadCapacity.ReadOnly = true;
            this.tbLoadCapacity.Size = new System.Drawing.Size(53, 20);
            this.tbLoadCapacity.TabIndex = 5;
            // 
            // lblLoadCapacity
            // 
            this.lblLoadCapacity.AutoSize = true;
            this.lblLoadCapacity.Location = new System.Drawing.Point(177, 76);
            this.lblLoadCapacity.Name = "lblLoadCapacity";
            this.lblLoadCapacity.Size = new System.Drawing.Size(75, 13);
            this.lblLoadCapacity.TabIndex = 6;
            this.lblLoadCapacity.Text = "Load Capacity";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(180, 140);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(53, 20);
            this.tbTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(177, 124);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbService);
            this.gbStatus.Controls.Add(this.rbCrushing);
            this.gbStatus.Controls.Add(this.rbTransitCrushing);
            this.gbStatus.Controls.Add(this.rbLoading);
            this.gbStatus.Controls.Add(this.rbTransitLoading);
            this.gbStatus.Controls.Add(this.rbInactive);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(294, 29);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(119, 148);
            this.gbStatus.TabIndex = 9;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Truck Status";
            this.toolTip2.SetToolTip(this.gbStatus, "View truck status");
            // 
            // rbService
            // 
            this.rbService.AutoSize = true;
            this.rbService.Location = new System.Drawing.Point(6, 125);
            this.rbService.Name = "rbService";
            this.rbService.Size = new System.Drawing.Size(61, 17);
            this.rbService.TabIndex = 5;
            this.rbService.Tag = "5";
            this.rbService.Text = "Service";
            this.rbService.UseVisualStyleBackColor = true;
            // 
            // rbCrushing
            // 
            this.rbCrushing.AutoSize = true;
            this.rbCrushing.Location = new System.Drawing.Point(6, 103);
            this.rbCrushing.Name = "rbCrushing";
            this.rbCrushing.Size = new System.Drawing.Size(66, 17);
            this.rbCrushing.TabIndex = 4;
            this.rbCrushing.Tag = "4";
            this.rbCrushing.Text = "Crushing";
            this.rbCrushing.UseVisualStyleBackColor = true;
            // 
            // rbTransitCrushing
            // 
            this.rbTransitCrushing.AutoSize = true;
            this.rbTransitCrushing.Location = new System.Drawing.Point(6, 81);
            this.rbTransitCrushing.Name = "rbTransitCrushing";
            this.rbTransitCrushing.Size = new System.Drawing.Size(113, 17);
            this.rbTransitCrushing.TabIndex = 3;
            this.rbTransitCrushing.Tag = "3";
            this.rbTransitCrushing.Text = "Transit to Crushing";
            this.rbTransitCrushing.UseVisualStyleBackColor = true;
            // 
            // rbLoading
            // 
            this.rbLoading.AutoSize = true;
            this.rbLoading.Location = new System.Drawing.Point(6, 59);
            this.rbLoading.Name = "rbLoading";
            this.rbLoading.Size = new System.Drawing.Size(63, 17);
            this.rbLoading.TabIndex = 2;
            this.rbLoading.Tag = "2";
            this.rbLoading.Text = "Loading";
            this.rbLoading.UseVisualStyleBackColor = true;
            // 
            // rbTransitLoading
            // 
            this.rbTransitLoading.AutoSize = true;
            this.rbTransitLoading.Location = new System.Drawing.Point(6, 37);
            this.rbTransitLoading.Name = "rbTransitLoading";
            this.rbTransitLoading.Size = new System.Drawing.Size(110, 17);
            this.rbTransitLoading.TabIndex = 1;
            this.rbTransitLoading.Tag = "1";
            this.rbTransitLoading.Text = "Transit to Loading";
            this.rbTransitLoading.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactive.Location = new System.Drawing.Point(6, 15);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(63, 17);
            this.rbInactive.TabIndex = 0;
            this.rbInactive.Tag = "0";
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(177, 177);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(75, 23);
            this.btnService.TabIndex = 10;
            this.btnService.Text = "Service";
            this.toolTip3.SetToolTip(this.btnService, "Select truck in main list to be serviced");
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnInactive
            // 
            this.btnInactive.Location = new System.Drawing.Point(177, 206);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(75, 23);
            this.btnInactive.TabIndex = 11;
            this.btnInactive.Text = "Inactive";
            this.toolTip3.SetToolTip(this.btnInactive, "Make truck inactive");
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // lbService
            // 
            this.lbService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbService.FormattingEnabled = true;
            this.lbService.Location = new System.Drawing.Point(300, 206);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(110, 69);
            this.lbService.TabIndex = 12;
            this.toolTip3.SetToolTip(this.lbService, "Trucks being serviced (view only)");
            this.lbService.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbService_DrawItem);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(297, 187);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service";
            // 
            // lblTransitCrushing
            // 
            this.lblTransitCrushing.AutoSize = true;
            this.lblTransitCrushing.Location = new System.Drawing.Point(222, 284);
            this.lblTransitCrushing.Name = "lblTransitCrushing";
            this.lblTransitCrushing.Size = new System.Drawing.Size(95, 13);
            this.lblTransitCrushing.TabIndex = 18;
            this.lblTransitCrushing.Text = "Transit to Crushing";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(117, 284);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(45, 13);
            this.lblLoading.TabIndex = 19;
            this.lblLoading.Text = "Loading";
            // 
            // lblTransitLoading
            // 
            this.lblTransitLoading.AutoSize = true;
            this.lblTransitLoading.Location = new System.Drawing.Point(12, 284);
            this.lblTransitLoading.Name = "lblTransitLoading";
            this.lblTransitLoading.Size = new System.Drawing.Size(92, 13);
            this.lblTransitLoading.TabIndex = 20;
            this.lblTransitLoading.Text = "Transit to Loading";
            // 
            // lblCrushing
            // 
            this.lblCrushing.AutoSize = true;
            this.lblCrushing.Location = new System.Drawing.Point(331, 284);
            this.lblCrushing.Name = "lblCrushing";
            this.lblCrushing.Size = new System.Drawing.Size(48, 13);
            this.lblCrushing.TabIndex = 21;
            this.lblCrushing.Text = "Crushing";
            // 
            // qlbCrushing
            // 
            this.qlbCrushing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qlbCrushing.FormattingEnabled = true;
            this.qlbCrushing.Location = new System.Drawing.Point(334, 300);
            this.qlbCrushing.Name = "qlbCrushing";
            this.qlbCrushing.Size = new System.Drawing.Size(90, 186);
            this.qlbCrushing.TabIndex = 25;
            this.toolTip3.SetToolTip(this.qlbCrushing, "Click to move to next queue");
            // 
            // qlbTransitCrushing
            // 
            this.qlbTransitCrushing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qlbTransitCrushing.FormattingEnabled = true;
            this.qlbTransitCrushing.Location = new System.Drawing.Point(227, 300);
            this.qlbTransitCrushing.Name = "qlbTransitCrushing";
            this.qlbTransitCrushing.Size = new System.Drawing.Size(90, 186);
            this.qlbTransitCrushing.TabIndex = 24;
            this.toolTip3.SetToolTip(this.qlbTransitCrushing, "Click to move to next queue");
            // 
            // qlbLoading
            // 
            this.qlbLoading.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qlbLoading.FormattingEnabled = true;
            this.qlbLoading.Location = new System.Drawing.Point(118, 300);
            this.qlbLoading.Name = "qlbLoading";
            this.qlbLoading.Size = new System.Drawing.Size(90, 186);
            this.qlbLoading.TabIndex = 23;
            this.toolTip3.SetToolTip(this.qlbLoading, "Click to move to next queue");
            // 
            // qlbTransitLoading
            // 
            this.qlbTransitLoading.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qlbTransitLoading.FormattingEnabled = true;
            this.qlbTransitLoading.Location = new System.Drawing.Point(15, 300);
            this.qlbTransitLoading.Name = "qlbTransitLoading";
            this.qlbTransitLoading.Size = new System.Drawing.Size(90, 186);
            this.qlbTransitLoading.TabIndex = 22;
            this.toolTip3.SetToolTip(this.qlbTransitLoading, "Click to move to next queue");
            // 
            // MiningSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 506);
            this.Controls.Add(this.qlbCrushing);
            this.Controls.Add(this.qlbTransitCrushing);
            this.Controls.Add(this.qlbLoading);
            this.Controls.Add(this.qlbTransitLoading);
            this.Controls.Add(this.lblCrushing);
            this.Controls.Add(this.lblTransitLoading);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblTransitCrushing);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lbService);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblLoadCapacity);
            this.Controls.Add(this.tbLoadCapacity);
            this.Controls.Add(this.lblTruckID);
            this.Controls.Add(this.tbTruckID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbMain);
            this.Name = "MiningSIM";
            this.Text = "Mining SIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiningSIM_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiningSimulator_FormClosed);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbTruckID;
        private System.Windows.Forms.Label lblTruckID;
        private System.Windows.Forms.TextBox tbLoadCapacity;
        private System.Windows.Forms.Label lblLoadCapacity;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbTransitLoading;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbLoading;
        private System.Windows.Forms.RadioButton rbService;
        private System.Windows.Forms.RadioButton rbCrushing;
        private System.Windows.Forms.RadioButton rbTransitCrushing;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.ListBox lbService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblTransitCrushing;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblTransitLoading;
        private System.Windows.Forms.Label lblCrushing;
        private QueueListBox qlbTransitLoading;
        private QueueListBox qlbLoading;
        private QueueListBox qlbTransitCrushing;
        private QueueListBox qlbCrushing;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

