Public Class Form1

    Dim b As Bitmap
    Dim lst As List(Of Rectangle)
    Dim cTransp As Color



    Private Sub btArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btArquivo.Click

        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        b = New Bitmap(ofd.FileName)
        pc1.Image = b

        Dim transp As New Bitmap(40, 40)
        Dim g As Graphics = Graphics.FromImage(transp)
        cTransp = b.GetPixel(0, 0)
        g.FillRectangle(New SolidBrush(cTransp), 0, 0, 40, 40)
        g.Dispose()

        pcTransp.Image = transp

        If lst IsNot Nothing Then lst.Clear()

    End Sub

    Private Sub btCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCortar.Click

        Try

            If pc1.Image Is Nothing Then Throw New Exception("Selecione o arquivo!")
            If lst Is Nothing OrElse lst.Count = 0 Then

                Throw New Exception("Nenhum corte foi identificado.")

            End If

            If MsgBox("A imagem será cortada em outras " & lst.Count & " imagens." & vbCrLf & "Deseja continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If


            If fbd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

            Dim bmp As Bitmap = Nothing
            For i As Integer = 0 To lst.Count - 1

                bmp = b.Clone(lst(i), b.PixelFormat)
                cortaImage(bmp, fbd.SelectedPath & "\" & i.ToString.PadLeft(5, "0") & ".png")

            Next
            bmp.Dispose()

            MsgBox("As imagens foram salvas!", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Exit Sub

        End Try

    End Sub

    Sub cortaImage(ByVal bmp As Bitmap, ByVal path As String)

        Dim x1, x2, y1, y2 As Integer
        x1 = bmp.Width - 1
        y1 = bmp.Height - 1
        x2 = 0
        y2 = 0

        Dim imgTransp As Boolean = True

        For j As Integer = 0 To bmp.Height - 1
            For i As Integer = 0 To bmp.Width - 1

                If bmp.GetPixel(i, j) <> cTransp Then
                    imgTransp = False
                    If i < x1 Then x1 = i
                    If j < y1 Then y1 = j
                    If i > x2 Then x2 = i
                    If j > y2 Then y2 = j
                End If

            Next
        Next

        If imgTransp Then
            Exit Sub
        End If

        Dim b As Bitmap = bmp.Clone(New Rectangle(x1, y1, x2 - x1 + 1, y2 - y1 + 1), bmp.PixelFormat)
        b.MakeTransparent(cTransp)
        b.Save(path, Imaging.ImageFormat.Png)

        b.Dispose()
        bmp.Dispose()



    End Sub

    Private Sub mudouQtds(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQLin.TextChanged, txtQCol.TextChanged

        If Not rQtd.Checked Then Exit Sub

        If IsNumeric(txtQLin.Text) = False Or IsNumeric(txtQCol.Text) = False Then Exit Sub
        If pc1.Image Is Nothing Then Exit Sub

        Dim lin As Integer = CInt(txtQLin.Text)
        Dim col As Integer = CInt(txtQCol.Text)

        If lin <= 0 Or col <= 0 Then Exit Sub

        Dim w As Integer = pc1.Image.Width
        Dim h As Integer = pc1.Image.Height

        Dim tLin As Integer = h / lin
        Dim tCol As Integer = w / col

        txtTCol.Text = tCol
        txtTLin.Text = tLin


        desenhaRects(lin, col, tLin, tCol)

    End Sub



    Private Sub mudouTams(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTCol.TextChanged, txtTLin.TextChanged


        If Not rTam.Checked Then Exit Sub

        If IsNumeric(txtTLin.Text) = False Or IsNumeric(txtTCol.Text) = False Then Exit Sub
        If pc1.Image Is Nothing Then Exit Sub

        Dim tLin As Integer = CInt(txtTLin.Text)
        Dim tCol As Integer = CInt(txtTCol.Text)

        If tLin <= 0 Or tCol <= 0 Then Exit Sub

        Dim w As Integer = pc1.Image.Width
        Dim h As Integer = pc1.Image.Height

        Dim lin As Integer = h / tLin
        Dim col As Integer = w / tCol

        txtQCol.Text = col
        txtQLin.Text = lin



        desenhaRects(lin, col, tLin, tCol)

    End Sub

    Sub desenhaRects(ByVal qLin As Integer, ByVal qCol As Integer, ByVal tLin As Integer, ByVal tCol As Integer)

        lst = New List(Of Rectangle)

        pc1.Image = b.Clone()
        Dim g As Graphics = Graphics.FromImage(pc1.Image)
        Dim p As New Pen(Color.White)
        Dim rect As Rectangle

        For j As Integer = 0 To qLin - 1
            For i As Integer = 0 To qCol - 1
                rect = New Rectangle(i * tCol, j * tLin, tCol, tLin)
                lst.Add(rect)
                g.DrawRectangle(p, rect)
            Next
        Next

        pc1.Update()

    End Sub


    Private Sub mudouCheck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rTam.CheckedChanged, rQtd.CheckedChanged

        txtQCol.Enabled = rQtd.Checked
        txtQLin.Enabled = rQtd.Checked

        txtTCol.Enabled = rTam.Checked
        txtTLin.Enabled = rTam.Checked

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
