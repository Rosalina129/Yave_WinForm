Public Class Enemies
    Public Shared randse As New Random
    Public Shared ReadOnly Enemy As InitEnemy() = {'0 Common 1 Ice 2 Fire 3 Water 4 Grass 5 Star 6 Metal 7 Electric 8 Shadow
        New InitEnemy(0, s_enemy(0, MainForm.langID), 6, 6, 3, 0, 0.05, 0.5, 8, 5),
        New InitEnemy(0, s_enemy(1, MainForm.langID), 25, 25, 7, 3, 0.1, 0.45, 7, 7),
        New InitEnemy(0, s_enemy(2, MainForm.langID), 4, 4, 9, 0, 0.75, 0.32, 4, 2),
        New InitEnemy(0, s_enemy(3, MainForm.langID), 8, 8, 2, 2, 0.05, 0.5, 8, 3),
        New InitEnemy(0, s_enemy(4, MainForm.langID), 5, 5, 6, 1, 0.05, 0.5, 4, 2),'0~4 R1, 0~2
        New InitEnemy(1, s_enemy(5, MainForm.langID), 49, 49, 21, 18, 0.45, 0.95, 28, 9),
        New InitEnemy(2, s_enemy(6, MainForm.langID), 120, 120, 45, 10, 0.15, 0.9, 28, 9),
        New InitEnemy(3, s_enemy(7, MainForm.langID), 80, 80, 13, 43, 0.1, 0.45, 28, 9),
        New InitEnemy(4, s_enemy(8, MainForm.langID), 120, 120, 29, 16, 0.05, 0.5, 46, 23)，
        New InitEnemy(0, s_enemy(9, MainForm.langID), 248, 248, 24, 36, 0.1, 0.45, 28, 20),
        New InitEnemy(0, s_enemy(10, MainForm.langID), 135, 135, 41, 22, 0.7, 0.65, 78, 49),'5~10 R1, 2~10
        New InitEnemy(0, s_enemy(11, MainForm.langID), 480, 480, 113, 96, 0.05, 0.5, 126, 96),
        New InitEnemy(1, s_enemy(12, MainForm.langID), 626, 626, 124, 142, 0.25, 0.75, 139, 118),
        New InitEnemy(2, s_enemy(12, MainForm.langID), 497, 497, 198, 108, 0.25, 0.75, 139, 118),
        New InitEnemy(3, s_enemy(12, MainForm.langID), 1075, 1075, 135, 135, 0.25, 0.75, 139, 118),
        New InitEnemy(4, s_enemy(12, MainForm.langID), 934, 934, 98, 109, 0.25, 0.75, 139, 118),
        New InitEnemy(1, s_enemy(5, MainForm.langID), 626, 626, 124, 142, 0.25, 0.75, 139, 118),
        New InitEnemy(2, s_enemy(6, MainForm.langID), 497, 497, 198, 108, 0.25, 0.75, 139, 118),
        New InitEnemy(3, s_enemy(7, MainForm.langID), 1075, 1075, 135, 135, 0.25, 0.75, 139, 118),
        New InitEnemy(4, s_enemy(8, MainForm.langID), 934, 934, 98, 109, 0.25, 0.75, 139, 118),
        New InitEnemy(7, s_enemy(12, MainForm.langID), 786, 786, 102, 45, 0.25, 0.75, 206, 135),
        New InitEnemy(8, s_enemy(12, MainForm.langID), 945, 945, 112, 29, 0.25, 0.75, 212, 135),
        New InitEnemy(0, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809),
        New InitEnemy(1, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809),
        New InitEnemy(2, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809),
        New InitEnemy(3, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809),
        New InitEnemy(4, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809),
        New InitEnemy(7, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809),
        New InitEnemy(8, s_enemy(13, MainForm.langID), 2306, 2306, 165, 102, 0.485, 1.125, 563, 809)
    }
    Public Shared ReadOnly Boss_R1 As InitEnemy() = {'0 Common 1 Ice 2 Fire 3 Water 4 Grass 5 Star 6 Metal 7 Electric 8 Shadow
        New InitEnemy(7, s_boss(0, MainForm.langID), 6000, 6000, 62, 40, 0.5, 1.5, 3200, 4000),'2km
        New InitEnemy(8, s_boss(1, MainForm.langID), 36000, 36000, 168, 198, 0.5, 2.5, 9000, 16000),'10km
        New InitEnemy(1, s_boss(2, MainForm.langID), 80000, 80000, 290, 215, 0.1, 1.5, 14000, 56000),'20km
        New InitEnemy(4, s_boss(3, MainForm.langID), 95000, 95000, 320, 405, 0.05, 0.5, 42000, 70000),'40km
        New InitEnemy(6, s_boss(4, MainForm.langID), 176500, 176500, 1080, 480, 0.05, 0.5, 38000, 80000),'50km
        New InitEnemy(7, s_boss(4, MainForm.langID), 37125, 37125, 450, 80, 0.5, 1.35, 96000, 140000),'75km
        New InitEnemy(0, s_boss(4, MainForm.langID), 89600, 89600, 696, 124, 0.25, 0.95, 158000, 320000),'90km
        New InitEnemy(4, s_boss(4, MainForm.langID), 792617, 792617, 932, 0, 0.85, 1, 0, 0)'100km
        }
End Class
