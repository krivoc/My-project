using UnityEngine;
using UnityEngine.Jobs;

public class ControladorFerramenta : MonoBehaviour
{
    public Vector3 posicaoFerramenta;
    public float deslocamentoFerramenta;
    public float incrementoVelocidade;

    internal float deslocamentoInicial;
    internal int sentidoV; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        deslocamentoInicial = deslocamentoFerramenta;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoFerramenta.x +=  deslocamentoFerramenta * Time.deltaTime;
        posicaoFerramenta.y +=  deslocamentoFerramenta * Time.deltaTime * sentidoV;

        transform.position = posicaoFerramenta;


        // arrumar sentido vertical:
        if (transform.position.y >= 485 && sentidoV == 1)
            sentidoV = -1;

        if (transform.position.y <= 35 && sentidoV == -1)
            sentidoV = 1;

        deslocamentoFerramenta += incrementoVelocidade * Time.deltaTime;

    }
}
