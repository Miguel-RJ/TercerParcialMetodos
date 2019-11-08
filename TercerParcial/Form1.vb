Imports info.lundin.math

Public Class Form_Principal
    Dim k As Integer
    Dim ec As Single
    Dim suma As Single
    Dim integra(200) As Single
    Dim erro(2000) As Single
    Dim c As Integer
    Dim a As Single

    Dim b As Single
    Dim h As Single
    Dim n As Integer
    Dim redon As Integer
    Dim i As Integer
    Dim g As Graphics
    Dim j As Single
    Dim m As Single
    Dim a1 As Single
    Dim b1 As Single
    Dim m1 As Single

    Function f(x As Single) As Single
        'libreria para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", 2.7183)
        parser.Values.Add("pi", 3.1416)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim SelectedFormula As String
        SelectedFormula = cbmenu.SelectedItem
        a = ta.Text
        b = tb.Text
        c = tc.Text
        a1 = ta1.Text
        b1 = tb1.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        erro(i) = 1
        Select Case SelectedFormula
            Case "Rectangulos"
                n = 100
            Case "Trapecios"
                n = 10
            Case "Simpson"
                n = 4
            Case Else
                n = 100
        End Select

        h = (b - a) / n
        suma = 0

        Select Case SelectedFormula
            Case "Rectangulos"
                For k = 0 To n - 1
                    suma = suma + h * f(a + k * h)
                    integra(i) = suma
                Next
            Case "Trapecios"
                For k = 1 To n - 1
                    suma = suma + h / 2 * (2 * f(a + k * h))
                Next
                integra(i) = suma + ((h / 2) * (f(a) + f(b)))
            Case "Simpson"
                h = (b - a) / (n * 2)
                For k = 1 To n
                    suma = suma + (4 * f(a + (2 * k - 1) * h) + (2 * f(a + (2 * k) * h)))
                Next
                integra(i) = h / 3 * (suma + (f(a) - f(b)))
            Case Else
                For k = 0 To n - 1
                    suma = suma + h * f(a + k * h)
                Next
        End Select

        'imprime en renglones
        salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(erro(i), redon))

        Do While erro(i) > ec
            Select Case SelectedFormula
                Case "Rectangulos"
                    n = n + 100
                    i = i + 1
                    h = (b - a) / n
                    suma = 0
                    For k = 0 To n - 1
                        suma = suma + h * f(a + k * h)
                    Next
                    integra(i) = suma
                Case "Trapecios"
                    n = n + 10
                    i = i + 1
                    h = (b - a) / n
                    suma = 0
                    For k = 1 To n - 1
                        suma = suma + h / 2 * (2 * f(a + k * h))
                    Next
                    integra(i) = suma + (h / 2 * (f(a) + f(b)))
                Case "Simpson"
                    n = n + 4
                    i = i + 1
                    h = (b - a) / (n * 2)
                    suma = 0
                    For k = 1 To n
                        suma = suma + (4 * f(a + (2 * k - 1) * h) + (2 * f(a + (2 * k) * h)))
                    Next
                    integra(i) = h / 3 * (suma + (f(a) - f(b)))
                Case Else
                    n = n + 100
                    i = i + 1
                    h = (b - a) / n
                    suma = 0
                    For k = 0 To n - 1
                        suma = suma + h * f(a + k * h)
                    Next
            End Select
            'integra(i) = suma + (h / 2 * (f(a) + f(b)))
            erro(i) = Math.Abs((integra(i) - integra(i - 1)) / integra(i))

            salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(erro(i), redon))
        Loop
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        'grafica de la función
        g = Graf.CreateGraphics()
        j = a1
        Do While j <= b1
            Graf.Series(0).Points.AddXY(Math.Round(j, 1), f(j))
            j = j + 0.1
        Loop
        m = a
        'gráfica de el área sombreada
        Do While m <= b
            Graf.Series(1).Points.AddXY(Math.Round(m, 1), f(m))
            m = m + 0.1
        Loop
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'limpia cajas de textos y demás
        ta.Clear()
        tb.Clear()
        tc.Clear()
        ta1.Clear()
        tb1.Clear()
        tc.Clear()
        Graf.Series(0).Points.Clear()
        Graf.Series(1).Points.Clear()
        salida.Rows.Clear()
        tf.Clear()
    End Sub
End Class
