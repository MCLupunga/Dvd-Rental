﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace CustomersTestFramework
{
    [TestClass]
    public class tstCustomersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomersListOK()
        {
            //create an instance of the class we want to create
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            //create some test data to assign to the property
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create the item to the list
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.DOB = DateTime.Now.Date.AddYears(-18);
            TestItem.PhoneNo = "07865432345";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomersList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomersPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            //create some test data to assign to the property
            clsCustomers TestCustomers = new clsCustomers();
            //set the properties of the test object
            TestCustomers.Active = true;
            TestCustomers.CustomerNo = 1;
            TestCustomers.FirstName = "John";
            TestCustomers.LastName = "Smith";
            TestCustomers.DOB = DateTime.Now.Date.AddYears(-18);
            TestCustomers.PhoneNo = "07865432345";
            TestCustomers.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomers = TestCustomers;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomers, TestCustomers);
        }


    }
}
