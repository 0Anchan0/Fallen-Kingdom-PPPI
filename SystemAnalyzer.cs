using UnityEngine;

/// <summary>
/// Класс <c>SystemAnalyzer</c> анализирует аппаратные характеристики системы игрока
/// и настраивает графические параметры игры в зависимости от доступных ресурсов.
/// Это позволяет оптимизировать производительность и качество графики для различных устройств.
/// </summary>
public class SystemAnalyzer : MonoBehaviour
{
    /// <summary>
    /// Инициализация анализа системы при старте игры.
    /// Этот метод вызывается один раз при запуске сцены и применяет настройки
    /// в зависимости от характеристик аппаратного обеспечения.
    /// </summary>
    void Start()
    {
        ApplySettingsBasedOnHardware();
    }

    /// <summary>
    /// Применяет настройки графики на основе характеристик аппаратного обеспечения.
    /// Этот метод анализирует объем оперативной и видеопамяти, а также название графического процессора,
    /// и устанавливает уровень качества графики в зависимости от доступных ресурсов.
    /// </summary>
    void ApplySettingsBasedOnHardware()
    {
        int ram = SystemInfo.systemMemorySize; // Объем оперативной памяти в МБ
        int vram = SystemInfo.graphicsMemorySize; // Объем видеопамяти в МБ
        string gpu = SystemInfo.graphicsDeviceName; // Название графического процессора

        Debug.Log($"Detected GPU: {gpu}, VRAM: {vram} MB, RAM: {ram} MB");

        // Установка уровня качества графики в зависимости от объема видеопамяти
        if (vram > 8000)
        {
            QualitySettings.SetQualityLevel(5); // Ultra
            Debug.Log("Quality set to Ultra.");
        }
        else if (vram > 4000)
        {
            QualitySettings.SetQualityLevel(4); // High
            Debug.Log("Quality set to High.");
        }
        else if (vram > 2000)
        {
            QualitySettings.SetQualityLevel(3); // Medium
            Debug.Log("Quality set to Medium.");
        }
        else
        {
            QualitySettings.SetQualityLevel(2); // Low
            Debug.Log("Quality set to Low.");
        }
    }
}
