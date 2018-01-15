using System.Collections;
using System.Collections.Generic;

namespace Client
{
    


public class AttributeRoot :Attribute {

	public int HpCur { get; set; }
    public int MpCur { get; set; }
    public int AtkCur { get; set; }
    public int DefCur { get; set; }
    public int SpdCur { get; set; }
    public int HitCur { get; set; }

    public double CriticalRateCur { get; set; }
    public double AtkSpdCur { get; set; }
    public double AtkRangeCur { get; set; }
    public double MoveSpdCur { get; set; }

    public List<Attribute> m_NodeList = new List<Attribute>();
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

        foreach (AttributeNode node in m_NodeList)
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
    public void Calculate(bool isInit)
    {
        Calculate();
        if (isInit)
        {
            this.HpCur = this.HpMax;
            this.MpCur = this.MpMax;
            this.AtkCur = this.AtkMax;
            this.DefCur = this.DefMax;
            this.SpdCur = this.SpdMax;
            this.HitCur = this.HitMax;
            this.CriticalRateCur = this.CriticalRateMax;
            this.AtkSpdCur = this.AtkSpdMax;
            this.MoveSpdCur = this.MoveSpdMax;
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

    public void RemoveNode(AttributeNode node)
    {
        m_NodeList.Remove(node);
    }
    }







}


