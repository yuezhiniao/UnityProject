using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

    private UserEntity m_User;
    public double m_MultipleExp = 1.18;
    public int m_StartExp = 40;
    public string PlayName { get; set; }
    public int Lv { get; set; }
    public int LvMax { get; set; }
    public double Exp { get; set; }
    public double ExpMax{get;set;}
    public double HpRegenTime { get; set; }
    public double MpRegenTime { get; set; }

    public AttributeNode statusGrowth = new AttributeNode();
    public AttributeNode statusEquip = new AttributeNode();
    public AttributeNode statusBuff = new AttributeNode();
    public AttributeRoot status = new AttributeRoot();

	// Use this for initialization
	void Start () {
		
	}
	
    private void InitALLStatus()
    {
        InitStatusGrowth();
        InitStatus();
    }

    private void InitStatusGrowth()
    {
        this.statusGrowth.Hp = this.Lv * this.m_User.Hero.HpGrowth;
        this.statusGrowth.Mp = this.Lv * this.m_User.Hero.MpGrowth;
        this.statusGrowth.Atk = this.Lv * this.m_User.Hero.AtkGrowth;
        this.statusGrowth.Def = this.Lv * this.m_User.Hero.DefGrowth;
        this.statusGrowth.Spd = this.Lv * this.m_User.Hero.SpdGrowth;
        this.statusGrowth.Hit = this.Lv * this.m_User.Hero.HitGrowth;
        this.statusGrowth.CriticalRate = this.Lv * this.m_User.Hero.CriticalRateGrowth;
        this.statusGrowth.AtkSpd = this.Lv * this.m_User.Hero.AtkSpdGrowth;
        this.statusGrowth.AtkRange = this.Lv * this.m_User.Hero.AtkRangeGrowth;
        this.statusGrowth.MoveSpd = this.Lv * this.m_User.Hero.MoveSpdGrowth;

        this.statusGrowth.Calculate();
    }

    private void InitStatus()
    {
        this.status.Hp = this.m_User.Hero.Hp;
        this.status.Mp = this.m_User.Hero.Mp;
        this.status.Atk = this.m_User.Hero.Atk;
        this.status.Def = this.m_User.Hero.Def;
        this.status.Spd = this.m_User.Hero.Spd;
        this.status.Hit = this.m_User.Hero.Hit;
        this.status.CriticalRate = this.m_User.Hero.CriticalRate;
        this.status.AtkSpd = this.m_User.Hero.AtkSpd;
        this.status.AtkRange = this.m_User.Hero.AtkRange;
        this.status.MoveSpd = this.m_User.Hero.MoveSpd;

        this.status.AddNode(this.statusGrowth);
        this.status.AddNode(this.statusEquip);
        this.status.AddNode(this.statusBuff);
        this.status.Calculate();
    }

    public void Load(UserEntity user)
    {
        this.m_User = user;
        this.Lv = this.m_User.Lv;
        this.PlayName = this.m_User.Name;
        this.Exp = this.m_User.Exp;
        this.ExpMax = m_StartExp * m_MultipleExp * this.Lv;
        this.LvMax = this.m_User.Hreo.MaxLv;
        this.HpRegenTime = this.m_User.HpRegenTime;
        this.MpRegenTime = this.m_User.MPRegenTime;

        InitAllStatus();

    }
	// Update is called once per frame
	void Update () {
		
	}
}
