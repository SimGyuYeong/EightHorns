using System;
using System.Collections;
using System.Collections.Generic;
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

public class ST_Base : MonoBehaviour
{
    public Dictionary<ST, int> St = new();
    public Button[] upgradeBtns;

    //�ø� ������ �����Ǵ� ȿ�� ����, 4�������� ū ��ȭ
    //����, ��ųƮ�� 2���� ��Ҹ� ��� ����ؾ� �ϹǷ�, ��ųƮ���� enum ���, ������ ��� ������ Ȱ���ϴ°ɷ� ����
    public virtual void Effect(ST skill)
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
    public void Upgrade(ST setSkill)
    {
        St[setSkill]++;
        UpdateUI();
    }
    public void Clear()
    {
        St.Clear();
        UpdateUI();
    }
    //UI�� dictionary�� ����� �ٲ�� ����
    public void UpdateUI()
    {
        for(int i = 0; i < St.Count; i++)
        {
        }
    }


}


