using UnityEngine;
using UnityEngine.Jobs;

public class controladorjogador : MonoBehaviour
{
    public float velocidadeMaozinha;
    public geral JuizDoJogo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // este codigo e para fazer maozinha subir
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 485)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position += novaPos;
        }

        // este codigo e para fazer a maozinha descer
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= 35)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position -= novaPos;
        }

      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("Ferramenta"))
        {
            float posicaoY = Random.value * 485;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.x = 0;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.y = posicaoY;

            JuizDoJogo.MarcarPonto(); 
        }
    }


}