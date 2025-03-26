// --- UI Manager ---
using UnityEngine;

/// <summary>
/// Класс <c>UIManager</c> управляет пользовательским интерфейсом в игре Fallen Kingdom.
/// Он отвечает за отображение главного меню и меню настроек, а также за переключение между ними.
/// </summary>
public class UIManager : MonoBehaviour
{
    /// <summary>
    /// Ссылка на объект главного меню.
    /// </summary>
    public GameObject mainMenu;

    /// <summary>
    /// Ссылка на объект меню настроек.
    /// </summary>
    public GameObject settingsMenu;

    /// <summary>
    /// Отображает главное меню и скрывает меню настроек.
    /// Этот метод может быть вызван, когда игрок начинает новую игру или возвращается в главное меню.
    /// </summary>
    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
        Debug.Log("Main menu displayed.");
    }

    /// <summary>
    /// Отображает меню настроек и скрывает главное меню.
    /// Этот метод может быть вызван, когда игрок выбирает опцию настроек из главного меню.
    /// </summary>
    public void ShowSettingsMenu()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
        Debug.Log("Settings menu displayed.");
    }
}
