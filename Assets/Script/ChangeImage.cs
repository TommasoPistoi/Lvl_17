using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour

{
    public int clicksToChange = 3; // Numero di clic necessari per cambiare lo sprite
    public Sprite[] sprites; // Array di sprite da ciclare
    public int initialSpriteIndex = 0; // Indice dello sprite iniziale
    private int currentSpriteIndex;
    private int clickCount = 0;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        if (image == null)
        {
            Debug.LogError("L'oggetto deve avere un componente Image.");
            enabled = false;
            return;
        }

        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogError("L'array di sprite è vuoto. Assegna degli sprite.");
            enabled = false;
            return;
        }

        currentSpriteIndex = initialSpriteIndex;
        UpdateSprite(); // Imposta lo sprite iniziale
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Click sinistro del mouse
        {
            clickCount++;
            if (clickCount >= clicksToChange)
            {
                ChangeSprite();
                clickCount = 0; // Resetta il contatore dei clic
            }
        }
    }

    void ChangeSprite()
    {
        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length; // Cicla tra gli sprite
        UpdateSprite();
    }

    void UpdateSprite()
    {
        image.sprite = sprites[currentSpriteIndex];
    }
}

