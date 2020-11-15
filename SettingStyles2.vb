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
    Set folderObj = fso.GetFolder(folderPath)
    Set files = folderObj.files
    Set SubFolders = folderObj.SubFolders
    
    Call ProcessFolder(files)
    Call ProcessFolder(SubFolders)
    
    Set fso = Nothing
        
    Application.ScreenUpdating = True
    
    
End Sub


Sub ProcessFolder(ByVal files As Object)

    Set fso = CreateObject("Scripting.FileSystemObject")

    For Each file In files
        
       If fso.FileExists(file) Then
            Call ProcessFile(file)
        ElseIf fso.FolderExists(file) Then
            Set folderObj = fso.GetFolder(file)
            Set inFiles = folderObj.files
            Set inSubFolders = folderObj.SubFolders
    
            Call ProcessFolder(inFiles)
            Call ProcessFolder(inSubFolders)
        End If
    
    Next file
    
    Set fso = Nothing

End Sub


Sub ProcessFile(ByVal file As Object)

    ' Skipping hidden file
    If Left(file.Name, 2) = "~$" Then
        GoTo SKIP_LOOP
    End If
        
        If Dir(file) = "" Then
            MsgBox filePath & vbCrLf & "File Not Found", vbExclamation
            Exit Sub
        End If
        For Each wb In Workbooks
            If wb.Name = buf Then
                MsgBox filePath & vbCrLf & "File Opened", vbExclamation
                Exit Sub
            End If
        Next wb
    
        Set currentWorkbook = Workbooks.Open(Filename:=file)
        
        'currentWorkbook.Activate
        'ActiveWindow.Visible = False
        
        'For i = 1 To currentWorkbook.Worksheets.Count
        
        For Each currentWorkSheet In currentWorkbook.Worksheets
        
            'currentWorkSheet.Activate
            
             With currentWorkSheet.PageSetup
                .Orientation = xlPortrait '?o?u?u?á?d?c?u?u?E?Yfe
                .Zoom = False '?gea?k?Ê?d?Yfe?i?ƒÊ?E?‘?j
                .FitToPagesWide = 1 '?E?~?A?I?n?d1?y?[?W?E?o?u
                .FitToPagesTall = False '?V?[?g?d1?y?[?W?E?o?u
            End With
        
        Next
        
        'Next i
        
        currentWorkbook.Save
        
        currentWorkbook.Close
        
        
SKIP_LOOP:

End Sub
