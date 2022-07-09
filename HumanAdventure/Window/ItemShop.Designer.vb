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
        Me.ArtifactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.attributeShopPanel = New System.Windows.Forms.Panel()
        Me.AttributeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.attributeShopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'coinCount
        '
        Me.coinCount.AutoSize = True
        Me.coinCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.coinCount.Location = New System.Drawing.Point(502, 109)
        Me.coinCount.Name = "coinCount"
        Me.coinCount.Size = New System.Drawing.Size(41, 15)
        Me.coinCount.TabIndex = 0
        Me.coinCount.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HumanAdventure.My.Resources.Resources.spr_coin_0
        Me.PictureBox1.Location = New System.Drawing.Point(480, 108)
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
        Me.TypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttributeToolStripMenuItem, Me.ArtifactToolStripMenuItem, Me.EquipmentsToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.MaterialToolStripMenuItem})
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(51, 21)
        Me.TypeToolStripMenuItem.Text = "Type:"
        '
        'ArtifactToolStripMenuItem
        '
        Me.ArtifactToolStripMenuItem.Name = "ArtifactToolStripMenuItem"
        Me.ArtifactToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArtifactToolStripMenuItem.Text = "Artifact"
        '
        'EquipmentsToolStripMenuItem
        '
        Me.EquipmentsToolStripMenuItem.Name = "EquipmentsToolStripMenuItem"
        Me.EquipmentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EquipmentsToolStripMenuItem.Text = "Equipment"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'attributeShopPanel
        '
        Me.attributeShopPanel.Controls.Add(Me.Button1)
        Me.attributeShopPanel.Location = New System.Drawing.Point(0, 28)
        Me.attributeShopPanel.Name = "attributeShopPanel"
        Me.attributeShopPanel.Size = New System.Drawing.Size(303, 267)
        Me.attributeShopPanel.TabIndex = 3
        '
        'AttributeToolStripMenuItem
        '
        Me.AttributeToolStripMenuItem.Checked = True
        Me.AttributeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AttributeToolStripMenuItem.Name = "AttributeToolStripMenuItem"
        Me.AttributeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AttributeToolStripMenuItem.Text = "Atrribute"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItemShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 379)
        Me.Controls.Add(Me.attributeShopPanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.coinCount)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ItemShop"
        Me.Text = "Item Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.attributeShopPanel.ResumeLayout(False)
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
    Friend WithEvents AttributeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents attributeShopPanel As Panel
    Friend WithEvents Button1 As Button
End Class
