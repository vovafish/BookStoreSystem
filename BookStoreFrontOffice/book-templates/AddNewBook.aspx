﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewBook.aspx.cs" Inherits="AddNewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Book</title>
    <link href="../styles/book-css/main.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="container">
                <div class="top-nav">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" class="btn" OnClick="btnLogout_Click" />
                </div>
                <main class="main-book">
                    <div class="form">
                        <div class="form-input">
                            <div class="error">
                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="form-wrapper">

                                <div class="form-input--fields form-design">
                                    <div>
                                        <div>
                                            <asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
                                            <asp:TextBox type="text" ID="txtAuthor" runat="server" placeholder="Author is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
                                            <asp:TextBox type="text" ID="txtTitle" runat="server" placeholder="Title is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label3" runat="server" Text="Edition"></asp:Label>
                                            <asp:TextBox type="text" ID="txtEdition" runat="server" placeholder="Edition is.."></asp:TextBox>
                                        </div>
                                    </div>
                                    <div>
                                        <div>
                                            <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
                                            <asp:TextBox type="text" ID="txtPrice" runat="server" placeholder="Price is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label5" runat="server" Text="Pub Year"></asp:Label>
                                            <asp:TextBox type="text" ID="txtPubYear" runat="server" placeholder="Publication year is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label6" runat="server" Text="Shelf No"></asp:Label>
                                            <asp:TextBox type="text" ID="txtShelfNo" runat="server" placeholder="Shelf number is.."></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Label ID="Label7" runat="server" Text="Genre"></asp:Label>
                                            <asp:TextBox type="text" ID="txtGenre" runat="server" placeholder="Genre is.."></asp:TextBox>
                                        </div>
                                    <div>
                                        <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" CssClass="btn btn-cancel" />
                                        <asp:Button ID="btnCancel" CssClass="btn btn-cancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                                    </div>
                                    </div>

                                </div>
                            </div>

                        </div>
                    </div>
                </main>
            </div>
        </div>
    </form>
</body>
</html>
