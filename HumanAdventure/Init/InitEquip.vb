Public Class InitEquip
    Structure Buffs
        Public type As Integer
        '0 Max Health
        '1 Attack Number
        '2 Defense Number
        '3 Attack Percent
        '4 Defense Percent
        '5 Crit Rate
        '6 Crit Damage
        Public value As Double
        Public operation As Byte
    End Structure
    Dim id As Integer
    Dim Name As String
    Dim PrimaryBuff As Buffs
    Dim SecondaryBuff() As Buffs
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, name As String, primaryBuff As Buffs, secondaryBuff() As Buffs)
        Me.id = id
        Me.Name = name
        Me.PrimaryBuff = primaryBuff
        Me.SecondaryBuff = secondaryBuff
    End Sub
    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property Name1 As String
        Get
            Return Name
        End Get
        Set(value As String)
            Name = value
        End Set
    End Property
    Public Property PrimaryBuff1 As Buffs
        Get
            Return PrimaryBuff
        End Get
        Set(value As Buffs)
            PrimaryBuff = value
        End Set
    End Property
    Public Property SecondaryBuff1 As Buffs()
        Get
            Return SecondaryBuff
        End Get
        Set(value As Buffs())
            SecondaryBuff = value
        End Set
    End Property
End Class
