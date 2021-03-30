namespace SecondHomework
{
    class SuperHero
    {
        public string notAllHeroesWearCapes = "Invisible-Joe";

        public string myAbility ="SeenByNone";

        public int Age= 13;


        public SuperHero (string notAllHeroesWearCapes, string myAbility, bool OrdinaryHuman, int Age)
        {
            this.notAllHeroesWearCapes = notAllHeroesWearCapes;
            this.myAbility = myAbility;
            OrdinaryHuman = propablyNot;
            this.Age = Age; 
            }

        public bool OrdinaryHuman {get;}

        

        public string SuperHeroStats()
        {
            return ($"{notAllHeroesWearCapes} {myAbility} {OrdinaryHuman} {Age}");
        }
    }
}