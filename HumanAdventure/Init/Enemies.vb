Public Class Enemies
    Public Shared ReadOnly Enemy As InitEnemy() = {
        New InitEnemy(0, "Slime", 6, 6, 3, 0, 0.05, 0.5, 8, 5),
        New InitEnemy(0, "Zombie", 25, 25, 7, 3, 0.1, 0.45, 16, 7),
        New InitEnemy(1, "Ice Slime", 8, 8, 5, 1, 0.05, 0.5, 14, 6),
        New InitEnemy(2, "Fire Slime", 8, 8, 5, 1, 0.05, 0.5, 14, 6)
    }
End Class
