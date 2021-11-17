/* 
    Methods vs. Functions
    --------------------------------------------------------------------------------------------------------------------------
    Funktioner är fristående, medan metoder ligger inuti en klass och måste instansieras. I C# har vi inga funktioner utan bara
    metoder. Finns undantag när vi pratar om Azure Functions.

        Exempel på en funktion
        -----------------------------------
            function Create() {
                do something....
            }
    
            Create();


        Exempel på en metod
        -----------------------------------
            public class User 
            {
                public void Create() 
                {
                    do something....
                }
            }
    
            var user = new User();
            user.Create();
        
    


    Access Modifiers (Encapsulation - OOP)
    --------------------------------------------------------------------------------------------------------------------------
    saker du bör kunna:    
        public                      blir accessbar överallt i alla projekt som har en relation till varandra (Project Reference)
        private                     blir bara accessbar inom det scope { } som den är skapad inom
        internal                    blir accessbart inom det egna projektet (assembly)
        protected                   blir accessbart genom arv

    special fall:
        internal protected          blir accessbart genom arv och inom det egna projektet (assembly)
        private protected           blir accessbart genom arv och inom det scope { } som den är skapad inom

    
    Bra att veta! 
    En klass kan bara vara public, internal och private MEN private funkar bara i en nestlad class, klass inuti en klass

*/
