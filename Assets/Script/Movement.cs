using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidadInicial;
    public float posicionX;
    public float aceleracion;
    public float tiempo;
    private float distanciaVisual; 
    private float posicionInicial;
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        posicionX = -0f;
        posicionInicial = posicionX;
        CalcularDistanciaVisual();
    }

    void Update()
    {
        tiempo += Time.deltaTime;
        MRUV();

        if (posicionX >= 16.97f)
        {
            posicionX = posicionInicial;
            tiempo = 0;
        }
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(new Vector2(posicionX, rb2D.position.y));
    }

    void MRUV()
    {
        posicionX = (velocidadInicial * tiempo) + (0.5f * aceleracion * Mathf.Pow(tiempo, 2));
    }

    void CalcularDistanciaVisual()
    {
        distanciaVisual = (velocidadInicial * tiempo) + (0.5f * aceleracion * Mathf.Pow(tiempo, 2));
    }

    public void SetInputAceleracion(string dato)
    {
        aceleracion = float.Parse(dato);
        CalcularDistanciaVisual();
    }

    public void SetInputTiempo(string dato)
    {
        tiempo = float.Parse(dato);
        CalcularDistanciaVisual();
    }

    public void SetInputVelocidadInicial(string dato)
    {
        velocidadInicial = float.Parse(dato);
        CalcularDistanciaVisual();
    }

    public float GetDistanciaVisual()
    {
        return distanciaVisual;
    }
}
