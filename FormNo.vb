Public Class FormNo
    Private Sub FormNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = FormMain.PC
    End Sub
    Private Sub FormNo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' 1. Validamos que el Label realmente tenga texto
        If Not String.IsNullOrWhiteSpace(Label1.Text) Then
            ' 2. Copiamos el texto exacto al portapapeles de Windows
            Clipboard.SetText(Label1.Text)
            ' 3. Mostramos el mensaje confirmando el texto exacto que se copió
            MsgBox("Se copió '" & Label1.Text & "' al portapapeles.", MsgBoxStyle.Information, "Quotely")
        End If
    End Sub
End Class