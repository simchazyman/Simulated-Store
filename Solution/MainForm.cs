using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class MainForm : Form
    {

        /*
         * • Users can check a list of all of their purchases, all of their purchases within a certain date range,
         * and all of their purchases within a certain price range.
         */

        
        /// <summary>
        /// Instance of the user using the application
        /// </summary>     
        User user;

        /// <summary>
        /// Track total price when the user is entering the info for a purchase.
        /// </summary>
        decimal? totalPrice = null;

        /// <summary>
        /// Tracks the id of the item the user wishes to purchase.
        /// </summary>
        int itemId = -1;


        /// <summary>
        /// Limit of how much a user can owe before not being allowed to purchase more.
        /// </summary>
        const decimal LIMIT = 1000m;

   



        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set up the parts that are not affected by the user's interaction.
            UserLbl.Text = "User: " + user.Username;
            
            ResetItems();    
        }

        private void ResetItems()
        {
            ResetListOfItems();
            ResetPurchaseTab();
            BalanceLbl.Text = user.Balance.Value.ToString("C");
            ResetHistoryList();
        }


 
        /// <summary>
        /// Update the list of items on the list.
        /// </summary>
        private void ResetListOfItems()
        {

            ListOfItems.Clear();
            using (var db = new DataClasses1DataContext())
            {
                // Get a collection of all the items to show.
                var items = db.Items;



                // Make a string to display, and then put it in the ListView.
                foreach (var item in items)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("ItemID: " + item.ItemID);
                    sb.Append(";   Name: " + item.ItemName);
                    sb.Append(";   Price: " + item.Price.ToString("C"));
                    sb.Append(";   Quantity in Stock: " + item.Quantity.ToString());
                    ListViewItem listViewItem = new ListViewItem(sb.ToString());
                    ListOfItems.Items.Add(listViewItem);
                }
            }
        }


 

        /// <summary>
        /// Exits and goes back to the login screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Close();
            loginScreen.Show();
        }


        private void ResetPurchaseTab()
        {
            // Set the starting text.
            if (user.Balance > LIMIT)
            {
                TotalLbl.Text = "Cannot purchase while balance is above " + LIMIT.ToString("C");
            }
            else
            {
                TotalLbl.Text = "Enter valid input";
            }

            IDTxt.Text = "";
            QuantityTxt.Text = "1";
        }


        private void IDTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void QuantityTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        /// <summary> Method to make sure an invalid entry is not put in.
        /// Also to update the total label. </summary>
             
        private void UpdateTotal()
        {

            // Make sure they don't own more than the limit.
            // It needs to be here for a case where the user buys something that puts them over the limit.
            if (user.Balance > LIMIT)
            {
                TotalLbl.Text = "Cannot purchase while balance is above " + LIMIT.ToString("C");
                return;
            }                  


            // Make sure the new value is good.
            if (!int.TryParse(IDTxt.Text, out itemId) ||
            !int.TryParse(QuantityTxt.Text, out var quantity) || quantity < 1)
            {
            TotalLbl.Text = "Enter valid input";
            return;
            }


            // Access the data.
            using (var db = new DataClasses1DataContext())
            {
                // Get the item and only continue if it exists. Otherwise, show an error message.
                var Item = db.Items.FirstOrDefault(i => i.ItemID == itemId);
                if (Item != null) 
                    if (int.Parse(QuantityTxt.Text) <= Item.Quantity)
                    {
                        totalPrice = Decimal.Parse(QuantityTxt.Text) * Item.Price;
                        TotalLbl.Text = "Total Price of Purchase: " + totalPrice.Value.ToString("C");
                    }
                    else
                        TotalLbl.Text = "Not in stock";

                else
                    TotalLbl.Text = "Invalid ID";
            }
        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            // Make sure valid info is entered.
            if (totalPrice == null || itemId == -1)
            return;    
           
                      

            // Update the database.
            using (var db = new DataClasses1DataContext())
            {
                var item = db.Items.FirstOrDefault(i => i.ItemID == itemId);
                user = db.Users.FirstOrDefault(u => u.UserID == user.UserID);
                item.Quantity -= int.Parse(QuantityTxt.Text);
                user.Balance += totalPrice;

                Purchase purchase = new Purchase()
                {
                    PurchaseID = 1,
                    UserID = user.UserID,
                    ItemID = itemId,
                    Quantity = int.Parse(QuantityTxt.Text),
                    Amount = totalPrice.Value,
                    PurchaseDate = DateTime.Now,
                };

                db.Purchases.InsertOnSubmit(purchase);
                db.SubmitChanges();
            }

            // Reset the view.
            totalPrice = null;
            itemId = -1;            
            ResetItems();
            TotalLbl.Text = "Purchase made!";

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            // First validate the user's input.
            if (!decimal.TryParse(AmountTxt.Text, out decimal amount))
                return;

            // Update the database.
            using (var db = new DataClasses1DataContext())
            {
                user = db.Users.FirstOrDefault(u => u.UserID == user.UserID);
                user.Balance -= amount;
                db.SubmitChanges();

                // Now update the GUI.
                BalanceLbl.Text = user.Balance.Value.ToString("C");
                AmountTxt.Text = "";

                // The only thing that will be affected by this is the Purchase tab.
                ResetPurchaseTab();
            }
        }



        private void ResetHistoryList()
        {
            HistoryList.Clear();
            using (var db = new DataClasses1DataContext())
            {
                // Get a collection of all the items to show.
                var purchases = db.Purchases.Where(p => p.UserID == user.UserID);

                // Filter if the user is using a filter.
                if (priceFilterChc.Checked)
                    purchases = purchases.Where(p => p.Amount >= decimal.Parse(LowerPriceTxt.Text)
                        && p.Amount < decimal.Parse(UpperPriceTxt.Text));

                if (DateFilterChc.Checked)
                    purchases = purchases.Where(p => p.PurchaseDate < UpperDatePicker.Value.Date
                    && p.PurchaseDate > LowerDatePicker.Value.Date);


                // Make a string to display, and then put it in the ListView.
                foreach (var purchase in purchases)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Date: " + purchase.PurchaseDate.ToString());
                    sb.Append("   Amount: " + purchase.Amount.ToString("C"));
                    sb.Append("   Item(s): ");
                    var item = db.Items.First(i => i.ItemID == purchase.ItemID);
                    sb.Append(purchase.Quantity.ToString());
                    sb.Append(" " + item.ItemName + "(s)");
                    ListViewItem listViewItem = new ListViewItem(sb.ToString());
                    HistoryList.Items.Add(listViewItem);
                }
            }
        }

        private void LowerPriceTxt_TextChanged(object sender, EventArgs e)
        {
            CheckPriceBounds();
        }

        private void UpperPriceTxt_TextChanged(object sender, EventArgs e)
        {
            CheckPriceBounds();
        }

        /// <summary>
        /// Method that will check the input in the text boxes is valid.
        /// If it is not, the check will be unchecked.
        /// </summary>
        private void CheckPriceBounds()
        {
            if (!decimal.TryParse(LowerPriceTxt.Text, out decimal lowerBound)
                || !decimal.TryParse(UpperPriceTxt.Text, out decimal upperBound)
                || upperBound < lowerBound)
                priceFilterChc.Checked = false;
        }

        private void LowerDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckDateBounds();
                
        }
        private void UpperDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckDateBounds();
        }

        /// <summary>
        /// Method that will check if the input in the date boxes is invalid.
        /// If it is not, it will uncheck the box.
        /// </summary>
        private void CheckDateBounds()
        {
            if (UpperDatePicker.Value < LowerDatePicker.Value)
                DateFilterChc.Checked = false;
        }


        private void PriceFilterChc_CheckedChanged(object sender, EventArgs e)
        {

            // Prevent recursion.
            if (!priceFilterChc.Checked)
            {
                ResetHistoryList();
                return;
            }
                

            CheckPriceBounds();

            ResetHistoryList();
        }



        private void DateFilterChc_CheckedChanged(object sender, EventArgs e)
        {

            // Prevent recursion.
            if (!DateFilterChc.Checked)
            {
                ResetHistoryList();
                return;
            }
                


            CheckDateBounds();

            
            ResetHistoryList();
        }


    }
}
