<%--*********************************************************************************************
 * Name            - Alexander Spurlock
 * Email Address   - spurloag@mail.uc.com
 * Assignment #    - Assignment #02
 * Due date        - 1/29/2020
 * Course          - IT3047C, ASP.NET
 * Semester        - Spring, 2020
 * Description     - The user fills in a number, clicks the button, and your code-behind will generate View controls 
                      inside the MultiView , drop-down to navigate the MultiView and something visually interesting 
                    in each View control so we can tell them apart. 
                     Note: your logic should work more than once without stopping and restarting your page.
//* CITE and OTHER HELP: 
//                      FINAL SOLUTION: https://forums.asp.net/t/1586152.aspx?ActiveViewIndex+is+being+set+to+0+
//                      https://www.tutorialspoint.com/asp.net/asp.net_multi_views.htm
//
//                      HELP: Worked with Joseph Svintsitsky.
 **********************************************************************************************--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assignment02.aspx.cs" Inherits="Assignment02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 2</title>
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
</head>
<body>
    <header class="header">
        <h1>Assignment 2</h1>
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
            <form id="form1" runat="server">

                

                <div runat="server" id="txtBox_and_btn_div">
                    <asp:TextBox ID="txtBox_UserNumber" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_GetUserNumber" runat="server" Text="Go" OnClick="btn_GetUserNumber_Click" />
                </div>

                <div runat="server" id="the_rest_div">
                    <asp:ListBox ID="lstBox_ViewTabs" runat="server" Width="201px" Height="107px"></asp:ListBox><br />
                    <asp:Button ID="btn_LoadView" runat="server" OnClick="btn_LoadView_Click" Text="Load View"/>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:MultiView ID="mltView_FromList" runat="server"></asp:MultiView>
                </div>
                
            </form>
        </main>

    </div>
    <footer>
        <small>
            Alex Spurlock<br />
            Week 2 Assignment(2)<br />
            DUE: 1/29/2020
        </small>
    </footer>
</body>
</html>
