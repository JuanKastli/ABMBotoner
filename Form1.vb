Public Class Form1

    Private Sub Enumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enumerar.Click

        Dim x As Integer
        If enumerado Then Exit Sub
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = CStr(x) + " " + ListBox1.Items.Item(x).ToString

        Next
        TextBox1.Focus()
        enumerado = True

    End Sub
    Dim enumerado As Boolean = False

End Class
