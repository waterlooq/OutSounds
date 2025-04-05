using UnityEngine;

public class SoundButtonManager : MonoBehaviour
{
    public AudioClip[] soundClips; // Assign your 6 audio clips here
    public GameObject audioSourcePrefab; // We'll use this to spawn sound layers

    public void PlaySound(int index)
    {
        if (index >= 0 && index < soundClips.Length)
        {
            // Create a temporary AudioSource object in the scene
            GameObject audioObj = Instantiate(audioSourcePrefab, transform);
            AudioSource source = audioObj.GetComponent<AudioSource>();
            source.clip = soundClips[index];
            source.Play();

            // Destroy the object after the clip finishes
            Destroy(audioObj, soundClips[index].length);
        }
    }
}
