Imports System.Data.SqlClient
Module SQLL
    Public sqlstringcon As String = "Data Source=FILESERVER\SQLEXPRESS;Initial Catalog=quotely;MultipleActiveResultSets=False; User ID=sa;Password=eyccazo" 'lector.ReadLine
    Dim con As New SqlConnection(sqlstringcon)
    Dim cmd As New SqlCommand
    Public Sub ConsultaIndice()
        Dim dt As New DataTable()
        Dim sql_command As String
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            sql_command = "SELECT Top 999 * FROM vis_indice ORDER BY Fecha DESC, Folio DESC"
            FormMain.dtgIndice.DataSource = Nothing
            FormMain.dtgIndice.Refresh()
            FormMain.dtgIndice.Rows.Clear()
            Dim adapter As New SqlDataAdapter(sql_command, con)
            adapter.Fill(dt)
            FormMain.dtgIndice.DataSource = dt
            'FormMain.AcomodarTablaIndice()
        Catch ex As Exception
            'ErrorLog.logg("Error ConsultaIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub ConsultaUsuarios()
        Dim dt As New DataTable()
        Dim sql_command As String
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            sql_command = "SELECT * FROM vis_usuarios ORDER BY Usuario DESC"
            FormConfig.dtgUsuarios.DataSource = Nothing
            FormConfig.dtgUsuarios.Refresh()
            FormConfig.dtgUsuarios.Rows.Clear()
            Dim adapter As New SqlDataAdapter(sql_command, con)
            adapter.Fill(dt)
            FormConfig.dtgUsuarios.DataSource = dt
            'FormMain.AcomodarTablaIndice()
        Catch ex As Exception
            'ErrorLog.logg("Error ConsultaIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub ConsultaClientes()
        Dim dt As New DataTable()
        Dim sql_command As String
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            sql_command = "SELECT * FROM tab_clientes ORDER BY Empresa DESC"
            FormClientes.dtgClientes.DataSource = Nothing
            FormClientes.dtgClientes.Refresh()
            FormClientes.dtgClientes.Rows.Clear()
            Dim adapter As New SqlDataAdapter(sql_command, con)
            adapter.Fill(dt)
            FormClientes.dtgClientes.DataSource = dt
            'FormMain.AcomodarTablaIndice()
        Catch ex As Exception
            'ErrorLog.logg("Error ConsultaIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub consultaClientesIndice(ByVal cb As ComboBox)
        Dim dr As SqlDataReader
        cb.Items.Clear()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM tab_clientes Order By Empresa Desc"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cb.Items.Add(dr.GetString(0))
            Loop
        Catch ex As Exception
            'ErrorLog.logg("Error consultaClientesIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Function consultaClientesVigencia(ByVal cb As String)
        Dim res As Integer = 0
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            ' Usamos parámetros (@Empresa) para evitar que truene si la empresa tiene un apóstrofe (ej. "Carl's Jr")
            cmd.CommandText = "SELECT Vigencia FROM tab_clientes WHERE Empresa = @Empresa"
            cmd.Parameters.Clear() ' Limpiamos parámetros anteriores por seguridad
            cmd.Parameters.AddWithValue("@Empresa", cb)
            ' ExecuteScalar trae directamente el valor de la primera celda de la primera fila
            Dim valorSQL = cmd.ExecuteScalar()
            ' Validamos que haya encontrado la empresa y no regrese un valor nulo
            If valorSQL IsNot Nothing AndAlso Not IsDBNull(valorSQL) Then
                res = Convert.ToInt32(valorSQL)
            End If
        Catch ex As Exception
            MsgBox("Error al buscar la vigencia: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return res
    End Function
    Public Sub consultaContantoCliente(ByVal cb As ComboBox, ByVal client As String)
        Dim dr As SqlDataReader
        cb.Items.Clear()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select DISTINCT Contacto FROM tab_indice WHERE Empresa = '" & client & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                cb.Items.Add(dr.GetString(0))
            Loop
        Catch ex As Exception
            MsgBox("Error al filtrar los contactos n: " & ex.ToString, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub insertIndice(ByVal folio As String)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tab_indice (Folio, Fecha, Empresa, Contacto, Vigencia, Descripcion, Usuario) VALUES('" _
                & FormAdd.GenerarFolio & "', '" _
                & FormAdd.DateTimePicker1.Value.ToString("MM/dd/yyyy") & "', '" _
                & FormAdd.ComboBox1.Text & "', '" _
                & FormAdd.ComboBox2.Text & "', " _
                & FormAdd.NumericUpDown1.Value & ", '" _
                & FormAdd.TextBox1.Text & "', '" _
                & FormMain.PC & " ')"
            cmd.ExecuteNonQuery()
            MsgBox("Folio insertado" & "" & ", a Cliente: " & FormAdd.ComboBox1.Text)
            'ErrorLog.logg("Folio insertado", cmd.CommandText.ToString, False)
        Catch ex As Exception
            'ErrorLog.logg("Error insertIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub borrarIndice(ByVal folio As String)
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM tab_indice WHERE Folio = '" & folio & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Folio Eliminado")
            'ErrorLog.logg("Partida elimindada", cmd.CommandText.ToString, False)
        Catch ex As Exception
            'ErrorLog.logg("Error borrarPartida", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub insertCliente()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tab_clientes (Empresa, Vigencia) VALUES('" _
                & FormClientes.TextBox1.Text & "', '" _
                & FormClientes.NumericUpDown1.Value & " ')"
            cmd.ExecuteNonQuery()
            MsgBox("Cliente insertado" & "" & ", a Cliente: " & FormClientes.TextBox1.Text)
            'ErrorLog.logg("Folio insertado", cmd.CommandText.ToString, False)
        Catch ex As Exception
            'ErrorLog.logg("Error insertIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub borrarCliente(ByVal empresa As String)
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM tab_clientes WHERE Empresa = '" & empresa & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Cliente Eliminado")
            'ErrorLog.logg("Partida elimindada", cmd.CommandText.ToString, False)
        Catch ex As Exception
            'ErrorLog.logg("Error borrarPartida", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub insertUser(ByVal id As String)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO tab_usuarios (ID, Usuario, Tipo) VALUES('" _
                & FormConfig.TextBox1.Text & "', '" _
                & FormConfig.TextBox2.Text & "', '" _
                & FormConfig.ComboBox1.SelectedIndex & " ')"
            cmd.ExecuteNonQuery()
            MsgBox("Usuario insertado" & "" & ", a ID: " & FormConfig.TextBox1.Text)
            'ErrorLog.logg("Folio insertado", cmd.CommandText.ToString, False)
        Catch ex As Exception
            'ErrorLog.logg("Error insertIndice", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub borrarUser(ByVal id As String)
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM tab_usuarios WHERE ID = '" & id & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Usuario Eliminado")
            'ErrorLog.logg("Partida elimindada", cmd.CommandText.ToString, False)
        Catch ex As Exception
            'ErrorLog.logg("Error borrarPartida", ex.ToString, True)
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Function consultaUsuarioAut(ByVal pc As String)
        Dim dr As SqlDataReader
        Dim res As String = ""
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM tab_usuarios WHERE id = '" & pc & "'"
            dr = cmd.ExecuteReader
            Do While dr.Read = True
                If dr.GetString(1).Length > 0 Then
                    res = dr.GetString(1)
                Else
                    res = ""
                End If
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function
End Module
