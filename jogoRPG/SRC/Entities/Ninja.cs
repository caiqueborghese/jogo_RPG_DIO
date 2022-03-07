namespace jogoRPG.SRC.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
            
        }
        public override string Attack(){
            return this.Name + " Aplicou um golpe ";

            }

         public string Attack(int Bonus){

             if (Bonus > 6){
                 return this.Name + " Aplicou um golpe com bonus de ataque de " + Bonus;
             }else{
                 return this.Name + " Aplicou um golpe com força fraca de " + Bonus;
             }
                
         }
    }
}