﻿Public Class Lang
    Public Shared Sub setstr(langid As Byte)
        Try
            'MainWindow Strings
            With MainForm
                .MenuToolStripMenuItem.Text = s_string(0, langid)
                .HelpStripMenuItem.Text = s_string(138, langid)
                .ShowDebugToolStripMenuItem.Text = s_string(2, langid)
                .AboutToolStripMenuItem.Text = s_string(3, langid)
                .NewSaveToolStripMenuItem.Text = s_string(4, langid)
                .Button2.Text = s_string(4, langid)
                .Button1.Text = s_string(5, langid)
                .LoadDataToolStripMenuItem.Text = s_string(5, langid)
                .SaveDataToolStripMenuItem.Text = s_string(6, langid)
                .SaveAsToolStripMenuItem.Text = s_string(7, langid)
                '.TextFormatToolStripMenuItem.Text = Strings.s_string(8, langid)
                '.JSONFormatToolStripMenuItem.Text = Strings.s_string(9, langid)
                .Help1ToolStripMenuItem.Text = s_string(10, langid)
                .Help2ToolStripMenuItem.Text = s_string(11, langid)
                .HealHPToolStripMenuItem.Text = s_string(13, langid)
                .CPPToolStripMenuItem.Text = s_string(14, langid)
                .AboutsToolStripMenuItem.Text = s_string(15, langid)
                .FeedbackToolStripMenuItem.Text = s_string(16, langid)

                .LabelLevel.Text = s_string(33, langid)
                .TabControl1.TabPages(0).Text = s_string(34, langid)
                .TabControl1.TabPages(1).Text = s_string(35, langid)

                .Label1.Text = s_string(26, langid)
                .Label3.Text = s_string(27, langid)
                .Label5.Text = s_string(28, langid)
                .Label2.Text = s_string(29, langid)
                .Label7.Text = s_string(30, langid)
                .Label4.Text = s_string(31, langid)
                .Label6.Text = s_string(32, langid)

                .BattleAttackButton.Text = s_string(28, langid)
                .BattleEleButton.Text = s_string(107, langid)
                .BattleBlockButton.Text = s_string(108, langid)
                .BattleRunButton.Text = s_string(109, langid)

                .Label26.Text = s_string(27, langid)
                .Label27.Text = s_string(28, langid)
                .Label29.Text = s_string(29, langid)
                .Label28.Text = s_string(31, langid)
                .Label30.Text = s_string(32, langid)

                .GroupBox1.Text = s_string(45, langid)
                .Button3.Text = s_string(46, langid)
                .RegionButton1.Text = s_string(48, langid)
                .RegionButton2.Text = s_string(49, langid)
                .RegionButton3.Text = s_string(50, langid)
                .RegionButton4.Text = s_string(51, langid)
                .RegionButton5.Text = s_string(52, langid)
                .RegionButton6.Text = s_string(53, langid)
                .RegionButton7.Text = s_string(54, langid)
                .RegionButton8.Text = s_string(55, langid)

                .AttributeToolTip.ToolTipTitle = s_string(26, langid)
                .AttributeToolTip.SetToolTip(.HEALTHLabel, s_string(74, langid))
                .AttributeToolTip.SetToolTip(.ATKLabel, s_string(75, langid))
                .AttributeToolTip.SetToolTip(.DEFLabel, s_string(76, langid))
                .AttributeToolTip.SetToolTip(.SELabel, s_string(77, langid))
                .AttributeToolTip.SetToolTip(.CRLabel, s_string(78, langid))
                .AttributeToolTip.SetToolTip(.CDLabel, s_string(79, langid))

                .GroupBox2.Text = s_string(89, langid)
                .TabControl2.TabPages(0).Text = s_string(90, langid)
                .TabControl2.TabPages(1).Text = s_string(91, langid)
                .TabControl2.TabPages(2).Text = s_string(159, langid)
                .TabControl2.TabPages(3).Text = s_string(92, langid)
                .TabControl2.TabPages(4).Text = s_string(1, langid)

                .GroupBox5.Text = s_string(35, langid)
                .AutoSaveCheckBox.Text = s_string(62, langid)
                .Label25.Text = s_string(95, langid)

                .Label32.Text = s_string(112, langid)
                .Label33.Text = s_string(113, langid)
                .ComboBox1.Items(0) = s_string(114, langid)
                .ComboBox1.Items(1) = s_string(115, langid)
                .ComboBox2.Items(0) = s_string(24, langid)
                .ComboBox2.Items(1) = s_string(27, langid)
                .ComboBox2.Items(2) = s_string(28, langid)
                .ComboBox2.Items(3) = s_string(29, langid)
                .ComboBox2.Items(4) = s_string(30, langid)
                .ComboBox2.Items(5) = s_string(31, langid)
                .ComboBox2.Items(6) = s_string(32, langid)
                .Label34.Text = s_string(117, langid)
                .CheckBox2.Text = s_string(118, langid)
                .Label35.Text = s_string(119, langid)
                .RadioButton5.Text = s_string(120, langid)
                .RadioButton6.Text = s_string(121, langid)
                .Label36.Text = s_string(122, langid)
                .ComboBox3.Items(0) = s_string(123, langid)
                .ComboBox3.Items(1) = s_string(124, langid)
                .ComboBox3.Items(2) = s_string(142, langid)
                .Label37.Text = s_string(125, langid)
                .TextBox3.Text = s_string(126, langid)
                .Button6.Text = s_string(138, langid)

                .Label38.Text = s_string(2, langid)
                .Label39.Text = s_string(153, langid)
                .Button12.Text = s_string(111, langid)
                .Label40.Text = s_string(156, langid) & ": x / 100 (m)"

                .TabControl3.TabPages(0).Text = s_string(160, langid)
                .TabControl3.TabPages(1).Text = s_string(170, langid)
                .TabControl3.TabPages(2).Text = s_string(171, langid)

                .useitem1.Text = s_item(1, langid)
                .useitem2.Text = s_item(2, langid)
                .useitem3.Text = s_item(3, langid)
                .useitem4.Text = s_item(4, langid)
                .useitem5.Text = s_item(5, langid)
                .useitem6.Text = s_item(6, langid)
                .useitem7.Text = s_item(7, langid)
                .useitem8.Text = s_item(8, langid)

                .Label42.Text = s_string(175, langid)
                .Label43.Text = s_string(177, langid)
                .Label44.Text = s_string(178, langid)
                .Label45.Text = s_string(179, langid)

                .Label51.Text = s_string(175, langid)
                .Label52.Text = s_string(176, langid)
                .Label53.Text = s_string(177, langid)
                .Label54.Text = s_string(180, langid)

                .Label55.Text = s_string(181, langid)
                .ListBox1.Items(0) = s_string(182, langid)
                .ListBox1.Items(1) = s_string(48, langid)
                .ListBox1.Items(2) = s_string(49, langid)
                .ListBox1.Items(3) = s_string(50, langid)
                .ListBox1.Items(4) = s_string(51, langid)
                .ListBox1.Items(5) = s_string(52, langid)
                .ListBox1.Items(6) = s_string(53, langid)
                .ListBox1.Items(7) = s_string(54, langid)
                .ListBox1.Items(8) = s_string(55, langid)

                .useitem1using.Text = "+100 XP"
                .useitem2using.Text = "+400 XP"
                .useitem3using.Text = "+1,500 XP"
                .useitem4using.Text = "+50 " & s_string(27, langid)
                .useitem5using.Text = "+400" & s_string(27, langid)
                .useitem6using.Text = "+10% Max " & s_string(27, langid)
                .useitem7using.Text = "+19% Max " & s_string(27, langid)
                .useitem8using.Text = "+35% Max " & s_string(27, langid)

                .Label11.Text = s_string(184, langid)

                .Item1Sell.Text = s_string(193, langid)
                .Item2Sell.Text = s_string(193, langid)
                .Item3Sell.Text = s_string(193, langid)
                .Item4Sell.Text = s_string(193, langid)
                .Item5Sell.Text = s_string(193, langid)
                .Item6Sell.Text = s_string(193, langid)
                .Item7Sell.Text = s_string(193, langid)
            End With
            'NewSave Strings
            With NewSave
                .Label2.Text = s_string(17, langid)
                .Label1.Text = s_string(18, langid)
                .Label4.Text = s_string(19, langid)
                .Label3.Text = s_string(20, langid)
                .ListBox1.Items(0) = s_string(24, langid)
                .ListBox1.Items(1) = s_string(21, langid) & " 1"
                .ListBox1.Items(2) = s_string(21, langid) & " 2"
                .ListBox1.Items(3) = s_string(21, langid) & " 3"
                .ListBox1.Items(4) = s_string(21, langid) & " 4"
                .ListBox1.Items(5) = s_string(21, langid) & " 5"
                .ListBox1.Items(6) = s_string(21, langid) & " 6"
                .Button1.Text = s_string(25, langid)
                .Button2.Text = s_string(22, langid)
                .Button3.Text = s_string(25, langid)
                .Text = s_string(23, langid)
                .Button4.Text = s_string(138, langid)
                .Label6.Text = s_string(195, langid)
                .Label7.Text = s_string(196, langid)
                .DifficultySelect.Items(0) = s_string(197, langid)
                .DifficultySelect.Items(1) = s_string(198, langid)
                .DifficultySelect.Items(2) = s_string(199, langid)
                .DifficultySelect.Items(3) = s_string(200, langid)
                .DifficultySelect.Items(4) = s_string(201, langid)
                .DifficultySelect.Items(5) = s_string(202, langid)
            End With
            'ChangeName Strings
            With ChangeName
                .Text = s_string(39, langid)
            End With
            'a
            With EleDescribe
                .Text = s_string(158, langid)
            End With
            With OldSaveDiff
                .Text = s_string(205, langid)
                .Title1.Text = s_string(203, langid)
                .Title2.Text = s_string(204, langid)
                .HelpButton.Text = s_string(138, langid)
                .Button1.Text = s_string(22, langid)
                .DifficultySelect.Items(0) = s_string(197, langid)
                .DifficultySelect.Items(1) = s_string(198, langid)
                .DifficultySelect.Items(2) = s_string(199, langid)
                .DifficultySelect.Items(3) = s_string(200, langid)
                .DifficultySelect.Items(4) = s_string(201, langid)
                .DifficultySelect.Items(5) = s_string(202, langid)
            End With
        Catch ex As StackOverflowException
            MainForm.ErrorOccurred()
        End Try
    End Sub
End Class