'   Created by Matthew Draper
'   Last Edited On: 3/30/2017
'   LaFreniere Running Store Lab 7
'   Description: Takes input on form and calculates wages and stuffzzzz
Option Strict On

Public Class Lab7

    Const cdecRaise As Decimal = 0.03D

    ' Function takes the selected index of the listbox and returns the salary
    Private Function FindYearlyPay(ByVal intSelectedIndex As Integer) As Decimal
        Dim decDeskClerkPay As Decimal = 14900D
        Dim decAssistantManagerPay As Decimal = 34430D
        Dim decRunningSpecialistPay As Decimal = 28710D
        Dim decInventoryClerk As Decimal = 12900D
        Dim decSalary As Decimal = 0D

        Select Case intSelectedIndex
            Case 0
                decSalary = decDeskClerkPay
            Case 1
                decSalary = decAssistantManagerPay
            Case 2
                decSalary = decRunningSpecialistPay
            Case 3
                decSalary = decInventoryClerk
        End Select
        Return decSalary
    End Function
    ' Function takes the selected index of the listbox and returns the hourly pay
    Private Function FindHourlyPay(ByVal intSelectedIndex As Integer) As Decimal
        Dim decDeskClerk As Decimal = 7.4D
        Dim decAssistantManager As Decimal = 17.07D
        Dim decRunningSpecialist As Decimal = 14.24D
        Dim decInventoryClerk As Decimal = 6.39D
        Dim decHourly As Decimal = 0D

        Select Case intSelectedIndex
            Case 0
                decHourly = decDeskClerk
            Case 1
                decHourly = decAssistantManager
            Case 2
                decHourly = decRunningSpecialist
            Case 3
                decHourly = decInventoryClerk
        End Select
        Return decHourly
    End Function
    ' Event handler for the btnCalcLongTermPay click event
    Private Sub btnCalcLongTermPay_Click(sender As Object, e As EventArgs) Handles btnCalcLongTermPay.Click
        Dim decFutureSalary As Decimal
        Dim intYears As Integer = 0
        ' Try if txtNumYears can be parsed as an integer
        Try
            intYears = Integer.Parse(txtNumYears.Text)
            ' If the years entered is out of range
            If intYears < 1 Or intYears > 30 Then
                MessageBox.Show("You need to enter years is not between 0 and 30.", "Format Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNumYears.Focus()
            Else ' Else the years entered is in range
                Dim decSalary As Decimal = FindYearlyPay(lstJobs.SelectedIndex)
                decFutureSalary = decSalary + (decSalary * cdecRaise * intYears)
                lblFuture.Text = "Your future Salary will be $" & Format(decFutureSalary, "0.00")
                lblFuture.Visible = True
                btnClear.Enabled = True
                btnCalcLongTermPay.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("You need to enter years as a number.", "Format Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNumYears.Focus()
        End Try
    End Sub
    ' Event handler for the btnClear click event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnCalcLongTermPay.Enabled = False
        btnClear.Enabled = False
        txtNumYears.Visible = False
        lblSalary.ResetText()
        lblHourly.ResetText()
        lblFuture.ResetText()
        lstJobs.Focus()
    End Sub
    ' Event handler for the btnClose click event
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    ' Event handler for the lstJobs changed selected index event
    Private Sub lstJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJobs.SelectedIndexChanged
        Dim intSelectedIndex As Integer = lstJobs.SelectedIndex()
        Dim decYearlyPay As Decimal = FindYearlyPay(intSelectedIndex)
        Dim decHourlyPay As Decimal = FindHourlyPay(intSelectedIndex)
        lblSalary.Text = "Yearly Salary: $" & Format(decYearlyPay, "0.00")
        lblHourly.Text = "Hourly Pay: $" & Format(decHourlyPay, "0.00")
        btnCalcLongTermPay.Enabled = True
        txtNumYears.Visible = True
        txtNumYears.Focus()
    End Sub
    ' Clears the form on load by running a btnClear click event
    Private Sub Lab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear_Click(sender, e)
    End Sub
End Class
