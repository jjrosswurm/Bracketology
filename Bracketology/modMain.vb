Module modMain

    Public imgControlint As Integer
    Public RoundData(0 To 1000, 0 To 1000) As Object
    Sub initMain()

        imgControlint = 1
        ClearObject(RoundData)



        'RoundData = Nothing

    End Sub
    Sub ClearPictureBoxes()

        Dim curName As String
        Dim ClearTries As Integer
        ClearTries = 0
        Do
            For Each elem As Control In mainForm.Controls
                curName = elem.Name
                If TypeName(elem) = "PictureBox" Then
                    mainForm.Controls.Remove(mainForm.Controls(curName))
                End If
            Next

            ClearTries = ClearTries + 1
        Loop Until ClearTries > 100

    End Sub
    Function ClearObject(sObj As Object)



        Dim Sr, Sc As Integer

        Sr = 1

        Do
            Sc = 1

            Do
                sObj(Sr, Sc) = ""
                Sc = Sc + 1
            Loop Until Sc > 1000

            Sr = Sr + 1
        Loop Until Sr > 1000

    End Function
    Sub SetRounds()

        ClearPictureBoxes()

        imgControlint = 1

        Dim TotalTeams, TotalRounds, CurrentRound, CurTeam, CurRound As Integer
        Dim ByeTeams As Integer

        If IsNumeric(mainForm.testBox1.Text) = False Then

            Exit Sub

        End If

        TotalTeams = mainForm.testBox1.Text
        TotalRounds = 1
        CurrentRound = TotalTeams
        ByeTeams = 0

        If IsDivTourn(TotalTeams) = False Then
            ByeTeams = TotalTeams
            Do
                ByeTeams = ByeTeams + 1
            Loop Until IsDivTourn(ByeTeams) = True

            ByeTeams = ByeTeams - TotalTeams

        End If

        Do
            CurrentRound = CurrentRound / 2
            TotalRounds = TotalRounds + 1
        Loop Until CurrentRound = 1

        mainForm.testLabel.Text = TotalRounds
        mainForm.testLabel2.Text = ByeTeams

        Dim WriteTeams, WriteRound As Integer

        WriteRound = 1

        Do

            If WriteRound = 1 And ByeTeams > 0 Then
                WriteTeams = TotalTeams - ByeTeams
            ElseIf WriteRound = 1 And ByeTeams = 0 Then
                WriteTeams = TeamsPerRound(WriteRound, TotalRounds)
            ElseIf WriteRound > 1 And ByeTeams > 0 Then
                WriteTeams = TeamsPerRound(WriteRound - 1, TotalRounds)
            Else
                WriteTeams = TeamsPerRound(WriteRound, TotalRounds)
            End If

            Do

                NewForm(WriteRound)
                RoundData(WriteRound, WriteTeams) = "X"
                WriteTeams = WriteTeams - 1
            Loop Until WriteTeams = 0

            imgControlint = 1
            WriteRound = WriteRound + 1

        Loop Until (ByeTeams > 0 And WriteRound > TotalRounds) Or (ByeTeams = 0 And WriteRound > TotalRounds)

        If ByeTeams > 0 Then
            NewForm(TotalRounds + 1)
        End If


    End Sub
    Function TeamsPerRound(sRound, TotalRounds)

        TeamsPerRound = 1

        Dim RoundCount As Integer

        RoundCount = 0

        Do
            If sRound <> TotalRounds Then
                TeamsPerRound = TeamsPerRound * 2
                RoundCount = RoundCount + 1
            End If
        Loop Until RoundCount >= TotalRounds - sRound





    End Function

    Function IsDivTourn(sDbl As Integer)

        IsDivTourn = False

        If sDbl <= 1 Then
            Exit Function
        End If

        Dim CurDiv As Integer

        CurDiv = 1024

        Do
            CurDiv = CurDiv / 2

            If CurDiv = sDbl Then
                IsDivTourn = True
                Exit Function
            End If

        Loop Until CurDiv <= 1


    End Function
    Sub NewForm(curRound)
        Dim newPic As New PictureBox
        Dim heightInt, heightPos, widthInt, widthPos, PrevRounds, boxSpacing, prevHeight As Integer


        boxSpacing = 10

        heightInt = 75

        If curRound > 1 Then
            heightInt = ((mainForm.Controls("TeamPic_" & 1 & "_" & curRound - 1).Height) * 2) + boxSpacing

        End If

        widthInt = heightInt

        heightPos = boxSpacing + ((imgControlint - 1) * (heightInt + boxSpacing))
        PrevRounds = 1

        widthPos = 20

        If curRound > 1 Then
            Do
                prevHeight = mainForm.Controls("TeamPic_" & 1 & "_" & PrevRounds).Height
                widthPos = widthPos + (prevHeight + boxSpacing)
                PrevRounds = PrevRounds + 1
            Loop Until PrevRounds = curRound
        End If

        With newPic
            .Size = New Size(widthInt, heightInt)
            .Location = New Point(widthPos, heightPos)
        End With

        mainForm.Controls.Add(newPic)
        newPic.Name = "TeamPic_" & imgControlint & "_" & curRound
        imgControlint = imgControlint + 1
        'newPic.ImageLocation = FindImage("x")
        newPic.BackColor = valRGB(0, 0, 0)
        newPic.SizeMode = PictureBoxSizeMode.StretchImage
        newPic.Visible = True

    End Sub

    Sub ClearPictureControls()

        Dim CurRound, CurPic As Integer
        Dim CurControl As Control

        CurRound = 1

        Do
            CurPic = 1

            Do

                If ControlExists("TeamPic_" & CurRound & "_" & CurPic) = True Then
                    mainForm.Controls.Remove(mainForm.Controls("TeamPic_" & CurRound & "_" & CurPic))
                    CurPic = CurPic + 1
                End If

            Loop Until ControlExists("TeamPic_" & CurRound & "_" & CurPic) = False
            CurRound = CurRound + 1
        Loop Until ControlExists("TeamPic_" & CurRound & "_" & 1) = False

    End Sub

    Function valRGB(sRed, sGreen, sBlue)

        valRGB = Color.FromArgb(CType(CType(sRed, Byte), Integer), CType(CType(sGreen, Byte), Integer), CType(CType(sBlue, Byte), Integer))

    End Function
    Function IsEven(sNum)

        Dim strNum, strInt As String

        strNum = CStr(sNum / 2)
        strInt = CStr(CInt(sNum / 2))

        If Len(strNum) = Len(strInt) Then
            IsEven = True
        Else
            IsEven = False
        End If

    End Function

    Function FindImage(sTeamName)

        FindImage = "https://ih1.redbubble.net/image.1132050830.2346/st,small,845x845-pad,1000x1000,f8f8f8.jpg"




    End Function


End Module
