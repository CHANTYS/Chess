Public Class game
    Public pieza As Integer 'esto lo uso para que en la funcion mov pueda saber que ficha muevo cuando hay mas de una ficha
    Public pre_board(7, 7) As Integer 'ESTA MATRIZ LA CREE PARA SOLUCIONAR EL JAQUE MATE
    Public board(7, 7) As Integer   'Matriz que lleva el juego logicamente con numeros para el tipo de ficha y signo para el color de la ficha
    Public can_move(7, 7) As Boolean
    Public check_for_white(7, 7) As Boolean 'Esta matriz booleana sirve para marcar todas las movidas posibles de las piezas negras
    Public check_for_black(7, 7) As Boolean 'Esta matriz booleana sirve para marcar todas las movidas posibles de las piezas blancas
    Public game_flag As Boolean = True
    Public player As Integer = 1            'CREO que es para definir de quien es el turno de mover
    Public b_in_danger As Boolean = False
    Public w_in_danger As Boolean = False
    Public Sub New()
        ''Array for chess_board +ve are for White_pieces -ve are for Black_pieces and 0 are for blank_boxes
        board = {{5, 4, 3, 2, 1, 3, 4, 5},
                 {6, 6, 6, 6, 6, 6, 6, 6},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {-6, -6, -6, -6, -6, -6, -6, -6},
                 {-5, -4, -3, -2, -1, -3, -4, -5}}     ''


        re_chk_black()  'Resetea la Matriz check_for_black toda a false
        re_chk_white()  'Resetea la Matriz check_for_white toda a false


    End Sub

    Public Sub chk_winner(ByVal selected, ByVal x, ByVal y)
        'show()
        'If b_in_danger = True Then
        '    game_flag = False
        '    Form1.b_king.poss_mov()
        '    For i As Integer = 0 To 7
        '        For j As Integer = 0 To 7
        '            If Form1.b_king.flags(i, j) = True Then
        '                game_flag = True
        '            End If
        '        Next
        '    Next
        'End If

        'ACA VOY A PROGRAMAR MI JAQUE MATRE
        Form1.w_king.poss_mov()
        Form1.w_king.fill_chk_king()
        Form1.b_king.poss_mov()
        Form1.b_king.fill_chk_king()
        Dim mate As Boolean = False ''
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                If check_for_black(i, j) = True Then '' 'Si el casillero esta prohibido limita la flgs del rey
                    Form1.b_king.flags(i, j) = False '' Actualiza flags para que tenga las movidas reales del rey
                End If ''
            Next ''
        Next ''
        Dim anulado_b As Boolean = True ''
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                If Form1.b_king.flags(i, j) = True Then
                    anulado_b = False ''
                    Exit For ''
                End If ''
            Next ''
        Next ''
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                If anulado_b = True And (Form1.b_king.x_pos = i And Form1.b_king.y_pos = j And check_for_black(i, j) = True) Then '' 'Si el casillero esta prohibido limita la flgs del rey
                    mate = True ''
                    Exit For ''
                End If ''
            Next ''
        Next ''

        'PARA LAS BLANCAS
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                If check_for_white(i, j) = True Then '' 'Si el casillero esta prohibido limita la flgs del rey
                    Form1.w_king.flags(i, j) = False ''
                End If ''
            Next ''
        Next ''
        Dim anulado_w As Boolean = True ''
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                If Form1.w_king.flags(i, j) = True Then
                    anulado_w = False ''
                    Exit For ''
                End If ''
            Next ''
        Next ''
        For i As Integer = 0 To 7 ''
            For j As Integer = 0 To 7 ''
                If anulado_w = True And (Form1.w_king.x_pos = i And Form1.w_king.y_pos = j And check_for_white(i, j) = True) Then '' 'Si el casillero esta prohibido limita la flgs del rey
                    mate = True ''
                    Exit For
                    'Else ''
                    'mate = False ''
                    'Exit For ''
                End If ''
            Next ''
        Next ''

        If mate = True Then
            game_flag = False
        End If
        If game_flag = False Then
            If player = 1 Then
                My.Computer.Audio.Play(My.Resources._06_Funeral_March__Checkmate___online_audio_converter_com_, AudioPlayMode.Background)
                MsgBox("PLAYER 2 WIN")
                JAQUE_MATE.Show()
                Exit Sub
            Else
                My.Computer.Audio.Play(My.Resources._06_Funeral_March__Checkmate___online_audio_converter_com_, AudioPlayMode.Background)
                MsgBox("PLAYER 1 WIN")
                JAQUE_MATE.Show()
                Exit Sub
            End If
        End If
        'aqui termine de programar mi mate
        ''If Form1.b_king.x_pos = x And Form1.b_king.y_pos = y And selected <> "b_king" Then
        ''game_flag = False
        ''End If
        ''If game_flag = False Then
        ''MsgBox("PLAYER 1 WiN")
        ''Exit Sub
        ''End If

        'If w_in_danger = True Then
        '    game_flag = False
        '    Form1.w_king.poss_mov()
        '    For i As Integer = 0 To 7
        '        For j As Integer = 0 To 7
        '            If Form1.w_king.flags(i, j) = True Then
        '                game_flag = True
        '            End If
        '        Next
        '    Next
        'End If
        ''If Form1.w_king.x_pos = x And Form1.w_king.y_pos = y And selected <> "w_king" Then
        ''game_flag = False
        ''End If
        ''If game_flag = False Then
        ''MsgBox("PLAYER 2 WiN")
        ''Exit Sub
        ''End If
    End Sub

    'this is to show images of pieces
    Public Sub show() 'Esta funcion es la que se encarga de mostrar las imagenes del tablero

        For i As Integer = 0 To 7
            For j As Integer = 0 To 7

                Select Case board(i, j) 'Se selecciona la imagen en base al numero que se encuentra en La Matriz Board juego logico
                    Case 1
                        Form1.pb(i, j).Image = My.Resources.wKing
                    Case 2
                        Form1.pb(i, j).Image = My.Resources.wQueen
                    Case 3
                        Form1.pb(i, j).Image = My.Resources.Wbishop
                    Case 4
                        Form1.pb(i, j).Image = My.Resources.wKnight
                    Case 5
                        Form1.pb(i, j).Image = My.Resources.wRook
                    Case 6
                        Form1.pb(i, j).Image = My.Resources.wPawn
                    Case -1
                        Form1.pb(i, j).Image = My.Resources.bKing
                    Case -2
                        Form1.pb(i, j).Image = My.Resources.bQueen
                    Case -3
                        Form1.pb(i, j).Image = My.Resources.bBishop
                    Case -4
                        Form1.pb(i, j).Image = My.Resources.bKnight
                    Case -5
                        Form1.pb(i, j).Image = My.Resources.bRook
                    Case -6
                        Form1.pb(i, j).Image = My.Resources.bPawn

                    Case Else
                        Form1.pb(i, j).Image = Nothing

                End Select
                show_chk()
            Next
        Next
    End Sub
    'this is to select pic box
    Public Function selection(ByVal x, ByVal y) As String   'Esta funcion relaciona la matriz logica board con el evento clic para definir la seleccion d euna pieza y luego cambiar la imagen de fondo de dicha casilla como seleccionada e identifica la ficha para cambiar la imagen de fondo de las casillas con las posibles movidas de dicha ficha mediante las otras funciones y por ultimo devuelve el nombre de la ficha que fue seleccionada
        If game_flag = True Then    'si el juego esta activo
            If board(x, y) <> 0 Then    'si la posicion de las coordenadas entregadas como parametro representan una ficha en el tablero logico
                Form1.pb(x, y).BackgroundImage = My.Resources.selection 'se cambia la imagen de fondo de la casilla corresponidiente en la matriz de picture boxes para marcar la seleccion de dicha casilla
            End If
            Select Case board(x, y) 'segun el numero dentro de la matriz logica del juego se seleccionan las movidas posibles y se cambian los pictures boxes correspondientes
                Case 1
                    If player = 1 Then
                        show_possible_move(Form1.w_king.poss_mov()) 'Esta funcion es la encargada de mostrar visualmente los cambios de imagen de fondo de los pictureboxes y se vale de la funcion poss_mov de cada pieza que a su vez utiliza las funciones white_mov y black_mov para definir los movimientos segun sea el caso
                        Return "w_king"
                    End If
                Case 2
                    If player = 1 Then
                        show_possible_move(Form1.w_queen.poss_mov())
                        Return "w_queen"
                    End If
                Case 3
                    If player = 1 Then
                        For i As Integer = 0 To 1
                            If Form1.w_bishop(i).ret_x = x And Form1.w_bishop(i).ret_y = y Then
                                show_possible_move(Form1.w_bishop(i).poss_mov())
                            End If
                        Next
                        Return "w_bishop"
                    End If
                Case 4
                    If player = 1 Then
                        For i As Integer = 0 To 1
                            If Form1.w_knight(i).ret_x = x And Form1.w_knight(i).ret_y = y Then
                                show_possible_move(Form1.w_knight(i).poss_mov())
                            End If
                        Next
                        Return "w_knight"
                    End If
                Case 5
                    If player = 1 Then
                        For i As Integer = 0 To 1
                            If Form1.w_rook(i).ret_x = x And Form1.w_rook(i).ret_y = y Then
                                show_possible_move(Form1.w_rook(i).poss_mov())
                            End If
                        Next
                        Return "w_rook"
                    End If
                Case 6
                    If player = 1 Then
                        For i As Integer = 0 To 7
                            If Form1.w_pawn(i).ret_x = x And Form1.w_pawn(i).ret_y = y Then
                                show_possible_move(Form1.w_pawn(i).poss_mov())
                            End If
                        Next
                        Return "w_pawn"
                    End If
                Case -1
                    If player = 2 Then
                        show_possible_move(Form1.b_king.poss_mov())
                        Return "b_king"
                    End If
                Case -2
                    If player = 2 Then
                        show_possible_move(Form1.b_queen.poss_mov())
                        Return "b_queen"
                    End If
                Case -3
                    If player = 2 Then
                        For i As Integer = 0 To 1
                            If Form1.b_bishop(i).ret_x = x And Form1.b_bishop(i).ret_y = y Then
                                show_possible_move(Form1.b_bishop(i).poss_mov())
                            End If
                        Next
                        Return "b_bishop"
                    End If
                Case -4
                    If player = 2 Then
                        For i As Integer = 0 To 1
                            If Form1.b_knight(i).ret_x = x And Form1.b_knight(i).ret_y = y Then
                                show_possible_move(Form1.b_knight(i).poss_mov())
                            End If
                        Next
                        Return "b_knight"
                    End If
                Case -5
                    If player = 2 Then
                        For i As Integer = 0 To 1
                            If Form1.b_rook(i).ret_x = x And Form1.b_rook(i).ret_y = y Then
                                show_possible_move(Form1.b_rook(i).poss_mov())
                            End If
                        Next
                        Return "b_rook"
                    End If
                Case -6
                    If player = 2 Then
                        For i As Integer = 0 To 7
                            If Form1.b_pawn(i).ret_x = x And Form1.b_pawn(i).ret_y = y Then
                                show_possible_move(Form1.b_pawn(i).poss_mov())
                            End If
                        Next
                        Return "b_pawn"
                    End If
                Case Else
                    Return Nothing
            End Select
        End If
        Return Nothing
    End Function

    Public Sub re_back() 'Resetea la imagen de fondo de todos los pictureboxes 
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                Form1.pb(i, j).BackgroundImage = Nothing
            Next
        Next
    End Sub

    Public Sub re_can_move()        'Esta funcion pone en falso a todas las posiciones de la Matriz Can_move
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                can_move(i, j) = False
            Next
        Next
    End Sub

    Public Sub re_chk_white()   'Resetea la Matriz check_for_white toda a false
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                check_for_white(i, j) = False
            Next
        Next
    End Sub

    Public Sub re_chk_black() 'Resetea la Matriz check_for_black toda a false
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                check_for_black(i, j) = False
            Next
        Next
    End Sub

    Public Sub fill_chk_for_black() 'LLena la matriz booleana del objeto game con todas las movidas posibles de las piezas blancas
        re_chk_black()
        For i As Integer = 0 To 7   'Utilizamos i, j y k para que la i recorra los peones y para que la j y k recorran las posiciones de la matriz interna de cada peon
            Form1.w_pawn(i).fill_chk_king() 'Viaja por todos los peones blancos y llena las matrices check_the _king de cada uno con las posibles movidas del mismo
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.w_pawn(i).check_the_king(j, k) = True Then 'Revisa en todas las matrices de los peones blancos de check_the_king si hay una 
                        check_for_black(j, k) = True                    'habilitacion y la copia en la matriz logica de game llamada check_for_black
                    End If
                Next
            Next
        Next
        'Se repite el proceso anterior con cada una de las fichas blancas
        For i As Integer = 0 To 1
            Form1.w_rook(i).fill_chk_king()
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.w_rook(i).check_the_king(j, k) = True Then
                        check_for_black(j, k) = True
                    End If
                Next
            Next
        Next
        For i As Integer = 0 To 1
            Form1.w_bishop(i).fill_chk_king()
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.w_bishop(i).check_the_king(j, k) = True Then
                        check_for_black(j, k) = True
                    End If
                Next
            Next
        Next

        For i As Integer = 0 To 1
            Form1.w_knight(i).fill_chk_king()
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.w_knight(i).check_the_king(j, k) = True Then
                        check_for_black(j, k) = True
                    End If
                Next
            Next
        Next

        Form1.w_queen.fill_chk_king()
        For j As Integer = 0 To 7
            For k As Integer = 0 To 7
                If Form1.w_queen.check_the_king(j, k) = True Then
                    check_for_black(j, k) = True
                End If
            Next
        Next

    End Sub

    Public Sub fill_chk_for_white()
        re_chk_white()      'Resetea la Matriz check_for_white toda a false
        For i As Integer = 0 To 7       'Se usa para recorrer todos los peones
            Form1.b_pawn(i).fill_chk_king()     'Se verifica peon por peon
            For j As Integer = 0 To 7       'Se recorren las matricez chek_the_king de cada uno de los peones y se lo carga en la matriz de game check_for_white de forma que todas las movidas posibles de todos los peones queden cargados en una unica matriz
                For k As Integer = 0 To 7
                    If Form1.b_pawn(i).check_the_king(j, k) = True Then
                        check_for_white(j, k) = True        'Aqui se copian las matrices
                    End If
                Next
            Next
        Next

        For i As Integer = 0 To 1   'se recorren las 2 torres
            Form1.b_rook(i).fill_chk_king()     'Se verifica torre por torre
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.b_rook(i).check_the_king(j, k) = True Then
                        check_for_white(j, k) = True
                    End If
                Next
            Next
        Next
        For i As Integer = 0 To 1
            Form1.b_bishop(i).fill_chk_king()
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.b_bishop(i).check_the_king(j, k) = True Then
                        check_for_white(j, k) = True
                    End If
                Next
            Next
        Next

        For i As Integer = 0 To 1
            Form1.b_knight(i).fill_chk_king()
            For j As Integer = 0 To 7
                For k As Integer = 0 To 7
                    If Form1.b_knight(i).check_the_king(j, k) = True Then
                        check_for_white(j, k) = True
                    End If
                Next
            Next
        Next

        Form1.b_queen.fill_chk_king()
        For j As Integer = 0 To 7
            For k As Integer = 0 To 7
                If Form1.b_queen.check_the_king(j, k) = True Then
                    check_for_white(j, k) = True
                End If
            Next
        Next

    End Sub
    'ESTA FUNCION ES PARECIDA AL SHOW CHECK PERO ES PARA DETERMINAR SI HAY JAQUE
    Public Function show_chk_jaque() As Boolean  'Creo que esto lo que hace es que cuando el rey entra en jaque cambia el fondo de la casilla del rey para mostrar visualmente el jaque
        w_in_danger = False
        b_in_danger = False
        '''''''''''''''''''''''''''''''''''''''''Black Check'''''''''''''''''''''''''''''''''''
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                If check_for_black(i, j) = True And Form1.b_king.x_pos = i And Form1.b_king.y_pos = j Then  'Comprueba que el rey negro se encuentre en una de las casillas habilitadad de check_for_black
                    b_in_danger = True 'Pone a la pieza en peligro
                End If
            Next
        Next
        '''''''''''''''''''''''''''''''''''''''''Black Check'''''''''''''''''''''''''''''''''''
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                If check_for_white(i, j) = True And Form1.w_king.x_pos = i And Form1.w_king.y_pos = j Then  'Comprueba que el rey negro se encuentre en una de las casillas habilitadad de check_for_black
                    w_in_danger = True 'Pone a la pieza en peligro
                End If
            Next
        Next
        If (player = 2 And b_in_danger = True) Or (w_in_danger = True And player = 1) Then
            Return False
        End If
        Return True
    End Function
    Public Sub show_chk() 'Creo que esto lo que hace es que cuando el rey entra en jaque cambia el fondo de la casilla del rey para mostrar visualmente el jaque
        w_in_danger = False
        b_in_danger = False
        '''''''''''''''''''''''''''''''''''''''''Black Check'''''''''''''''''''''''''''''''''''
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                If check_for_black(i, j) = True And Form1.b_king.x_pos = i And Form1.b_king.y_pos = j Then  'Comprueba que el rey negro se encuentre en una de las casillas habilitadad de check_for_black
                    Form1.pb(i, j).BackgroundImage = My.Resources.check ' cambia el fondo del cuadrito del rey blanco para marcar visualmente el jaque
                    b_in_danger = True 'Pone a la pieza en peligro
                End If
            Next
        Next

        '''''''''''''''''''''''''''''''''''''''''White Check'''''''''''''''''''''''''''''''''''
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                If check_for_white(i, j) = True And Form1.w_king.x_pos = i And Form1.w_king.y_pos = j Then
                    Form1.pb(i, j).BackgroundImage = My.Resources.check
                    w_in_danger = True
                End If
            Next
        Next
    End Sub

    Public Sub show_possible_move(ByVal b As Boolean(,)) 'Creo que cambia la imagen de fondo de las casillas segun la pieza seleccionada para mostrar las movidas posibles de dicha pieza 
        For i As Integer = 0 To 7                        'b creo que es un parametro matriz que sera reemplazado por la matriz flag de cada una de las fichas
            For j As Integer = 0 To 7
                If b(i, j) = True Then
                    Form1.pb(i, j).BackgroundImage = My.Resources.V_Move    'cambia la imagen de fondo cuando encuentra un TRUE en la matriz de movimientos de la pieza
                    can_move(i, j) = True   'guarda los posibles movimientos de las diferentes piezas en una unica matriz llamada Can_move
                End If
            Next
        Next
    End Sub

    Public Sub mov(ByVal selected, ByVal x, ByVal y, ByVal pre_x, ByVal pre_y)
        Select Case selected    'pregunta que ficha fue seleccionada
            Case "w_king"
                Form1.w_king.change_pos(x, y, pre_x, pre_y)     'Cambia la ficha de posicion dentro del tablero logico board
                re_chk_white()      'Resetea la Matriz check_for_white toda a false
                re_chk_black()      'Resetea la Matriz check_for_black toda a false
                fill_chk_for_white()
                fill_chk_for_black()
                'ESTA ES LA PREGUNTA  QUE HAGO PARA VALIDAR LA MOVIDA
                If False = Form1.ga.show_chk_jaque Then ''
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.w_king.x_pos = pre_x ' RESETEO LOS CAMBIOS DE LA FUNCION CHANGE_POS
                    Form1.w_king.y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else  '''      'AQUI HABRIA QUE PROGRAMAR EL DESPLAZAMIENTO GRAFICO
                    '''

                    Form1.Timer1.Enabled = True '''

                    'show_chk()
                    player = 2
                    chk_winner(selected, x, y)
                End If  ''
                'If show_chk_jaque() = false Then
                '                For i = 0 To 7
                '                For j = 0 To 7
                '                board(i, j) = pre_board(i, j)
                '               Next
                '              Next
                '             re_back()
                '            show()
                '           show_chk()
                '          Else


                '         End If

            Case "w_queen"
                Form1.w_queen.change_pos(x, y, pre_x, pre_y)
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.w_queen.x_pos = pre_x
                    Form1.w_queen.y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 2
                    chk_winner(selected, x, y)
                End If  ''
            Case "w_bishop"
                For i As Integer = 0 To 1
                    If Form1.w_bishop(i).ret_x = pre_x And Form1.w_bishop(i).ret_y = pre_y Then
                        pieza = i ''
                        Form1.w_bishop(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.w_bishop(pieza).x_pos = pre_x
                    Form1.w_bishop(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 2
                    chk_winner(selected, x, y)
                End If  ''
            Case "w_knight"
                For i As Integer = 0 To 1
                    If Form1.w_knight(i).ret_x = pre_x And Form1.w_knight(i).ret_y = pre_y Then
                        pieza = i ''
                        Form1.w_knight(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.w_knight(pieza).x_pos = pre_x
                    Form1.w_knight(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 2
                    chk_winner(selected, x, y)
                End If  ''
            Case "w_rook"
                For i As Integer = 0 To 1
                    If Form1.w_rook(i).ret_x = pre_x And Form1.w_rook(i).ret_y = pre_y Then
                        pieza = i ''
                        Form1.w_rook(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.w_rook(pieza).x_pos = pre_x
                    Form1.w_rook(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 2
                    chk_winner(selected, x, y)
                End If  ''
            Case "w_pawn"
                For i As Integer = 0 To 7
                    If Form1.w_pawn(i).ret_x = pre_x And Form1.w_pawn(i).ret_y = pre_y And board(x, y) <= 0 Then
                        pieza = i ''
                        Form1.w_pawn(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.w_pawn(pieza).x_pos = pre_x
                    Form1.w_pawn(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 2
                    chk_winner(selected, x, y)
                End If  ''

            Case "b_king"
                Form1.b_king.change_pos(x, y, pre_x, pre_y)
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.b_king.x_pos = pre_x
                    Form1.b_king.y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 1
                    chk_winner(selected, x, y)
                End If  ''
            Case "b_queen"
                Form1.b_queen.change_pos(x, y, pre_x, pre_y)
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.b_queen.x_pos = pre_x
                    Form1.b_queen.y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 1
                    chk_winner(selected, x, y)
                End If  ''
            Case "b_bishop"
                For i As Integer = 0 To 1
                    If Form1.b_bishop(i).ret_x = pre_x And Form1.b_bishop(i).ret_y = pre_y Then
                        pieza = i ''
                        Form1.b_bishop(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.b_bishop(pieza).x_pos = pre_x
                    Form1.b_bishop(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    ' show_chk()
                    player = 1
                    chk_winner(selected, x, y)
                End If  ''
            Case "b_knight"
                For i As Integer = 0 To 1
                    If Form1.b_knight(i).ret_x = pre_x And Form1.b_knight(i).ret_y = pre_y Then
                        pieza = i ''
                        Form1.b_knight(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.b_knight(pieza).x_pos = pre_x
                    Form1.b_knight(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 1
                    chk_winner(selected, x, y)
                End If  ''
            Case "b_rook"
                For i As Integer = 0 To 1
                    If Form1.b_rook(i).ret_x = pre_x And Form1.b_rook(i).ret_y = pre_y Then
                        pieza = i ''
                        Form1.b_rook(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.b_rook(pieza).x_pos = pre_x
                    Form1.b_rook(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    'show_chk()
                    player = 1
                    chk_winner(selected, x, y)
                End If  ''
            Case "b_pawn"
                For i As Integer = 0 To 7
                    If Form1.b_pawn(i).ret_x = pre_x And Form1.b_pawn(i).ret_y = pre_y And board(x, y) >= 0 Then
                        pieza = i ''
                        Form1.b_pawn(i).change_pos(x, y, pre_x, pre_y)
                    End If
                Next
                re_chk_white()
                re_chk_black()
                fill_chk_for_white()
                fill_chk_for_black()
                If False = Form1.ga.show_chk_jaque Then
                    MsgBox("No puedes realizar este movimiento ya que entrarias en jaque", MsgBoxStyle.Information, "MOVIMIENTO INVALIDO")
                    'la movida no se deberia realizar reseteando todo hasta antes de la movida o salir un cartel que diga que es una movida invalida
                    For i = 0 To 7  ''  
                        For j = 0 To 7  ''
                            Form1.ga.board(i, j) = Form1.ga.pre_board(i, j) ''
                        Next    ''
                    Next    ''
                    Form1.b_pawn(pieza).x_pos = pre_x
                    Form1.b_pawn(pieza).y_pos = pre_y
                    Form1.selected = False
                    Form1.ga.re_back()
                    Form1.ga.show()
                Else

                    Form1.Timer1.Enabled = True '''
                    ' show_chk()
                    player = 1
                    chk_winner(selected, x, y)
                End If  ''
            Case Else

        End Select


    End Sub

End Class
