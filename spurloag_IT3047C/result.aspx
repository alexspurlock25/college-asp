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
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="result.aspx.cs" Inherits="result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Selected Car/Options</title>
    <link type="text/css" rel="stylesheet" href="StyleSheet.css" />
    <link type="text/css" rel="stylesheet" href="mobile.css" />
</head>
<body>

    <form id="form1" runat="server">

    <header>
        <h1>
            Results
        </h1>
    </header>
    
        <div class="nav-div">
            <nav>
                <ul class="ul-nav">
                    <li><a href="Default.aspx">Home</a></li>
                    <li><a href="Assignment03.aspx">Back</a></li>
                </ul>
            </nav>
        </div>

    <div id="wrapper">

        <main>

            <asp:Label ID="lbl_Car" Text="Car Model" runat="server"></asp:Label>
            <br />
            <p>Options you've selected:</p>
            <asp:ListBox ID="lst_OptionsResult" runat="server" Height="150px" Width="100px"></asp:ListBox>

        </main>

    </div>

    
    </form>

    
</body>
</html>
