Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class FormCot
    Private Sub FormCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewpdf()
    End Sub
    Public Sub previewpdf()
        ' 1. Definimos una ruta temporal o fija para guardar la vista previa
        ' Usamos la carpeta de archivos temporales de Windows para no llenar de basura el disco
        Dim rutaTemporal As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Cotizacion_Preview.pdf")

        Try
            ' 2. Generamos el PDF usando tu Sub de iTextSharp
            GenerarCotizacionSSCA(rutaTemporal,
                                 14250D)

            ' 3. ¡La Magia! Le decimos al WebBrowser que cargue ese archivo
            WebBrowser1.Navigate(rutaTemporal)

        Catch ex As Exception
            MsgBox("Error al generar o mostrar la vista previa: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub GenerarCotizacionSSCA(ByVal rutaGuardado As String, ByVal folio As String)
        ' 1. Documento con márgenes estrechos para que quepa toda la información
        Dim doc As New Document(PageSize.A4, 30, 30, 30, 30)

        Try
            PdfWriter.GetInstance(doc, New FileStream(rutaGuardado, FileMode.Create))
            doc.Open()

            ' Fuentes (Tamaños ajustados para verse profesional)
            Dim fontTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY)
            Dim fontBold As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            Dim fontNormal As Font = FontFactory.GetFont(FontFactory.HELVETICA, 8)
            Dim fontMini As Font = FontFactory.GetFont(FontFactory.HELVETICA, 6)

            ' ==========================================
            ' 1. LOGO DE LA EMPRESA
            ' ==========================================
            Try
                ' CAMBIA ESTA RUTA POR LA DE TU IMAGEN REAL
                Dim rutaLogo As String = "C:\ruta_ejemplo_logo.jpg"
                Dim imgLogo As Image = Image.GetInstance(rutaLogo)
                imgLogo.ScaleToFit(150.0F, 150.0F) ' Ajusta el tamaño
                imgLogo.Alignment = Image.ALIGN_LEFT
                doc.Add(imgLogo)
            Catch ex As Exception
                ' Si no encuentra la imagen, pone un texto para que no truene el programa
                doc.Add(New Paragraph("[ESPACIO PARA IMAGEN / LOGOTIPO]", fontTitulo))
            End Try
            doc.Add(New Paragraph("Soluciones en Sistemas de Control y Automatizacion", fontTitulo))
            doc.Add(New Paragraph(" ", fontNormal))

            ' ==========================================
            ' 2. ENCABEZADO: DATOS DEL CLIENTE Y COTIZACIÓN
            ' ==========================================
            Dim tblHeader As New PdfPTable(2)
            tblHeader.WidthPercentage = 100
            tblHeader.SetWidths(New Single() {60.0F, 40.0F}) ' 60% izquierda, 40% derecha

            ' Izquierda (Datos Cliente) [cite: 1, 4, 5, 6, 7]
            Dim cellIzquierda As New PdfPCell()
            cellIzquierda.Border = 0
            cellIzquierda.AddElement(New Paragraph("ATENCION A: Azael Ruiz", fontBold))
            cellIzquierda.AddElement(New Paragraph("CORREO: azael-ruiz@hedesa.com.mx", fontNormal))
            cellIzquierda.AddElement(New Paragraph("OBSERVACIONES:", fontNormal))
            cellIzquierda.AddElement(New Paragraph("EMPRESA: HEDESA HERMOSILLO", fontBold))
            cellIzquierda.AddElement(New Paragraph("TELEFONO: 81 8309 2102", fontNormal))
            tblHeader.AddCell(cellIzquierda)

            ' Derecha (Datos Cotización) 
            Dim cellDerecha As New PdfPCell()
            cellDerecha.Border = 0
            cellDerecha.AddElement(New Paragraph("FECHA: " & DateTime.Now.ToString("dd/MM/yyyy"), fontBold))
            cellDerecha.AddElement(New Paragraph("VIGENCIA DE COTIZACION: 30 Días", fontNormal))
            cellDerecha.AddElement(New Paragraph("NUMERO DE COTIZACION: " & folio, fontBold))
            tblHeader.AddCell(cellDerecha)

            doc.Add(tblHeader)
            doc.Add(New Paragraph(" ", fontNormal))

            ' ==========================================
            ' 3. TABLA PRINCIPAL DE PARTIDAS
            ' ==========================================
            Dim tblItems As New PdfPTable(6)
            tblItems.WidthPercentage = 100
            tblItems.SetWidths(New Single() {1.0F, 1.5F, 1.0F, 5.0F, 2.0F, 2.0F})

            ' Encabezados exactos 
            Dim headers() As String = {"PARTIDA", "CANTIDAD", "UME", "DESCRIPCION DEL MATERIAL", "PRECIO UNITARIO SIN IVA", "IMPORTE TOTAL"}
            For Each h In headers
                Dim cellH As New PdfPCell(New Phrase(h, fontBold))
                cellH.BackgroundColor = New BaseColor(220, 220, 220) ' Gris claro
                cellH.HorizontalAlignment = Element.ALIGN_CENTER
                tblItems.AddCell(cellH)
            Next

            ' Fila de ejemplo 
            tblItems.AddCell(New PdfPCell(New Phrase("1", fontNormal)) With {.HorizontalAlignment = Element.ALIGN_CENTER})
            tblItems.AddCell(New PdfPCell(New Phrase("1", fontNormal)) With {.HorizontalAlignment = Element.ALIGN_CENTER})
            tblItems.AddCell(New PdfPCell(New Phrase("N.A.", fontNormal)) With {.HorizontalAlignment = Element.ALIGN_CENTER})
            tblItems.AddCell(New PdfPCell(New Phrase("Servicio de Programación: Conveyor Transportador Discos de Freno BREMBO", fontNormal)))
            tblItems.AddCell(New PdfPCell(New Phrase("$ 14,250.00", fontNormal)) With {.HorizontalAlignment = Element.ALIGN_RIGHT})
            tblItems.AddCell(New PdfPCell(New Phrase("$ 14,250.00", fontNormal)) With {.HorizontalAlignment = Element.ALIGN_RIGHT})

            doc.Add(tblItems)

            ' Notas debajo de la tabla [cite: 13, 14, 15, 16]
            doc.Add(New Paragraph("Solo se contempla servicio de programación y cableado de sensores.", fontNormal))
            doc.Add(New Paragraph("CONDICIONES DE PAGO: CONTADO: Pago por anticipado.", fontBold))
            doc.Add(New Paragraph(" ", fontNormal))

            ' ==========================================
            ' 4. TOTALES
            ' ==========================================
            Dim tblTotales As New PdfPTable(2)
            tblTotales.HorizontalAlignment = Element.ALIGN_RIGHT
            tblTotales.WidthPercentage = 30

            ' 
            tblTotales.AddCell(New PdfPCell(New Phrase("SUBTOTAL", fontBold)) With {.Border = 0})
            tblTotales.AddCell(New PdfPCell(New Phrase("$ 14,250.00", fontNormal)) With {.Border = 0, .HorizontalAlignment = Element.ALIGN_RIGHT})

            tblTotales.AddCell(New PdfPCell(New Phrase("IVA", fontBold)) With {.Border = 0})
            tblTotales.AddCell(New PdfPCell(New Phrase("$ 2,280.00", fontNormal)) With {.Border = 0, .HorizontalAlignment = Element.ALIGN_RIGHT})

            tblTotales.AddCell(New PdfPCell(New Phrase("TOTAL", fontBold)) With {.Border = 0})
            tblTotales.AddCell(New PdfPCell(New Phrase("$ 16,530.00", fontBold)) With {.Border = 0, .HorizontalAlignment = Element.ALIGN_RIGHT})

            doc.Add(tblTotales)

            ' Importe con letra [cite: 19, 20]
            doc.Add(New Paragraph("IMPORTE CON LETRA:", fontBold))
            doc.Add(New Paragraph("Dieciseis Mil Quinientos Treinta 00/100 MXN.", fontNormal))
            doc.Add(New Paragraph(" ", fontNormal))

            ' ==========================================
            ' 5. PIE DE PÁGINA (3 COLUMNAS: FISCALES, CONTACTO, BANCO)
            ' ==========================================
            Dim tblFooter As New PdfPTable(3)
            tblFooter.WidthPercentage = 100
            tblFooter.SetWidths(New Single() {33.3F, 33.3F, 33.3F})

            ' Columna 1: DATOS FISCALES [cite: 22, 23, 24, 25, 26]
            Dim cellFiscales As New PdfPCell()
            cellFiscales.BorderColor = BaseColor.LIGHT_GRAY
            cellFiscales.AddElement(New Paragraph("DATOS FISCALES", fontBold))
            cellFiscales.AddElement(New Paragraph("RFC: FOAE9812222SA", fontNormal))
            cellFiscales.AddElement(New Paragraph("RAZON SOCIAL: Ernesto Flores Aguilar", fontNormal))
            tblFooter.AddCell(cellFiscales)

            ' Columna 2: CONTACTO [cite: 27, 28, 29, 30, 31]
            Dim cellContacto As New PdfPCell()
            cellContacto.BorderColor = BaseColor.LIGHT_GRAY
            cellContacto.AddElement(New Paragraph("CONTACTO", fontBold))
            cellContacto.AddElement(New Paragraph("Ernesto Flores", fontNormal))
            cellContacto.AddElement(New Paragraph("Ernesto.Flores@ssca.com.mx", fontNormal))
            cellContacto.AddElement(New Paragraph("81-20-02-57-70", fontNormal))
            cellContacto.AddElement(New Paragraph("www.sscaautomatizacion.com.mx", fontNormal))
            tblFooter.AddCell(cellContacto)

            ' Columna 3: CUENTA BANCARIA [cite: 32, 33, 34, 35, 39, 40, 41]
            Dim cellBanco As New PdfPCell()
            cellBanco.BorderColor = BaseColor.LIGHT_GRAY
            cellBanco.AddElement(New Paragraph("CUENTA BANCARIA", fontBold))
            cellBanco.AddElement(New Paragraph("BANCO: Banamex", fontNormal))
            cellBanco.AddElement(New Paragraph("Razón Social: Ernesto Flores Aguilar", fontNormal))
            cellBanco.AddElement(New Paragraph("CLAVE: 002375701669160012", fontNormal))
            cellBanco.AddElement(New Paragraph("No. de Cuenta: 6916001", fontNormal))
            tblFooter.AddCell(cellBanco)

            doc.Add(tblFooter)

            ' Textos legales finales [cite: 44, 47]
            doc.Add(New Paragraph(" ", fontNormal))
            doc.Add(New Paragraph("Enviamos la cotización solicitada agradeciendo de antemano la atención prestada...", fontMini))
            doc.Add(New Paragraph("Esta cotización y sus adjuntos se dirigen exclusivamente a su destinatario...", fontMini))

        Catch ex As Exception
            MsgBox("Error al generar el documento: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If doc.IsOpen() Then doc.Close()
        End Try
    End Sub

End Class