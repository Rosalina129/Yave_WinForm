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
    "Tive", "Bill", "Jean", "Fluent", "Collei", "Amber", "Wilison"}
    Public Shared Yave_Name() As String = {
        "Yave", "Wave", "Save", "Nave", "Fave", "Have", "Cave",
        "Zave", "Tave", "Mave", "Bave", "Ave", "Helzong", "Shaff",
        "Firaga", "Blizzaga", "Thundaga", "Yave Family #18", "Yave Family #19", "Yave Family #20", "Yave Family #21"
    }
    Public Shared Elementname() As String = {
    "Common",       '普通
    "Ice",          '冰
    "Fire",         '火
    "Water",        '水
    "Grass",        '草
    "Star",         '星
    "Metal",        '钢铁
    "Electric"      '雷电
    }
    Public Shared ReadOnly ECR() As Integer = {
    32, 32, 129, 32, 66, 172, 125, 199, &H43
    }
    Public Shared ReadOnly ECG() As Integer = {
    32, 123, 20, 46, 109, 156, 125, 175, &H4
    }
    Public Shared ReadOnly ECB() As Integer = {
    32, 134, 20, 175, 20, 20, 125, 78, &H6C
    }
End Class
