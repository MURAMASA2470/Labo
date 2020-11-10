Sub WorkbookXXX()
    Dim currentWorkbook As Workbook
    Dim currentWorkSheet As Worksheet
    Dim filePath: filePath = "/Users/muramasa/Downloads/meibo.xlsx"
    Dim dialog As FileDialog
    Dim folderPath As String
    
    Application.ScreenUpdating = False
    
   With Application.FileDialog(msoFileDialogFolderPicker)
        If .Show Then
            folderPath = .SelectedItems(1)
        End If
    End With

' ディレクトリないのファイルを取得

  If Dir(filePath) = "" Then
    MsgBox filePath & vbCrLf & "は存在していません", vbExclamation
    Exit Sub
  End If
  For Each wb In Workbooks
    If wb.Name = buf Then
        MsgBox filePath & vbCrLf & "はすでに開かれています", vbExclamation
        Exit Sub
    End If
Next wb

    Set currentWorkbook = Workbooks.Open(filePath)
    currentWorkbook.Activate
    ActiveWindow.Visible = False
    
    Set currentWorkSheet = currentWorkbook.Worksheets("教室(B4)")

    With currentWorkSheet.PageSetup
        .Orientation = xlPortrait '印刷向きを縦方向に設定
        .Zoom = False '拡大縮小を設定（しない）
        .FitToPagesWide = 1 'すべての列を1ページに印刷
        .FitToPagesTall = False 'シートを1ページに印刷
    End With
    
    currentWorkbook.Save
    
    currentWorkbook.Close
    
    Application.ScreenUpdating = True
    
End Sub

