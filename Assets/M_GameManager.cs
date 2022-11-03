using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M_GameManager : MonoBehaviour
{

    public Button[] Btn_Items;
    public GameObject[] Items;
    public Transform[] BackPackItems;

    public Button[] Btn_ItemMessage;
    public GameObject ItemMessagePanel;
    private void Awake()
    {
        //点击该按钮  在背包最近的一个空位添加物体1
        Btn_Items[0].onClick.AddListener(() =>
        {
        for (int i = 0; i < BackPackItems.Length; i++)
        {
            if (BackPackItems[i].transform.childCount == 1)//先判断出最近的一个空框，transform.childCount 获取子物体数量
                {
                GameObject item0 = Instantiate(Items[0], BackPackItems[i].transform); //给该框添加该物体
                item0.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;//改变RectTransform的pos
                break;
            }
            else if (BackPackItems[i].transform.childCount > 1 && BackPackItems[i].GetChild(1).name.Equals("Item1(Clone)") && int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) < 5)
            {
                BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text = (int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) + 1).ToString();
                break;
            }
        }
        });

        //点击该按钮  在背包最近的一个空位添加物体2
        Btn_Items[1].onClick.AddListener(() =>
        {
            for (int i = 0; i < BackPackItems.Length; i++)
            {
                if (BackPackItems[i].transform.childCount == 1)
                {
                    GameObject item1 = Instantiate(Items[1], BackPackItems[i].transform);
                    item1.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                    break;
                }
                else if (BackPackItems[i].transform.childCount > 1 && BackPackItems[i].GetChild(1).name.Equals("Item2(Clone)") && int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) < 5)
                {
                    BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text = (int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) + 1).ToString();
                    break;
                }
            }
        });

        //点击该按钮  在背包最近的一个空位添加物体3

        Btn_Items[2].onClick.AddListener(() =>
        {
            for (int i = 0; i < BackPackItems.Length; i++)
            {
                if (BackPackItems[i].transform.childCount == 1)
                {
                    GameObject item2 = Instantiate(Items[2], BackPackItems[i].transform);
                    item2.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                    break;
                }
                else if (BackPackItems[i].transform.childCount > 1 && BackPackItems[i].GetChild(1).name.Equals("Item3(Clone)") && int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) < 5)
                {
                    BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text = (int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) + 1).ToString();
                    break;
                }
            }
            });
        //点击背包物品按钮显示对应信息
        Btn_ItemMessage[0].onClick.AddListener(() =>
        {
            ItemBtnClickEvent(BackPackItems[0]);
        });
        //点击背包物品按钮显示对应信息
        Btn_ItemMessage[1].onClick.AddListener(() =>
        {
            ItemBtnClickEvent(BackPackItems[1]);
        });
        //点击背包物品按钮显示对应信息
        Btn_ItemMessage[2].onClick.AddListener(() =>
        {
            ItemBtnClickEvent(BackPackItems[2]);
        });

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
/// <summary>
/// 物品栏点击展示信息  根据名字来区别点击的物体是哪个  然后显示对应的信息
/// </summary>
/// <param name="itemParent"></param>
public void ItemBtnClickEvent(Transform itemParent)
{
    if (itemParent.childCount == 1) return;
    switch (itemParent.GetChild(1).name)
    {
        case "Item1(Clone)":
            ItemMessagePanel.transform.GetChild(2).GetComponent<Text>().text = "这是一把钻石镰刀。" +
                "（可用于收割小麦）";
            break;
        case "Item2(Clone)":
            ItemMessagePanel.transform.GetChild(2).GetComponent<Text>().text = "这是一把钻石斧头。（可用于劈砍树木）";
            break;
        case "Item3(Clone)":
            ItemMessagePanel.transform.GetChild(2).GetComponent<Text>().text = "这是一把钻石凿子。（可用于开采矿石）";
            break;
        default:
            break;
    }
    ItemMessagePanel.SetActive(true);
}
}

//public void AddBagButton()

//{
//    int btnPos = 0; //第一个Button的Y轴位置 增加-131
//    int btnHeight = 30; //Button的高度
//    int btnCount = 100; //Button的数量

//    GameObject panel_button = GameObject.Find("Bg");
//    var rectTransform = panel_button.transform.GetComponent<RectTransform>();
//    panel_button.transform.localPosition = new Vector3(0, 0 - (((btnHeight * btnCount) / 2) - (rectTransform.rect.height / 2)), 0);
//    rectTransform.sizeDelta = new Vector2(rectTransform.rect.width, btnHeight * btnCount);

//    for (int i = 0; i < btnCount; i++)
//    {
//        string text = i.ToString();

//        GameObject goClone = Instantiate(go);
//        goClone.transform.parent = panel_button.transform;
//        goClone.transform.localScale = new Vector3(1, 1, 1);    //由于克隆的Button缩放被设置为0，所以这里要设置为1
//        goClone.transform.localPosition = new Vector3(0, btnPos, 0);
//        goClone.transform.Find("Text").GetComponent<Text>().text = text;
//        goClone.GetComponent<Button>().onClick.AddListener
//        (
//            () =>
//            {
//                Click(text);    //添加按钮点击事件
//                }
//        );

//        //下一个Button的位置等于当前减去他的高度
//        btnPos = btnPos - btnHeight;
//    }
//}

//void Click(string text)
//{
//    Debug.Log(text);
//}

