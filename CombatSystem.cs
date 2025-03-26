// --- Combat System ---
using UnityEngine;

/// <summary>
/// Класс <c>CombatSystem</c> управляет механикой боя в игре Fallen Kingdom.
/// Он отвечает за здоровье игрока и обработку получаемого урона.
/// </summary>
public class CombatSystem : MonoBehaviour
{
    /// <summary>
    /// Текущее здоровье игрока. Начальное значение составляет 100.
    /// Здоровье влияет на выживаемость игрока в боях с врагами и боссами.
    /// </summary>
    public int playerHealth = 100;

    /// <summary>
    /// Обрабатывает получение урона игроком.
    /// Уменьшает текущее здоровье игрока на величину урона.
    /// Если здоровье игрока падает до нуля, игрок считается павшим.
    /// </summary>
    /// <param name="damage">Количество урона, получаемого игроком.</param>
    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        Debug.Log($"Player Health: {playerHealth}");

        // Проверка на падение игрока
        if (playerHealth <= 0)
        {
            PlayerDefeated();
        }
    }

    /// <summary>
    /// Вызывается, когда здоровье игрока достигает нуля.
    /// Здесь можно реализовать логику, связанную с поражением игрока,
    /// например, перезапуск уровня или отображение экрана "Game Over".
    /// </summary>
    private void PlayerDefeated()
    {
        Debug.Log("Player has been defeated!");
        // Здесь можно добавить логику для обработки поражения игрока
    }

    /// <summary>
    /// Восстанавливает здоровье игрока на заданное количество.
    /// Используется для лечения игрока с помощью предметов или навыков.
    /// </summary>
    /// <param name="amount">Количество здоровья, которое нужно восстановить.</param>
    public void Heal(int amount)
    {
        playerHealth += amount;
        Debug.Log($"Player Health after healing: {playerHealth}");
    }
}
