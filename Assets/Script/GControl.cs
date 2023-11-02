using UnityEngine;
using TMPro;

public class GControl : MonoBehaviour
{
    [SerializeField] Movement player1;
    [SerializeField] Movement player2;
    [SerializeField] TMP_Text textPlayer1;
    [SerializeField] TMP_Text textPlayer2;

    void Update()
    {
        textPlayer1.text = "X = " + player1.GetDistanciaVisual().ToString("F2");
        textPlayer2.text = "X = " + player2.GetDistanciaVisual().ToString("F2");

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetearJugadores();
        }
    }

    void ResetearJugadores()
    {
        player1.tiempo = 0;
        player2.tiempo = 0;
    }
}
