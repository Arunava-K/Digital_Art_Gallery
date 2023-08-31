using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public Text songNameText;
    public AudioClip[] songs; // Add your audio clips here
    
    public int currentSongIndex = 0;
    public bool isPlaying = true;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        PlayCurrentSong();
        UpdateSongName();
    }

    public void PlayPause()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            audioSource.Play();
        }
        else
        {
            isPlaying = false;
            audioSource.Pause();
        }
    }

    public void Stop()
    {
        isPlaying = false;
        audioSource.Stop();
    }

    public void NextSong()
    {
        currentSongIndex = (currentSongIndex + 1) % songs.Length;
        PlayCurrentSong();
    }

    public void PreviousSong()
    {
        currentSongIndex = (currentSongIndex - 1 + songs.Length) % songs.Length;
        PlayCurrentSong();
    }

    private void PlayCurrentSong()
    {
        audioSource.Stop();
        audioSource.clip = songs[currentSongIndex];
        UpdateSongName();

        if (isPlaying)
        {
            audioSource.Play();
        }
    }

    private void UpdateSongName()
    {
        if (songNameText != null)
        {
            songNameText.text = songs[currentSongIndex].name;
        }
    }
}
