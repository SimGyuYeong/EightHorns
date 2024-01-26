using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//�ؾ��� �� : ��(���ݷ�), ��(����), ��(����) 3�ܰ� ��ųƮ�� ����
//��ų ����Ʈ�� �� 12��, �б� �� �ִ� ������ 8, 4���� ū ��ȭ
public enum ST
{
    CRASH = 0,
    RAPID,
    GIANT,
}

public class SkillTree : MonoBehaviour
{
    public Dictionary<ST, int> St = new();

    [SerializeField]
    private Button[] upgradeBtn;
    private List<TextMeshProUGUI> upgradeTxt = new();

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        for (int i = 0; i < upgradeBtn.Length; i++)
        {
            int idx = i;

            upgradeTxt.Add(upgradeBtn[idx].GetComponentInChildren<TextMeshProUGUI>());
            upgradeBtn[idx].onClick.AddListener(()=> Upgrade((ST)idx));
        }

        Clear();
    }

    //�ø� ������ �����Ǵ� ȿ�� ����, 4�������� ū ��ȭ
    //����, ��ųƮ�� 2���� ��Ҹ� ��� ����ؾ� �ϹǷ�, ��ųƮ���� enum ���, ������ ��� ������ Ȱ���ϴ°ɷ� ����
    public void Effect(ST skill)
    {

    }

    public void UpgradeWeapon()
    {
        //�� = 100 ~ 800, �� = 10 ~ 80, �� = 1 ~ 8
        //�� + �� + �� = ���� ID
        //���� ID�� ��ĥ ������ ���� ���°� �ٲ�� ��������

        int result = 0;
        for(int i = 0; i < St.Count; i++)
        {
            int value = St[(ST)i];
            result *= 10;

            if (value < 4 || value % 4 != 0) return;
            result += value;
        }

        //���� ������ ���� ID �����ͼ� ��ġ�ϸ� ���� ��ȭ�ϱ�
    }


    //UI�� Ŭ���� �� dictionary�� int���� ������Ű�� ���
    //���� ���� key�� value�� 8 �̻��̶��, �� �ö󰡵��� ���ƾ� �� << Ŭ�� ������ ���°ɷ� ����
    //���׷��̵� �Ұ��� ���� : ���� ��带 �ع����� �ʾҰų�, ��ų ����Ʈ�� �����ϰų�, ���� 8 �̻��̰ų�
    public void Upgrade(ST setSkill)
    {
        St[setSkill]++;
        UpdateUI();
    }
    public void Clear()
    {
        St.Clear();

        for (int i = 0; i < 3; i++)
            St.Add((ST)i, 0);

        UpdateUI();
    }
    //UI�� dictionary�� ����� �ٲ�� ����
    public void UpdateUI()
    {
        for(int i = 0; i < St.Count; i++)
        {
            upgradeTxt[i].text = St[(ST)i].ToString();
        }
    }


}


