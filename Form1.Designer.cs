namespace IBTradingPlatform
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTif = new System.Windows.Forms.ComboBox();
            this.cbMarket = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.tbVisible = new System.Windows.Forms.TextBox();
            this.cbPrimaryEx = new System.Windows.Forms.ComboBox();
            this.tbBid = new System.Windows.Forms.TextBox();
            this.tbAsk = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbValidID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.chkOutside = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listViewTns = new System.Windows.Forms.ListView();
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbStopLoss = new System.Windows.Forms.TextBox();
            this.tbTakeProfit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 25);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSymbol
            // 
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Items.AddRange(new object[] {
            "MSFT",
            "AAPL",
            "TSLA"});
            this.cbSymbol.Location = new System.Drawing.Point(15, 90);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbSymbol.TabIndex = 1;
            this.cbSymbol.Text = "MSFT";
            this.cbSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSymbol_SelectedIndexChanged);
            this.cbSymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSymbol_KeyDown);
            this.cbSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSymbol_KeyPress);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(163, 190);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(418, 108);
            this.lbData.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Market";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Visible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Primary Ex";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TIF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ask";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Last";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(160, 74);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(79, 13);
            this.Quantity.TabIndex = 15;
            this.Quantity.Text = "Shares Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Symbol";
            // 
            // cbTif
            // 
            this.cbTif.FormattingEnabled = true;
            this.cbTif.Items.AddRange(new object[] {
            "DAY",
            "GTC (Good-to-Cancel)"});
            this.cbTif.Location = new System.Drawing.Point(460, 138);
            this.cbTif.Name = "cbTif";
            this.cbTif.Size = new System.Drawing.Size(121, 21);
            this.cbTif.TabIndex = 17;
            this.cbTif.Text = "DAY";
            // 
            // cbMarket
            // 
            this.cbMarket.FormattingEnabled = true;
            this.cbMarket.Items.AddRange(new object[] {
            "SMART",
            "ARCA",
            "BATS",
            "ISLAND"});
            this.cbMarket.Location = new System.Drawing.Point(460, 90);
            this.cbMarket.Name = "cbMarket";
            this.cbMarket.Size = new System.Drawing.Size(121, 21);
            this.cbMarket.TabIndex = 18;
            this.cbMarket.Text = "SMART";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(163, 90);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 19;
            this.numQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrice.Location = new System.Drawing.Point(315, 90);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 20;
            // 
            // cbOrderType
            // 
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Items.AddRange(new object[] {
            "LMT",
            "MCT",
            "STP",
            "MOC"});
            this.cbOrderType.Location = new System.Drawing.Point(12, 137);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(121, 21);
            this.cbOrderType.TabIndex = 21;
            this.cbOrderType.Text = "LMT";
            // 
            // tbVisible
            // 
            this.tbVisible.Location = new System.Drawing.Point(163, 138);
            this.tbVisible.Name = "tbVisible";
            this.tbVisible.Size = new System.Drawing.Size(100, 20);
            this.tbVisible.TabIndex = 22;
            this.tbVisible.Text = "100";
            // 
            // cbPrimaryEx
            // 
            this.cbPrimaryEx.FormattingEnabled = true;
            this.cbPrimaryEx.Items.AddRange(new object[] {
            "NASDAQ"});
            this.cbPrimaryEx.Location = new System.Drawing.Point(315, 137);
            this.cbPrimaryEx.Name = "cbPrimaryEx";
            this.cbPrimaryEx.Size = new System.Drawing.Size(121, 21);
            this.cbPrimaryEx.TabIndex = 23;
            this.cbPrimaryEx.Text = "NASDAQ";
            // 
            // tbBid
            // 
            this.tbBid.Location = new System.Drawing.Point(12, 190);
            this.tbBid.Name = "tbBid";
            this.tbBid.Size = new System.Drawing.Size(100, 20);
            this.tbBid.TabIndex = 24;
            this.tbBid.Text = "0";
            this.tbBid.Click += new System.EventHandler(this.tbBid_Click);
            // 
            // tbAsk
            // 
            this.tbAsk.Location = new System.Drawing.Point(12, 231);
            this.tbAsk.Name = "tbAsk";
            this.tbAsk.Size = new System.Drawing.Size(100, 20);
            this.tbAsk.TabIndex = 25;
            this.tbAsk.Text = "0";
            this.tbAsk.Click += new System.EventHandler(this.tbAsk_Click);
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(12, 280);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 26;
            this.tbLast.Text = "0";
            this.tbLast.Click += new System.EventHandler(this.tbLast_Click);
            // 
            // tbValidID
            // 
            this.tbValidID.Location = new System.Drawing.Point(163, 28);
            this.tbValidID.Name = "tbValidID";
            this.tbValidID.Size = new System.Drawing.Size(100, 20);
            this.tbValidID.TabIndex = 27;
            this.tbValidID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Next Valid Order ID";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(315, 24);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 27);
            this.btnDisconnect.TabIndex = 29;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Red;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSell.Location = new System.Drawing.Point(12, 307);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 30;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuy.Location = new System.Drawing.Point(12, 337);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 31;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // chkOutside
            // 
            this.chkOutside.AutoSize = true;
            this.chkOutside.Location = new System.Drawing.Point(460, 28);
            this.chkOutside.Name = "chkOutside";
            this.chkOutside.Size = new System.Drawing.Size(88, 17);
            this.chkOutside.TabIndex = 32;
            this.chkOutside.Text = "Outside RTH";
            this.chkOutside.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listViewTns
            // 
            this.listViewTns.BackColor = System.Drawing.SystemColors.MenuText;
            this.listViewTns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.price,
            this.shares,
            this.time});
            this.listViewTns.ForeColor = System.Drawing.SystemColors.Menu;
            this.listViewTns.HideSelection = false;
            this.listViewTns.Location = new System.Drawing.Point(6, 6);
            this.listViewTns.Name = "listViewTns";
            this.listViewTns.Size = new System.Drawing.Size(545, 336);
            this.listViewTns.TabIndex = 33;
            this.listViewTns.UseCompatibleStateImageBehavior = false;
            this.listViewTns.View = System.Windows.Forms.View.Details;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 139;
            // 
            // shares
            // 
            this.shares.Text = "Shares";
            this.shares.Width = 157;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 137;
            // 
            // tbStopLoss
            // 
            this.tbStopLoss.Location = new System.Drawing.Point(267, 337);
            this.tbStopLoss.Name = "tbStopLoss";
            this.tbStopLoss.Size = new System.Drawing.Size(100, 20);
            this.tbStopLoss.TabIndex = 34;
            this.tbStopLoss.Text = "0.00";
            // 
            // tbTakeProfit
            // 
            this.tbTakeProfit.Location = new System.Drawing.Point(158, 337);
            this.tbTakeProfit.Name = "tbTakeProfit";
            this.tbTakeProfit.Size = new System.Drawing.Size(100, 20);
            this.tbTakeProfit.TabIndex = 35;
            this.tbTakeProfit.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Profit Target";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Stop Loss";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(587, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 386);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewTns);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Time & Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStopScan);
            this.tabPage2.Controls.Add(this.btnScan);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(466, 7);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(75, 23);
            this.btnStopScan.TabIndex = 2;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(385, 7);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pos,
            this.Symbol,
            this.Last});
            this.dataGridView1.Location = new System.Drawing.Point(0, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Pos
            // 
            this.Pos.HeaderText = "Pos";
            this.Pos.Name = "Pos";
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Last
            // 
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(557, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Watchlist";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(544, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Symbol";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Volume";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Change";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Close";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1154, 566);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTakeProfit);
            this.Controls.Add(this.tbStopLoss);
            this.Controls.Add(this.chkOutside);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValidID);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.tbAsk);
            this.Controls.Add(this.tbBid);
            this.Controls.Add(this.cbPrimaryEx);
            this.Controls.Add(this.tbVisible);
            this.Controls.Add(this.cbOrderType);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.cbMarket);
            this.Controls.Add(this.cbTif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.cbSymbol);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbSymbol;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTif;
        private System.Windows.Forms.ComboBox cbMarket;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.TextBox tbVisible;
        private System.Windows.Forms.ComboBox cbPrimaryEx;
        private System.Windows.Forms.TextBox tbBid;
        private System.Windows.Forms.TextBox tbAsk;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbValidID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.CheckBox chkOutside;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listViewTns;
        private System.Windows.Forms.TextBox tbStopLoss;
        private System.Windows.Forms.TextBox tbTakeProfit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader shares;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

