Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CalcApp
    Dim FirstNum, SecondNum, Ans As Decimal
    Dim Operations As Integer
    Dim Opr_Selecter As Boolean = False
    Dim CurrentOperator As String = "" ' Store the current operator symbol

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppendNumber("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AppendNumber("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AppendNumber("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AppendNumber("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AppendNumber("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AppendNumber("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AppendNumber("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AppendNumber("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AppendNumber("9")
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        AppendNumber("0")
    End Sub

    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles ButtonDot.Click
        If Not TextBox.Text.Contains(".") Then
            AppendNumber(".")
        End If
    End Sub

    Private Sub AppendNumber(number As String)
        If TextBox.Text = "0" And number <> "." Then
            TextBox.Text = number
        Else
            TextBox.Text &= number
        End If
    End Sub
    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        PerformOperation(1, "+")
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        PerformOperation(2, "-")
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        PerformOperation(3, "*")
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        PerformOperation(4, "/")
    End Sub

    Private Sub PerformOperation(operation As Integer, operatorSymbol As String)
        If String.IsNullOrEmpty(TextBox.Text) Then
            ' Handle empty textbox case
            TextBox.Text = "Error: Enter a number first"
            Opr_Selecter = False
            Return ' Exit the subroutine
        End If

        If Opr_Selecter Then
            ButtonEquals_Click(Me, EventArgs.Empty)
        End If

        Operations = operation
        FirstNum = Decimal.Parse(TextBox.Text)
        Opr_Selecter = True
        CurrentOperator = operatorSymbol
        LabelOperator.Text = CurrentOperator ' Display the operator
        TextBox.Text = "" ' Clear for the second number
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        If Opr_Selecter Then
            SecondNum = Decimal.Parse(TextBox.Text)

            Select Case Operations
                Case 1
                    TextBox.Text = (FirstNum + SecondNum).ToString()
                Case 2
                    TextBox.Text = (FirstNum - SecondNum).ToString()
                Case 3
                    TextBox.Text = (FirstNum * SecondNum).ToString()
                Case 4
                    If SecondNum = 0 Then
                        TextBox.Text = "Cannot divide by zero"
                    Else
                        TextBox.Text = (FirstNum / SecondNum).ToString()
                    End If
                Case 5
                    TextBox.Text = (FirstNum / 100).ToString()
            End Select

            Opr_Selecter = False 'Reset the operation flag
        End If
        LabelOperator.Text = ""
    End Sub

    Private Sub ButtonPercent_Click(sender As Object, e As EventArgs) Handles ButtonPercent.Click
        PerformOperation(5, "%")
        ButtonEquals_Click(sender, e)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox.Text = "0"
        FirstNum = 0
        SecondNum = 0
        Operations = 0
        LabelOperator.Text = ""
        Opr_Selecter = False

    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If TextBox.Text.Length > 0 Then
            TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1)
            If TextBox.Text.Length = 0 Then
                TextBox.Text = "0"
            End If
        End If
    End Sub

End Class