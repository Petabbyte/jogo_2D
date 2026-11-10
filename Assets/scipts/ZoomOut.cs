
using UnityEngine;
using System.Collections;

public class CameraOpening : MonoBehaviour
{
    [Header("Configurações da câmera")]
    public float tamanhoInicial = 2f;
    public float tamanhoFinal = 7f;
    public float duracao = 3f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();

        // Começa com a visão fechada
        cam.orthographicSize = tamanhoInicial;

        // Inicia a abertura da câmera
        StartCoroutine(AbrirCamera());
    }

    IEnumerator AbrirCamera()
    {
        float tempo = 0f;

        while (tempo < duracao)
        {
            tempo += Time.deltaTime;

            float progresso = Mathf.Clamp01(tempo / duracao);

            // Suaviza a abertura
            float suavizacao = Mathf.SmoothStep(0f, 1f, progresso);

            cam.orthographicSize = Mathf.Lerp(
                tamanhoInicial,
                tamanhoFinal,
                suavizacao
            );

            yield return null;
        }

        cam.orthographicSize = tamanhoFinal;
    }
}

