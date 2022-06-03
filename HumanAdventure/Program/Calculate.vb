Imports System.Threading
Public Class Calculate

    '一次攻击结算伤害=攻击者输出伤害*(1-防御值物免率)

    '防御值物免率换算方法1：

    '防御值物免率=1-1/(1+防守者防御总值/10)
    Public Shared Function ADCount(hp As Integer, a As Integer, ed As Integer, crate As Double, cdmg As Double)
        Dim r1 As New Random
        Thread.Sleep(1)
        Dim c As Double
        c = r1.NextDouble()
        Dim Defenseinv As Double
        Defenseinv = 1 - 1 / (1 + ed / 10)
        'MsgBox(c & " to " & 1 - crate)
        'MainWindow.DamageCountBox.Text = MainWindow.DamageCountBox.Text & Chr(13) & "Random:" & c
        If c >= 1 - crate Then
            Return hp - a * (1 - Defenseinv) * (1 + cdmg)
        Else
            Return hp - a * (1 - Defenseinv)
        End If
    End Function
End Class
