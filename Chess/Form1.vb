Imports System.Speech.Recognition
Imports System.Globalization
Imports System.Threading
'CORREGIDO ERROR DEL RECOGNITION CUANDO NO HAY JUEGO
'CORREGIDO EL JAQUE MATE
'CORREGIDAS MOVIDAS INVALIDAS 
Public Class Form1
    'PARA EL DESPLAZAMIENTO
    'Public origen As Point
    ' Public pos_final As Point

    'AGREGANDO RECONOCIMIENTO DE VOZ
    Dim motor As SpeechRecognitionEngine = New SpeechRecognitionEngine
    Dim vocabulario As String() = {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "C1", "se1", "se2", "C3", "se4", "se5", "se6", "se7", "se8", "De1", "De2", "De3", "De4", "De5", "De6", "De7", "De8", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "F1", "F2", "efe3", "efe4", "efe5", "efe6", "F7", "F8", "ge1", "ge2", "ge3", "ge4", "G5", "G6", "G7", "ge8", "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "juego nuevo"}

    Public Event speechrecognized As EventHandler(Of SpeechRecognizedEventArgs)
    Public Event speechrecognitionrejected As EventHandler(Of SpeechRecognitionRejectedEventArgs)
    Public origen As Point

    Public Sub reconoce(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        'Esto es para no tener problemas con el reconocimiento de voz al momento de iniciar un juego y que no intente mover casilleros no instanciados
        Select Case e.Result.Text
            Case "A1"
                If ga Is Nothing Then
                Else
                    TextBox1.Text = e.Result.Text.ToUpper
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "A2"
                If ga Is Nothing Then
                Else
                    TextBox1.Text = e.Result.Text.ToUpper
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "A3"
                If ga Is Nothing Then
                Else
                    TextBox1.Text = e.Result.Text.ToUpper
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "A4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''

            Case "A5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "A6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "A7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "A8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 0
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "B1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''

            Case "B2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "B3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "B4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "B5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "B6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "B7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "B8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 1
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "se1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "C2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "C3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "se4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "se5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "se6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "se7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "se8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 2
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "De1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "De2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "De3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "De4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "De5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''

            Case "De6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''

            Case "De7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "De8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 3
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "E1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If
            Case "E2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "E3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "E4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "E5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "E6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    If ga Is Nothing Then
                    Else

                        ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                        x = 4
                        y = 5
                        If selected <> True Then    'Si la variable selected se encuentra en falso
                            ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                            sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                            sel_x = x
                            sel_y = y
                            selected = True
                        Else
                            If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                                ga.mov(sel_piece, x, y, sel_x, sel_y)
                            End If
                            selected = False
                            ga.show()
                        End If
                    End If
                End If ''
            Case "E7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "E8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 4
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "F1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "F2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "efe3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "efe4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "efe5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "efe6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "F7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "F8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 5
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "ge1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "ge2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "ge3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "ge4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "G5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "G6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "G7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "ge8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 6
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H1"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 0
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H2"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 1
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H3"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 2
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H4"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 3
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H5"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 4
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H6"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 5
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H7"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 6
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "H8"
                If ga Is Nothing Then ''
                Else ''
                    TextBox1.Text = e.Result.Text.ToUpper ''
                    ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
                    x = 7
                    y = 7
                    If selected <> True Then    'Si la variable selected se encuentra en falso
                        ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
                        sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
                        sel_x = x
                        sel_y = y
                        selected = True
                    Else
                        If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                            ga.mov(sel_piece, x, y, sel_x, sel_y)
                        End If
                        selected = False
                        ga.show()
                    End If
                End If ''
            Case "juego nuevo"
                PB_Enabled()
                pb = New PictureBox(7, 7) {{Me.p00, Me.p01, Me.p02, Me.p03, Me.p04, Me.p05, Me.p06, Me.p07},
                                {Me.p10, Me.p11, Me.p12, Me.p13, Me.p14, Me.p15, Me.p16, Me.p17},
                                {Me.p20, Me.p21, Me.p22, Me.p23, Me.p24, Me.p25, Me.p26, Me.p27},
                                {Me.p30, Me.p31, Me.p32, Me.p33, Me.p34, Me.p35, Me.p36, Me.p37},
                                {Me.p40, Me.p41, Me.p42, Me.p43, Me.p44, Me.p45, Me.p46, Me.p47},
                                {Me.p50, Me.p51, Me.p52, Me.p53, Me.p54, Me.p55, Me.p56, Me.p57},
                                {Me.p60, Me.p61, Me.p62, Me.p63, Me.p64, Me.p65, Me.p66, Me.p67},
                                {Me.p70, Me.p71, Me.p72, Me.p73, Me.p74, Me.p75, Me.p76, Me.p77}}   ' pictureboxes on chessboard (Llena la matriz de pictureboxes instanciando los objetos pictureboxe)

                all_objects()       'Con esta funcion se cargan los datos a todos los objetos fichas creados identificandolos de forma logica con numeros que indican su posicion y su tipo y color
                ga.re_can_move()    'Esta funcion resetea la matriz llamada Can_move y la pone toda en false
                ga.show()           'Esta funcion es la que muestra el tablero de acuerdo al numero indicado en cada objeto que lo identifica como 
                ga.re_back()         'Resetea el back color de todos los pictureboxes 
                ga.fill_chk_for_black() 'Esta funcion llena la Matriz check_for_black de game con todas las posibles movidas de als piezas blancas
                ga.fill_chk_for_white() ''Esta funcion llena la Matriz check_for_black de game con todas las posibles movidas de als piezas blancas
                ' motor.SetInputToDefaultAudioDevice()
                ' motor.RecognizeAsync(RecognizeMode.Multiple)
                'AddHandler motor.SpeechRecognized, AddressOf Me.reconoce
            Case Else

        End Select

    End Sub

    Public pb(7, 7) As PictureBox 'Se crea una amtriz de pictureboxes para la visualizacion grafica del juego
    Public w_king As king
    Public w_queen As queen
    Public w_bishop(1) As bishop
    Public w_knight(1) As knight
    Public w_rook(1) As rook
    Public w_pawn(7) As pawn
    Public b_king As king
    Public b_queen As queen
    Public b_bishop(1) As bishop
    Public b_knight(1) As knight
    Public b_rook(1) As rook
    Public b_pawn(7) As pawn

    Public ga As game = Nothing
    Public x, y, sel_x, sel_y As Integer    'X e Y son las coordenadas asignadas a cada picture box dentro del tableero y sel_x y sel_y son las coordenadas de la casilla seleccionada
    Public selected As Boolean = False      '' this is to check if a piece is selected by player or not
    Public sel_piece As String = Nothing
    Private Sub Newgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Newgame.Click  'Evento clic del boton new game
        PB_Enabled()
        pb = New PictureBox(7, 7) {{Me.p00, Me.p01, Me.p02, Me.p03, Me.p04, Me.p05, Me.p06, Me.p07},
                                {Me.p10, Me.p11, Me.p12, Me.p13, Me.p14, Me.p15, Me.p16, Me.p17},
                                {Me.p20, Me.p21, Me.p22, Me.p23, Me.p24, Me.p25, Me.p26, Me.p27},
                                {Me.p30, Me.p31, Me.p32, Me.p33, Me.p34, Me.p35, Me.p36, Me.p37},
                                {Me.p40, Me.p41, Me.p42, Me.p43, Me.p44, Me.p45, Me.p46, Me.p47},
                                {Me.p50, Me.p51, Me.p52, Me.p53, Me.p54, Me.p55, Me.p56, Me.p57},
                                {Me.p60, Me.p61, Me.p62, Me.p63, Me.p64, Me.p65, Me.p66, Me.p67},
                                {Me.p70, Me.p71, Me.p72, Me.p73, Me.p74, Me.p75, Me.p76, Me.p77}}   ' pictureboxes on chessboard (Llena la matriz de pictureboxes instanciando los objetos pictureboxe)

        all_objects()       'Con esta funcion se cargan los datos a todos los objetos fichas creados identificandolos de forma logica con numeros que indican su posicion y su tipo y color
        ga.re_can_move()    'Esta funcion resetea la matriz llamada Can_move y la pone toda en false
        ga.show()           'Esta funcion es la que muestra el tablero de acuerdo al numero indicado en cada objeto que lo identifica como 
        ga.re_back()         'Resetea el back color de todos los pictureboxes 
        ga.fill_chk_for_black() 'Esta funcion llena la Matriz check_for_black de game con todas las posibles movidas de als piezas blancas
        ga.fill_chk_for_white() ''Esta funcion llena la Matriz check_for_black de game con todas las posibles movidas de als piezas blancas
        'motor.SetInputToDefaultAudioDevice()
        ' motor.RecognizeAsync(RecognizeMode.Multiple)
        AddHandler motor.SpeechRecognized, AddressOf Me.reconoce

    End Sub

    Public Sub all_objects()                'En esta funcion se cargan los datos de las posiciones logicas de cada una de las piesas 
        w_king = New king(0, 4, 1)          'y un numero que las identifica de que tipo son y si son blancas o negras 
        w_queen = New queen(0, 3, 2)
        w_bishop(0) = New bishop(0, 2, 3)
        w_bishop(1) = New bishop(0, 5, 3)
        w_knight(0) = New knight(0, 1, 4)
        w_knight(1) = New knight(0, 6, 4)
        w_rook(0) = New rook(0, 0, 5)
        w_rook(1) = New rook(0, 7, 5)
        w_pawn(0) = New pawn(1, 0, 6)
        w_pawn(1) = New pawn(1, 1, 6)
        w_pawn(2) = New pawn(1, 2, 6)
        w_pawn(3) = New pawn(1, 3, 6)
        w_pawn(4) = New pawn(1, 4, 6)
        w_pawn(5) = New pawn(1, 5, 6)
        w_pawn(6) = New pawn(1, 6, 6)
        w_pawn(7) = New pawn(1, 7, 6)

        '''''''''''''''''''''''''''''''''''''''  BLACK PIECES OBJECTS''''''''''''''''' 

        b_king = New king(7, 4, -1)
        b_queen = New queen(7, 3, -2)
        b_bishop(0) = New bishop(7, 2, -3)
        b_bishop(1) = New bishop(7, 5, -3)
        b_knight(0) = New knight(7, 1, -4)
        b_knight(1) = New knight(7, 6, -4)
        b_rook(0) = New rook(7, 0, -5)
        b_rook(1) = New rook(7, 7, -5)
        b_pawn(0) = New pawn(6, 0, -6)
        b_pawn(1) = New pawn(6, 1, -6)
        b_pawn(2) = New pawn(6, 2, -6)
        b_pawn(3) = New pawn(6, 3, -6)
        b_pawn(4) = New pawn(6, 4, -6)
        b_pawn(5) = New pawn(6, 5, -6)
        b_pawn(6) = New pawn(6, 6, -6)
        b_pawn(7) = New pawn(6, 7, -6)


        ga = New game()         'Instancia o crea un objeto de la clase Game


    End Sub             ''initialization of all objects

    Private Sub p00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p00.Click
        ga.re_back()    'Reseteamos los fondos de todos los pictureboxes
        x = 0
        y = 0
        If selected <> True Then    'Si la variable selected se encuentra en falso
            ga.re_can_move()        'Reseteamos la matriz logica can_move del objeto game
            sel_piece = ga.selection(x, y)  'Relaciona la matriz logica con la matriz de pictureboxes mediante los movimientos de las diferentes piezas
            sel_x = x
            sel_y = y
            origen = New Point(p00.Location.X, p00.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then    'En el caso en que ya se encuentre seleccionada alguna pieza
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If

    End Sub
    Private Sub p01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p01.Click
        ga.re_back()
        x = 0
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p01.Location.X, p01.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If

    End Sub
    Private Sub p02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p02.Click
        ga.re_back()
        x = 0
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p02.Location.X, p02.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If

    End Sub
    Private Sub p03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p03.Click
        ga.re_back()
        x = 0
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p03.Location.X, p03.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            '' ga.show()
        End If

    End Sub
    Private Sub p04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p04.Click
        ga.re_back()
        x = 0
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p04.Location.X, p04.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If

    End Sub
    Private Sub p05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p05.Click
        ga.re_back()
        x = 0
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p05.Location.X, p05.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If

    End Sub
    Private Sub p06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p06.Click
        ga.re_back()
        x = 0
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p06.Location.X, p06.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If

    End Sub
    Private Sub p07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p07.Click
        ga.re_back()
        x = 0
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p07.Location.X, p07.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If

    End Sub

    Private Sub p10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p10.Click
        ga.re_back()
        x = 1
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p10.Location.X, p10.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ''ga.show()
        End If
    End Sub
    Private Sub p11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p11.Click
        ga.re_back()
        x = 1
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p11.Location.X, p11.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p12.Click
        ga.re_back()
        x = 1
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p12.Location.X, p12.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p13.Click
        ga.re_back()
        x = 1
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p13.Location.X, p13.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p14.Click
        ga.re_back()
        x = 1
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p14.Location.X, p14.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p15.Click
        ga.re_back()
        x = 1
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p15.Location.X, p15.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p16.Click
        ga.re_back()
        x = 1
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p16.Location.X, p16.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p17.Click
        ga.re_back()
        x = 1
        y = 7
        If selected <> True Then

            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p17.Location.X, p17.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub

    Private Sub p20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p20.Click
        ga.re_back()
        x = 2
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p20.Location.X, p20.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If

    End Sub
    Private Sub p21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p21.Click
        ga.re_back()
        x = 2
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p21.Location.X, p21.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p22.Click
        ga.re_back()
        x = 2
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p22.Location.X, p22.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p23.Click
        ga.re_back()
        x = 2
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p23.Location.X, p23.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p24.Click
        ga.re_back()
        x = 2
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p24.Location.X, p24.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p25.Click
        ga.re_back()
        x = 2
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p25.Location.X, p25.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p26.Click
        ga.re_back()
        x = 2
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p26.Location.X, p26.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p27.Click
        ga.re_back()
        x = 2
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p27.Location.X, p27.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub

    Private Sub p30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p30.Click
        ga.re_back()
        x = 3
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p30.Location.X, p30.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p31.Click
        ga.re_back()
        x = 3
        y = 1

        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p31.Location.X, p31.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()

        End If
    End Sub
    Private Sub p32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p32.Click
        ga.re_back()
        x = 3
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p32.Location.X, p32.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p33.Click
        ga.re_back()
        x = 3
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p33.Location.X, p33.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p34.Click
        ga.re_back()
        x = 3
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p34.Location.X, p34.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p35.Click
        ga.re_back()
        x = 3
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p35.Location.X, p35.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p36.Click
        ga.re_back()
        x = 3
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p36.Location.X, p36.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p37.Click
        ga.re_back()
        x = 3
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p37.Location.X, p37.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub

    Private Sub p40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p40.Click
        ga.re_back()
        x = 4
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p40.Location.X, p40.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p41.Click
        ga.re_back()
        x = 4
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p41.Location.X, p41.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p42.Click
        ga.re_back()
        x = 4
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p42.Location.X, p42.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p43.Click
        ga.re_back()
        x = 4
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p43.Location.X, p43.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p44.Click
        ga.re_back()
        x = 4
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p44.Location.X, p44.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p45.Click
        ga.re_back()
        x = 4
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p45.Location.X, p45.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ''ga.show()
        End If
    End Sub
    Private Sub p46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p46.Click
        ga.re_back()
        x = 4
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p46.Location.X, p46.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p47.Click
        ga.re_back()
        x = 4
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p47.Location.X, p47.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub

    Private Sub p50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p50.Click
        ga.re_back()
        x = 5
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p50.Location.X, p50.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p51.Click
        ga.re_back()
        x = 5
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p51.Location.X, p51.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p52.Click
        ga.re_back()
        x = 5
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p52.Location.X, p52.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p53.Click
        ga.re_back()
        x = 5
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p53.Location.X, p53.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p54.Click
        ga.re_back()
        x = 5
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p54.Location.X, p54.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p55.Click
        ga.re_back()
        x = 5
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p55.Location.X, p55.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p56.Click
        ga.re_back()
        x = 5
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p56.Location.X, p56.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p57.Click
        ga.re_back()
        x = 5
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p57.Location.X, p57.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub

    Private Sub p60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p60.Click
        ga.re_back()
        x = 6
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p60.Location.X, p60.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p61.Click
        ga.re_back()
        x = 6
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y

            origen = New Point(p61.Location.X, p61.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p62.Click
        ga.re_back()
        x = 6
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p62.Location.X, p62.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p63.Click
        ga.re_back()
        x = 6
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p63.Location.X, p63.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p64.Click
        ga.re_back()
        x = 6
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p64.Location.X, p64.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p65.Click
        ga.re_back()
        x = 6
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p65.Location.X, p65.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p66.Click
        ga.re_back()
        x = 6
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p66.Location.X, p66.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p67.Click
        ga.re_back()
        x = 6
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p67.Location.X, p67.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub

    Private Sub p70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p70.Click
        ga.re_back()
        x = 7
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p70.Location.X, p70.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p71.Click
        ga.re_back()
        x = 7
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p71.Location.X, p71.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p72.Click
        ga.re_back()
        x = 7
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p72.Location.X, p72.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p73.Click
        ga.re_back()
        x = 7
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p73.Location.X, p73.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p74.Click
        ga.re_back()
        x = 7
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p74.Location.X, p74.Location.Y)
            Select Case sel_piece
                Case "b_knight" '
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background) '

                Case "b_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "b_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "b_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case "w_rook" '
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background) '
                Case "w_bishop" '
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background) '
                Case "w_pawn" '
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background) '
                Case Else '
            End Select '
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub
    Private Sub p75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p75.Click
        ga.re_back()
        x = 7
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p75.Location.X, p75.Location.Y)
            Select Case sel_piece
                Case "b_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background)
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background)

                Case "b_rook"
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background)
                Case "b_bishop"
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background)
                Case "b_pawn"
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background)
                Case "w_rook"
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background)
                Case "w_bishop"
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background)
                Case "w_pawn"
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background)
                Case Else
            End Select
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p76.Click
        ga.re_back()
        x = 7
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p76.Location.X, p76.Location.Y)
            Select Case sel_piece
                Case "b_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background)
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background)

                Case "b_rook"
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background)
                Case "b_bishop"
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background)
                Case "b_pawn"
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background)
                Case "w_rook"
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background)
                Case "w_bishop"
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background)
                Case "w_pawn"
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background)
                Case Else
            End Select
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ' ga.show()
        End If
    End Sub
    Private Sub p77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p77.Click
        ga.re_back()
        x = 7
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            origen = New Point(p77.Location.X, p77.Location.Y)
            Select Case sel_piece
                Case "b_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background)
                Case "w_knight"
                    My.Computer.Audio.Play(My.Resources.CABALLO14, AudioPlayMode.Background)

                Case "b_rook"
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background)
                Case "b_bishop"
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background)
                Case "b_pawn"
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background)
                Case "w_rook"
                    My.Computer.Audio.Play(My.Resources.TORRE, AudioPlayMode.Background)
                Case "w_bishop"
                    My.Computer.Audio.Play(My.Resources.ALFIL, AudioPlayMode.Background)
                Case "w_pawn"
                    My.Computer.Audio.Play(My.Resources.ESPADA_PEON31, AudioPlayMode.Background)
                Case Else
            End Select
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            'ga.show()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Desea salir del juego", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PB_Disabled()
        motor.UnloadAllGrammars()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
        Dim constructor_gramatical As GrammarBuilder = New GrammarBuilder
        constructor_gramatical.Append(New Choices(vocabulario), 0, 1)
        motor.LoadGrammar(New Grammar(constructor_gramatical))
        motor.SetInputToDefaultAudioDevice()
        motor.RecognizeAsync(RecognizeMode.Multiple)
        AddHandler motor.SpeechRecognized, AddressOf Me.reconoce



    End Sub

    Public Sub PB_Enabled()
        Me.p00.Enabled = True
        Me.p01.Enabled = True
        Me.p02.Enabled = True
        Me.p03.Enabled = True
        Me.p04.Enabled = True
        Me.p05.Enabled = True
        Me.p06.Enabled = True
        Me.p07.Enabled = True
        Me.p10.Enabled = True
        Me.p11.Enabled = True
        Me.p12.Enabled = True
        Me.p13.Enabled = True
        Me.p14.Enabled = True
        Me.p15.Enabled = True
        Me.p16.Enabled = True
        Me.p17.Enabled = True
        Me.p20.Enabled = True
        Me.p21.Enabled = True
        Me.p22.Enabled = True
        Me.p23.Enabled = True
        Me.p24.Enabled = True
        Me.p25.Enabled = True
        Me.p26.Enabled = True
        Me.p27.Enabled = True
        Me.p30.Enabled = True
        Me.p31.Enabled = True
        Me.p32.Enabled = True
        Me.p33.Enabled = True
        Me.p34.Enabled = True
        Me.p35.Enabled = True
        Me.p36.Enabled = True
        Me.p37.Enabled = True
        Me.p40.Enabled = True
        Me.p41.Enabled = True
        Me.p42.Enabled = True
        Me.p43.Enabled = True
        Me.p44.Enabled = True
        Me.p45.Enabled = True
        Me.p46.Enabled = True
        Me.p47.Enabled = True
        Me.p50.Enabled = True
        Me.p51.Enabled = True
        Me.p52.Enabled = True
        Me.p53.Enabled = True
        Me.p54.Enabled = True
        Me.p55.Enabled = True
        Me.p56.Enabled = True
        Me.p57.Enabled = True
        Me.p60.Enabled = True
        Me.p61.Enabled = True
        Me.p62.Enabled = True
        Me.p63.Enabled = True
        Me.p64.Enabled = True
        Me.p65.Enabled = True
        Me.p66.Enabled = True
        Me.p67.Enabled = True
        Me.p70.Enabled = True
        Me.p71.Enabled = True
        Me.p72.Enabled = True
        Me.p73.Enabled = True
        Me.p74.Enabled = True
        Me.p75.Enabled = True
        Me.p76.Enabled = True
        Me.p77.Enabled = True
    End Sub
    Public Sub PB_Disabled()
        Me.p00.Enabled = False
        Me.p01.Enabled = False
        Me.p02.Enabled = False
        Me.p03.Enabled = False
        Me.p04.Enabled = False
        Me.p05.Enabled = False
        Me.p06.Enabled = False
        Me.p07.Enabled = False
        Me.p10.Enabled = False
        Me.p11.Enabled = False
        Me.p12.Enabled = False
        Me.p13.Enabled = False
        Me.p14.Enabled = False
        Me.p15.Enabled = False
        Me.p16.Enabled = False
        Me.p17.Enabled = False
        Me.p20.Enabled = False
        Me.p21.Enabled = False
        Me.p22.Enabled = False
        Me.p23.Enabled = False
        Me.p24.Enabled = False
        Me.p25.Enabled = False
        Me.p26.Enabled = False
        Me.p27.Enabled = False
        Me.p30.Enabled = False
        Me.p31.Enabled = False
        Me.p32.Enabled = False
        Me.p33.Enabled = False
        Me.p34.Enabled = False
        Me.p35.Enabled = False
        Me.p36.Enabled = False
        Me.p37.Enabled = False
        Me.p40.Enabled = False
        Me.p41.Enabled = False
        Me.p42.Enabled = False
        Me.p43.Enabled = False
        Me.p44.Enabled = False
        Me.p45.Enabled = False
        Me.p46.Enabled = False
        Me.p47.Enabled = False
        Me.p50.Enabled = False
        Me.p51.Enabled = False
        Me.p52.Enabled = False
        Me.p53.Enabled = False
        Me.p54.Enabled = False
        Me.p55.Enabled = False
        Me.p56.Enabled = False
        Me.p57.Enabled = False
        Me.p60.Enabled = False
        Me.p61.Enabled = False
        Me.p62.Enabled = False
        Me.p63.Enabled = False
        Me.p64.Enabled = False
        Me.p65.Enabled = False
        Me.p66.Enabled = False
        Me.p67.Enabled = False
        Me.p70.Enabled = False
        Me.p71.Enabled = False
        Me.p72.Enabled = False
        Me.p73.Enabled = False
        Me.p74.Enabled = False
        Me.p75.Enabled = False
        Me.p76.Enabled = False
        Me.p77.Enabled = False
    End Sub

    Private Sub btnAudio_Click(sender As Object, e As EventArgs) Handles btnAudio.Click
        Select Case ComboBox1.SelectedIndex

            Case 0
                My.Computer.Audio.Stop()

                '   My.Computer.Audio.Play(My.Resources.Chessmaster_II___Countermoves__128kbit_AAC___online_audio_converter_com_, AudioPlayMode.BackgroundLoop)

            Case 1
                'My.Computer.Audio.Stop()

                My.Computer.Audio.Play(My.Resources.AGEopen, AudioPlayMode.BackgroundLoop)
            Case 2
                ' My.Computer.Audio.Stop()

                My.Computer.Audio.Play(My.Resources.Chessmaster_II___Countermoves__128kbit_AAC___online_audio_converter_com_, AudioPlayMode.BackgroundLoop)
            Case 3

                My.Computer.Audio.Play(My.Resources.AGEmusic2, AudioPlayMode.BackgroundLoop)

            Case 4

                My.Computer.Audio.Play(My.Resources.AGEmusic8, AudioPlayMode.BackgroundLoop)
            Case 5
                My.Computer.Audio.Play(My.Resources.Chess_Ultra_recortado__online_audio_converter_com_, AudioPlayMode.BackgroundLoop)
        End Select
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CREDITOS_CHESS.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        REGLAS.Show()

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.pb(sel_x, sel_y).Bounds.IntersectsWith(Me.pb(x, y).Bounds) = False Then '''
            Me.pb(sel_x, sel_y).BringToFront()
            If x = sel_x Then '''
                If y > sel_y Then '''
                    Me.pb(sel_x, sel_y).Left = Me.pb(sel_x, sel_y).Left + 3 '''
                Else '''
                    Me.pb(sel_x, sel_y).Left = Me.pb(sel_x, sel_y).Left - 3 '''

                End If '''
            Else '''
                If x > sel_x Then '''
                    If y = sel_y Then '''
                        Me.pb(sel_x, sel_y).Top = Me.pb(sel_x, sel_y).Top + 3

                    Else '''
                        If y > sel_y Then '''
                            Me.pb(sel_x, sel_y).Top = Me.pb(sel_x, sel_y).Top + 3
                            Me.pb(sel_x, sel_y).Left = Me.pb(sel_x, sel_y).Left + 3 '''
                        Else '''
                            Me.pb(sel_x, sel_y).Top = Me.pb(sel_x, sel_y).Top + 3
                            Me.pb(sel_x, sel_y).Left = Me.pb(sel_x, sel_y).Left - 3 '''
                        End If '''

                    End If '''
                Else '''
                    If y = sel_y Then '''
                        Me.pb(sel_x, sel_y).Top = Me.pb(sel_x, sel_y).Top - 3 '''
                    Else '''
                        If y > sel_y Then '''
                            Me.pb(sel_x, sel_y).Top = Me.pb(sel_x, sel_y).Top - 3
                            Me.pb(sel_x, sel_y).Left = Me.pb(sel_x, sel_y).Left + 3 '''
                        Else '''
                            Me.pb(sel_x, sel_y).Top = Me.pb(sel_x, sel_y).Top - 3
                            Me.pb(sel_x, sel_y).Left = Me.pb(sel_x, sel_y).Left - 3 '''
                        End If '''
                    End If '''
                End If '''
            End If '''
        Else '''
            Timer1.Enabled = False '''
            pb(sel_x, sel_y).BringToFront()
            ' pb(sel_x, sel_y).SizeMode = PictureBoxSizeMode.StretchImage
            pb(sel_x, sel_y).Image = My.Resources.caballoHP '''
            System.Threading.Thread.Sleep(500)

            'pausa para la ejecucion del gift '''
            'pb(x, y).Image = pb(sel_x, sel_y).Image '''
            'pb(sel_x, sel_y).Image = Nothing '''
            ga.show() '''
            Me.pb(sel_x, sel_y).Location = origen '''


            'Me.pb(sel_x, sel_y).BackColor = Color.Red

        End If '''
    End Sub
End Class