Imports QRCoder

Public Class QRCG
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(txtInput.Text, QRCodeGenerator.ECCLevel.Q)
        Dim Code As New QRCode(data)
        pic.Image = Code.GetGraphic(6)
    End Sub
End Class
