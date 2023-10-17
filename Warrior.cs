using System;

namespace CSharpDiscovery.Examen{

    public class Warrior : Character, ITank {

        private bool Bravery;
        public int AttackPower {
            get{
                return AttackPower;

            }
            set{
                AttackPower = 25;
            }
        }

         public void Character(){
        }

        public void Character(string Name, float MaxHealth){
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.Health = MaxHealth;
        }

        override public void Special(){
            if (this.Health < 30.0) {
                Bravery = true;
            }
        }
        
        override public void CibledSpecial(Character Cible){
            if (Cible.Health < AttackPower ){
                Cible.Health = 0 ;}
                else {
                    Cible.Health -= AttackPower;
                };
            
            if (Bravery == true){
                if (Cible.Health < 15){
                    Cible.Health = 0;
                    }
                    else {
                        Cible.Health -= 15;
                    }
                
            }
        }

        public void  DoubleHit(Character cible){
            this.Health -= 10;
            if (cible.Health < AttackPower*2){
                cible.Health = 0;}
                else {
                    cible.Health -= AttackPower * 2;
                }
            }


        }
        override public string ToString(){
                return $"{Name} : {Health}/{MaxHealth} | Classe : Clerc | Mana : {Mana}";
            }

    }
