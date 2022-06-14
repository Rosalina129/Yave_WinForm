Public Class Lang
    Public Shared Sub setstr(langid As Byte)
        'MainWindow Strings
        With MainForm
            .MenuToolStripMenuItem.Text = LangStr.s_string(0, langid)
            .HelpStripMenuItem.Text = LangStr.s_string(138, langid)
            .ShowDebugToolStripMenuItem.Text = LangStr.s_string(2, langid)
            .AboutToolStripMenuItem.Text = LangStr.s_string(3, langid)
            .NewSaveToolStripMenuItem.Text = LangStr.s_string(4, langid)
            .Button2.Text = LangStr.s_string(4, langid)
            .LoadDataToolStripMenuItem.Text = LangStr.s_string(5, langid)
            .Button1.Text = LangStr.s_string(5, langid)
            .SaveDataToolStripMenuItem.Text = LangStr.s_string(6, langid)
            .SaveAsToolStripMenuItem.Text = LangStr.s_string(7, langid)
            '.TextFormatToolStripMenuItem.Text = Strings.s_string(8, langid)
            '.JSONFormatToolStripMenuItem.Text = Strings.s_string(9, langid)
            .Help1ToolStripMenuItem.Text = LangStr.s_string(10, langid)
            .Help2ToolStripMenuItem.Text = LangStr.s_string(11, langid)
            .HealHPToolStripMenuItem.Text = LangStr.s_string(13, langid)
            .CPPToolStripMenuItem.Text = LangStr.s_string(14, langid)
            .AboutsToolStripMenuItem.Text = LangStr.s_string(15, langid)
            .FeedbackToolStripMenuItem.Text = LangStr.s_string(16, langid)
            .SetTourDistanceToolStripMenuItem.Text = LangStr.s_string(154, langid)

            .LabelLevel.Text = LangStr.s_string(33, langid)
            .TabControl1.TabPages(0).Text = LangStr.s_string(34, langid)
            .TabControl1.TabPages(1).Text = LangStr.s_string(35, langid)

            .Label1.Text = LangStr.s_string(26, langid)
            .Label3.Text = LangStr.s_string(27, langid)
            .Label5.Text = LangStr.s_string(28, langid)
            .Label2.Text = LangStr.s_string(29, langid)
            .Label7.Text = LangStr.s_string(30, langid)
            .Label4.Text = LangStr.s_string(31, langid)
            .Label6.Text = LangStr.s_string(32, langid)

            .Button8.Text = LangStr.s_string(28, langid)
            .Button9.Text = LangStr.s_string(107, langid)
            .Button10.Text = LangStr.s_string(108, langid)
            .Button11.Text = LangStr.s_string(109, langid)

            .Label26.Text = LangStr.s_string(27, langid)
            .Label27.Text = LangStr.s_string(28, langid)
            .Label29.Text = LangStr.s_string(29, langid)
            .Label28.Text = LangStr.s_string(31, langid)
            .Label30.Text = LangStr.s_string(32, langid)

            .GroupBox1.Text = LangStr.s_string(45, langid)
            .Button3.Text = LangStr.s_string(46, langid)
            .Label10.Text = LangStr.s_string(47, langid)
            .RadioButton1.Text = LangStr.s_string(48, langid)
            .RadioButton2.Text = LangStr.s_string(49, langid)
            .RadioButton3.Text = LangStr.s_string(50, langid)
            .RadioButton4.Text = LangStr.s_string(51, langid)
            .Label9.Text = LangStr.s_string(33, langid) & " 15 " & LangStr.s_string(72, langid)

            .AttributeToolTip.ToolTipTitle = LangStr.s_string(26, langid)
            .AttributeToolTip.SetToolTip(.HEALTHLabel, LangStr.s_string(74, langid))
            .AttributeToolTip.SetToolTip(.ATKLabel, LangStr.s_string(75, langid))
            .AttributeToolTip.SetToolTip(.DEFLabel, LangStr.s_string(76, langid))
            .AttributeToolTip.SetToolTip(.SELabel, LangStr.s_string(77, langid))
            .AttributeToolTip.SetToolTip(.CRLabel, LangStr.s_string(78, langid))
            .AttributeToolTip.SetToolTip(.CDLabel, LangStr.s_string(79, langid))

            .GroupBox2.Text = LangStr.s_string(89, langid)
            .TabControl2.TabPages(0).Text = LangStr.s_string(90, langid)
            .TabControl2.TabPages(1).Text = LangStr.s_string(91, langid)
            .TabControl2.TabPages(2).Text = LangStr.s_string(92, langid)
            .TabControl2.TabPages(3).Text = LangStr.s_string(1, langid)
            .TabControl2.TabPages(4).Text = LangStr.s_string(2, langid)

            .GroupBox5.Text = LangStr.s_string(35, langid)
            .CheckBox1.Text = LangStr.s_string(62, langid)
            .Label25.Text = LangStr.s_string(95, langid)

            .Label32.Text = LangStr.s_string(112, langid)
            .Label33.Text = LangStr.s_string(113, langid)
            .ComboBox1.Items(0) = LangStr.s_string(114, langid)
            .ComboBox1.Items(1) = LangStr.s_string(115, langid)
            .ComboBox2.Items(0) = LangStr.s_string(24, langid)
            .ComboBox2.Items(1) = LangStr.s_string(27, langid)
            .ComboBox2.Items(2) = LangStr.s_string(28, langid)
            .ComboBox2.Items(3) = LangStr.s_string(29, langid)
            .ComboBox2.Items(4) = LangStr.s_string(30, langid)
            .ComboBox2.Items(5) = LangStr.s_string(31, langid)
            .ComboBox2.Items(6) = LangStr.s_string(32, langid)
            .Label34.Text = LangStr.s_string(117, langid)
            .CheckBox2.Text = LangStr.s_string(118, langid)
            .Label35.Text = LangStr.s_string(119, langid)
            .RadioButton5.Text = LangStr.s_string(120, langid)
            .RadioButton6.Text = LangStr.s_string(121, langid)
            .Label36.Text = LangStr.s_string(122, langid)
            .ComboBox3.Items(0) = LangStr.s_string(123, langid)
            .ComboBox3.Items(1) = LangStr.s_string(124, langid)
            .ComboBox3.Items(2) = LangStr.s_string(142, langid)
            .Label37.Text = LangStr.s_string(125, langid)
            .TextBox3.Text = LangStr.s_string(126, langid)
            .Label11.Text = LangStr.s_string(127, langid)
            .GroupBox3.Text = LangStr.s_string(128, langid)
            .GroupBox4.Text = LangStr.s_string(129, langid)
            .Label13.Text = LangStr.s_string(27, langid)
            .Label14.Text = LangStr.s_string(28, langid)
            .Label15.Text = LangStr.s_string(29, langid)
            .Label23.Text = LangStr.s_string(130, langid)
            .Label22.Text = LangStr.s_string(131, langid)
            .Label21.Text = LangStr.s_string(132, langid)
            .Button5.Text = LangStr.s_string(133, langid)
            .Label17.Text = LangStr.s_string(27, langid)
            .Label16.Text = LangStr.s_string(28, langid)
            .Label12.Text = LangStr.s_string(29, langid)
            .Button6.Text = LangStr.s_string(138, langid)
        End With
        'NewSave Strings
        With NewSave
            .Label2.Text = LangStr.s_string(17, langid)
            .Label1.Text = LangStr.s_string(18, langid)
            .Label4.Text = LangStr.s_string(19, langid)
            .Label3.Text = LangStr.s_string(20, langid)
            .ListBox1.Items(0) = LangStr.s_string(24, langid)
            .ListBox1.Items(1) = LangStr.s_string(21, langid) & " 1"
            .ListBox1.Items(2) = LangStr.s_string(21, langid) & " 2"
            .ListBox1.Items(3) = LangStr.s_string(21, langid) & " 3"
            .ListBox1.Items(4) = LangStr.s_string(21, langid) & " 4"
            .ListBox1.Items(5) = LangStr.s_string(21, langid) & " 5"
            .ListBox1.Items(6) = LangStr.s_string(21, langid) & " 6"
            .Button1.Text = LangStr.s_string(25, langid)
            .Button2.Text = LangStr.s_string(22, langid)
            .Button3.Text = LangStr.s_string(25, langid)
            .Text = LangStr.s_string(23, langid)
        End With
        'ChangeName Strings
        With ChangeName
            .Text = LangStr.s_string(39, langid)
            .Label1.Text = LangStr.s_string(40, langid)
            .Button1.Text = LangStr.s_string(25, langid)
        End With
    End Sub
End Class