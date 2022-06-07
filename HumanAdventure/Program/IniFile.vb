Module IniFile
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" _
(ByVal lpApplicationName As String, ByVal lpKeyName As String,
ByVal lpDefault As String, ByVal lpReturnedString As String,
ByVal nSize As Integer, ByVal lpFileName As String) As Integer '引用读INI文件的API

    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" _
    (ByVal lpApplicationName As String, ByVal lpKeyName As String,
    ByVal lpString As String, ByVal lpFileName As String) As Integer '引用写INI文件的API

    Public strINIFile As String 'INI文件名

    Public Function sGetINI(ByRef sPubINIFile As String, ByRef sSection As String, ByRef sKey As String, ByRef sDefault As String) As String '从INI文件中获取值函数

        Dim sTemp As String
        Dim nLength As Short

        sTemp = Space(256)
        nLength = GetPrivateProfileString(sSection, sKey, sDefault, sTemp, 255, sPubINIFile) '调用API函数
        sGetINI = Left(sTemp, nLength)

    End Function

    Public Sub writeINI(ByRef sINIFile As String, ByRef sSection As String, ByRef sKey As String, ByRef sValue As String) '将数值写入INI文件

        Dim n As Short
        Dim sTemp As String

        sTemp = sValue

        For n = 1 To Len(sValue)
            If Mid(sValue, n, 1) = vbCr Or Mid(sValue, n, 1) = vbLf Then Mid(sValue, n) = " "
        Next n

        n = WritePrivateProfileString(sSection, sKey, sTemp, sINIFile)

    End Sub
End Module
