using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attribute  {
    private Attribute m_Parent;

    public int Hp { get; set; }
    public int Mp { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
	public int Spd { get; set; }
    public int Hit { get; set; }
    public double CriticalRate { get; set; }
    public double AtkRange { get; set; }
    public double AtkSpd { get; set; }
    public double MoveSpd { get; set; }

    public int HpMax { get; set; }
    public int MpMax { get; set; }
    public int AtkMax { get; set; }
    public int DefMax { get; set; }
    public int SpdMax { get; set; }
    public int HitMax { get; set; }
    public double CriticalRateMax { get; set; }
    public double AtkSpdMax { get; set; }
    public double AtkRangeMax { get; set; }
    public double MoveSpdMax { get; set; }

    public abstract void Calculate();

    protected void SetParent(AttributeNode child)
    {
        child.m_Parent = this.m_Parent;
    }

    public Attribute GetParent()
    {
        return this.m_Parent;
    }

    















}
