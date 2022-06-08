Public Class InitEnemy
    'Enemies Database
    Dim Elementid As Integer
    Dim name As String
    Dim HP As Integer
    Dim HPM As Integer
    Dim ATK As Integer
    Dim DEF As Integer
    Dim CRate As Double
    Dim CDMG As Double
    Dim EXP As UInt64
    Dim Coins As Integer
    Dim Basics As ULong
    Dim Skills As ULong
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, name As String, hp As Integer, hpm As Integer, atk As Integer, def As Integer, crate As Double, cdmg As Double, xp As UInt64, coins As Integer)
        Me.Elementid = id
        Me.name = name
        Me.HP = hp
        Me.HPM = hpm
        Me.ATK = atk
        Me.DEF = def
        Me.CRate = crate
        Me.CDMG = cdmg
        Me.EXP = xp
        Me.Coins = coins
    End Sub
    Public Property ID1 As Integer
        Get
            Return Elementid
        End Get
        Set(value As Integer)
            Elementid = value
        End Set
    End Property
    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property HP1 As Integer
        Get
            Return HP
        End Get
        Set(value As Integer)
            HP = value
        End Set
    End Property
    Public Property HPM1 As Integer
        Get
            Return HPM
        End Get
        Set(value As Integer)
            HPM = value
        End Set
    End Property
    Public Property ATK1 As Integer
        Get
            Return ATK
        End Get
        Set(value As Integer)
            ATK = value
        End Set
    End Property
    Public Property DEF1 As Integer
        Get
            Return DEF
        End Get
        Set(value As Integer)
            DEF = value
        End Set
    End Property
    Public Property CRate1 As Double
        Get
            Return CRate
        End Get
        Set(value As Double)
            CRate = value
        End Set
    End Property
    Public Property CDMG1 As Double
        Get
            Return CDMG
        End Get
        Set(value As Double)
            CDMG = value
        End Set
    End Property
    Public Property EXP1 As UInt64
        Get
            Return EXP
        End Get
        Set(value As UInt64)
            EXP = value
        End Set
    End Property
    Public Property Coins1 As Integer
        Get
            Return Coins
        End Get
        Set(value As Integer)
            Coins = value
        End Set
    End Property
End Class
