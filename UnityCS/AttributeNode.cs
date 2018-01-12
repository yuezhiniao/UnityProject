using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeNode : Attribute {

    private List<Attribute> m_NodeList = new List<Attribute>();
    public override void Calculate()
    {
        this.HpMax = this.Hp;
        this.MpMax = this.Mp;
        this.AtkMax = this.Atk;
        this.DefMax = this.Def;
        this.SpdMax = this.Spd;
        this.HitMax = this.Hit;
        this.CriticalRateMax = this.CriticalRate;
        this.AtkSpdMax = this.AtkSpd;
        this.AtkRangeMax = this.AtkRange;
        this.MoveSpdMax = this.MoveSpd;

        foreach(AttributeNode node in m_NodeList)
        {
            if (node.NodeCount() > 0)
            {
                node.Calculate();
            }

            this.HpMax += node.HpMax;
            this.MpMax += node.MpMax;
            this.AtkMax += node.AtkMax;
            this.DefMax += node.DefMax;
            this.SpdMax += node.SpdMax;
            this.HitMax += node.HitMax;
            this.CriticalRateMax += node.CriticalRateMax;
            this.AtkSpdMax += node.AtkSpdMax;
            this.MoveSpdMax += node.MoveSpdMax;

        }
        
    }

    public int NodeCount()
    {
        return m_NodeList.Count;

    }

    public void AddNode(AttributeNode node)
    {
        m_NodeList.Add(node);
    }

    public void RemoveNode (Attribute node)
    {
        m_NodeList.Remove(node);
    }
}
