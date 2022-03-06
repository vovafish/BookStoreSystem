﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;


public partial class BookViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //create a new instance of clsBook
        clsBook ABook = new clsBook();
        //get the data from the session object
        ABook = (clsBook)Session["ABook"];
        //display the house number for this entry
        Response.Write(ABook.Author);
        Response.Write(ABook.BookTitle);
        Response.Write(ABook.BookPrice);
        Response.Write(ABook.Edition);
        Response.Write(ABook.PublicationYear);
        Response.Write(ABook.GenreName);
        Response.Write(ABook.BookShelfNo);
        
    }
}