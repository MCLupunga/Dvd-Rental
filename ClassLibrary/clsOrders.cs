﻿using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for OrderNo
        private string mOrderNo;
        //private data member for CustomerID
        private string mCustomerID;
        //private data member for StockID
        private string mStockID;
        //private data member for ExpectedReturnDate
        private DateTime mExpectedReturnDate;
        //private data member for order date
        private DateTime mOrderDate;
        //private data member for PaymentMethod
        private string mPaymentMethod;

        //public property for OrderNo
        public string OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }
        }
        //public property for CustomerID
        public string CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        //public property for StockID
        public string   StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }
            set
            {
                //set the value of the private data member
                mStockID = value;
            }
        }
        //public property for ExpectedReturnDate
        public DateTime ExpectedReturnDate
        {
            get
            {
                //return the private data
                return mExpectedReturnDate;
            }
            set
            {
                //set the value of the private data member
                mExpectedReturnDate = value;
            }
        }
        //public property for OrderDate
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }
        //public property for PaymentMethod
        public string PaymentMethod
        {
            get
            {
                //return the private data
                return mPaymentMethod;
            }
            set
            {
                //set the value of the private data member
                mPaymentMethod = value;
            }
        }
        public bool Find(string OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@Order_No", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToString(DB.DataTable.Rows[0]["Order_No"]);
                mCustomerID = Convert.ToString(DB.DataTable.Rows[0]["Customer_No"]);
                mStockID = Convert.ToString(DB.DataTable.Rows[0]["Stock_ID"]);
                mExpectedReturnDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Expected_Return_Date"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_Date"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["Payment_Method"]);
                //return that everything worked ok
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string stock_ID, string expected_Return_Date, string order_Date, string customer_ID, string payment_Method)
        {
            //create a string variable to store the error
            String Error = "";
            //if Stock_ID is blank
            if (stock_ID.Length == 0)
            {
                //record the error
                Error = Error + "The Stock_ID may not be blank: ";
            }
            //if the Stock_ID is greater than 8
            if (stock_ID.Length > 8)
            {
                //record the error
                Error = Error + "The Stock_ID must be less than 8 characters";
            }
            //return any error messages
            return Error;
        }
    }
}