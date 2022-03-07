namespace jogoRPG.SRC.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType){
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
            
        }
        public override string Attack(){
            return this.Name + " Lançou Magia negra ";

            }

         public string Attack(int Bonus){

             if (Bonus > 6){
                 return this.Name + " Lançou Magia negra com bonus de ataque de " + Bonus;
             }else{
                 return this.Name + " Lançou Magia negra com força fraca de " + Bonus;
             }
                
         }
    }
}