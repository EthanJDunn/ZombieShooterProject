using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    public Slider Eslider;

    public Gradient Egradient;

    public Image Efill;

    public void SetMaxHealth(int Ehealth)
    {
        Eslider.maxValue = Ehealth;
        Eslider.value = Ehealth;

        Efill.color = Egradient.Evaluate(1f);

    }

    public void SetHealth(int Ehealth)
    {
        Eslider.value = Ehealth;
        
        Efill.color = Egradient.Evaluate(Eslider.normalizedValue);
    }

}
