using System;
using System.Dynamic;

namespace CSharpDiscovery.Examen {

// Les variables
    public abstract class Character{
        public string Name {get; set;} 
        public float Health {get; set;}
        public float MaxHealth {get; set;}
        public DateTime CreationDate {get; set;}
// Les Constructeurs
        public Character(){
            Name = "NPC";
            Health = 100;
            MaxHealth = 100;
        }

        public Character(string Name, float MaxHealth){
            this.Name = Name;
            this.MaxHealth = MaxHealth;
            this.Health = MaxHealth;
        }

// Les methodes :
        public void TakeDamage(int dmg){
            if (Health !=  0){
                Health -= 1;
            }
        }

        public static string GetCreationDate(){
            return DateTime.Now.ToString();
            
        }

        override public string ToString(){
            return $"{Name} : {Health}/{MaxHealth}";
        }
        
        public abstract void Special();
        public abstract void CibledSpecial(Character c);
    }
}
