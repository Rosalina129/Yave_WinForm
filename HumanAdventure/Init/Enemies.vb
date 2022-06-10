Public Class Enemies
    Public Shared randse As New Random
    Public Shared ReadOnly Enemy As InitEnemy() = {
        New InitEnemy(0, LangStr.s_enemy(0, MainForm.langID), 6, 6, 3, 0, 0.05, 0.5, 8, 5),
        New InitEnemy(0, LangStr.s_enemy(1, MainForm.langID), 25, 25, 7, 3, 0.1, 0.45, 7, 7),
        New InitEnemy(0, LangStr.s_enemy(2, MainForm.langID), 4, 4, 9, 0, 0.75, 0.32, 4, 2),
        New InitEnemy(0, LangStr.s_enemy(3, MainForm.langID), 8, 8, 2, 2, 0.05, 0.5, 8, 3),
        New InitEnemy(0, LangStr.s_enemy(4, MainForm.langID), 5, 5, 6, 1, 0.05, 0.5, 4, 2),
        New InitEnemy(1, LangStr.s_enemy(5, MainForm.langID), 49, 49, 21, 18, 0.45, 0.95, 28, 9),
        New InitEnemy(2, LangStr.s_enemy(6, MainForm.langID), 120, 120, 45, 10, 0.15, 0.9, 28, 9),
        New InitEnemy(3, LangStr.s_enemy(7, MainForm.langID), 80, 80, 13, 43, 0.1, 0.45, 28, 9),
        New InitEnemy(4, LangStr.s_enemy(8, MainForm.langID), 120, 120, 29, 16, 0.05, 0.5, 46, 23)，
        New InitEnemy(0, LangStr.s_enemy(9, MainForm.langID), 248, 248, 24, 36, 0.1, 0.45, 28, 20),
        New InitEnemy(0, LangStr.s_enemy(10, MainForm.langID), 135, 135, 41, 22, 0.7, 0.65, 78, 49),'5~19
        New InitEnemy(0, LangStr.s_enemy(11, MainForm.langID), 480, 480, 113, 96, 0.328, 0.946, 126, 96),
        New InitEnemy(1, LangStr.s_enemy(11, MainForm.langID), 626, 626, 124, 112, 0.05, 0.5, 139, 118)
    }
End Class
