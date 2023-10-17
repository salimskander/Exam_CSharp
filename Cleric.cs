Using system;

Namespace CSharpDiscovery.Examen{

    public class Cleric : IHealer{

        private int HealPower = 15;

         public Character(){
            Name = "NPC";
            Health = 100.0
            MaxHealth = 100.0
            Mana = 100.0
        }

        public Character(string Name, float Health){
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.Health = MaxHealth;
        }
        public void override Special(){
            if (this.Mana > 85) {
                Mana = 100
                else {
                    Mana += 15
                }
            }
        }
        
        public void override CibledSpecial(Character Cible){
            if (Cible.Health < 75){
                Cible.Health += HealPower
                else {
                    Cible.Health += 0
                }
            }                   
        }

        public void override DoubleHeal(Character a, Character b ){
            a.Health += HealPower/2
            b.Health += HealPower/2
        }

        public override ToString(){
                return $"{Name} : {Health}/{MaxHealth} | Classe : Clerc | Mana : {Mana}"
            }
    }



}