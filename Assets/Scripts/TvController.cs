using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using TMPro;

public class TvController : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoClip[] canales = new VideoClip[5];
    private string[] nombresCanales = {"Nickelodeon","Teleamazonas","Barça TV","Tc","Ecuavisa"};
    public VideoClip disney;
    public VideoClip tv;
    public VideoClip tc;
    public VideoClip ecuavisa;
    public VideoClip hbo;
    public VideoClip netflix;
    public VideoClip spotify;
    public GameObject planePlayer;
    public VideoPlayer playervideo;
    public TextMeshProUGUI canal;
    private int canalActual;
    public GameObject controlCanal;

    public GameObject salida;
    public GameObject menuAjustes;
    public GameObject menuGuia;
    public GameObject menuMas;
    
    void Start()
    {
        controlCanal.SetActive(false);
        canalActual = 0;
        playervideo = planePlayer.GetComponent(typeof(VideoPlayer)) as VideoPlayer;
    }

    public void disneyPlayed(){
        controlCanal.SetActive(false);
        hidePaneles();
        playervideo.clip = disney;
        playervideo.Play();
    }

    public void hboPlayed(){
        controlCanal.SetActive(false);
        hidePaneles();
        playervideo.clip = hbo;
        playervideo.Play();
    }

    public void netflixPlayed(){
        controlCanal.SetActive(false);
        hidePaneles();
        playervideo.clip = netflix;
        playervideo.Play();
    }

    public void spotiFyPlayed(){
        controlCanal.SetActive(false);
        hidePaneles();
        playervideo.clip = spotify;
        playervideo.Play();
    }

    public void tvPlayed(){
        controlCanal.SetActive(true);
        hidePaneles();
        playervideo.clip = canales[canalActual];
        canal.text = nombresCanales[canalActual];
        playervideo.Play();
    }
    public void chanelUP(){
        if(canalActual<4){
            canalActual++;
            hidePaneles();
            playervideo.clip = canales[canalActual];
            canal.text = nombresCanales[canalActual];
            playervideo.Play();
        }
        
    }

    public void chanelDown(){
        if(canalActual>0){
            canalActual--;
            hidePaneles();
            playervideo.clip = canales[canalActual];
            canal.text = nombresCanales[canalActual];
            playervideo.Play();
        }
    }
    public void hidePaneles(){
        menuAjustes.SetActive(false);
        menuMas.SetActive(false);
        menuGuia.SetActive(false);
        salida.SetActive(false);
    }
}
