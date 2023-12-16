﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using IBApi;


namespace IBTradingPlatform
{
    public partial class Form1 : Form
    {

        int order_id = 0;
        int timer1_counter = 5;

        delegate void SetTextCallback(string text);
        delegate void SetTextCallbackTickPrice(string _tickPrice);
        delegate void SetTextCallbackTickString(string _tickString);

        IBTradingPlatform.EWrapperImpl ibClient;

        public void AddListBoxItem(string text)
        {
            if (this.lbData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddListBoxItem);
                this.Invoke(d, new object[] {text});
            } 
            else
            {
                this.lbData.Items.Add(text);
            }
        }

        public Form1()
        {
            InitializeComponent();
            ibClient = new IBTradingPlatform.EWrapperImpl();
        }

        private void Form1_Load(object sender, EventArgs e){}
        
        private void lbData_SelectedIndexChanged(object sender, EventArgs e){}


        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e) 
        {
            getData();
        }

        private void cbSymbol_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
        
        private void cbSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbSymbol.SelectionStart = 0;
                cbSymbol.SelectionLength = cbSymbol.Text.Length;
                e.SuppressKeyPress = true;

                string name = cbSymbol.Text;

                if (!cbSymbol.Items.Contains(name)){cbSymbol.Items.Add(name);}
                cbSymbol.SelectAll();
                getData();

            }
        }


        public void AddListViewItemTickString(string _tickString)
        {
            if (this.listViewTns.InvokeRequired)
            {
                try
                {
                    SetTextCallbackTickString d = new SetTextCallbackTickString(AddListViewItemTickString);
                    this.Invoke(d, new object[] { _tickString });
                }
                catch (Exception)
                {
                    Console.WriteLine("Poxuy");
                }
            }
            else
            {
                try
                {
                    
                    double theBid = Convert.ToDouble(tbBid.Text);
                    double theAsk = Convert.ToDouble(tbAsk.Text);


                    string[] listTimeSales = _tickString.Split(';');
                    double last_price = Convert.ToDouble(listTimeSales[0]);
                    int trade_size = Convert.ToInt32(listTimeSales[1]);
                    double trade_time = Convert.ToDouble(listTimeSales[2]);
                    int share_size = trade_size * 100;
                    string strShareSize = share_size.ToString("###,####,##0");

                    DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    epoch = epoch.AddMilliseconds(trade_time);
                    epoch = epoch.AddHours(-5);   //Daylight saving time use -4 Summer otherwise use -5 Winter

                    string strSaleTime = epoch.ToString("h:mm:ss:ff");

                    double myMeanPrice = ((theAsk - theBid) / 2);
                    double myMean = (theBid + myMeanPrice);

                    ListViewItem lx = new ListViewItem();

                    // string dt = String.Format("{0:hh:mm:ss}", dnt);

                    
                    if (last_price == theAsk)
                    {
                        lx.ForeColor = Color.Green; 
                        lx.Text = (listTimeSales[0]);
                        lx.SubItems.Add(strShareSize);
                        lx.SubItems.Add(strSaleTime); 
                        listViewTns.Items.Insert(0, lx); // use Insert instead of Add listView.Items.Add(li); 
                    }
                    
                    else if (last_price == theBid)
                    {
                        lx.ForeColor = Color.Red;
                        lx.Text = (listTimeSales[0]);
                        lx.SubItems.Add(strShareSize);
                        lx.SubItems.Add(strSaleTime);
                        listViewTns.Items.Insert(0, lx);

                        lbData.Items.Insert(0, strSaleTime);
                    }
                    
                    else if (last_price > myMean && last_price < theAsk)
                    {
                        lx.ForeColor = Color.Lime;
                        lx.Text = (listTimeSales[0]);
                        lx.SubItems.Add(strShareSize);
                        lx.SubItems.Add(strSaleTime);
                        listViewTns.Items.Insert(0, lx);

                        lbData.Items.Add(epoch);
                    }
                    else
                    {
                        lx.ForeColor = Color.DarkRed;
                        lx.Text = (listTimeSales[0]);
                        lx.SubItems.Add(strShareSize);
                        lx.SubItems.Add(strSaleTime);
                        listViewTns.Items.Insert(0, lx);
                    }
                }
                catch
                {

                }
            }
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.eConnect("", 7496, 0);

            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();

            new Thread(() =>
            {
                while (ibClient.ClientSocket.IsConnected())
                {
                    ibClient.Signal.waitForSignal();
                    reader.processMsgs();
                }


            })
            {IsBackground = true}.Start();

            while (ibClient.NextOrderId <= 0) { }

            ibClient.myform = (Form1)Application.OpenForms[0];

            getData();

        }

        private void getData()
        {
            ibClient.ClientSocket.cancelMktData(1);
            listViewTns.Items.Clear();
            IBApi.Contract contract = new IBApi.Contract();
            List<IBApi.TagValue> mktDataOptions = new List<IBApi.TagValue>();

            contract.Symbol = cbSymbol.Text;
            contract.SecType = "STK";           // STK stands for Stock
            contract.Exchange = "SMART";        // As General Exchange
            contract.PrimaryExch = "ISLAND";    // Either ISLAND or NYSE
            contract.Currency = "USD";          // May be changed

            ibClient.ClientSocket.reqMarketDataType(1);    //Delayed data = 3, live data = 1
            ibClient.ClientSocket.reqMktData(1, contract, "233", false, false, mktDataOptions);


        }

        public void AddTextBoxItemTickPrice(string _tickPrice)
        {
            if (this.tbLast.InvokeRequired)
            {
                SetTextCallbackTickPrice d = new SetTextCallbackTickPrice(AddTextBoxItemTickPrice);
                try
                {
                    this.Invoke(d, new object[] { _tickPrice });
                }
                catch (Exception e)
                {
                    Console.WriteLine("This comes from AddTextBoxItemTickPrice, Form1.cs", e.ToString());
                }
            }
            else
            {
                string[] tickerPrice = new string[] { _tickPrice };
                tickerPrice = _tickPrice.Split(',');

                if (Convert.ToInt32(tickerPrice[0]) == 1)
                {
                    if (Convert.ToInt32(tickerPrice[1]) == 4){this.tbLast.Text = tickerPrice[2];}        // Delayed Last Quote 68
                    else if (Convert.ToInt32(tickerPrice[1]) == 2) { this.tbAsk.Text = tickerPrice[2]; } // Delayed Ask Quote 67
                    else if (Convert.ToInt32(tickerPrice[1]) == 1) { this.tbAsk.Text = tickerPrice[2]; } // Delayed Ask Quote 66 

                }
                        
            }
        }

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.eDisconnect();
        }

        private void tbAsk_Click(object sender, EventArgs e)
        {
            numPrice.Value = Convert.ToDecimal(tbAsk.Text);
        }

        private void tbBid_Click(object sender, EventArgs e)
        {
            numPrice.Value = Convert.ToDecimal(tbBid.Text);
        }

        private void tbLast_Click(object sender, EventArgs e)
        {
            numPrice.Value = Convert.ToDecimal(tbLast.Text);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string side = "Sell";
            send_order(side);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string side = "Buy";
            send_order(side);
        }


        public void send_order(string side)
        {
            
            IBApi.Contract contract = new IBApi.Contract();

            
            contract.Symbol = cbSymbol.Text;
            contract.SecType = "STK";
            contract.Exchange = cbMarket.Text;
            contract.PrimaryExch = "ISLAND";
            contract.Currency = "USD";

            IBApi.Order order = new IBApi.Order();
            
            order.OrderId = order_id;
            order.Action = side;
            order.OrderType = cbOrderType.Text;
            order.TotalQuantity = Convert.ToDouble(numQuantity.Value);
            order.LmtPrice = Convert.ToDouble(numPrice.Value);

            if (cbOrderType.Text == "STP")
            {
                order.AuxPrice = Convert.ToDouble(numPrice.Value);
            }
            
            order.DisplaySize = Convert.ToInt32(tbVisible.Text);
            order.OutsideRth = chkOutside.Checked;

            ibClient.ClientSocket.placeOrder(order_id, contract, order);

            order_id++;
            tbValidID.Text = Convert.ToString(order_id);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1_counter == 0)
            {
                timer1.Stop();
                
                numPrice.Value = Convert.ToDecimal(tbBid.Text);
                timer1_counter = 5; 
            }
            timer1_counter--; 
        }
    }
}
