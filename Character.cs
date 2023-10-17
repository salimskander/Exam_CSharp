Using system;

Namespace CSharpDiscovery.Examen {

// Les variables
    public abstract class Character{
        string Name;
        float Health;
        float MaxHealth;
        DateTime CreationDate;
// Les Constructeurs
        public Character(){
            Name = "NPC";
            Health = 100.0
            MaxHealth = 100.0
        }

        public Character(string Name, float Health){
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.Health = MaxHealth;
        }

// Les methodes :
        public static void TakeDamage(int dmg){
            if (Health !=  0){
                Health -= 1;
            }
        }

        public static string GetCreationDate(){
            return CreationDate.ToString();
            
        }

        public static string ToString(){
            return String.Format(Name + " :" + Health + "/" + MaxHealth)
        }
        
        public abstract void Special(){
        }
        public abstract void CibledSpecial(Character c){
        }
    }
}
