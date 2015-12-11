using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBar : MonoBehaviour {
    Color32[] Colors;
    float Goodvalue = 3f;

    Image[] images;

    public void GoodSlider(float value)
    {
        Goodvalue = value;
    }

    void Awake()
    {
        Colors = new Color32[4];
        Colors[0] = new Color32(255, 255, 255, 255);
        Colors[1] = new Color32(255, 255, 0, 255);
    }

    void Update()
    {
            GoodSlider(this.GetComponent<Slider>().value); //Add this
            images = gameObject.GetComponentsInChildren<Image>();
            foreach (Image image in images)
            {
                if(Goodvalue < 100f)
                {
                    image.color = Colors[0];
                }
                if (Goodvalue == 100f)
                {
                    image.color = Colors[1];
                }
            }
     }
}
