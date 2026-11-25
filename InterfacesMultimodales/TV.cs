using UnityEngine;
using System.IO;

public class TV : MonoBehaviour
{
    public Renderer screen;

    private WebCamTexture webcam;
    private Texture originalTexture;

    private void Start()
    {
        originalTexture = screen.material.mainTexture;

        WebCamDevice[] cameras = WebCamTexture.devices;

        if (cameras.Length == 0)
        {
            Debug.LogWarning("No hay cámaras disponibles");
            return;
        }

        // Seleccionar la primera cámara disponible
        webcam = new WebCamTexture(
            cameras[0].name,
            1280,
            720,
            30
        );

        // Apartado 4: mostrar nombre de la cámara
        Debug.Log("Nombre de la cámara: " + cameras[0].name);
    }

    private void Update()
    {
        // Apartado 3: iniciar cámara
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCamera();
        }

        // Apartado 3: detener cámara
        if (Input.GetKeyDown(KeyCode.P))
        {
            StopCamera();
        }

        // Apartado 5: capturar imagen
        if (Input.GetKeyDown(KeyCode.X))
        {
            CaptureImage();
        }
    }

    private void StartCamera()
    {
        if (webcam == null || webcam.isPlaying)
            return;

        screen.material.mainTexture = webcam;

        webcam.Play();

        Debug.Log("Cámara iniciada");
    }

    private void StopCamera()
    {
        if (webcam == null)
            return;

        webcam.Stop();

        screen.material.mainTexture = originalTexture;

        Debug.Log("Cámara detenida");
    }

    private void CaptureImage()
    {
        if (webcam == null || !webcam.isPlaying ||
            webcam.width <= 16)
        {
            Debug.LogWarning("La cámara no está preparada");
            return;
        }

        Texture2D image = new Texture2D(
            webcam.width,
            webcam.height,
            TextureFormat.RGB24,
            false
        );

        image.SetPixels32(webcam.GetPixels32());
        image.Apply();

        byte[] png = image.EncodeToPNG();

        string filename = "Captura_" +
            System.DateTime.Now.ToString("yyyyMMdd_HHmmss_fff") +
            ".png";

        string path = Path.Combine(
            Application.persistentDataPath,
            filename
        );

        File.WriteAllBytes(path, png);

        Destroy(image);

        Debug.Log("Imagen guardada en: " + path);
    }

    private void OnDisable()
    {
        if (webcam != null)
            webcam.Stop();
    }
}