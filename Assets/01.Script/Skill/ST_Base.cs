using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//해야할 일 : 파(공격력), 쾌(공속), 거(범위) 3단계 스킬트리 구현
//스킬 포인트는 총 12개, 분기 당 최대 개수는 8, 4마다 큰 변화
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

    //올릴 때마다 증가되는 효과 구현, 4레벨마다 큰 변화
    //가면, 스킬트리 2가지 요소를 모두 고려해야 하므로, 스킬트리는 enum 방식, 가면은 상속 구조를 활용하는걸로 하자
    public virtual void Effect(ST skill)
    {

    }

    public void UpgradeWeapon()
    {
        //파 = 100 ~ 800, 쾌 = 10 ~ 80, 거 = 1 ~ 8
        //파 + 쾌 + 거 = 무기 ID
        //무기 ID랑 겹칠 때마다 무기 형태가 바뀌게 설계하자

        int result = 0;
        for(int i = 0; i < St.Count; i++)
        {
            int value = St[(ST)i];
            result *= 10;

            if (value < 4 || value % 4 != 0) return;
            result += value;
        }

        //파일 내부의 무기 ID 가져와서 일치하면 형태 변화하기
    }


    //UI를 클릭할 때 dictionary의 int값을 증가시키는 방식
    //만약 현재 key의 value가 8 이상이라면, 못 올라가도록 막아야 함 << 클릭 이전에 막는걸로 하자
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
    //UI가 dictionary의 값대로 바뀌게 설정
    public void UpdateUI()
    {
        for(int i = 0; i < St.Count; i++)
        {
        }
    }


}


