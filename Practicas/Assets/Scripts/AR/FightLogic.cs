using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightLogic : MonoBehaviour
{
    float player_life;
    float enemy_life;
    public float max_life= 100f;
    public Image player_bar;
    public Image enemy_bar;

    public GameObject pnlWin,pnlLose,HudPlayerAttack;

    // animator de personajes
    public Animator guerrero,mounstro;
    void Start()
    {
        player_life = max_life;
        enemy_life = max_life;
        pnlWin.SetActive(false);
        pnlLose.SetActive(false);

    }

    void Update()
    {
        UpdateUI();

    }

    void UpdateUI()
    {
        enemy_bar.fillAmount = (enemy_life/100f);
        player_bar.fillAmount = (player_life/100f);
    }

    public void damagePlayer()
    {
        float damage = Random.Range(1f,20f);
        if(player_life - damage<0)
        {
            player_life=0;
            pnlLose.SetActive(true);
            guerrero.SetBool("lose",true);
            mounstro.SetBool("win",true);
            showHudAttackDisable();

        }
        player_life-=damage;
    }


    public void damageEnemy()
    {
        float damage = Random.Range(1f,20f);
        if(enemy_life - damage<0)
        {
            enemy_life=0;
            pnlWin.SetActive(true);
            guerrero.SetBool("win",true);
            mounstro.SetBool("lose",true);
            showHudAttackDisable();

        }
        enemy_life-=damage;
    }

    public void attacklogic(string attack)
    {
        guerrero.SetTrigger(attack);
        mounstro.SetTrigger(attack);
        damagePlayer();
        damageEnemy();
    }

    public void restartLevel()
    {
        player_life = max_life;
        enemy_life = max_life;
        pnlWin.SetActive(false);
        pnlLose.SetActive(false);
        guerrero.SetBool("win",false);
        guerrero.SetBool("lose",false);
        mounstro.SetBool("win",false);
        mounstro.SetBool("lose",false);
        guerrero.Play("Idle");
        mounstro.Play("IDLE");
        UpdateUI();
    }


    public void showHudAttackActive()
    {
        HudPlayerAttack.SetActive(true);
    }

    public void showHudAttackDisable()
    {
        HudPlayerAttack.SetActive(false);
    }
}
