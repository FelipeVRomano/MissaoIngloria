using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    [SerializeField]
    float timerRecoverDanoAumenta;
    [SerializeField]
    float timerRecoverDano;   
    [SerializeField]
    Image[] imgsVida;
    [SerializeField]
    private int numVidas;

    [SerializeField]
    float timer;
    [SerializeField]
    int dano;
    [SerializeField]
    bool tomouDano;
    public Image imageFade;
    public ControleInput inputVida;
    [SerializeField]
    private GameObject MenuPause;
    public bool morreuF;
    private AudioSettings audio1;

    public GameObject faleceu;
    private bool chamouFaleceu;

    

    // Start is called before the first frame update
    void Start()
    {
        timerRecoverDano = timerRecoverDanoAumenta;
        audio1 = GameObject.Find("AudioManager").GetComponent<AudioSettings>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dano == numVidas && chamouFaleceu == false)
        {
            StartCoroutine(Faleceu());
        }


        if(tomouDano)
        {
            timer += Time.deltaTime;
        }

        if(timer >= timerRecoverDano)
        {
            for(int i = 0; i <= dano; i++)
            {
                imgsVida[i].enabled = false;
            }
            tomouDano = false;
            dano = 0;
            timerRecoverDano = timerRecoverDanoAumenta;
            timer = 0;
        }
    }

    public IEnumerator Faleceu()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Derrota");

        chamouFaleceu = true;

        faleceu.SetActive(true);

        morreuF = true;
        audio1.MasterVolumeLevel(0f);
        inputVida.inputController.Player.Disable();
        inputVida.inputController.UI.Disable();

        yield return new WaitForSeconds(3);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        MenuPause.SetActive(true);


    }

    public void Morreu()
    {
        //  SceneManager.LoadScene(0);
        morreuF = true;
        audio1.MasterVolumeLevel(0f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        inputVida.inputController.Player.Disable();
        inputVida.inputController.UI.Disable();
        MenuPause.SetActive(true);
   //     Time.timeScale = 0f;
    }
    public void chama(int x)
    {
        StartCoroutine(Morte(x));
    }
    public IEnumerator Morte(int x)
    {
        imageFade.gameObject.SetActive(true);
        Color cor = imageFade.color;
        while (cor.a < 1f)
        {
            print("...");
            cor.a += Time.deltaTime;
            imageFade.color = cor;
            yield return null;
        }
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(x);
    }
    public void Dano()
    {
        dano++;
        timerRecoverDano += timerRecoverDanoAumenta / dano;
        imgsVida[dano].enabled = true;
        if(!tomouDano)
        tomouDano = true;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bullet"))
    //    {
    //        Dano();
    //    }
    //}

}
