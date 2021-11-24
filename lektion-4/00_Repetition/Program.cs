/*
    Access Modifiers (Encapsulation - OOP)
    -------------------------------------------------------------------------------------------------------------
    private                 accessbar inom sin det scope { } som den är skapad i        högsta säkerhetsnivå
    internal                accessbar inom sitt egna projekt (assembly)                 mellan hög säkerhetsnivå
    public                  accessbar inom alla projekt (assemby) som har en relation   lägsta säkerhetnivå
 
    protected               accessbar via arv
 
    internal protected      accessbar via projekt och via arv
    private protected       accessbar via sitt lokala scope { } och arv
 
    BRA ATT VETA!
    En klass kan bara vara public och internal, men kan även vara private om den är nestlad inuti en annan klass



    Getters And Setters { get; set; } (Encapsulation - OOP)
    --------------------------------------------------------------------------------------------------------------
    get         Read  (Hämta/Läsa)           var firstName = customer.FirstName;
    set         Write (Sätt/Skriv)           customer.FirstName = "Hans";

    public string FirstName { get; }                    get
    public string FirstName => "Hans";                  get med default värde
    public string FirstName { get; set; }               get och set
    public string FirstName { get; set; } = "Hans"      get och set med default värde
    public string FirstName { get; private set; }       get och set



    private string firstName;
    public string FirstName { get { return "Hans" } }


    private string firstName;
    public string FirstName 
    {
        get { return firstName; }
        set { firstName = value; }
    }

    
    public Customer() 
    {
        FirstName = "Hans"
    }
 
    public string FirstName { get; private set; }
 
*/