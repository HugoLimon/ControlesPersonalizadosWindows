namespace CustomControls111BTEC
{
    partial class _111DatetimePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_111DatetimePicker));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.panelDays = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackMonth = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Panel();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.tabDays = new System.Windows.Forms.TableLayoutPanel();
            this.panelHora = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hourPick = new System.Windows.Forms.NumericUpDown();
            this.minutesPick = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBar.SuspendLayout();
            this.panelDays.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesPick)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDays, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabDays, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelHora, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBar
            // 
            this.panelBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.panelBar.Controls.Add(this.lblCurrentDate);
            this.panelBar.Controls.Add(this.lblYear);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(220, 54);
            this.panelBar.TabIndex = 0;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Roboto Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDate.Location = new System.Drawing.Point(3, 17);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(166, 33);
            this.lblCurrentDate.TabIndex = 1;
            this.lblCurrentDate.Text = "Mar, May 19";
            this.lblCurrentDate.Click += new System.EventHandler(this.lblCurrentDate_Click);
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Roboto Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblYear.Location = new System.Drawing.Point(6, 3);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 18);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "HOY";
            // 
            // panelDays
            // 
            this.panelDays.BackColor = System.Drawing.SystemColors.Control;
            this.panelDays.ColumnCount = 7;
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelDays.Controls.Add(this.label9, 6, 0);
            this.panelDays.Controls.Add(this.label8, 5, 0);
            this.panelDays.Controls.Add(this.label7, 4, 0);
            this.panelDays.Controls.Add(this.label6, 3, 0);
            this.panelDays.Controls.Add(this.label5, 2, 0);
            this.panelDays.Controls.Add(this.label4, 1, 0);
            this.panelDays.Controls.Add(this.label3, 0, 0);
            this.panelDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDays.Location = new System.Drawing.Point(0, 87);
            this.panelDays.Margin = new System.Windows.Forms.Padding(0);
            this.panelDays.Name = "panelDays";
            this.panelDays.RowCount = 1;
            this.panelDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDays.Size = new System.Drawing.Size(220, 37);
            this.panelDays.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(189, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = "DO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(158, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 37);
            this.label8.TabIndex = 6;
            this.label8.Text = "SA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(127, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "VI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(96, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "JU";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(65, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "MI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(34, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "MA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "LU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.btnBackMonth, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNextMonth, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMonthYear, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 33);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnBackMonth
            // 
            this.btnBackMonth.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackMonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackMonth.BackgroundImage")));
            this.btnBackMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackMonth.Location = new System.Drawing.Point(0, 0);
            this.btnBackMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackMonth.Name = "btnBackMonth";
            this.btnBackMonth.Size = new System.Drawing.Size(30, 33);
            this.btnBackMonth.TabIndex = 3;
            this.btnBackMonth.Click += new System.EventHandler(this.btnBackMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextMonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextMonth.BackgroundImage")));
            this.btnNextMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextMonth.Location = new System.Drawing.Point(190, 0);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(30, 33);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.BackColor = System.Drawing.SystemColors.Control;
            this.lblMonthYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthYear.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblMonthYear.Location = new System.Drawing.Point(30, 0);
            this.lblMonthYear.Margin = new System.Windows.Forms.Padding(0);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(160, 33);
            this.lblMonthYear.TabIndex = 2;
            this.lblMonthYear.Text = "Mayo 2019";
            this.lblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDays
            // 
            this.tabDays.BackColor = System.Drawing.SystemColors.Control;
            this.tabDays.ColumnCount = 7;
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDays.Location = new System.Drawing.Point(0, 124);
            this.tabDays.Margin = new System.Windows.Forms.Padding(0);
            this.tabDays.Name = "tabDays";
            this.tabDays.RowCount = 6;
            this.tabDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabDays.Size = new System.Drawing.Size(220, 131);
            this.tabDays.TabIndex = 3;
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.SystemColors.Control;
            this.panelHora.Controls.Add(this.label2);
            this.panelHora.Controls.Add(this.hourPick);
            this.panelHora.Controls.Add(this.minutesPick);
            this.panelHora.Controls.Add(this.label1);
            this.panelHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHora.Location = new System.Drawing.Point(0, 255);
            this.panelHora.Margin = new System.Windows.Forms.Padding(0);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(220, 32);
            this.panelHora.TabIndex = 6;
            this.panelHora.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora";
            // 
            // hourPick
            // 
            this.hourPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hourPick.Location = new System.Drawing.Point(96, 8);
            this.hourPick.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourPick.Name = "hourPick";
            this.hourPick.Size = new System.Drawing.Size(53, 21);
            this.hourPick.TabIndex = 5;
            // 
            // minutesPick
            // 
            this.minutesPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minutesPick.Location = new System.Drawing.Point(169, 8);
            this.minutesPick.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesPick.Name = "minutesPick";
            this.minutesPick.Size = new System.Drawing.Size(40, 21);
            this.minutesPick.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.Controls.Add(this.btnOK, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 287);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(220, 28);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.btnOK.Location = new System.Drawing.Point(152, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseHover += new System.EventHandler(this.btnOK_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(254)))));
            this.btnCancel.Location = new System.Drawing.Point(75, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // _111DatetimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "_111DatetimePicker";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(222, 317);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.panelDays.ResumeLayout(false);
            this.panelDays.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesPick)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TableLayoutPanel panelDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel btnNextMonth;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.TableLayoutPanel tabDays;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown hourPick;
        private System.Windows.Forms.NumericUpDown minutesPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label btnOK;
        private System.Windows.Forms.Label btnCancel;
        private System.Windows.Forms.Panel btnBackMonth;
    }
}
