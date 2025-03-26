// --- Graphics Manager ---
using UnityEngine;

/// <summary>
/// Класс <c>GraphicsManager</c> управляет графическими настройками и освещением в игре Fallen Kingdom.
/// Он отвечает за настройку визуальных эффектов и параметров сцены.
/// </summary>
public class GraphicsManager : MonoBehaviour
{
    /// <summary>
    /// Ссылка на источник света в сцене, который будет использоваться для освещения.
    /// </summary>
    public Light sceneLight;

    /// <summary>
    /// Инициализация графических настроек при старте игры.
    /// Этот метод вызывается один раз при запуске сцены и настраивает
    /// параметры освещения и другие графические эффекты.
    /// </summary>
    void Start()
    {
        SetupGraphics();
    }

    /// <summary>
    /// Настраивает графические параметры сцены.
    /// Устанавливает интенсивность света и применяет другие визуальные настройки,
    /// чтобы создать атмосферу, соответствующую мрачному фэнтезийному миру игры.
    /// </summary>
    void SetupGraphics()
    {
        if (sceneLight != null)
        {
            sceneLight.intensity = 1.0f; // Установка интенсивности света
            Debug.Log("Graphics settings applied.");
        }
        else
        {
            Debug.LogWarning("Scene light is not assigned.");
        }
    }
}
