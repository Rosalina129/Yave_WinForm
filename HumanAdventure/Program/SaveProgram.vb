Module SaveProgram
    Public Structure SaveJSON
        Public saveVersion() As Integer
        Public characterName As String
        Public skin As Integer
        Public regionID As Integer
        Public regionDistance() As Double
        Public materialCount() As Integer
        Public equips() As Double
        Dim player As player

    End Structure
    Public Structure player
        Public element As Integer
        Public level As Integer
        Public xp As Double
        Public xpneed As Double
        Public hp As Integer
        Public maxhp As Integer
        Public attack As Integer
        Public defense As Integer
        Public star_energy As Integer
        Public crit_rate As Double
        Public crit_damage As Double
        Public coins As Integer
    End Structure
    'Public Structure basic

    'End Structure
    'Public Structure skill

    'End Structure
    Public Structure equip
    End Structure
    'Public Structure af

    'End Structure
    Public Structure materials

    End Structure
End Module