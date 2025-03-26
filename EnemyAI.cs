// --- AI System ---
using UnityEngine;

/// <summary>
/// Класс <c>EnemyAI</c> управляет поведением врагов в игре Fallen Kingdom.
/// Он отвечает за отслеживание игрока и взаимодействие с ним в бою.
/// </summary>
public class EnemyAI : MonoBehaviour
{
    /// <summary>
    /// Ссылка на трансформ игрока, который будет отслеживаться врагом.
    /// </summary>
    public Transform player;

    /// <summary>
    /// Обновляет поведение врага каждый кадр.
    /// Этот метод отвечает за поворот врага в сторону игрока,
    /// что позволяет врагу следить за его движениями.
    /// </summary>
    void Update()
    {
        if (player != null)
        {
            // Поворачивает врага в сторону игрока
            transform.LookAt(player);
            Debug.Log("Enemy AI tracking player.");
        }
        else
        {
            Debug.LogWarning("Player transform is not assigned.");
        }
    }

    /// <summary>
    /// Реакция врага на действия игрока.
    /// Этот метод может быть расширен для реализации различных
    /// тактик поведения врага, таких как атака, уклонение или преследование.
    /// </summary>
    public void ReactToPlayerAction()
    {
        // Здесь можно добавить логику для реакции врага на действия игрока
        Debug.Log("Enemy reacting to player action.");
    }

    /// <summary>
    /// Устанавливает цель для врага.
    /// Этот метод позволяет динамически изменять цель врага,
    /// например, при смене позиции игрока или при появлении новых угроз.
    /// </summary>
    /// <param name="newTarget">Новая цель для отслеживания.</param>
    public void SetTarget(Transform newTarget)
    {
        player = newTarget;
        Debug.Log($"Enemy target set to: {player.name}");
    }
}
