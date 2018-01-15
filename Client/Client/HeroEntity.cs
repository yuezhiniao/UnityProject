using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [Serializable]
    public class HeroEntity
    {
        public virtual int ID { get; set; }
        public virtual int Lv { get; set; }
        public virtual int MaxLv { get; set; }
        public virtual int Hp { get; set; }
        public virtual int Mp { get; set; }
        public virtual int Atk { get; set; }
        public virtual int Def { get; set; }
        public virtual int Spd { get; set; }
        public virtual  int Hit { get; set; }
        public virtual double CriticalRate { get; set; }
        public virtual double AtkSpd { get; set; }
        public  virtual double AtkRange { get; set; }
        public virtual  double MoveSpd { get; set; }
        public  virtual int HpGrowth { get; set; }
        public virtual int MpGrowth { get; set; }
        public virtual int AtkGrowth { get; set; }
        public virtual int DefGrowth { get; set; }
        public virtual int SpdGrowth { get; set; }
        public virtual int HitGrowth { get; set; }
        public virtual double CriticalRateGrowth { get; set; }
        public virtual double AtkSpdGrowth { get; set; }
        public virtual double AtkRangeGrowth { get; set; }
        public virtual double MoveSpdGrowth { get; set; }
        public virtual double HpRegenTime { get; set; }
        public virtual double MpRegenTime { get; set; }
        public virtual string Description { get; set; }
        public virtual string PrefabName { get; set; }



    }
}
