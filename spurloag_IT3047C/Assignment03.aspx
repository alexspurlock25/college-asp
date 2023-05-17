<%--//*********************************************************************************************
//* Name            - Alexander Spurlock
//* Email Address   - spurloag @mail.uc.com
//* Assignment #    - Assignment #03
//* Due date        - 2/5/2020
//* Course          - IT3047C, ASP.NET
//* Semester        - Spring, 2020
//* Description     - A webform that allowes a user to select a car, and later select options 
//                    only available to that car. As the user adds the options from a ListBox, those options are
//                    moved to a second ListBox. User can then click "done", which leads him/her to
//                    a secondarty page with the car and options the user had selected.
//
//* CITE             - Dictionary with List<String> as values https://stackoverflow.com/questions/17887407/dictionary-with-list-of-strings-as-value
//                   - Spliting words https://stackoverflow.com/questions/53138384/how-to-read-the-first-word-in-a-text-file-and-display-it-in-a-richtextbox
//                   - File reading, and currect way of getting the path of a file: Professor Nicholson
//**********************************************************************************************--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assignment03.aspx.cs" Inherits="Assignment03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
</head>
<body>
    <header class="header">
        <h1>Assignment 3</h1>
    </header>

    <div class="nav-div">
        <nav>
            <ul class="ul-nav">
                <li><a href="Default.aspx">Home</a></li>
            </ul>
        </nav>
    </div>
    
    <div id="wrapper">

        <main>

            <form runat="server">
                
                <div class="drop-down-list">
                    <asp:DropDownList CssClass="drop-down-list" ID="drpDwn_Cars" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpDwn_Cars_SelectedIndexChanged" Height="17px" Width="91px"></asp:DropDownList>
                    <br />
                    <br />
                </div>

                <div class="box-container">

                    <div class="box-1">
                        <asp:ListBox ID="lst_CarOptions" runat="server" SelectionMode="Multiple" Height="150px" Width="140px"></asp:ListBox>
                        <asp:Button ID="btn_Add" runat="server" OnClick="btn_Add_Click" Text="Add" Width="100px" />
                    </div>

                    <div class="box-2">
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btn_RemoveAll" runat="server" Text="Remove All" OnClick="btn_RemoveAll_Click" Width="100px" />
                        <asp:Button ID="btn_AddAll" runat="server" Text="Add All" OnClick="btn_AddAll_Click" Width="100px" />
                    </div>

                    <div class="box-3">
                        <asp:ListBox ID="lstBox_SelectedOptions" runat="server" SelectionMode="Multiple" Height="150px" Width="139px"></asp:ListBox>
                        <asp:Button ID="btn_Remove" runat="server" Text="Remove" OnClick="btn_Remove_Click" Width="100px" />
                    </div>

                </div>

                
                <div class="done-button">
                    <asp:Button ID="btn_Done" runat="server" Text="Done" OnClick="btn_Done_Click" />
                </div>
                
            </form>

        </main>

    </div>
        <footer>
        <small>
            Alex Spurlock<br />
            Week 3 Assignment(3)<br />
            DUE: 2/6/2020
        </small>
    </footer>

</body>
</html>
