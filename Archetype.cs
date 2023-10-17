Using system;

Namespace CSharpDiscovery.Examen{

    interface IHealer{
        int HealPower;

        public void DoubleHeal(Character a, Character b ){
        }
        public int GetHeal(){
            return HealPower
        }
    }

    interface ITank{
        int AttackPower;

        public void DoubleHit(Character c){
        }
        public int GetAttack(){
            return AttackPower
        }
    }

}