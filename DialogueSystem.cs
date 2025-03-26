// --- Narrative System ---
using UnityEngine;

/// <summary>
/// Класс <c>DialogueSystem</c> управляет системой диалогов в игре Fallen Kingdom.
/// Он отвечает за начало диалогов с NPC и взаимодействие игрока с нарративом.
/// </summary>
public class DialogueSystem : MonoBehaviour
{
    /// <summary>
    /// Запускает диалог с NPC.
    /// Этот метод может быть вызван, когда игрок взаимодействует с NPC,
    /// инициируя обмен репликами и развитие сюжета.
    /// </summary>
    public void StartDialogue()
    {
        Debug.Log("Dialogue started.");
        // Здесь можно добавить логику для отображения текста диалога
        // и управления взаимодействием с NPC
    }

    /// <summary>
    /// Завершает текущий диалог.
    /// Этот метод может быть вызван, когда игрок завершает разговор с NPC,
    /// позволяя продолжить игру или перейти к другим действиям.
    /// </summary>
    public void EndDialogue()
    {
        Debug.Log("Dialogue ended.");
        // Здесь можно добавить логику для завершения диалога
        // и возврата к игровому процессу
    }

    /// <summary>
    /// Отображает текст диалога на экране.
    /// Этот метод может быть использован для отображения реплик NPC
    /// и выбора игрока в процессе диалога.
    /// </summary>
    /// <param name="dialogueText">Текст, который нужно отобразить.</param>
    public void DisplayDialogue(string dialogueText)
    {
        Debug.Log($"Dialogue: {dialogueText}");
        // Здесь можно добавить логику для отображения текста на экране
    }
}
