Public Class king
    Public defensa(7, 7) As Boolean ''MATRIZ CON FICHAS DEFENDIDAS
    Public x_pos, y_pos As Integer
    Public piece_val As Integer
    Public flags(7, 7) As Boolean
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

    Public Function ret_x() As Integer      'Estas serian las propiedades para el manejo de lo parametros solo que estan hechas mediante funciones
        Return x_pos
    End Function
    Public Function ret_y() As Integer      'Estas serian las propiedades para el manejo de lo parametros solo que estan hechas mediante funciones
        Return y_pos
    End Function
    Public Function ret_val() As Integer    'Estas serian las propiedades para el manejo de lo parametros solo que estan hechas mediante funciones
        Return piece_val
    End Function
    Public Function poss_mov() As Boolean(,)    ''to show possible moves
        re_flags()
        If piece_val > 0 Then
            white_mov()
        End If
        If piece_val < 0 Then
            black_mov()
        End If
        Return flags
    End Function
    Public Sub white_mov()
        re_defensa() ''
        Form1.ga.re_chk_white() ''
        Form1.ga.fill_chk_for_white() ''
        If x_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos + 1, y_pos) <= 0 And Form1.ga.check_for_white(x_pos + 1, y_pos) <> True Then
                flags(x_pos + 1, y_pos) = True
            Else ''
                defensa(x_pos + 1, y_pos) = True ''
            End If
        End If
        If y_pos + 1 <= 7 And x_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos + 1, y_pos + 1) <= 0 And Form1.ga.check_for_white(x_pos + 1, y_pos + 1) <> True Then
                flags(x_pos + 1, y_pos + 1) = True
            Else ''
                defensa(x_pos + 1, y_pos + 1) = True ''
            End If
        End If

        If y_pos - 1 >= 0 And x_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos + 1, y_pos - 1) <= 0 And Form1.ga.check_for_white(x_pos + 1, y_pos - 1) <> True Then
                flags(x_pos + 1, y_pos - 1) = True
            Else ''
                defensa(x_pos + 1, y_pos - 1) = True ''
            End If
        End If
        If x_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos) <= 0 And Form1.ga.check_for_white(x_pos - 1, y_pos) <> True Then
                flags(x_pos - 1, y_pos) = True
            Else ''
                defensa(x_pos - 1, y_pos) = True ''
            End If
        End If
        If y_pos + 1 <= 7 And x_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos + 1) <= 0 And Form1.ga.check_for_white(x_pos - 1, y_pos + 1) <> True Then
                flags(x_pos - 1, y_pos + 1) = True
            Else ''
                defensa(x_pos - 1, y_pos + 1) = True ''
            End If
        End If
        If y_pos - 1 >= 0 And x_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos - 1) <= 0 And Form1.ga.check_for_white(x_pos - 1, y_pos - 1) <> True Then
                flags(x_pos - 1, y_pos - 1) = True
            Else ''
                defensa(x_pos - 1, y_pos - 1) = True ''
            End If
        End If

        If y_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos, y_pos + 1) <= 0 And Form1.ga.check_for_white(x_pos, y_pos + 1) <> True Then
                flags(x_pos, y_pos + 1) = True
            Else ''
                defensa(x_pos, y_pos + 1) = True ''
            End If
        End If
        If y_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos, y_pos - 1) <= 0 And Form1.ga.check_for_white(x_pos, y_pos - 1) <> True Then
                flags(x_pos, y_pos - 1) = True
            Else ''
                defensa(x_pos, y_pos - 1) = True ''
            End If
        End If
    End Sub
    Public Sub black_mov()
        If x_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos + 1, y_pos) >= 0 And Form1.ga.check_for_black(x_pos + 1, y_pos) <> True Then
                flags(x_pos + 1, y_pos) = True
            Else ''
                defensa(x_pos + 1, y_pos) = True ''
            End If
        End If
        If y_pos + 1 <= 7 And x_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos + 1, y_pos + 1) >= 0 And Form1.ga.check_for_black(x_pos + 1, y_pos + 1) <> True Then
                flags(x_pos + 1, y_pos + 1) = True
            Else ''
                defensa(x_pos + 1, y_pos + 1) = True ''
            End If
        End If

        If y_pos - 1 >= 0 And x_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos + 1, y_pos - 1) >= 0 And Form1.ga.check_for_black(x_pos + 1, y_pos - 1) <> True Then
                flags(x_pos + 1, y_pos - 1) = True
            Else ''
                defensa(x_pos + 1, y_pos - 1) = True ''
            End If
        End If
        If x_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos) >= 0 And Form1.ga.check_for_black(x_pos - 1, y_pos) <> True Then
                flags(x_pos - 1, y_pos) = True
            Else ''
                defensa(x_pos - 1, y_pos) = True ''
            End If
        End If
        If y_pos + 1 <= 7 And x_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos + 1) >= 0 And Form1.ga.check_for_black(x_pos - 1, y_pos + 1) <> True Then
                flags(x_pos - 1, y_pos + 1) = True
            Else ''
                defensa(x_pos - 1, y_pos + 1) = True ''
            End If
        End If
        If y_pos - 1 >= 0 And x_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos - 1) >= 0 And Form1.ga.check_for_black(x_pos - 1, y_pos - 1) <> True Then
                flags(x_pos - 1, y_pos - 1) = True
            Else ''
                defensa(x_pos - 1, y_pos - 1) = True ''
            End If
        End If

        If y_pos + 1 <= 7 Then
            If Chess.Form1.ga.board(x_pos, y_pos + 1) >= 0 And Form1.ga.check_for_black(x_pos, y_pos + 1) <> True Then
                flags(x_pos, y_pos + 1) = True
            Else ''
                defensa(x_pos, y_pos + 1) = True ''
            End If
        End If
        If y_pos - 1 >= 0 Then
            If Chess.Form1.ga.board(x_pos, y_pos - 1) >= 0 And Form1.ga.check_for_black(x_pos, y_pos - 1) <> True Then
                flags(x_pos, y_pos - 1) = True
            Else ''
                defensa(x_pos, y_pos - 1) = True ''
            End If
        End If
    End Sub
    Public Sub re_flags()   ' Coloca todas las banderas de la matriz de banderas en falso
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                flags(i, j) = False
            Next
        Next
    End Sub
    Public Sub fill_chk_king()
        poss_mov()
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
    Public Sub change_pos(ByVal x, ByVal y, ByVal pre_x, ByVal pre_y)       'Este procedimiento es el encargado de hacer el cambio de posicion al mover una ficha en la matriz logica board. En esta funcion X e Y son las posiciones de la casilla a la cual debe moverse la pieza y pre_x y pre_y son las coordenadas de donde se encontraba la ficha
        For i As Integer = 0 To 7           ' copiamos la matriz logica inical
            For j As Integer = 0 To 7   ''
                Form1.ga.pre_board(i, j) = Form1.ga.board(i, j) ''
            Next    ''
        Next    ''
        'AHORA HAGO EL MOVIMIENTO
        Form1.ga.board(x, y) = Form1.ga.board(pre_x, pre_y)     'Se guarda el numero que corresponde a la ficha en la nueva posicion dentro del tablero logico
        Form1.ga.board(pre_x, pre_y) = 0        'Se deja en blanco el casillero abandonado por la ficha en el juego logico board
        x_pos = x       'Se actualiza la posicion actuak en el objeto que representa la ficha
        y_pos = y
    End Sub

End Class
