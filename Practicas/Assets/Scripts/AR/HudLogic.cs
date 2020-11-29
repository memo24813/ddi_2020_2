using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudLogic : MonoBehaviour
{
    public GameObject HudEnemy;
    public GameObject HudPlayer;
    public GameObject HudPlayerAttack;

    public GameObject PlayerTarget;
    public GameObject EnemyTarget;

    private void Awake() {
        HudEnemy.SetActive(false);
        HudPlayer.SetActive(false);
        HudPlayerAttack.SetActive(false);    
    }
    public void showHudEnemy(bool status)
    {
        HudEnemy.SetActive(status);
    }

    public void showHudPlayer(bool status)
    {
        HudPlayer.SetActive(status);
    }

    public void showPlayerTarget(bool status)
    {
        PlayerTarget.SetActive(status);
    }

    public void showEnemyTarget(bool status)
    {
        EnemyTarget.SetActive(status);
    }
    public void showHudAttack()
    {
        if(HudEnemy.activeSelf && HudPlayer.activeSelf)
        {
            HudPlayerAttack.SetActive(true);
        }
        else
        {
            HudPlayerAttack.SetActive(false);
        }
    }

    void showHudAttackActive()
    {
        HudPlayerAttack.SetActive(true);
    }

    void showHudAttackDisable()
    {
        HudPlayerAttack.SetActive(false);
    }

}
