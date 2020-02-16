using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text textoPontuacao;
    public PlayerController player;
    Vector3 posicaoInicial;
    public float divisorDaPontuacao;
    public GameObject painelGameOver;
    public GameObject painelVenceuJogo;
    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanciaPercorrida = player.transform.position - posicaoInicial;
        float pontuacao = distanciaPercorrida.z / divisorDaPontuacao;
        textoPontuacao.text = pontuacao.ToString("0");
    }

    public void GameOver()
    {
        painelGameOver.SetActive(true);
    }

    public void VencerJogo()
    {
        painelVenceuJogo.SetActive(true);
    }

    public void RecarregarLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
