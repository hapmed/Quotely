Imports Microsoft.Win32
Imports System.Management
Public Class FormMain
    Public PC As String = GetShortPCID()
    Private Sub btnAddFolio_Click(sender As Object, e As EventArgs) Handles btnAddFolio.Click
        FormAdd.Show()
    End Sub
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQLL.consultaUsuarioAut(PC).length > 5 Then
            SQLL.ConsultaIndice()
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
            FormNo.Show()
        End If
    End Sub
    Public Function GetShortPCID() As String
        Try
            Dim idOriginal As String = ""
            ' Obtenemos el Serial de la Motherboard
            Dim searcher As New Management.ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard")
            For Each obj As Management.ManagementObject In searcher.Get()
                idOriginal = obj("SerialNumber").ToString()
            Next
            ' Si no hay serial, usamos el nombre de la PC
            If String.IsNullOrEmpty(idOriginal) Then idOriginal = Environment.MachineName
            ' 1. Obtenemos el Hash (Número único)
            Dim numID As Long = Math.Abs(CLng(idOriginal.GetHashCode()))
            ' 2. Convertimos a Base 36
            Dim b36 As String = DecimalToBase36(numID).ToUpper()
            ' 3. AJUSTE PARA QUE SIEMPRE SEA DE 6:
            If b36.Length > 6 Then
                ' Si es más largo, tomamos los últimos 6 (son los que más cambian)
                Return b36.Substring(b36.Length - 6)
            Else
                ' Si es más corto, rellenamos con ceros a la izquierda
                Return b36.PadLeft(6, "0"c)
            End If
        Catch ex As Exception
            ' Respaldo en caso de error crítico
            Return "PC" & Environment.MachineName.Substring(0, Math.Min(4, Environment.MachineName.Length)).ToUpper()
        End Try
    End Function
    Private Function DecimalToBase36(ByVal valor As Long) As String
        Const chars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim res As String = ""
        Do
            res = chars(valor Mod 36) & res
            valor = valor \ 36
        Loop While valor > 0
        Return res
    End Function
    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        FormConfig.Show()
    End Sub
    Private Sub dtgIndice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgIndice.CellClick
        ' Validamos que el clic sea en una fila real y no en los títulos de las columnas (RowIndex = -1)
        If e.RowIndex >= 0 Then
            ' Obtenemos la fila exacta a la que se le hizo clic
            Dim fila As DataGridViewRow = dtgIndice.Rows(e.RowIndex)
            ' Usamos Convert.ToString para evitar errores en caso de que algún campo en SQL esté vacío (NULL)
            Label1.Text = Convert.ToString(fila.Cells(0).Value) ' Folio
            Label2.Text = Convert.ToString(fila.Cells(1).Value) ' Fecha
            Label3.Text = Convert.ToString(fila.Cells(2).Value) ' Empresa
            Label4.Text = Convert.ToString(fila.Cells(3).Value) ' Contacto
            Label5.Text = Convert.ToString(fila.Cells(4).Value) ' FechaVencimiento
            Label6.Text = Convert.ToString(fila.Cells(5).Value) ' Descripcion
            Label7.Text = Convert.ToString(fila.Cells(6).Value) ' Usuario
        End If
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FormClientes.Show()
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim index As Integer = dtgIndice.SelectedRows.Item(0).Index
        Dim result As DialogResult = MessageBox.Show("Desea Borrar el Folio seleccionado: " & dtgIndice.Item(0, index).Value, "Borrar Folio", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            If dtgIndice.Rows.Count > 0 Then
                SQLL.borrarUser(dtgIndice.Item(0, index).Value)
                SQLL.ConsultaIndice()
            End If
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim folio As String = Label1.Text.Trim().ToUpper()
        ' 1. Validamos que tenga exactamente los 6 caracteres de nuestro formato
        If folio.Length = 6 Then
            Try
                ' 2. Partimos el folio en sus dos componentes originales
                Dim parteDia As String = folio.Substring(0, 2)
                Dim parteTiempo As String = folio.Substring(2, 4)
                ' 3. Convertimos la Base 36 de regreso a números normales (Decimales)
                Dim diaAnio As Integer = CInt(Base36ToDecimal(parteDia))
                Dim segundosHoy As Integer = CInt(Base36ToDecimal(parteTiempo))
                ' 4. Reconstruimos la fecha
                ' Empezamos en el 1 de enero del año actual
                Dim fechaReconstruida As New DateTime(DateTime.Now.Year, 1, 1)
                ' Le sumamos los días (menos 1 porque ya estamos en el día 1) y los segundos
                fechaReconstruida = fechaReconstruida.AddDays(diaAnio - 1).AddSeconds(segundosHoy)
                ' 5. Mostramos el mensaje limpio
                MsgBox("Generado el: " & fechaReconstruida.ToString("dd/MM/yyyy a las hh:mm:ss tt"), MsgBoxStyle.Information, "Decodificador Quotely")
            Catch ex As Exception
                MsgBox("Error al decodificar el folio. Asegúrate de que sea un formato válido.", MsgBoxStyle.Exclamation, "Error")
            End Try
        End If
    End Sub
    Private Function Base36ToDecimal(ByVal base36 As String) As Long
        Const chars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim resultado As Long = 0
        Dim multiplicador As Long = 1
        ' Leemos los caracteres de derecha a izquierda
        For i As Integer = base36.Length - 1 To 0 Step -1
            Dim letra As Char = base36(i)
            Dim valor As Integer = chars.IndexOf(letra)
            resultado += valor * multiplicador
            multiplicador *= 36
        Next
        Return resultado
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormCot.Show()
    End Sub
End Class