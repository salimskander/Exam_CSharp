Using system;

Namespace CSharpDiscovery.Examen{

    public class Warrior : ITank{

        private int AttackPower = 25;

         public Character(){
            Name = "NPC";
            Health = 100.0
            MaxHealth = 100.0
            Bravery = false
        }

        public Character(string Name, float Health){
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.Health = MaxHealth;
        }

        public void override Special(){
            if (this.Health < 30.0) {
                Bravery = true
            }
        }
        
        public void override CibledSpecial(Character Cible){
            if (Cible.Health < AttackPower ){
                Cible.Health = 0.0;
                else {
                    Cible.Health -= AttackPower
                }
            }
            if (Bravery == true){
                if (Cible.Health < 15){
                    Cible.Health = 0.0
                    else {
                        Cible.Health -= 15
                    }
                }
            }
        }

        public void override DoubleHit(Character cible){
            this.Health -= 10;
            if (c.Health < AttackPower*2){
                c.Health = 0.0
                else {
                    c.Health -= AttackPower * 2
                }
            }


        }
        public override ToString(){
            return $"{Name} : {Health}/{MaxHealth} | Classe : Guerrier | Bravoure : {Bravery}"
        }

    }



}