using System;

namespace CSharpDiscovery.Examen{

    interface IHealer{
        public int HealPower {get; set;}

        public abstract void DoubleHeal(Character a, Character b );
        public int GetHeal(){
            return HealPower;
        }
    }

    interface ITank{
        public int AttackPower{get; set;}

        public void DoubleHit(Character c){
        }
        public int GetAttack(){
            return AttackPower;
        }
    }

}