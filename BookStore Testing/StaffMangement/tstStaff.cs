﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing.StaffMangement
{
    [TestClass]
    public class tstStaff
    {
            //creating an instance of the class we want to create
            clsStaffCollections AStaff = new clsStaffCollections();
            //Test System
            [TestMethod]
            public void InstanceOK()
            {
                string SomeStaffName = "JohnSmith";
            //Assigning the data to the property
            AStaff.StaffInstance = SomeStaffName;
                //testing to see that it exists
                Assert.IsNotNull(AStaff);
            }
            [TestMethod]
            public void ActiveOK()
            {

                Boolean TestData;
                TestData = true;
                AStaff.Active = TestData;
                Assert.AreEqual(TestData, AStaff.Active);

            }
            [TestMethod]
            public void Staff_NameOK()
            {

                //Creating the test data to be assigned to the properties
                string Name = "JohnSmith";
                //assign the data to the property
                AStaff.Staff_Name = Name;
                //testing ton see that the 2 values are the same
                Assert.AreEqual(Name, AStaff.Staff_Name);
            }
            [TestMethod]
            public void ValidMethodOK()
            {

                //create a string varible to store the result of the validation
                string Error = "";
                //create some test data to test the method
                string Name = "JohnSmith";
                //invoke the method
                Error = AStaff.Valid(Name);
                //test to see that the result is ok(no error returned)
                Assert.AreEqual(Error, "");


            }

            //Field Testing Below
            //Staff_Name Tests

            [TestMethod]
            //this test covers both extreme and -1 min tests
            public void NameMinMinus1()
            {
                //testing the minimum for the field Staff_Name -1
                string TestData;
                TestData = "";
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreNotEqual(Error, "");//AreNotEqual means if Fails the ValidMethod then the test passes as the Vaild Method has worked


            }
            [TestMethod]
            //min test
            public void NameMin()
            {
                //testing the minimum for the field Staff_Name
                string TestData;
                TestData = "A";
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
            }
            [TestMethod]
            //Max -1 Test
            public void NameMaxMinus1()
            {
                string TestData = "";
                TestData = TestData.PadRight(19, 'A');
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
            }
            [TestMethod]
            //Max Test
            public void NameMax()
            {
                string TestData = "";
                TestData = TestData.PadRight(20, 'A');
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
            }

            [TestMethod]
            //Max +1 Test
            public void NameMaxPlus1()
            {
                string TestData = "";
                TestData = TestData.PadRight(21, 'A');
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreNotEqual(Error, "");//AreNotEqual means if Fails the ValidMethod then the test passes as the Vaild Method has worked


            }
            [TestMethod]
            //Mid Test
            public void NameMid()
            {
                string TestData = "";
                TestData = TestData.PadRight(10, 'A');
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
            }
            [TestMethod]
            //Max Extreme Test
            public void NameMaxExtreme()
            {
                string TestData = "";
                TestData = TestData.PadRight(500, 'A');
                string Error;
                Error = AStaff.Valid(TestData);
                Assert.AreNotEqual(Error, "");//AreNotEqual means if Fails the ValidMethod then the test passes as the Vaild Method has worked


            }


        }

    }
