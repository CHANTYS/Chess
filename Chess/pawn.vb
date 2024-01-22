Public Class pawn
    Public defensa(7, 7) As Boolean ''MATRIZ CON FICHAS DEFENDIDAS
    Public x_pos, y_pos As Integer
    Public piece_val As Integer
    Private flags(7, 7) As Boolean  'esta matriz representa las movidas posibles de la pieza
    Public check_the_king(7, 7) As Boolean 'aparentemente es una matriz que va a guardar todas las movidas posibles de todo un color para verificar si el rey se encuentra en jaque (REVISAR) Creo que carece de sentido esta matriz porque podria ser reemplazada por flags
    Private pin As Boolean = False
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
        re_chk_king()

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

    Public Function poss_mov() As Boolean(,)    ''to show possible moves 'Muestra posibles movimientos
        re_flags()                              'Resetea la matriz de banderas del peon, es decir, la matriz flags que muestra las movidas posibles de la ficha
        If piece_val > 0 Then                   'Condicion para definir si mueve blanca o negra
            white_mov()
        End If
        If piece_val < 0 Then
            black_mov()
        End If
        Return flags
    End Function
    'Aclaracion de que los ejes X e Y estan intercambiados
    Public Sub white_mov()  'Esta funcion habilita las movidas posibles del peon BLANCO en la matriz booleana flags
        re_defensa() ''
        If x_pos = 1 Then       'Definimos si el peon se encuentra en la primera fila
            If Chess.Form1.ga.board(x_pos + 1, y_pos) = 0 And x_pos < 7 And pin = False Then 'si el casillero siguiente esta vacio y el peon no esta en la ultima fila y
                flags(x_pos + 1, y_pos) = True  'Se habilita una bandera en la posicion siguiente al peon

            End If
            If Chess.Form1.ga.board(x_pos + 2, y_pos) = 0 And Chess.Form1.ga.board(x_pos + 1, y_pos) = 0 And pin = False Then   'Si la posicion 2 cuadros adelante esta vacia y la posicion 1 cuadro adelante esta vacia 
                flags(x_pos + 2, y_pos) = True  'Se habilita otra bandera en la posicion 2 adelante
            End If
            If y_pos + 1 <= 7 And x_pos + 1 <= 7 Then   'Si al moverme en diagonal hacia la derecha y abajo no te fuiste del tablero
                If Chess.Form1.ga.board(x_pos + 1, y_pos + 1) < 0 Then  'Si en la diagonal indicada hay una ficha negra ya que el numero debe ser negativo en la matriz logica board
                    flags(x_pos + 1, y_pos + 1) = True 'Se habilita una bandera que permite comer esa ficha
                ElseIf Chess.Form1.ga.board(x_pos + 1, y_pos + 1) > 0 Then ''
                    defensa(x_pos + 1, y_pos + 1) = True ''
                End If
            End If
            If y_pos - 1 >= 0 And x_pos + 1 <= 7 Then 'Si al moverme a la izquierda y hacia abajo no me salgo del tablero
                If Chess.Form1.ga.board(x_pos + 1, y_pos - 1) < 0 Then 'Si en esa diagonal existe una ficha negra
                    flags(x_pos + 1, y_pos - 1) = True  'Se habilita una bandera para comer en esa posicion
                ElseIf Chess.Form1.ga.board(x_pos + 1, y_pos - 1) > 0 Then ''
                    defensa(x_pos + 1, y_pos - 1) = True ''
                End If
            End If
        Else
            If x_pos + 1 <= 7 Then  'Repitiendo todo pero sin las movidas dobles de primera movida
                If Chess.Form1.ga.board(x_pos + 1, y_pos) = 0 And pin = False Then
                    flags(x_pos + 1, y_pos) = True
                End If
            End If
            If y_pos + 1 <= 7 And x_pos + 1 <= 7 Then
                If Chess.Form1.ga.board(x_pos + 1, y_pos + 1) < 0 Then
                    flags(x_pos + 1, y_pos + 1) = True
                End If
            End If

            If y_pos - 1 >= 0 And x_pos + 1 <= 7 Then
                If Chess.Form1.ga.board(x_pos + 1, y_pos - 1) < 0 Then
                    flags(x_pos + 1, y_pos - 1) = True
                End If
            End If
        End If
        pin = False

    End Sub

    Public Sub black_mov()  'Esta funcion habilita las movidas posibles del peon NEGRO en la matriz booleana flags
        re_defensa() ''
        If x_pos = 6 Then
            If Chess.Form1.ga.board(x_pos - 1, y_pos) = 0 And x_pos > 0 And pin = False Then
                flags(x_pos - 1, y_pos) = True
            End If
            If Chess.Form1.ga.board(x_pos - 2, y_pos) = 0 And Chess.Form1.ga.board(x_pos - 1, y_pos) = 0 And pin = False Then
                flags(x_pos - 2, y_pos) = True
            End If
            If y_pos + 1 <= 7 And x_pos - 1 >= 0 Then
                If Chess.Form1.ga.board(x_pos - 1, y_pos + 1) > 0 Then
                    flags(x_pos - 1, y_pos + 1) = True
                ElseIf Chess.Form1.ga.board(x_pos - 1, y_pos + 1) > 0 Then ''
                    defensa(x_pos - 1, y_pos + 1) = True ''
                End If
            End If
            If y_pos - 1 >= 0 And x_pos - 1 >= 0 Then
                If Chess.Form1.ga.board(x_pos - 1, y_pos - 1) > 0 Then
                    flags(x_pos - 1, y_pos - 1) = True
                ElseIf Chess.Form1.ga.board(x_pos - 1, y_pos - 1) > 0 Then ''
                    defensa(x_pos - 1, y_pos - 1) = True ''
                End If
            End If
        Else
            If x_pos - 1 >= 0 Then
                If Chess.Form1.ga.board(x_pos - 1, y_pos) = 0 And pin = False Then
                    flags(x_pos - 1, y_pos) = True
                End If
            End If
            If y_pos + 1 <= 7 And x_pos - 1 >= 0 Then
                If Chess.Form1.ga.board(x_pos - 1, y_pos + 1) > 0 Then
                    flags(x_pos - 1, y_pos + 1) = True
                End If
            End If
            If y_pos - 1 >= 0 And x_pos - 1 >= 0 Then
                If Chess.Form1.ga.board(x_pos - 1, y_pos - 1) > 0 Then
                    flags(x_pos - 1, y_pos - 1) = True
                End If
            End If
        End If
        pin = False
    End Sub

    Public Sub re_flags()           'Resetea la matriz booleana Flags
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                flags(i, j) = False
            Next
        Next
    End Sub

    Public Sub re_chk_king()    'Resetea la matriz booleana check_the_king
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                check_the_king(i, j) = False
            Next
        Next
    End Sub

    Public Sub fill_chk_king()
        pin = True
        poss_mov()  'Define si la ficha es blanca o negra y segun eso llena la matriz flags con las posibles movidas de dicha ficha
        For i As Integer = 0 To 7       'recorremos la matriz flags
            For j As Integer = 0 To 7
                If flags(i, j) = True Or defensa(i, j) = True Then ''agregamos el or defensa 'copia la matriz boobleana Flags en la matriz boobleana check_the_king
                    check_the_king(i, j) = True
                Else
                    check_the_king(i, j) = False
                End If
            Next
        Next
    End Sub

    Public Sub change_pos(ByVal x, ByVal y, ByVal pre_x, ByVal pre_y)   '
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
        fill_chk_king()
    End Sub
End Class
