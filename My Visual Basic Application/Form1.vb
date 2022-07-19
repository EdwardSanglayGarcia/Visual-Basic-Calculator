Public Class Form1

    Dim initialValue As Integer
    Dim userOperator As String

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        tbTextArea.Text += "1"
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        tbTextArea.Text += "2"
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        tbTextArea.Text += "3"
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        tbTextArea.Text += "4"
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        tbTextArea.Text += "5"
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        tbTextArea.Text += "6"
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        tbTextArea.Text += "7"
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        tbTextArea.Text += "8"
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        tbTextArea.Text += "9"
    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        tbTextArea.Text += "0"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbTextArea.Clear()
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        userOperator = "+"
        initialValue = tbTextArea.Text
        tbTextArea.Clear()
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        userOperator = "-"
        initialValue = tbTextArea.Text
        tbTextArea.Clear()
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        userOperator = "*"
        initialValue = tbTextArea.Text
        tbTextArea.Clear()
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        userOperator = "/"
        initialValue = tbTextArea.Text
        tbTextArea.Clear()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim finalAnswer As Decimal
        If (userOperator = "+") Then finalAnswer = Convert.ToInt32(initialValue) + Convert.ToInt32(tbTextArea.Text)
        If (userOperator = "-") Then finalAnswer = Convert.ToInt32(initialValue) - Convert.ToInt32(tbTextArea.Text)
        If (userOperator = "*") Then finalAnswer = Convert.ToInt32(initialValue) * Convert.ToInt32(tbTextArea.Text)
        If (userOperator = "/") Then finalAnswer = Convert.ToInt32(initialValue) / Convert.ToInt32(tbTextArea.Text)
        tbTextArea.Text = finalAnswer
    End Sub
End Class

