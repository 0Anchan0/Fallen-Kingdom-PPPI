// --- Sound Manager ---
using UnityEngine;

/// <summary>
/// Класс <c>SoundManager</c> управляет звуковыми эффектами и фоновым музыкальным сопровождением в игре Fallen Kingdom.
/// Он отвечает за воспроизведение музыки и звуковых эффектов, создавая атмосферу игры.
/// </summary>
public class SoundManager : MonoBehaviour
{
    /// <summary>
    /// Ссылка на компонент AudioSource, используемый для воспроизведения фоновой музыки.
    /// </summary>
    public AudioSource backgroundMusic;

    /// <summary>
    /// Инициализация звукового менеджера при старте игры.
    /// Этот метод вызывается один раз при запуске сцены и начинает воспроизведение фоновой музыки.
    /// </summary>
    void Start()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.Play();
            Debug.Log("Background music started playing.");
        }
        else
        {
            Debug.LogWarning("Background music AudioSource is not assigned.");
        }
    }

    /// <summary>
    /// Останавливает воспроизведение фоновой музыки.
    /// Этот метод может быть вызван, когда игрок покидает сцену или при переходе на другой уровень.
    /// </summary>
    public void StopBackgroundMusic()
    {
        if (backgroundMusic.isPlaying)
        {
            backgroundMusic.Stop();
            Debug.Log("Background music stopped.");
        }
    }

    /// <summary>
    /// Устанавливает громкость фоновой музыки.
    /// Этот метод позволяет изменять громкость музыки в зависимости от настроек игрока.
    /// </summary>
    /// <param name="volume">Новое значение громкости (от 0.0 до 1.0).</param>
    public void SetVolume(float volume)
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.volume = Mathf.Clamp(volume, 0.0f, 1.0f);
            Debug.Log($"Background music volume set to: {backgroundMusic.volume}");
        }
    }
}
