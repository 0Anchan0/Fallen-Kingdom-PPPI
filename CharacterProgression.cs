// --- Character Progression ---
using UnityEngine;

/// <summary>
/// Класс <c>CharacterProgression</c> управляет прогрессией персонажа в игре Fallen Kingdom.
/// Он отвечает за атрибуты персонажа, такие как сила и ловкость, и предоставляет методы для их изменения.
/// </summary>
public class CharacterProgression : MonoBehaviour
{
    /// <summary>
    /// Сила персонажа, влияющая на физическую мощь и урон в ближнем бою.
    /// </summary>
    public int strength = 10;

    /// <summary>
    /// Ловкость персонажа, влияющая на скорость передвижения и уклонение от атак.
    /// </summary>
    public int agility = 10;

    /// <summary>
    /// Увеличивает атрибуты персонажа при повышении уровня.
    /// Каждый раз, когда вызывается этот метод, сила и ловкость увеличиваются на 2,
    /// что отражает прогрессию персонажа в хардкорной RPG.
    /// </summary>
    public void LevelUp()
    {
        strength += 2;
        agility += 2;
        Debug.Log($"New stats - Strength: {strength}, Agility: {agility}");
    }

    /// <summary>
    /// Устанавливает значение силы персонажа.
    /// Используется для настройки параметров персонажа в зависимости от выбранного билда или класса.
    /// </summary>
    /// <param name="newStrength">Новое значение силы.</param>
    public void SetStrength(int newStrength)
    {
        strength = newStrength;
        Debug.Log($"Strength set to: {strength}");
    }

    /// <summary>
    /// Устанавливает значение ловкости персонажа.
    /// Позволяет адаптировать персонажа к различным стилям игры и тактикам.
    /// </summary>
    /// <param name="newAgility">Новое значение ловкости.</param>
    public void SetAgility(int newAgility)
    {
        agility = newAgility;
        Debug.Log($"Agility set to: {agility}");
    }

    /// <summary>
    /// Возвращает текущие атрибуты персонажа в виде строки.
    /// Используется для отображения информации о состоянии персонажа в интерфейсе игры.
    /// </summary>
    /// <returns>Строка с текущими значениями силы и ловкости.</returns>
    public string GetStats()
    {
        return $"Current stats - Strength: {strength}, Agility: {agility}";
    }

    /// <summary>
    /// Увеличивает силу персонажа на заданное количество.
    /// Это может быть полезно при использовании предметов или навыков, которые временно увеличивают силу.
    /// </summary>
    /// <param name="amount">Количество, на которое нужно увеличить силу.</param>
    public void IncreaseStrength(int amount)
    {
        strength += amount;
        Debug.Log($"Strength increased by {amount}. New strength: {strength}");
    }

    /// <summary>
    /// Увеличивает ловкость персонажа на заданное количество.
    /// Это может быть полезно для адаптации персонажа к различным ситуациям в бою.
    /// </summary>
    /// <param name="amount">Количество, на которое нужно увеличить ловкость.</param>
    public void IncreaseAgility(int amount)
    {
        agility += amount;
        Debug.Log($"Agility increased by {amount}. New agility: {agility}");
    }
}
