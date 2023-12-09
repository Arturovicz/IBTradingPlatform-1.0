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
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
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
            this.cbSymbol.Location = new System.Drawing.Point(15, 78);
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
            this.lbData.Location = new System.Drawing.Point(163, 178);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(418, 108);
            this.lbData.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Market";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Visible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Primary Ex";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TIF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ask";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Last";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(160, 62);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(79, 13);
            this.Quantity.TabIndex = 15;
            this.Quantity.Text = "Shares Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
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
            this.cbTif.Location = new System.Drawing.Point(460, 126);
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
            this.cbMarket.Location = new System.Drawing.Point(460, 78);
            this.cbMarket.Name = "cbMarket";
            this.cbMarket.Size = new System.Drawing.Size(121, 21);
            this.cbMarket.TabIndex = 18;
            this.cbMarket.Text = "SMART";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(163, 78);
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
            this.numPrice.Location = new System.Drawing.Point(315, 78);
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
            this.cbOrderType.Location = new System.Drawing.Point(12, 125);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(121, 21);
            this.cbOrderType.TabIndex = 21;
            this.cbOrderType.Text = "LMT";
            // 
            // tbVisible
            // 
            this.tbVisible.Location = new System.Drawing.Point(163, 126);
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
            this.cbPrimaryEx.Location = new System.Drawing.Point(315, 125);
            this.cbPrimaryEx.Name = "cbPrimaryEx";
            this.cbPrimaryEx.Size = new System.Drawing.Size(121, 21);
            this.cbPrimaryEx.TabIndex = 23;
            this.cbPrimaryEx.Text = "NASDAQ";
            // 
            // tbBid
            // 
            this.tbBid.Location = new System.Drawing.Point(12, 178);
            this.tbBid.Name = "tbBid";
            this.tbBid.Size = new System.Drawing.Size(100, 20);
            this.tbBid.TabIndex = 24;
            this.tbBid.Text = "0";
            // 
            // tbAsk
            // 
            this.tbAsk.Location = new System.Drawing.Point(12, 219);
            this.tbAsk.Name = "tbAsk";
            this.tbAsk.Size = new System.Drawing.Size(100, 20);
            this.tbAsk.TabIndex = 25;
            this.tbAsk.Text = "0";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(12, 268);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 26;
            this.tbLast.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

