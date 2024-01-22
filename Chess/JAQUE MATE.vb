Public Class JAQUE_MATE

    Private Sub JAQUE_MATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.Hide()
        Me.Hide()
        Form1.PB_Enabled()
        Form1.pb = New PictureBox(7, 7) {{Form1.p00, Form1.p01, Form1.p02, Form1.p03, Form1.p04, Form1.p05, Form1.p06, Form1.p07},
                                {Form1.p10, Form1.p11, Form1.p12, Form1.p13, Form1.p14, Form1.p15, Form1.p16, Form1.p17},
                                {Form1.p20, Form1.p21, Form1.p22, Form1.p23, Form1.p24, Form1.p25, Form1.p26, Form1.p27},
                                {Form1.p30, Form1.p31, Form1.p32, Form1.p33, Form1.p34, Form1.p35, Form1.p36, Form1.p37},
                                {Form1.p40, Form1.p41, Form1.p42, Form1.p43, Form1.p44, Form1.p45, Form1.p46, Form1.p47},
                                {Form1.p50, Form1.p51, Form1.p52, Form1.p53, Form1.p54, Form1.p55, Form1.p56, Form1.p57},
                                {Form1.p60, Form1.p61, Form1.p62, Form1.p63, Form1.p64, Form1.p65, Form1.p66, Form1.p67},
                                {Form1.p70, Form1.p71, Form1.p72, Form1.p73, Form1.p74, Form1.p75, Form1.p76, Form1.p77}}   ' pictureboxes on chessboard (Llena la matriz de pictureboxes instanciando los objetos pictureboxe)

        Form1.all_objects()       'Con esta funcion se cargan los datos a todos los objetos fichas creados identificandolos de forma logica con numeros que indican su posicion y su tipo y color
        Form1.ga.re_can_move()    'Esta funcion resetea la matriz llamada Can_move y la pone toda en false
        Form1.ga.show()           'Esta funcion es la que muestra el tablero de acuerdo al numero indicado en cada objeto que lo identifica como 
        Form1.ga.re_back()         'Resetea el back color de todos los pictureboxes 
        Form1.ga.fill_chk_for_black() 'Esta funcion llena la Matriz check_for_black de game con todas las posibles movidas de als piezas blancas
        Form1.ga.fill_chk_for_white() ''Esta funcion llena la Matriz check_for_black de game con todas las posibles movidas de als piezas blancas
        'motor.SetInputToDefaultAudioDevice()
        ' motor.RecognizeAsync(RecognizeMode.Multiple)

    End Sub
End Class