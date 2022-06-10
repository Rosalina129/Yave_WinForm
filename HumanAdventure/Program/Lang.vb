Public Class Lang
    Public Shared Sub setstr(langid As Byte)
        'MainWindow Strings
        With MainWindow
            .MenuToolStripMenuItem.Text = Strings.s_string(0, langid)
            .ViewToolStripMenuItem.Text = Strings.s_string(1, langid)
            .ShowDebugToolStripMenuItem.Text = Strings.s_string(2, langid)
            .AboutToolStripMenuItem.Text = Strings.s_string(3, langid)
            .NewSaveToolStripMenuItem.Text = Strings.s_string(4, langid)
            .Button2.Text = Strings.s_string(4, langid)
            .LoadDataToolStripMenuItem.Text = Strings.s_string(5, langid)
            .Button1.Text = Strings.s_string(5, langid)
            .SaveDataToolStripMenuItem.Text = Strings.s_string(6, langid)
            .SaveAsToolStripMenuItem.Text = Strings.s_string(7, langid)
            '.TextFormatToolStripMenuItem.Text = Strings.s_string(8, langid)
            '.JSONFormatToolStripMenuItem.Text = Strings.s_string(9, langid)
            .ItemListToolStripMenuItem.Text = Strings.s_string(10, langid)
            '.SettingsToolStripMenuItem.Text = Strings.s_string(12, langid)
            .HealHPToolStripMenuItem.Text = Strings.s_string(13, langid)
            .CPPToolStripMenuItem.Text = Strings.s_string(14, langid)
            .AboutsToolStripMenuItem.Text = Strings.s_string(15, langid)
            .FeedbackToolStripMenuItem.Text = Strings.s_string(16, langid)

            .LabelLevel.Text = Strings.s_string(33, langid)
            .TabControl1.TabPages(0).Text = Strings.s_string(34, langid)
            .TabControl1.TabPages(1).Text = Strings.s_string(35, langid)

            .Label1.Text = Strings.s_string(26, langid)
            .Label3.Text = Strings.s_string(27, langid)
            .Label5.Text = Strings.s_string(28, langid)
            .Label2.Text = Strings.s_string(29, langid)
            .Label7.Text = Strings.s_string(30, langid)
            .Label4.Text = Strings.s_string(31, langid)
            .Label6.Text = Strings.s_string(32, langid)

            .Button8.Text = Strings.s_string(28, langid)
            .Button9.Text = Strings.s_string(107, langid)
            .Button10.Text = Strings.s_string(108, langid)
            .Button11.Text = Strings.s_string(109, langid)

            .Label26.Text = Strings.s_string(27, langid)
            .Label27.Text = Strings.s_string(28, langid)
            .Label29.Text = Strings.s_string(29, langid)
            .Label28.Text = Strings.s_string(31, langid)
            .Label30.Text = Strings.s_string(32, langid)

            .GroupBox1.Text = Strings.s_string(45, langid)
            .Button3.Text = Strings.s_string(46, langid)
            .Label10.Text = Strings.s_string(47, langid)
            .RadioButton1.Text = Strings.s_string(48, langid)
            .RadioButton2.Text = Strings.s_string(49, langid)
            .RadioButton3.Text = Strings.s_string(50, langid)
            .RadioButton4.Text = Strings.s_string(51, langid)
            .Label9.Text = Strings.s_string(33, langid) & " 15 " & Strings.s_string(72, langid)

            .AttributeToolTip.ToolTipTitle = Strings.s_string(26, langid)
            .AttributeToolTip.SetToolTip(.HEALTHLabel, Strings.s_string(74, langid))
            .AttributeToolTip.SetToolTip(.ATKLabel, Strings.s_string(75, langid))
            .AttributeToolTip.SetToolTip(.DEFLabel, Strings.s_string(76, langid))
            .AttributeToolTip.SetToolTip(.SELabel, Strings.s_string(77, langid))
            .AttributeToolTip.SetToolTip(.CRLabel, Strings.s_string(78, langid))
            .AttributeToolTip.SetToolTip(.CDLabel, Strings.s_string(79, langid))

            .GroupBox2.Text = Strings.s_string(89, langid)
            .TabControl2.TabPages(0).Text = Strings.s_string(90, langid)
            .TabControl2.TabPages(1).Text = Strings.s_string(91, langid)
            .TabControl2.TabPages(2).Text = Strings.s_string(92, langid)
            .TabControl2.TabPages(3).Text = Strings.s_string(1, langid)
            .TabControl2.TabPages(4).Text = Strings.s_string(2, langid)

            .GroupBox5.Text = Strings.s_string(35, langid)
            .CheckBox1.Text = Strings.s_string(62, langid)
            .Label25.Text = Strings.s_string(95, langid)

            .Label32.Text = Strings.s_string(112, langid)
            .Label33.Text = Strings.s_string(113, langid)
            .ComboBox1.Items(0) = Strings.s_string(114, langid)
            .ComboBox1.Items(1) = Strings.s_string(115, langid)
            .ComboBox2.Items(0) = Strings.s_string(24, langid)
            .ComboBox2.Items(1) = Strings.s_string(27, langid)
            .ComboBox2.Items(2) = Strings.s_string(28, langid)
            .ComboBox2.Items(3) = Strings.s_string(29, langid)
            .ComboBox2.Items(4) = Strings.s_string(30, langid)
            .ComboBox2.Items(5) = Strings.s_string(31, langid)
            .ComboBox2.Items(6) = Strings.s_string(32, langid)
            .Label34.Text = Strings.s_string(117, langid)
            .CheckBox2.Text = Strings.s_string(118, langid)
            .Label35.Text = Strings.s_string(119, langid)
            .RadioButton5.Text = Strings.s_string(120, langid)
            .RadioButton6.Text = Strings.s_string(121, langid)
            .Label36.Text = Strings.s_string(122, langid)
            .ComboBox3.Items(0) = Strings.s_string(123, langid)
            .ComboBox3.Items(1) = Strings.s_string(124, langid)
            .Label37.Text = Strings.s_string(125, langid)
            .TextBox3.Text = Strings.s_string(126, langid)
            .Label11.Text = Strings.s_string(127, langid)
            .GroupBox3.Text = Strings.s_string(128, langid)
            .GroupBox4.Text = Strings.s_string(129, langid)
            .Label13.Text = Strings.s_string(27, langid)
            .Label14.Text = Strings.s_string(28, langid)
            .Label15.Text = Strings.s_string(29, langid)
            .Label23.Text = Strings.s_string(130, langid)
            .Label22.Text = Strings.s_string(131, langid)
            .Label21.Text = Strings.s_string(132, langid)
            .Button5.Text = Strings.s_string(133, langid)
            .Label17.Text = Strings.s_string(27, langid)
            .Label16.Text = Strings.s_string(28, langid)
            .Label12.Text = Strings.s_string(29, langid)
        End With
        'NewSave Strings
        With NewSave
            .Label2.Text = Strings.s_string(17, langid)
            .Label1.Text = Strings.s_string(18, langid)
            .Label4.Text = Strings.s_string(19, langid)
            .Label3.Text = Strings.s_string(20, langid)
            .ListBox1.Items(0) = Strings.s_string(24, langid)
            .ListBox1.Items(1) = Strings.s_string(21, langid) & " 1"
            .ListBox1.Items(2) = Strings.s_string(21, langid) & " 2"
            .ListBox1.Items(3) = Strings.s_string(21, langid) & " 3"
            .ListBox1.Items(4) = Strings.s_string(21, langid) & " 4"
            .ListBox1.Items(5) = Strings.s_string(21, langid) & " 5"
            .ListBox1.Items(6) = Strings.s_string(21, langid) & " 6"
            .Button1.Text = Strings.s_string(25, langid)
            .Button2.Text = Strings.s_string(22, langid)
            .Button3.Text = Strings.s_string(25, langid)
            .Text = Strings.s_string(23, langid)
        End With
        'ChangeName Strings
        With ChangeName
            .Text = Strings.s_string(39, langid)
            .Label1.Text = Strings.s_string(40, langid)
            .Button1.Text = Strings.s_string(25, langid)
        End With
    End Sub
End Class