Imports System.Management
Public Class FormConfig
    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDetallesSistema()
        SQLL.ConsultaUsuarios()
    End Sub
    Public Sub CargarDetallesSistema()
        Try
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("Nombre de PC: " & Environment.MachineName)
            sb.AppendLine("Usuario Actual: " & Environment.UserName)
            sb.AppendLine("Sistema: " & My.Computer.Info.OSFullName)
            sb.AppendLine("Memoria RAM: " & Math.Round(My.Computer.Info.TotalPhysicalMemory / (1024 ^ 3), 2) & " GB")
            ' Obtener el Modelo de la PC usando WMI
            Dim searcher As New ManagementObjectSearcher("SELECT Model FROM Win32_ComputerSystem")
            For Each obj As ManagementObject In searcher.Get()
                sb.AppendLine("Modelo: " & obj("Model").ToString())
            Next
            ' Llamamos a tu función de ID corto que ya tienes en el proyecto
            sb.AppendLine("ID: " & FormMain.PC)
            ' Asignamos todo el texto construido al Label
            lblInfoPC.Text = sb.ToString()
        Catch ex As Exception
            lblInfoPC.Text = "Error al cargar configuración: " & ex.Message
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index As Integer = dtgUsuarios.SelectedRows.Item(0).Index
        Dim result As DialogResult = MessageBox.Show("Desea Borrar el Usuario seleccionado: " & dtgUsuarios.Item(1, index).Value, "Borrar Usuario", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            If dtgUsuarios.Rows.Count > 0 Then
                SQLL.borrarUser(dtgUsuarios.Item(0, index).Value)
                SQLL.ConsultaUsuarios()
                TextBox1.Text = ""
                TextBox2.Text = ""
                ComboBox1.SelectedText = -1
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQLL.insertUser(FormMain.PC)
        SQLL.ConsultaUsuarios()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.SelectedText = -1
    End Sub
End Class