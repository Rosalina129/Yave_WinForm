Public Class InitData
    Public Shared CName As String = ""
    Public Shared Skin As Double = 0

    Public Shared SkinGallery() As Object = {
        HumanAdventure.My.Resources.Resources.yave_1,
        HumanAdventure.My.Resources.Resources.yave_2,
        HumanAdventure.My.Resources.Resources.yave_3,
        HumanAdventure.My.Resources.Resources.yave_4,
        HumanAdventure.My.Resources.Resources.yave_5,
        HumanAdventure.My.Resources.Resources.yave_6,
        HumanAdventure.My.Resources.Resources.yave_7
    }
    Public Shared isUpgrade As Boolean = False
    Public Shared Name_Dictionary() As String = {
    "Yave Yu", "Steve", "Alex", "John",
    "Jove", "Smith", "Faye", "Amber",
    "Save", "Kate", "Slash", "Orama",
    "Tive", "Bill", "Jean", "Fluent"}
    Public Shared Elementname() As String = {
    "Ice",          '冰
    "Fire",         '火
    "Water",        '水
    "Earth",        '草
    "Star",         '星
    "Metal",        '钢铁
    "Electric"      '雷电
    }
    Public Shared ECR() As Integer = {
    32, 129, 32, 66, 172, 125, 199
    }
    Public Shared ECG() As Integer = {
    123, 20, 46, 109, 156, 125, 175
    }
    Public Shared ECB() As Integer = {
    134, 20, 175, 20, 20, 125, 78
    }
End Class
