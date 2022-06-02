Public Class InitPlayer
    Dim Skin As Integer                 'SkinID
    Dim Element As Integer              'ElementID
    Dim CName As String                 'Character Name
    Dim Level As Integer                'Level
    Dim XP As UInt64                    'XP
    Dim XPNeed As UInt64                'Need some XPs
    Dim HP As Integer                   'Health
    Dim HPM As Integer                  'Max Health
    Dim ATK As Integer                  'Attack
    Dim DEF As Integer                  'Defense
    Dim SE As UInteger                  'Star Energy
    Dim CRate As Double                 'Crit Rate
    Dim CDMG As Double                  'Crit Damage
    Dim Coins As Integer                'Coins
    Public Sub New()

    End Sub
    Public Sub New(S As Integer, e As Integer, cn As String, l As Integer, xp As UInt64, xpn As UInt64, hpm As Integer, hp As Integer, atk As Integer, def As Integer, se As UInteger, cr As Double, cd As Double, co As Integer)
        Me.Skin = S
        Me.Element = e
        Me.CName = cn
        Me.Level = l
        Me.XP = xp
        Me.XPNeed = xpn
        Me.HPM = hpm
        Me.HP = hp
        Me.ATK = atk
        Me.DEF = def
        Me.SE = se
        Me.CRate = cr
        Me.CDMG = cd
        Me.Coins = co
    End Sub
    Public Property Sk As Integer
        Get
            Return Skin
        End Get
        Set(value As Integer)
            Skin = value
        End Set
    End Property

    Public Property element1 As Integer
        Get
            Return Element
        End Get
        Set(value As Integer)
            Element = value
        End Set
    End Property

    Public Property CName1 As String
        Get
            Return CName
        End Get
        Set(value As String)
            CName = value
        End Set
    End Property

    Public Property Level1 As Integer
        Get
            Return Level
        End Get
        Set(value As Integer)
            Level = value
        End Set
    End Property

    Public Property XP1 As UInt64
        Get
            Return XP
        End Get
        Set(value As UInt64)
            XP = value
        End Set
    End Property

    Public Property XPNeed1 As UInt64
        Get
            Return XPNeed
        End Get
        Set(value As UInt64)
            XPNeed = value
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
    Public Property HP1 As Integer
        Get
            Return HP
        End Get
        Set(value As Integer)
            HP = value
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

    Public Property SE1 As UInteger
        Get
            Return SE
        End Get
        Set(value As UInteger)
            SE = value
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
    Public Property Coins1 As Double
        Get
            Return Coins
        End Get
        Set(value As Double)
            Coins = value
        End Set
    End Property

End Class
