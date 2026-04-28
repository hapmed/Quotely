Public Class FormAdd
    Private Sub FormAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        SQLL.consultaClientesIndice(ComboBox1)
    End Sub
    Public Function GenerarFolio() As String
        ' 1. Obtener el día del año (1-366)
        Dim diaAnio As Integer = DateTime.Now.DayOfYear
        ' 2. Calcular el segundo exacto del día (0 a 86400)
        Dim segundosHoy As Integer = (DateTime.Now.Hour * 3600) + (DateTime.Now.Minute * 60) + DateTime.Now.Second
        ' 3. Convertir ambos a Base 36 con relleno (Padding)
        ' Día: PadLeft(2) asegura que el 1 de enero sea "01" en lugar de "1"
        ' Tiempo: PadLeft(4) asegura que la madrugada sea "00A5" en lugar de "A5"
        Dim parteDia As String = DecimalToBase36(diaAnio).PadLeft(2, "0"c)
        Dim parteTiempo As String = DecimalToBase36(segundosHoy).PadLeft(4, "0"c)
        ' Unir y asegurar mayúsculas para la Base de Datos
        Return (parteDia & parteTiempo).ToUpper()
    End Function
    Private Function DecimalToBase36(ByVal valor As Long) As String
        Const chars As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim res As String = ""
        ' Caso especial para el valor 0
        If valor = 0 Then Return "0"
        Do
            res = chars(valor Mod 36) & res
            valor = valor \ 36
        Loop While valor > 0
        Return res
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text.Trim() <> "" Then
            NumericUpDown1.Value = Val(SQLL.consultaClientesVigencia(ComboBox1.Text))
            ComboBox2.Items.Clear()
            SQLL.consultaContantoCliente(ComboBox2, ComboBox1.Text)
            If ComboBox2.Items.Count > 0 Then
                ComboBox2.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value > 0 Then
            DateTimePicker2.Value = DateTimePicker1.Value.AddDays(NumericUpDown1.Value)
        End If
    End Sub
    Private Sub btnAddFolio_Click(sender As Object, e As EventArgs) Handles btnAddFolio.Click
        If TextBox1.Text.Length > 0 And ComboBox1.Text.Length > 0 And ComboBox2.Text.Length > 0 And NumericUpDown1.Value > 0 Then
            SQLL.insertIndice(GenerarFolio)
            SQLL.ConsultaIndice()
            Me.Close()
        Else
            MsgBox("Falta un campo")
        End If
    End Sub
End Class