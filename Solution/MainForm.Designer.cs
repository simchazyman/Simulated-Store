namespace SemesterProject
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ViewItemsTab = new System.Windows.Forms.TabPage();
            this.ListOfItems = new System.Windows.Forms.ListView();
            this.PurchaseTab = new System.Windows.Forms.TabPage();
            this.label = new System.Windows.Forms.Label();
            this.PurchaseBtn = new System.Windows.Forms.Button();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ItemIDLlb = new System.Windows.Forms.Label();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.BalanceTab = new System.Windows.Forms.TabPage();
            this.PayBtn = new System.Windows.Forms.Button();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.EnterAmountLbl = new System.Windows.Forms.Label();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.HistoryTab = new System.Windows.Forms.TabPage();
            this.ToLbl = new System.Windows.Forms.Label();
            this.FromLbl = new System.Windows.Forms.Label();
            this.DateFilterChc = new System.Windows.Forms.CheckBox();
            this.priceFilterChc = new System.Windows.Forms.CheckBox();
            this.HistoryList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperPriceTxt = new System.Windows.Forms.TextBox();
            this.LowerPriceTxt = new System.Windows.Forms.TextBox();
            this.UpperDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LowerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UserLbl = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.ViewItemsTab.SuspendLayout();
            this.PurchaseTab.SuspendLayout();
            this.BalanceTab.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ViewItemsTab);
            this.TabControl.Controls.Add(this.PurchaseTab);
            this.TabControl.Controls.Add(this.BalanceTab);
            this.TabControl.Controls.Add(this.HistoryTab);
            this.TabControl.Location = new System.Drawing.Point(62, 76);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(670, 334);
            this.TabControl.TabIndex = 0;
            // 
            // ViewItemsTab
            // 
            this.ViewItemsTab.Controls.Add(this.ListOfItems);
            this.ViewItemsTab.Location = new System.Drawing.Point(4, 25);
            this.ViewItemsTab.Name = "ViewItemsTab";
            this.ViewItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewItemsTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ViewItemsTab.Size = new System.Drawing.Size(662, 305);
            this.ViewItemsTab.TabIndex = 0;
            this.ViewItemsTab.Text = "View Items";
            this.ViewItemsTab.UseVisualStyleBackColor = true;
            // 
            // ListOfItems
            // 
            this.ListOfItems.FullRowSelect = true;
            this.ListOfItems.HideSelection = false;
            this.ListOfItems.Location = new System.Drawing.Point(65, 19);
            this.ListOfItems.Name = "ListOfItems";
            this.ListOfItems.Size = new System.Drawing.Size(549, 240);
            this.ListOfItems.TabIndex = 0;
            this.ListOfItems.UseCompatibleStateImageBehavior = false;
            this.ListOfItems.View = System.Windows.Forms.View.List;
            // 
            // PurchaseTab
            // 
            this.PurchaseTab.Controls.Add(this.label);
            this.PurchaseTab.Controls.Add(this.PurchaseBtn);
            this.PurchaseTab.Controls.Add(this.TotalLbl);
            this.PurchaseTab.Controls.Add(this.QuantityLbl);
            this.PurchaseTab.Controls.Add(this.ItemIDLlb);
            this.PurchaseTab.Controls.Add(this.QuantityTxt);
            this.PurchaseTab.Controls.Add(this.IDTxt);
            this.PurchaseTab.Location = new System.Drawing.Point(4, 25);
            this.PurchaseTab.Name = "PurchaseTab";
            this.PurchaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.PurchaseTab.Size = new System.Drawing.Size(662, 305);
            this.PurchaseTab.TabIndex = 1;
            this.PurchaseTab.Text = "Purchase";
            this.PurchaseTab.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(379, 246);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(240, 16);
            this.label.TabIndex = 6;
            this.label.Text = "Total will be added to account balance.";
            // 
            // PurchaseBtn
            // 
            this.PurchaseBtn.Location = new System.Drawing.Point(423, 157);
            this.PurchaseBtn.Name = "PurchaseBtn";
            this.PurchaseBtn.Size = new System.Drawing.Size(131, 54);
            this.PurchaseBtn.TabIndex = 5;
            this.PurchaseBtn.Text = "Purchase";
            this.PurchaseBtn.UseVisualStyleBackColor = true;
            this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(121, 48);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(101, 16);
            this.TotalLbl.TabIndex = 4;
            this.TotalLbl.Text = "Enter valid input";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(121, 179);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuantityLbl.Size = new System.Drawing.Size(55, 16);
            this.QuantityLbl.TabIndex = 3;
            this.QuantityLbl.Text = "Quantity";
            // 
            // ItemIDLlb
            // 
            this.ItemIDLlb.AutoSize = true;
            this.ItemIDLlb.Location = new System.Drawing.Point(121, 130);
            this.ItemIDLlb.Name = "ItemIDLlb";
            this.ItemIDLlb.Size = new System.Drawing.Size(45, 16);
            this.ItemIDLlb.TabIndex = 2;
            this.ItemIDLlb.Text = "ItemID";
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(192, 173);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuantityTxt.Size = new System.Drawing.Size(100, 22);
            this.QuantityTxt.TabIndex = 1;
            this.QuantityTxt.Text = "1";
            this.QuantityTxt.TextChanged += new System.EventHandler(this.QuantityTxt_TextChanged);
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(192, 130);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IDTxt.Size = new System.Drawing.Size(100, 22);
            this.IDTxt.TabIndex = 0;
            this.IDTxt.TextChanged += new System.EventHandler(this.IDTxt_TextChanged);
            // 
            // BalanceTab
            // 
            this.BalanceTab.Controls.Add(this.PayBtn);
            this.BalanceTab.Controls.Add(this.AmountTxt);
            this.BalanceTab.Controls.Add(this.EnterAmountLbl);
            this.BalanceTab.Controls.Add(this.BalanceLbl);
            this.BalanceTab.Controls.Add(this.MessageLbl);
            this.BalanceTab.Location = new System.Drawing.Point(4, 25);
            this.BalanceTab.Name = "BalanceTab";
            this.BalanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.BalanceTab.Size = new System.Drawing.Size(662, 305);
            this.BalanceTab.TabIndex = 2;
            this.BalanceTab.Text = "Balance";
            this.BalanceTab.UseVisualStyleBackColor = true;
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(211, 222);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(130, 49);
            this.PayBtn.TabIndex = 4;
            this.PayBtn.Text = "Pay";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(299, 183);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(100, 22);
            this.AmountTxt.TabIndex = 3;
            // 
            // EnterAmountLbl
            // 
            this.EnterAmountLbl.AutoSize = true;
            this.EnterAmountLbl.Location = new System.Drawing.Point(134, 189);
            this.EnterAmountLbl.Name = "EnterAmountLbl";
            this.EnterAmountLbl.Size = new System.Drawing.Size(127, 16);
            this.EnterAmountLbl.TabIndex = 2;
            this.EnterAmountLbl.Text = "Enter Amount to Pay";
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.Location = new System.Drawing.Point(242, 118);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(31, 16);
            this.BalanceLbl.TabIndex = 1;
            this.BalanceLbl.Text = "xxxx";
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(197, 84);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(136, 16);
            this.MessageLbl.TabIndex = 0;
            this.MessageLbl.Text = "Your Current Balance:";
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.ToLbl);
            this.HistoryTab.Controls.Add(this.FromLbl);
            this.HistoryTab.Controls.Add(this.DateFilterChc);
            this.HistoryTab.Controls.Add(this.priceFilterChc);
            this.HistoryTab.Controls.Add(this.HistoryList);
            this.HistoryTab.Controls.Add(this.label2);
            this.HistoryTab.Controls.Add(this.label1);
            this.HistoryTab.Controls.Add(this.UpperPriceTxt);
            this.HistoryTab.Controls.Add(this.LowerPriceTxt);
            this.HistoryTab.Controls.Add(this.UpperDatePicker);
            this.HistoryTab.Controls.Add(this.LowerDatePicker);
            this.HistoryTab.Location = new System.Drawing.Point(4, 25);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTab.Size = new System.Drawing.Size(662, 305);
            this.HistoryTab.TabIndex = 3;
            this.HistoryTab.Text = "History";
            this.HistoryTab.UseVisualStyleBackColor = true;
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(343, 277);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(33, 16);
            this.ToLbl.TabIndex = 13;
            this.ToLbl.Text = "Until";
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Location = new System.Drawing.Point(343, 249);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(38, 16);
            this.FromLbl.TabIndex = 12;
            this.FromLbl.Text = "From";
            // 
            // DateFilterChc
            // 
            this.DateFilterChc.AutoSize = true;
            this.DateFilterChc.Location = new System.Drawing.Point(450, 203);
            this.DateFilterChc.Name = "DateFilterChc";
            this.DateFilterChc.Size = new System.Drawing.Size(108, 20);
            this.DateFilterChc.TabIndex = 11;
            this.DateFilterChc.Text = "Filter by Date";
            this.DateFilterChc.UseVisualStyleBackColor = true;
            this.DateFilterChc.CheckedChanged += new System.EventHandler(this.DateFilterChc_CheckedChanged);
            // 
            // priceFilterChc
            // 
            this.priceFilterChc.AutoSize = true;
            this.priceFilterChc.Location = new System.Drawing.Point(96, 203);
            this.priceFilterChc.Name = "priceFilterChc";
            this.priceFilterChc.Size = new System.Drawing.Size(110, 20);
            this.priceFilterChc.TabIndex = 10;
            this.priceFilterChc.Text = "Filter by Price";
            this.priceFilterChc.UseVisualStyleBackColor = true;
            this.priceFilterChc.CheckedChanged += new System.EventHandler(this.PriceFilterChc_CheckedChanged);
            // 
            // HistoryList
            // 
            this.HistoryList.HideSelection = false;
            this.HistoryList.Location = new System.Drawing.Point(17, 19);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(639, 150);
            this.HistoryList.TabIndex = 9;
            this.HistoryList.UseCompatibleStateImageBehavior = false;
            this.HistoryList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lower Than:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Higher Than:";
            // 
            // UpperPriceTxt
            // 
            this.UpperPriceTxt.Location = new System.Drawing.Point(110, 266);
            this.UpperPriceTxt.Name = "UpperPriceTxt";
            this.UpperPriceTxt.Size = new System.Drawing.Size(100, 22);
            this.UpperPriceTxt.TabIndex = 6;
            this.UpperPriceTxt.TextChanged += new System.EventHandler(this.UpperPriceTxt_TextChanged);
            // 
            // LowerPriceTxt
            // 
            this.LowerPriceTxt.Location = new System.Drawing.Point(110, 238);
            this.LowerPriceTxt.Name = "LowerPriceTxt";
            this.LowerPriceTxt.Size = new System.Drawing.Size(100, 22);
            this.LowerPriceTxt.TabIndex = 5;
            this.LowerPriceTxt.TextChanged += new System.EventHandler(this.LowerPriceTxt_TextChanged);
            // 
            // UpperDatePicker
            // 
            this.UpperDatePicker.Location = new System.Drawing.Point(393, 272);
            this.UpperDatePicker.Name = "UpperDatePicker";
            this.UpperDatePicker.Size = new System.Drawing.Size(200, 22);
            this.UpperDatePicker.TabIndex = 3;
            this.UpperDatePicker.ValueChanged += new System.EventHandler(this.UpperDatePicker_ValueChanged);
            // 
            // LowerDatePicker
            // 
            this.LowerDatePicker.Location = new System.Drawing.Point(393, 244);
            this.LowerDatePicker.Name = "LowerDatePicker";
            this.LowerDatePicker.Size = new System.Drawing.Size(200, 22);
            this.LowerDatePicker.TabIndex = 2;
            this.LowerDatePicker.ValueChanged += new System.EventHandler(this.LowerDatePicker_ValueChanged);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(80, 40);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(39, 16);
            this.UserLbl.TabIndex = 1;
            this.UserLbl.Text = "User:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(536, 33);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 37);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.ViewItemsTab.ResumeLayout(false);
            this.PurchaseTab.ResumeLayout(false);
            this.PurchaseTab.PerformLayout();
            this.BalanceTab.ResumeLayout(false);
            this.BalanceTab.PerformLayout();
            this.HistoryTab.ResumeLayout(false);
            this.HistoryTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ViewItemsTab;
        private System.Windows.Forms.TabPage PurchaseTab;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.TabPage BalanceTab;
        private System.Windows.Forms.TabPage HistoryTab;
        private System.Windows.Forms.ListView ListOfItems;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Button PurchaseBtn;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label ItemIDLlb;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label EnterAmountLbl;
        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.DateTimePicker UpperDatePicker;
        private System.Windows.Forms.DateTimePicker LowerDatePicker;
        private System.Windows.Forms.ListView HistoryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpperPriceTxt;
        private System.Windows.Forms.TextBox LowerPriceTxt;
        private System.Windows.Forms.CheckBox DateFilterChc;
        private System.Windows.Forms.CheckBox priceFilterChc;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Label FromLbl;
    }
}