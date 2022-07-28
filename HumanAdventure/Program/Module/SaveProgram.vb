Module SaveProgram
    Public Structure SaveJSON
        Public save_version() As Integer
        Public tour_time As Integer
        Public character_name As String
        Public death_count As Integer
        Public skin As Integer
        Public region_id As Integer
        Public region_distance() As Double
        Public equips() As equip
        Public talent_basics() As basic
        Public talent_skills() As skill
        Public player As player
    End Structure
    Public Structure artifact
        Public id As Integer
        Public name As String
        Public primary_buff As attribute_buff
    End Structure
    Public Structure player
        Public element_id As Integer
        Public level As Integer
        Public xp As xp
        Public health As health
        Public attack As Integer
        Public defense As Integer
        Public star_energy As Integer
        Public crit_rate As Double
        Public crit_damage As Double
        Public coins As Integer
        Public upgrade_point As Integer
        Public items() As items
        Public artifact() As artifact
    End Structure
    Public Structure basic

    End Structure
    Public Structure skill

    End Structure
    Public Structure equip

    End Structure
    Public Structure equip_attribute
        Public id As Integer
        Public buff As attribute_buff
    End Structure
    Public Structure attribute_buff
        Public name As String
        Public amount As Double
        Public type As Integer
        Public operation As Integer
    End Structure
    Public Structure items
        Public id As Integer
        Public count As Integer
    End Structure
    Public Structure materials

    End Structure
    Public Structure xp
        Public current As Double
        Public need As Double
    End Structure
    Public Structure health
        Public current As Integer
        Public max As Integer
    End Structure
End Module