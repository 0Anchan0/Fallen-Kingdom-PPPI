// --- Localization ---
using UnityEngine;
using System.Globalization;

/// <summary>
/// Класс <c>LocalizationManager</c> управляет локализацией в игре Fallen Kingdom.
/// Он отвечает за установку языка и культурных настроек для отображения текста.
/// </summary>
public class LocalizationManager : MonoBehaviour
{
    /// <summary>
    /// Устанавливает язык игры на основе кода языка.
    /// Этот метод изменяет текущую культуру приложения, что позволяет
    /// отображать текст на выбранном языке.
    /// </summary>
    /// <param name="langCode">Код языка, который нужно установить (например, "en", "ru").</param>
    public void SetLanguage(string langCode)
    {
        CultureInfo.CurrentCulture = new CultureInfo(langCode);
        Debug.Log($"Language set to {langCode}");
        // Здесь можно добавить логику для обновления текстов в интерфейсе
        // и других локализованных элементов игры
    }

    /// <summary>
    /// Получает текущий установленный язык.
    /// Этот метод может быть использован для проверки текущей локализации
    /// и отображения информации о языке в интерфейсе.
    /// </summary>
    /// <returns>Код текущего языка.</returns>
    public string GetCurrentLanguage()
    {
        return CultureInfo.CurrentCulture.Name;
    }
}
