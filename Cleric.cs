using System;

namespace CSharpDiscovery.Examen{

    public class Cleric : Character , IHealer {

        public int HealPower {
            get{
                return HealPower;
            }
            set{
                HealPower = 15;
            }
        }
        private float Mana = 100;

         public void Character(){
        }

        public void Character(string Name, float MaxHealth){
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.Health = MaxHealth;
        }
        override public void  Special(){
            if (this.Mana > 85) {
                Mana = 100;}
                else {
                    Mana += 15;
                }
        }
        
        override public void CibledSpecial(Character Cible){
            if (Cible.Health < 75){
                Cible.Health += HealPower;
            }
                else {
                    Cible.Health += 0;
                }
            }                   

        public void DoubleHeal(Character a, Character b ){
            a.Health += HealPower/2;
            b.Health += HealPower/2;
        }

        
            public int GetHeal(){
            return HealPower;
        }

        override public string ToString(){
                return $"{Name} : {Health}/{MaxHealth} | Classe : Clerc | Mana : {Mana}";
            }

    }



}