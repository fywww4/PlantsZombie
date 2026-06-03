using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMenu : MonoBehaviour
{
    public Image sunImage;
    public Text sunScoreText;

    public Button[] plantButtons;

    public BuildInfo[] plants;

    public static BuildInfo cur;

    void Start()
    {
        for (int i = 0; i < plants.Length; i++)
        {
            int index = i;

            plantButtons[i].image.sprite = Sprite.Create((Texture2D)plants[i].previewImage,
                new Rect(0.0f, 0.0f, plants[i].previewImage.width, plants[i].previewImage.height),
                new Vector2(0.5f, 0.5f));

            plantButtons[i].GetComponentInChildren<Text>().text = plants[i].price.ToString();
            plantButtons[i].onClick.AddListener(() => OnPlantButtonClicked(index));

        }
    }

    void Update()
    {
        sunScoreText.text = SunCollect.scoure.ToString();

        for (int i = 0; i < plants.Length;i++)
        {
            plantButtons[i].interactable = SunCollect.scoure >= plants[i].price;
        }
    }

    void OnPlantButtonClicked(int index)
    {
        cur = plants[index];
    }
}
