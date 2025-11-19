using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaMenu : MonoBehaviour
{
    [Header("Referencias UI")]
    public GameObject panelPausa; // Panel que contiene el menú de pausa

    private bool estaPausado = false;

    void Start()
    {
        ReanudarJuego(); // asegurar que arranque sin pausa
    }

    void Update()
    {
        // PC / Editor: tecla ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AlternarPausa();
        }
    }

    // ==== LÓGICA DE PAUSA ====

    public void AlternarPausa()
    {
        if (estaPausado)
            ReanudarJuego();
        else
            PausarJuego();
    }

    public void PausarJuego()
    {
        estaPausado = true;
        if (panelPausa != null)
            panelPausa.SetActive(true);

        Time.timeScale = 0f; // detiene el tiempo del juego
    }

    public void ReanudarJuego()
    {
        estaPausado = false;
        if (panelPausa != null)
            panelPausa.SetActive(false);

        Time.timeScale = 1f; // vuelve a la normalidad
    }

    // Opcional: botón para regresar al menú principal
    public void VolverAlMenu()
    {
        Time.timeScale = 1f; // por si estaba en pausa
        SceneManager.LoadScene("MainMenu");
    }
}
