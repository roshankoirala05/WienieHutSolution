'Created By : Roshan Koirala
' CSCI 2000, 
' Date : 10/27/2013
' Program Topic : A visual Basic Program to calculate the customer's total cost of Wild Wienie Hut Snack.
' Program Description : The program uses textbox to allow the user to input the number of items they want. 
'                        Use of  Sub procedure and Function Procedure to calculate the total cost


Option Explicit On
Option Strict On
Option Infer Off

Public Class nchilllabel

    Private Sub calculatebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebutton.Click
        ' Declaring All the variables that have been used 
        Dim totalchillidogprice, totalfriesprice, totaldrinkprice, subtotal, totaltaxprice, Totalprice As Double
        Dim numberofchillidogs, numberoffries, numberofdrink As Integer

        ' Assigning the value entered in textbox to the variables using Try parse
        Integer.TryParse(nchilitextbox.Text, numberofchillidogs)
        Integer.TryParse(nfriestextbox.Text, numberoffries)
        Integer.TryParse(ndrinkstextbox.Text, numberofdrink)

        ' Using chillidogprice Function to calculate the total chillidog price
        totalchillidogprice = chillidogprice(numberofchillidogs)

        ' Using friesprice Function to calculate the total fries price
        totalfriesprice = friesprice(numberoffries)

        ' Using drinkprice Function to calculate the total drink price
        totaldrinkprice = drinkprice(numberofdrink)

        subtotal = totalchillidogprice + totalfriesprice + totaldrinkprice ' Assigning the total price of food in subtotal variable

        ' Using taxprice Function to calculate the total tax price
        totaltaxprice = taxprice(subtotal)

        Totalprice = subtotal + totaltaxprice ' Assigning the grand total value in total price 

        ' Invoking the Sub- procedure called totaldisplay which displays the result in the respective labels
        Call totaldisplay(subtotal, totaltaxprice, Totalprice)
    End Sub
    ' Defining all the functions that have been invoked 
    Private Function chillidogprice(ByVal numberofchillidogs As Integer) As Double
        Dim tcdp As Double
        If numberofchillidogs = 1 Then

            Const Rateofchilli As Double = 2.5
            tcdp = Rateofchilli * numberofchillidogs

        ElseIf numberofchillidogs >= 2 AndAlso numberofchillidogs <= 4 Then

            Const Rateofchilli As Double = 2.25
            tcdp = Rateofchilli * numberofchillidogs

        ElseIf numberofchillidogs >= 5 Then

            Const Rateofchilli As Double = 2
            tcdp = Rateofchilli * numberofchillidogs

        End If
        Return tcdp
    End Function

    Private Function friesprice(ByVal numberoffries As Integer) As Double
        Dim tfp As Double
        Const Rateoffries As Double = 1.25
        tfp = numberoffries * Rateoffries
        Return tfp
    End Function
    Private Function drinkprice(ByVal numberofdrink As Integer) As Double
        Dim tdp As Double
        Const Rateofdrink As Double = 0.75
        tdp = numberofdrink * Rateofdrink
        Return tdp
    End Function
    Private Function taxprice(ByVal subtotal As Double) As Double
        Dim ttp As Double
        Const taxrate As Double = 0.04
        ttp = subtotal * taxrate
        Return ttp
    End Function
    ' Defining the Sub Procedure that has been invoked
    Private Sub totaldisplay(ByVal subtotal As Double, ByVal totaltaxprice As Double, ByVal totalprice As Double)
        costoffoodlabel.Text = subtotal.ToString("C2")
        totaltaxlabel.Text = totaltaxprice.ToString("C2")
        grandtotallabel.Text = totalprice.ToString("C2")
    End Sub
    ' Code for exit button
    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub
    ' Code for clear buttom
    Private Sub clearbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbutton.Click
        nchilitextbox.Text = String.Empty
        nfriestextbox.Text = String.Empty
        ndrinkstextbox.Text = String.Empty
        costoffoodlabel.Text = String.Empty
        totaltaxlabel.Text = String.Empty
        grandtotallabel.Text = String.Empty


    End Sub
End Class
