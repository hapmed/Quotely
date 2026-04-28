Imports System.Reflection

Public Class FormClientes
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLL.ConsultaClientes()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SQLL.insertCliente()
        SQLL.ConsultaClientes()
        TextBox1.Text = ""
        NumericUpDown1.Value = 0
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim index As Integer = dtgClientes.SelectedRows.Item(0).Index
        Dim result As DialogResult = MessageBox.Show("Desea Borrar el Cliente seleccionado: " & dtgClientes.Item(0, index).Value, "Borrar Cliente", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            If dtgClientes.Rows.Count > 0 Then
                SQLL.borrarCliente(dtgClientes.Item(0, index).Value)
                SQLL.ConsultaClientes()
                TextBox1.Text = ""
                NumericUpDown1.Value = 0
            End If
        End If
    End Sub
End Class