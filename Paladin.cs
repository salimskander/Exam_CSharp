using System;

namespace CSharpDiscovery.Examen{

    public class Paladin : Character , IHealer , ITank{
        private int Buff = 0;
        public int HealPower {
            get{
                return HealPower;
            }
            set{
                HealPower = 15;
            }
        }
        public int AttackPower {
            get{
                return AttackPower;

            }
            set{
                AttackPower = 25;
            }
        }


        public void DoubleHeal(Character a, Character b ){
            a.Health += HealPower/2;
            b.Health += HealPower/2;
        }



        override public void  Special(){
            if (this.Health + HealPower + Buff > 100)
            {
                this.Health = 100;
                
            } else {
                this.Health += HealPower + Buff;
            }
            
        }

        public int GetHeal(){
            return this.HealPower;
        }

        override public void CibledSpecial(Character cible){
            if (cible.Health - AttackPower - Buff < 0){
                cible.Health = 0;
            } else {
                cible.Health -= AttackPower + Buff;
            }
            Buff += 3;
        }
        override public string  ToString(){

            return $"{Name} : {Health}/{MaxHealth} | Classe : Paladin | Buff : {Buff}";
            
        }
        
    }
}