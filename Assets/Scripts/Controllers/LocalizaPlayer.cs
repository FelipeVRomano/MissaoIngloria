using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizaPlayer : MonoBehaviour
{
    public string salaAtual;
    public string[] salasDisponiveias;
    public List<GameObject> posDestino;
    public Transform imagePlayer;
    public Image imageMap;
    [SerializeField]
    private Sprite[] spriteMaps;
    public bool liberouMapa;
    public int andar;
    public GameObject[] andares;
    private string andarName;
    public List<string> instanciaInimigos;
    [SerializeField]
    private GameManager gm;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mapa"))
        {
          salaAtual = other.gameObject.name;   
           for(int i = 0; i < instanciaInimigos.Count; i++)
            {
                if(instanciaInimigos[i] == salaAtual)
                {
                    print("hihihihih");
                    gm.TirosCabeca(i);
                }
            }
        }
    }

    public void AtualizaMapa()
    {
        for(int i = 0; i < salasDisponiveias.Length; i++)
        {
            if (salaAtual == salasDisponiveias[i])
            {
                if (liberouMapa)
                {
                    foreach (GameObject objct in andares)
                    {
                        objct.SetActive(false);
                    }
                    posDestino[i].transform.parent.gameObject.SetActive(true);
                    andarName = posDestino[i].transform.parent.gameObject.name;
                    for(int l = 0; l < andares.Length; l++)
                    {
                        if (andarName == andares[l].name)
                            imageMap.sprite = spriteMaps[l];
                    }
                    imagePlayer.position = posDestino[i].transform.position;
                    imagePlayer.parent = posDestino[i].transform;
                }
            }
        }
    }

    public void trocAndar(int x)
    {
        if(liberouMapa)
        {
            imageMap.sprite = spriteMaps[x];
            foreach(GameObject objct in andares)
            {
                objct.SetActive(false);
            }
            andares[x].SetActive(true);
        }
    }
}
