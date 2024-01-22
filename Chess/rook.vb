Public Class rook
    Public defensa(7, 7) As Boolean ''MATRIZ CON FICHAS DEFENDIDAS
    Public x_pos, y_pos As Integer
    Public piece_val As Integer
    Private flags(7, 7) As Boolean
    Public check_the_king(7, 7) As Boolean
    Public Sub re_defensa()       'resetea la matriz defensa toda en false ''
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                defensa(i, j) = False ''
            Next ''
        Next ''
    End Sub ''
    Public Sub New(ByVal x, ByVal y, ByVal p_val)   'color=+ve val if white color=-ve if black  
        x_pos = x
        y_pos = y
        piece_val = p_val
        re_flags()

    End Sub

    Public Function ret_x() As Integer
        Return x_pos
    End Function

    Public Function ret_y() As Integer
        Return y_pos
    End Function

    Public Function ret_val() As Integer
        Return piece_val
    End Function

    Public Function poss_mov() As Boolean(,)    ''to show possible moves    Muestra las posiblebles movidas
        re_flags()          'Resetea la matriz booleana flags que guarda las posibles movidas de la ficha
        If piece_val > 0 Then       'Se define si se habla d euna torre blanca o una torre negra para entrar en el algoritmo de movimiento posible
            white_mov()     'Expresa el movimiento de la ficha blanca
        End If
        If piece_val < 0 Then
            black_mov()
        End If
        Return flags
    End Function

    Public Sub white_mov()      'Se define el movimiento posible de una torre blanca
        re_defensa() ''
        If x_pos > 0 Then       'Si no nos encontramos en la primera linea existe movimiento hacia arriba (ANALIZAMOS EL MOVIMIENTO HACIA ARRIBA)
            For i As Integer = x_pos - 1 To 0 Step -1   'Comenzamos a analizar la casilla inmediatamente superior seguimos analizando las siguientes si es necesario
                If Form1.ga.board(i, y_pos) <= 0 Then       'Identificamos si dicha casilla es una casilla vacia o es una pieza enemiga
                    flags(i, y_pos) = True  'Como era vacia o enemiga habilitamos la movida dentro de la matriz flags
                    If Form1.ga.board(i, y_pos) < 0 Then        'Preguntamos si era vacia O enemiga para saber si es necesario seguir analizando las casillas siguientes
                        Exit For        'En caso de ser una pieza enemiga no es necesario continuar analizando las demas ya que esta bloquea el paso
                    End If
                Else
                    defensa(i, y_pos) = True ''
                    Exit For
                End If
            Next
        End If
        If x_pos < 7 Then   'De forma similar se analiza el movimiento hacia abajo de la torre
            For i As Integer = x_pos + 1 To 7
                If Form1.ga.board(i, y_pos) <= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) < 0 Then
                        Exit For
                    End If
                Else
                    defensa(i, y_pos) = True ''
                    Exit For
                End If
            Next
        End If

        ''''''''''''this is for column'''''''''''''''''''''''''

        If y_pos > 0 Then       'Aqui se analiza el movimiento a izquierda
            For i As Integer = y_pos - 1 To 0 Step -1
                If Form1.ga.board(x_pos, i) <= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) < 0 Then
                        Exit For
                    End If
                Else
                    defensa(x_pos, i) = True ''
                    Exit For
                End If
            Next
        End If
        If y_pos < 7 Then  'Se analiza el movimiento a derecha
            For i As Integer = y_pos + 1 To 7
                If Form1.ga.board(x_pos, i) <= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) < 0 Then
                        Exit For
                    End If
                Else
                    defensa(x_pos, i) = True ''
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub black_mov()      'Movimiento de la torre negra
        re_defensa() ''
        If x_pos > 0 Then
            For i As Integer = x_pos - 1 To 0 Step -1
                If Form1.ga.board(i, y_pos) >= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) > 0 Then
                        Exit For
                    End If
                Else
                    defensa(i, y_pos) = True ''
                    Exit For
                End If
            Next
        End If
        If x_pos <= 7 Then
            For i As Integer = x_pos + 1 To 7
                If Form1.ga.board(i, y_pos) >= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) > 0 Then
                        Exit For
                    End If
                Else
                    defensa(i, y_pos) = True ''
                    Exit For
                End If
            Next
        End If

        ''''''''''''this is for column'''''''''''''''''''''''''

        If y_pos > 0 Then
            For i As Integer = y_pos - 1 To 0 Step -1
                If Form1.ga.board(x_pos, i) >= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) > 0 Then
                        Exit For
                    End If
                Else
                    defensa(x_pos, i) = True ''
                    Exit For
                End If
            Next
        End If
        If y_pos <= 7 Then
            For i As Integer = y_pos + 1 To 7
                If Form1.ga.board(x_pos, i) >= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) > 0 Then
                        Exit For
                    End If
                Else
                    defensa(x_pos, i) = True ''
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub re_flags()       'resetea la matriz flags toda en false
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                flags(i, j) = False
            Next
        Next
    End Sub

    Public Sub fill_chk_king()
        poss_mov()      'esta funcion tiene una funcion que resetea la matriz de movida de las fichas y despues de identificar si es una ficha blanca o negra llena la matriz con las movidas posibles en ese momento
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                If flags(i, j) = True Or defensa(i, j) = True Then ''agregamos el or defensa
                    check_the_king(i, j) = True
                Else
                    check_the_king(i, j) = False
                End If
            Next
        Next
    End Sub

    Public Sub change_pos(ByVal x, ByVal y, ByVal pre_x, ByVal pre_y)
        For i As Integer = 0 To 7           ' copiamos la matriz logica inical
            For j As Integer = 0 To 7   ''
                Form1.ga.pre_board(i, j) = Form1.ga.board(i, j) ''
            Next    ''
        Next    ''
        'AHORA HAGO EL MOVIMIENTO
        Form1.ga.board(x, y) = Form1.ga.board(pre_x, pre_y)
        Form1.ga.board(pre_x, pre_y) = 0
        x_pos = x
        y_pos = y
    End Sub
End Class
