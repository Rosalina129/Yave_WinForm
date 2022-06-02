<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upgrade
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvl = New System.Windows.Forms.Label()
        Me.mh = New System.Windows.Forms.Label()
        Me.atk = New System.Windows.Forms.Label()
        Me.def = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.defafter = New System.Windows.Forms.Label()
        Me.atkafter = New System.Windows.Forms.Label()
        Me.mhafter = New System.Windows.Forms.Label()
        Me.lvlafter = New System.Windows.Forms.Label()
        Me.RandomLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 163)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upgrade"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Upgrade Attributes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Max Health"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Attack"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(13, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Defense"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(13, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Level"
        '
        'lvl
        '
        Me.lvl.AutoSize = True
        Me.lvl.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lvl.Location = New System.Drawing.Point(116, 51)
        Me.lvl.Name = "lvl"
        Me.lvl.Size = New System.Drawing.Size(58, 30)
        Me.lvl.TabIndex = 6
        Me.lvl.Text = "level"
        '
        'mh
        '
        Me.mh.AutoSize = True
        Me.mh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mh.Location = New System.Drawing.Point(117, 93)
        Me.mh.Name = "mh"
        Me.mh.Size = New System.Drawing.Size(82, 21)
        Me.mh.TabIndex = 7
        Me.mh.Text = "maxhealth"
        '
        'atk
        '
        Me.atk.AutoSize = True
        Me.atk.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.atk.Location = New System.Drawing.Point(117, 114)
        Me.atk.Name = "atk"
        Me.atk.Size = New System.Drawing.Size(31, 21)
        Me.atk.TabIndex = 8
        Me.atk.Text = "atk"
        '
        'def
        '
        Me.def.AutoSize = True
        Me.def.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.def.Location = New System.Drawing.Point(117, 135)
        Me.def.Name = "def"
        Me.def.Size = New System.Drawing.Size(32, 21)
        Me.def.TabIndex = 9
        Me.def.Text = "def"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.Label10.Location = New System.Drawing.Point(234, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 59)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "→"
        '
        'defafter
        '
        Me.defafter.AutoSize = True
        Me.defafter.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.defafter.Location = New System.Drawing.Point(287, 135)
        Me.defafter.Name = "defafter"
        Me.defafter.Size = New System.Drawing.Size(64, 21)
        Me.defafter.TabIndex = 13
        Me.defafter.Text = "defafter"
        '
        'atkafter
        '
        Me.atkafter.AutoSize = True
        Me.atkafter.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.atkafter.Location = New System.Drawing.Point(287, 114)
        Me.atkafter.Name = "atkafter"
        Me.atkafter.Size = New System.Drawing.Size(63, 21)
        Me.atkafter.TabIndex = 12
        Me.atkafter.Text = "atkafter"
        '
        'mhafter
        '
        Me.mhafter.AutoSize = True
        Me.mhafter.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mhafter.Location = New System.Drawing.Point(287, 93)
        Me.mhafter.Name = "mhafter"
        Me.mhafter.Size = New System.Drawing.Size(114, 21)
        Me.mhafter.TabIndex = 11
        Me.mhafter.Text = "maxhealthafter"
        '
        'lvlafter
        '
        Me.lvlafter.AutoSize = True
        Me.lvlafter.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lvlafter.Location = New System.Drawing.Point(286, 51)
        Me.lvlafter.Name = "lvlafter"
        Me.lvlafter.Size = New System.Drawing.Size(103, 30)
        Me.lvlafter.TabIndex = 14
        Me.lvlafter.Text = "levelafter"
        '
        'RandomLabel
        '
        Me.RandomLabel.AutoSize = True
        Me.RandomLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RandomLabel.Location = New System.Drawing.Point(13, 188)
        Me.RandomLabel.Name = "RandomLabel"
        Me.RandomLabel.Size = New System.Drawing.Size(56, 21)
        Me.RandomLabel.TabIndex = 15
        Me.RandomLabel.Text = "Label6"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Upgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 222)
        Me.Controls.Add(Me.RandomLabel)
        Me.Controls.Add(Me.lvlafter)
        Me.Controls.Add(Me.defafter)
        Me.Controls.Add(Me.atkafter)
        Me.Controls.Add(Me.mhafter)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.def)
        Me.Controls.Add(Me.atk)
        Me.Controls.Add(Me.mh)
        Me.Controls.Add(Me.lvl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Upgrade"
        Me.ShowIcon = False
        Me.Text = "Upgrade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lvl As Label
    Friend WithEvents mh As Label
    Friend WithEvents atk As Label
    Friend WithEvents def As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents defafter As Label
    Friend WithEvents atkafter As Label
    Friend WithEvents mhafter As Label
    Friend WithEvents lvlafter As Label
    Friend WithEvents RandomLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
