using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    public PlayerCharacterGood stats;

    [Header("UI Elements")]
    public Slider healthBar;
    public Slider xpBar;
    public TMP_Text levelText;
    //public TMP_Text statsText;


    // Update is called once per frame
    void Update()
    {
        // Santé
        healthBar.maxValue = stats.MaxHealth;
        healthBar.value = stats.CurrentHealth;

        // XP
        xpBar.maxValue = stats.XPToNextlevel;
        xpBar.value = stats.CurrentXP;

        // Texte du niveau
        levelText.text = $"Niveau : {stats.Level}";

        // Stats
        //statsText.text = $"Force : {stats.Force}";
    }
}
