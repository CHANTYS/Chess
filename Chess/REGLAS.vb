Public Class REGLAS

    Private Sub AxAcroPDF1_OnError(sender As Object, e As EventArgs) Handles AxAcroPDF1.OnError


    End Sub

    Private Sub REGLAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AxAcroPDF1.LoadFile("C:\Users\amdsa\OneDrive\Documentos\VISUAL BASIC\ESTABLE VB_CHESS-master\DEFINITIVO VB_CHESS-master\Chess\Resources\REGLAS VISUAL CHESS ESPAÑOL.pdf")

    End Sub
End Class