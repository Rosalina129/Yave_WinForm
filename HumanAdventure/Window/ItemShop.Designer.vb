<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemShop
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.coinCount = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtifactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'coinCount
        '
        Me.coinCount.AutoSize = True
        Me.coinCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.coinCount.Location = New System.Drawing.Point(111, 86)
        Me.coinCount.Name = "coinCount"
        Me.coinCount.Size = New System.Drawing.Size(41, 15)
        Me.coinCount.TabIndex = 0
        Me.coinCount.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HumanAdventure.My.Resources.Resources.spr_coin_0
        Me.PictureBox1.Location = New System.Drawing.Point(89, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TypeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TypeToolStripMenuItem
        '
        Me.TypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtifactToolStripMenuItem, Me.EquipmentsToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.MaterialToolStripMenuItem})
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(51, 21)
        Me.TypeToolStripMenuItem.Text = "Type:"
        '
        'EquipmentsToolStripMenuItem
        '
        Me.EquipmentsToolStripMenuItem.Name = "EquipmentsToolStripMenuItem"
        Me.EquipmentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EquipmentsToolStripMenuItem.Text = "Equipment"
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'ArtifactToolStripMenuItem
        '
        Me.ArtifactToolStripMenuItem.Name = "ArtifactToolStripMenuItem"
        Me.ArtifactToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArtifactToolStripMenuItem.Text = "Artifact"
        '
        'ItemShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 379)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.coinCount)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ItemShop"
        Me.Text = "ItemShop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents coinCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtifactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialToolStripMenuItem As ToolStripMenuItem
End Class
