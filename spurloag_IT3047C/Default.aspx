<%--*********************************************************************************************
 * Name            - Alexander Spurlock
 * Email Address   - spurloag@mail.uc.com
 * Assignment #    - Assignment #01
 * Due date        - 1/22/2020
 * Course          - IT3047C, ASP.NET
 * Semester        - Spring, 2020
 * Description     - A landing page for IT3047C, during Spring semester, year 2020
 **********************************************************************************************--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
    <link rel="stylesheet" type="text/css" href="mobile.css" />
</head>
<body runat="server">

    <header>
    <h1>
    Alex Spurlock
    </h1>
    </header>

    <div id="wrapper">

        <main>

            <div class="projects-div">
            <p class="projects-list-classname">ASP.NET</p>
                  
                <ul class="projects-list">

                    <li><a href="Assignment01.aspx">Project Euler Problem</a></li>
                    <li><a href="Assignment02.aspx">Dynamic MultiView</a></li>
                    <li><a href="Assignment03.aspx">Car Model</a></li>
                    
                </ul>
                  
            </div>
        
        </main>

    </div>
        <footer style="text-align:center;">
            <small>
                Alexander Spurlock<br />
                spurloag@mail.uc.edu
            </small>
        </footer>    
</body>
</html>
