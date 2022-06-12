Public Class Enemies
    Public Shared randse As New Random
    Public Shared ReadOnly Enemy As InitEnemy() = {'0 Common 1 Ice 2 Fire 3 Water 4 Grass 5 Star 6 Metal 7 Electric 8 Shadow
        New InitEnemy(0, LangStr.s_enemy(0, MainForm.langID), 6, 6, 3, 0, 0.05, 0.5, 8, 5),
        New InitEnemy(0, LangStr.s_enemy(1, MainForm.langID), 25, 25, 7, 3, 0.1, 0.45, 7, 7),
        New InitEnemy(0, LangStr.s_enemy(2, MainForm.langID), 4, 4, 9, 0, 0.75, 0.32, 4, 2),
        New InitEnemy(0, LangStr.s_enemy(3, MainForm.langID), 8, 8, 2, 2, 0.05, 0.5, 8, 3),
        New InitEnemy(0, LangStr.s_enemy(4, MainForm.langID), 5, 5, 6, 1, 0.05, 0.5, 4, 2),'0~4 R1, 0~2
        New InitEnemy(1, LangStr.s_enemy(5, MainForm.langID), 49, 49, 21, 18, 0.45, 0.95, 28, 9),
        New InitEnemy(2, LangStr.s_enemy(6, MainForm.langID), 120, 120, 45, 10, 0.15, 0.9, 28, 9),
        New InitEnemy(3, LangStr.s_enemy(7, MainForm.langID), 80, 80, 13, 43, 0.1, 0.45, 28, 9),
        New InitEnemy(4, LangStr.s_enemy(8, MainForm.langID), 120, 120, 29, 16, 0.05, 0.5, 46, 23)，
        New InitEnemy(0, LangStr.s_enemy(9, MainForm.langID), 248, 248, 24, 36, 0.1, 0.45, 28, 20),
        New InitEnemy(0, LangStr.s_enemy(10, MainForm.langID), 135, 135, 41, 22, 0.7, 0.65, 78, 49),'5~19 R1, 2~10
        New InitEnemy(0, LangStr.s_enemy(11, MainForm.langID), 480, 480, 113, 96, 0.05, 0.5, 126, 96),
        New InitEnemy(1, LangStr.s_enemy(12, MainForm.langID), 626, 626, 124, 142, 0.25, 0.75, 139, 118),
        New InitEnemy(2, LangStr.s_enemy(12, MainForm.langID), 497, 497, 198, 108, 0.25, 0.75, 139, 118),
        New InitEnemy(3, LangStr.s_enemy(12, MainForm.langID), 1075, 1075, 135, 135, 0.25, 0.75, 139, 118),
        New InitEnemy(4, LangStr.s_enemy(12, MainForm.langID), 934, 934, 98, 109, 0.25, 0.75, 139, 118),
        New InitEnemy(1, LangStr.s_enemy(5, MainForm.langID), 626, 626, 124, 142, 0.25, 0.75, 139, 118),
        New InitEnemy(2, LangStr.s_enemy(6, MainForm.langID), 497, 497, 198, 108, 0.25, 0.75, 139, 118),
        New InitEnemy(3, LangStr.s_enemy(7, MainForm.langID), 1075, 1075, 135, 135, 0.25, 0.75, 139, 118),
        New InitEnemy(4, LangStr.s_enemy(8, MainForm.langID), 934, 934, 98, 109, 0.25, 0.75, 139, 118),
    }
End Class
