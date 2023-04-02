Public Class Form1

    '//More Inf. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-6.0

    Public Sub New()
        InitializeComponent()
    End Sub

    '//-> Text-Only Message Box
    Private Sub btnMsgText_Click(sender As Object, e As EventArgs) Handles btnMsgText.Click
        labelDialogResult.Text = "Dialog Box Result"
        'It Is optional to save the Dialog Result,
        'use it when you need to know which button Or action the user selected,
        'And do a specific function/task according to the dialogue result.
        '-| For Example:
        Dim result As DialogResult = BJCMessageBox.Show("Este es un ejemplo de un cuadro de mensaje de solo texto.")
        If result = DialogResult.OK Then
            labelDialogResult.Text = "Ha seleccionado el BOTÓN OK"
        Else
            labelDialogResult.Text = "Ha seleccionado CANCELAR"
        End If
        'Many times we only need to display a message box, without the need to retrieve the button Or action selected by the user.
        '-| For Example:
        'BJCMessageBox.Show("This is an example of a Text-Only Message Box.");
    End Sub

    '//-> Text + Caption Message Box
    Private Sub btnMsgTextCaption1_Click(sender As Object, e As EventArgs) Handles btnMsgTextCaption1.Click
        labelDialogResult.Text = "Resultado del cuadro de diálogo"
        Dim result As DialogResult = BJCMessageBox.Show("Este es un ejemplo de un cuadro de mensaje de texto + título.",
                                                       "Mensaje importante")
        labelDialogResult.Text = result.ToString() & " Seleccionado"
    End Sub
    Private Sub btnMsgTextCaption2_Click(sender As Object, e As EventArgs) Handles btnMsgTextCaption2.Click
        labelDialogResult.Text = "Resultado del cuadro de diálogo"
        Dim result = BJCMessageBox.Show("Lorem Ipsum es simplemente un texto ficticio de la industria de la imprenta y la composición tipográfica. Lorem Ipsum ha sido el texto ficticio estándar de la industria desde el año 1500, cuando un impresor desconocido tomó una galera de tipos y la codificó para hacer un libro de muestras tipográficas. Ha sobrevivido no solo cinco siglos, sino también el salto a la composición tipográfica electrónica, permaneciendo esencialmente sin cambios. Se popularizó en la década de 1960 con el lanzamiento de hojas de Letraset que contenían pasajes de Lorem Ipsum y, más recientemente, con software de autoedición como Aldus PageMaker, que incluye versiones de Lorem Ipsum." & vbLf & vbLf & "¿Por qué lo usamos?" & vbLf & vbLf & "Es un hecho establecido desde hace mucho tiempo que un lector se distraerá con el contenido legible de una página cuando mire su diseño. El punto de usar Lorem Ipsum es que tiene una distribución de letras más o menos normal, en lugar de usar 'Contenido aquí, contenido aquí', lo que hace que parezca un inglés legible. Muchos paquetes de autoedición y editores de páginas web ahora usan Lorem Ipsum como su modelo de texto predeterminado, y una búsqueda de 'lorem ipsum' descubrirá muchos sitios web que aún están en su infancia. Varias versiones han evolucionado a lo largo de los años, a veces por accidente, a veces a propósito (humor inyectado y similares).",
                                       "Sistema: Guardar cambios")
        labelDialogResult.Text = result.ToString() & " Seleccionado"
    End Sub

    '//-> Buttons Message Box
    Private Sub btnMsgOk_Click(sender As Object, e As EventArgs) Handles btnMsgOk.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an OK Button Message Box.",
                                       "OK Button",
                                       MessageBoxButtons.OK)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgOkCancel_Click(sender As Object, e As EventArgs) Handles btnMsgOkCancel.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an OK, Cancel Button Message Box.",
                                       "OK-Cancel Button",
                                       MessageBoxButtons.OKCancel)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgAbortRetryIgnore_Click(sender As Object, e As EventArgs) Handles btnMsgAbortRetryIgnore.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Abort, Retry, Ignore Button Message Box.",
                                       "Abort-Retry-Ignore Button",
                                       MessageBoxButtons.AbortRetryIgnore)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgYesNo_Click(sender As Object, e As EventArgs) Handles btnMsgYesNo.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Yes, No Button Message Box.",
                                       "Yes-No Button",
                                       MessageBoxButtons.YesNo)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgYesNoCancel_Click(sender As Object, e As EventArgs) Handles btnMsgYesNoCancel.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Yes, No, Cancel Button Message Box.",
                                       "Yes-No-Cancel Button",
                                       MessageBoxButtons.YesNoCancel)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgRetryCancel_Click(sender As Object, e As EventArgs) Handles btnMsgRetryCancel.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Retry, Cancel Button Message Box.",
                                       "Retry-Cancel Button",
                                       MessageBoxButtons.RetryCancel)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//-> Icons Message Box
    Private Sub btnMsgQuestion_Click(sender As Object, e As EventArgs) Handles btnMsgQuestion.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Question Icon Message Box.",
                                       "Question Icon",
                                       MessageBoxButtons.OKCancel,
                                       MessageBoxIcon.Question)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgWarning_Click(sender As Object, e As EventArgs) Handles btnMsgWarning.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Warning-Exclamation Icon Message Box.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Warning)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgError_Click(sender As Object, e As EventArgs) Handles btnMsgError.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Error-Stop Icon Message Box.",
                                       "Error-Stop Icon",
                                       MessageBoxButtons.RetryCancel,
                                       MessageBoxIcon.Error)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgInformation_Click(sender As Object, e As EventArgs) Handles btnMsgInformation.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of an Information Icon Message Box.",
                                       "Information Icon",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//-> Default Button
    Private Sub btnMsgButton1_Click(sender As Object, e As EventArgs) Handles btnMsgButton1.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of a Message Box that sets Button1 as the Default Selected Button." & vbLf & "That is, pressing the Enter Key selects the Button1.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Warning,
                                       MessageBoxDefaultButton.Button1)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgButton2_Click(sender As Object, e As EventArgs) Handles btnMsgButton2.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of a Message Box that sets Button2 as the Default Selected Button." & vbLf & "That is, pressing the Enter Key selects the Button2.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.RetryCancel,
                                       MessageBoxIcon.Information,
                                       MessageBoxDefaultButton.Button2)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgButton3_Click(sender As Object, e As EventArgs) Handles btnMsgButton3.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = BJCMessageBox.Show("This is an example of a Message Box that sets Button3 as the Default Selected Button." & vbLf & "That is, pressing the Enter Key selects the Button3.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.AbortRetryIgnore,
                                       MessageBoxIcon.[Error],
                                       MessageBoxDefaultButton.Button3)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//Set Owner Object
    Private Sub Any()
        '-| IWin32Window owner:
        'Displays a message box in front of the specified object And with the other specified parameters.
        BJCMessageBox.Show(Me, "Text")
        BJCMessageBox.Show(Me, "Text", "Caption")
        BJCMessageBox.Show(Me, "Text", "Caption", MessageBoxButtons.OKCancel)
        'Etc
    End Sub
End Class
