namespace jogoRPG.SRC.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
            
        }
        public override string Attack(){
            return this.Name + " Atacou com a espada";

            }

         public string Attack(int Bonus){

             if (Bonus > 6){
                 return this.Name + " Atacou com a espada com bonus de ataque de " + Bonus;
             }else{
                 return this.Name + " Atacou com a espada com força fraca de " + Bonus;
             }
                
         }
        
    }
}