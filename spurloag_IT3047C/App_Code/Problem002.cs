//<%--*********************************************************************************************
// * Name            - Alexander Spurlock
// * Email Address   - spurloag @mail.uc.com
// * Assignment #    - Assignment #01
// * Due date        - 1/22/2020
// * Course          - IT3047C, ASP.NET
// * Semester        - Spring, 2020
// * Description     - A landing page for IT3047C, during Spring semester, year 2020
// **********************************************************************************************--%>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Problem002
{

    public int Solve()
    {

        int first = 0;
        int next = 1;
        int result = 0;
        int sum = 0;

        while (result < 4000000)
        {
            result = first + next;
            first = next;
            next = result;
            if (result % 2 == 0)
            {
                sum += result;
            }
        }
        return sum;
    }

}