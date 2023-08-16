Module modExceptions

    Function ControlExists(sControl)

        Dim curHeight As Integer

        ControlExists = True

        Try
            curHeight = mainForm.Controls(sControl).Height
        Catch ex As Exception
            ControlExists = False
        End Try


    End Function


End Module
