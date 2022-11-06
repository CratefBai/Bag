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
        //����ð�ť  �ڱ��������һ����λ�������1
        Btn_Items[0].onClick.AddListener(() =>
        {
        for (int i = 0; i < BackPackItems.Length; i++)
        {
            if (BackPackItems[i].transform.childCount == 1)//���жϳ������һ���տ�transform.childCount ��ȡ����������
                {
                GameObject item0 = Instantiate(Items[0], BackPackItems[i].transform); //���ÿ���Ӹ�����
                item0.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;//�ı�RectTransform��pos
                break;
            }
            else if (BackPackItems[i].transform.childCount > 1 && BackPackItems[i].GetChild(1).name.Equals("Item1(Clone)") && int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) < 5)
            {
                BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text = (int.Parse(BackPackItems[i].GetChild(1).GetChild(0).GetComponent<Text>().text) + 1).ToString();
                break;
            }
        }
        });

        //����ð�ť  �ڱ��������һ����λ�������2
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

        //����ð�ť  �ڱ��������һ����λ�������3

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
        //���������Ʒ��ť��ʾ��Ӧ��Ϣ
        Btn_ItemMessage[0].onClick.AddListener(() =>
        {
            ItemBtnClickEvent(BackPackItems[0]);
        });
        //���������Ʒ��ť��ʾ��Ӧ��Ϣ
        Btn_ItemMessage[1].onClick.AddListener(() =>
        {
            ItemBtnClickEvent(BackPackItems[1]);
        });
        //���������Ʒ��ť��ʾ��Ӧ��Ϣ
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
/// ��Ʒ�����չʾ��Ϣ  �������������������������ĸ�  Ȼ����ʾ��Ӧ����Ϣ
/// </summary>
/// <param name="itemParent"></param>
public void ItemBtnClickEvent(Transform itemParent)
{
    if (itemParent.childCount == 1) return;
    switch (itemParent.GetChild(1).name)
    {
        case "Item1(Clone)":
            ItemMessagePanel.transform.GetChild(2).GetComponent<Text>().text = "����һ����ʯ������" +
                "���������ո�С��";
            break;
        case "Item2(Clone)":
            ItemMessagePanel.transform.GetChild(2).GetComponent<Text>().text = "����һ����ʯ��ͷ����������������ľ��";
            break;
        case "Item3(Clone)":
            ItemMessagePanel.transform.GetChild(2).GetComponent<Text>().text = "����һ����ʯ���ӡ��������ڿ��ɿ�ʯ��";
            break;
        default:
            break;
    }
    ItemMessagePanel.SetActive(true);
}
}

//public void AddBagButton()

//{
//    int btnPos = 0; //��һ��Button��Y��λ�� ����-131
//    int btnHeight = 30; //Button�ĸ߶�
//    int btnCount = 100; //Button������

//    GameObject panel_button = GameObject.Find("Bg");
//    var rectTransform = panel_button.transform.GetComponent<RectTransform>();
//    panel_button.transform.localPosition = new Vector3(0, 0 - (((btnHeight * btnCount) / 2) - (rectTransform.rect.height / 2)), 0);
//    rectTransform.sizeDelta = new Vector2(rectTransform.rect.width, btnHeight * btnCount);

//    for (int i = 0; i < btnCount; i++)
//    {
//        string text = i.ToString();

//        GameObject goClone = Instantiate(go);
//        goClone.transform.parent = panel_button.transform;
//        goClone.transform.localScale = new Vector3(1, 1, 1);    //���ڿ�¡��Button���ű�����Ϊ0����������Ҫ����Ϊ1
//        goClone.transform.localPosition = new Vector3(0, btnPos, 0);
//        goClone.transform.Find("Text").GetComponent<Text>().text = text;
//        goClone.GetComponent<Button>().onClick.AddListener
//        (
//            () =>
//            {
//                Click(text);    //��Ӱ�ť����¼�
//                }
//        );

//        //��һ��Button��λ�õ��ڵ�ǰ��ȥ���ĸ߶�
//        btnPos = btnPos - btnHeight;
//    }
//}

//void Click(string text)
//{
//    Debug.Log(text);
//}

