Imports System.IO
Public Class Form1
    Dim x As Integer
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Salvar1.ShowDialog()
        If Salvar1.FileName = "" Then
            MsgBox("Digite um nome válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim arq As StreamWriter = New StreamWriter(Salvar1.FileName)

        For x = 0 To txtSalvar.Lines.Length - 1
            arq.WriteLine(txtSalvar.Lines(x).ToString)
        Next
        arq.Close()
    End Sub

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        txtAbrir.Text = ""
        Abrir1.ShowDialog()
        If Abrir1.FileName = "" Then
            MsgBox("Selecione um arquivo válido !", MsgBoxStyle.Information)
            Exit Sub

        End If
        Dim arq As StreamReader = New StreamReader(Abrir1.FileName)
        While arq.EndOfStream = False
            txtAbrir.Text = txtAbrir.Text & Environment.NewLine & arq.ReadLine
        End While
        arq.Close()
    End Sub
End Class
