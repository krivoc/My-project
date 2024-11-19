using UnityEngine;
using UnityEngine.UI;

public class geral : MonoBehaviour
{

    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public GameObject GameOver,personagemPrincipal, ferramenta;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;
    }

    public void MarcarPonto()

    {
        placarJogadorNum += 1;

        if (recordeNum < placarJogadorNum)
            recordeNum += 1;

        AtualizarTextodoPlacar();

        GetComponent<AudioSource>().Play();
    }

    public void AtualizarTextodoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados;" + placarJogadorNum;
        recordeTexto.text = "recorde atual:" + recordeNum;
    }

    public void IniciarPartida()
    {
        placarJogadorNum = 0;
        AtualizarTextodoPlacar();

                 
       
        GameOver.SetActive(false);

        personagemPrincipal.transform.position = new Vector3(875, 250, 0);

      
        ferramenta.GetComponent<ControladorFerramenta>().posicaoFerramenta = new Vector3(0, 0, 0);

        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoFerramenta = ferramenta.GetComponent<ControladorFerramenta>().deslocamentoInicial; 
    }
}
