Sub WorkbookXXX()
    Dim currentWorkbook As Workbook
    Dim currentWorkSheet As Worksheet
    Dim filePath: filePath = "C:\Users\muramasa\Desktop\work\Book2.xlsm"
    Dim dialog As FileDialog
    Dim folderPath As String
    
    Application.ScreenUpdating = False
    
   With Application.FileDialog(msoFileDialogFolderPicker)
        If .Show Then
            folderPath = .SelectedItems(1)
        End If
    End With
    
    
    Set fso = CreateObject("Scripting.FileSystemObject")
    Set Files = fso.GetFolder(folderPath).Files

' ƒfƒBƒŒƒNƒgƒŠ‚È‚¢‚Ìƒtƒ@ƒCƒ‹‚ðŽæ“¾

    For Each file In Files
        
        If Dir(file) = "" Then
            MsgBox filePath & vbCrLf & "‚Í‘¶Ý‚µ‚Ä‚¢‚Ü‚¹‚ñ", vbExclamation
            Exit Sub
        End If
        For Each wb In Workbooks
            If wb.Name = buf Then
                MsgBox filePath & vbCrLf & "‚Í‚·‚Å‚ÉŠJ‚©‚ê‚Ä‚¢‚Ü‚·", vbExclamation
                Exit Sub
            End If
        Next wb
    
        Workbooks.Open file
        
        'currentWorkbook.Activate
        'ActiveWindow.Visible = False
        
        'For i = 1 To currentWorkbook.Worksheets.Count
        
        For Each currentWorkSheet In ActiveWorkbook.Worksheets
        
            currentWorkSheet.Activate
            
             With currentWorkSheet.PageSetup
                .Orientation = xlPortrait 'ˆóüŒü‚«‚ðc•ûŒü‚ÉÝ’è
                .Zoom = False 'Šg‘åk¬‚ðÝ’èi‚µ‚È‚¢j
                .FitToPagesWide = 1 '‚·‚×‚Ä‚Ì—ñ‚ð1ƒy[ƒW‚Éˆóü
                .FitToPagesTall = False 'ƒV[ƒg‚ð1ƒy[ƒW‚Éˆóü
            End With
        
        Next
        
        'Next i
        
        currentWorkbook.Save
        
        currentWorkbook.Close
    
    Next file
    
    Set fso = Nothing
        
    Application.ScreenUpdating = True
    
    
End Sub
