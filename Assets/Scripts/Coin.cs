using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valor = 1;
    public GameCoins gameCoins;
    Animator anim;

    BoxCollider2D boxCollider;

    SFXManager sfxManager;

    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
    
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();

        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {}
    public void Get()
        {
            gameCoins.SumarPuntos(valor);
            anim.SetBool("IsGet", true);
            boxCollider.enabled = false;
            Destroy(this.gameObject, 0.1f);
            sfxManager.GetCoin();

        }
         
    
}
