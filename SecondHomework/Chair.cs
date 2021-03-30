namespace SecondHomework
{   
    class Chair
        {
        
            private int chair6 = 6;
            public int chairLegs{
                get {
                    return chair6;
                }
                set 
                {
                    chair6 = value;
                }
            }

            public string chairColor = "blue";

            private int theWeight = 1;

            public Chair (int chair6, string chairColor, int theWeight )
            {
                this.chair6 = chair6;
                this.chairColor = chairColor;
                this.theWeight = theWeight;
                RealWeight = theWeight;
            }

            public int RealWeight { get; }

            public bool onoffChair {get; set;}

            

            public string AllofIt()
            {
                return ($"{chair6},{chairColor},{RealWeight}");
            }
            
        }
}