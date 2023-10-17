Using system;

Namespace CSharpDiscovery.Examen{

    public class Paladin : Character : IHealer :ITank{
        private int Buff = 0;

        public void override Special(){
            if (this.Health + HealPower + Buff > 100)
            {
                this.Health = 100;
                
            } else {
                this.Health += HealPower + Buff
            }
            
        }

        public void override CibledSpecial(Character cible){
            if (cible.Health - AttackPower - Buff < 0){
                cible.Health = 0;
            } else {
                cible.Health -= AttackPower + Buff;
            }
            Buff += 3;
        }

        public string override ToString(){

            return $"{Name} : {Health}/{MaxHealth} | Classe : Paladin | Buff : {Buff}"
            
        }
        
    }
}