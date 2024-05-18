using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Sprite[] diceSides; // Assurez-vous que les sprites sont attribu�s dans l'inspecteur
    private Image diceImage;

    void Start()
    {
        diceImage = GetComponent<Image>();
        RollDice(); // Pour initialiser avec une face de d� visible
    }

    public void RollDice()
    {
        int randomSide = Random.Range(0, diceSides.Length);
        diceImage.sprite = diceSides[randomSide];
    }
}
