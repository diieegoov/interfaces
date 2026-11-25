using UnityEngine;

public class Recorder : MonoBehaviour
{
    public AudioSource speakerLeft;
    public AudioSource speakerRight;

    private string microphoneName;
    private AudioClip microphoneClip;
    private bool recording = false;

    private void Start()
    {
        if (Microphone.devices.Length > 0)
        {
            microphoneName = Microphone.devices[0];

            Debug.Log("Micrófono: " + microphoneName);
        }
        else
        {
            Debug.LogWarning("No hay micrófonos disponibles");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartRecording();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            StopRecording();
        }

        // Esperar hasta que el micrófono capture audio
        if (recording && microphoneClip != null &&
            !speakerLeft.isPlaying &&
            Microphone.GetPosition(microphoneName) > 2048)
        {
            speakerLeft.Play();
            speakerRight.Play();
        }
    }

    private void StartRecording()
    {
        if (recording || string.IsNullOrEmpty(microphoneName))
            return;

        microphoneClip = Microphone.Start(
            microphoneName,
            true,
            10,
            44100
        );

        if (microphoneClip == null)
            return;

        speakerLeft.clip = microphoneClip;
        speakerRight.clip = microphoneClip;

        speakerLeft.loop = true;
        speakerRight.loop = true;

        recording = true;

        Debug.Log("Capturando audio del micrófono");
    }

    private void StopRecording()
    {
        if (!recording)
            return;

        recording = false;

        speakerLeft.Stop();
        speakerRight.Stop();

        Microphone.End(microphoneName);

        Debug.Log("Captura de audio detenida");
    }

    private void OnDisable()
    {
        StopRecording();
    }
}