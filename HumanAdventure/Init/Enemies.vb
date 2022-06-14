Public Class Enemies
    Public Shared ReadOnly Enemy As InitEnemy() = {'0 Common 1 Ice 2 Fire 3 Water 4 Grass 5 Star 6 Metal 7 Electric 8 Shadow
        New InitEnemy(0, LangStr.s_enemy(0, MainForm.langID), 6, 6, 3, 0, 0.05, 0.5, 22, 18),
        New InitEnemy(0, LangStr.s_enemy(1, MainForm.langID), 25, 25, 7, 3, 0.1, 0.45, 34, 19),
        New InitEnemy(0, LangStr.s_enemy(2, MainForm.langID), 4, 4, 9, 0, 0.75, 0.32, 32, 16),
        New InitEnemy(0, LangStr.s_enemy(3, MainForm.langID), 8, 8, 2, 2, 0.05, 0.5, 32, 18),
        New InitEnemy(0, LangStr.s_enemy(4, MainForm.langID), 5, 5, 6, 1, 0.05, 0.5, 28, 16),'0~4 R1, 0~2
        New InitEnemy(1, LangStr.s_enemy(5, MainForm.langID), 49, 49, 21, 18, 0.45, 0.95, 68, 49),
        New InitEnemy(2, LangStr.s_enemy(6, MainForm.langID), 120, 120, 45, 10, 0.15, 0.9, 68, 49),
        New InitEnemy(3, LangStr.s_enemy(7, MainForm.langID), 80, 80, 13, 43, 0.1, 0.45, 68, 49),
        New InitEnemy(4, LangStr.s_enemy(8, MainForm.langID), 120, 120, 29, 16, 0.05, 0.5, 86, 53)，
        New InitEnemy(0, LangStr.s_enemy(9, MainForm.langID), 248, 248, 24, 36, 0.1, 0.45, 68, 40),
        New InitEnemy(0, LangStr.s_enemy(10, MainForm.langID), 135, 135, 41, 22, 0.7, 0.65, 78, 49),'5~10 R1, 2~5
        New InitEnemy(0, LangStr.s_enemy(11, MainForm.langID), 480, 480, 113, 96, 0.05, 0.5, 126, 96),
        New InitEnemy(1, LangStr.s_enemy(12, MainForm.langID), 626, 626, 124, 142, 0.25, 0.75, 139, 118),
        New InitEnemy(2, LangStr.s_enemy(12, MainForm.langID), 497, 497, 198, 108, 0.25, 0.75, 139, 118),
        New InitEnemy(3, LangStr.s_enemy(12, MainForm.langID), 1075, 1075, 135, 135, 0.25, 0.75, 139, 118),
        New InitEnemy(4, LangStr.s_enemy(12, MainForm.langID), 934, 934, 98, 109, 0.25, 0.75, 139, 118),
<<<<<<< Updated upstream
        New InitEnemy(1, LangStr.s_enemy(5, MainForm.langID), 438, 438, 69, 82, 0.45, 0.5, 106, 75),
        New InitEnemy(2, LangStr.s_enemy(6, MainForm.langID), 512, 512, 113, 45, 0.05, 0.85, 106, 75),
        New InitEnemy(3, LangStr.s_enemy(7, MainForm.langID), 396, 396, 88, 36, 0.05, 0.5, 106, 75),
        New InitEnemy(4, LangStr.s_enemy(8, MainForm.langID), 407, 407, 78, 40, 0.05, 0.5, 106, 75)
=======
        New InitEnemy(1, LangStr.s_enemy(5, MainForm.langID), 626, 626, 124, 142, 0.25, 0.75, 139, 118),
        New InitEnemy(2, LangStr.s_enemy(6, MainForm.langID), 497, 497, 198, 108, 0.25, 0.75, 139, 118),
        New InitEnemy(3, LangStr.s_enemy(7, MainForm.langID), 1075, 1075, 135, 135, 0.25, 0.75, 139, 118),
        New InitEnemy(4, LangStr.s_enemy(8, MainForm.langID), 934, 934, 98, 109, 0.25, 0.75, 139, 118),
        New InitEnemy(7, LangStr.s_enemy(12, MainForm.langID), 786, 786, 102, 45, 0.25, 0.75, 206, 135),
        New InitEnemy(8, LangStr.s_enemy(12, MainForm.langID), 945, 945, 112, 29, 0.25, 0.75, 212, 135),'11~21 R1, 5~10
        New InitEnemy(0, LangStr.s_enemy(13, MainForm.langID), 2306, 2306, 165, 62, 0.485, 1.125, 563, 809),
        New InitEnemy(1, LangStr.s_enemy(13, MainForm.langID), 2780, 2780, 178, 106, 0.515, 0.825, 642, 960),
        New InitEnemy(2, LangStr.s_enemy(13, MainForm.langID), 1829, 1829, 165, 62, 0.15, 0.5, 690, 1075),
        New InitEnemy(3, LangStr.s_enemy(13, MainForm.langID), 3142, 3142, 132, 77, 0.05, 0.5, 690, 1075),
        New InitEnemy(4, LangStr.s_enemy(13, MainForm.langID), 2539, 2539, 174, 72, 0.05, 0.5, 583, 857),
        New InitEnemy(7, LangStr.s_enemy(13, MainForm.langID), 2510, 2510, 165, 62, 0.05, 0.5, 560, 906),
        New InitEnemy(8, LangStr.s_enemy(13, MainForm.langID), 2613, 2613, 165, 62, 0.05, 0.5, 592, 934),
        New InitEnemy(0, LangStr.s_enemy(14, MainForm.langID), 3980, 3980, 236, 150, 0.05, 0.5, 1108, 934),
        New InitEnemy(2, LangStr.s_enemy(14, MainForm.langID), 2613, 2613, 308, 138, 0.05, 0.5, 1332, 1065),
        New InitEnemy(3, LangStr.s_enemy(14, MainForm.langID), 4209, 4209, 234, 196, 0.05, 0.5, 1209, 1048),
        New InitEnemy(0, LangStr.s_enemy(15, MainForm.langID), 1064, 1064, 478, 102, 0.45, 0.85, 3146, 1142),
        New InitEnemy(0, LangStr.s_enemy(15, MainForm.langID), 2734, 2734, 478, 102, 0.45, 0.85, 3840, 1475)
>>>>>>> Stashed changes
    }
    Public Shared ReadOnly Boss_R1 As InitEnemy() = {'0 Common 1 Ice 2 Fire 3 Water 4 Grass 5 Star 6 Metal 7 Electric 8 Shadow
        New InitEnemy(7, LangStr.s_boss(0, MainForm.langID), 6000, 6000, 92, 40, 0.5, 1.5, 3200, 4000),'2km
        New InitEnemy(8, LangStr.s_boss(1, MainForm.langID), 36000, 36000, 450, 270, 0.5, 2.5, 9000, 16000),'10km
        New InitEnemy(1, LangStr.s_boss(2, MainForm.langID), 80000, 80000, 320, 215, 0.1, 1.5, 14000, 56000),'15km
        New InitEnemy(4, LangStr.s_boss(3, MainForm.langID), 245000, 245000, 2100, 425, 0.05, 0.5, 42000, 70000),'20km
        New InitEnemy(6, LangStr.s_boss(4, MainForm.langID), 60000, 60000, 1080, 80, 0.05, 0.5, 38000, 80000)'25km
        }
End Class
'New InitEnemy(0, LangStr.s_boss(5, MainForm.langID), 36000, 36000, 450, 270, 0.05, 0.5, 9000, 16000)