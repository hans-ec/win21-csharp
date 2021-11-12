#region KOMMENTARER

/* 
    KOMMENTARER
    //inline-comment  (VS CODE: ctrl + *, VS: "ctrl + e c"  ctrl + e u)

    /* 
        block-comment  
        (VS CODE: shift + alt + a, VS: ctrl + shift + *) 
    */

/*
/// <summary>
/// This will create a new user and save it to the database
/// </summary>
/// <param name="user">UserModel Object</param>
/// <returns>Returns a user object</returns>
public User CreateUser(User user)
{
    return user;
}

*/
#endregion

#region DATATYPER
/* 
    DATATYPER 
    
    JS                              C#
    --------------------------------------------------------------------------------------------------------------------------------
    Number                          sbyte, byte, short, ushort, int, uint, long, ulong, Int16, Int32, Int64, decimal, double, float
    Boolean                         bool
    String                          string, char
    Object                          object
    null (Object)                   null
    Undefined                       ---
    ---                             dynamic
    

    C# Integrals
    TYPE        BIT     RANGE
    ---------------------------------------------------------------------------------------------------------------------------------
    sbyte       8       -128 > 127      
    byte        8       0 > 255
    short       16      -32 768 > 32 767
    ushort      16      0 > 65 536
    int         32      -2 147 483 648 > 2 147 483 647
    uint        32      0 > 4 294 967 295
    long        64      -9 223 372 036 854 775 808 > 9 223 372 036 854 775 807
    ulong       64      0 > 18 446 744 073 709 551 615

    Int16       16      = short
    Int32       32      = int
    Int64       64      = long


    C# Floating Points
    TYPE        BYTES       RANGE           SUFFIX
    ---------------------------------------------------------------------------------------------------------------------------------
    decimal     16          28-29 digits    m eller M           lämplig för finanser såsom pengar (0.1 + 0.1 + 0.1 = 0.3)
    double      8           15-17 digits    d eller D           lämplig för optimering av prestanda/lagring
    float       4           6-9   digits    f eller F           lämplig för Machine Learning etc. (ML.NET baseras på float)
 
    decimal SumWithDecimal = 0.1m + 0.1M + 0.1m;
    double SumWithDouble = 0.1d + 0.1D + 0.1d;
    float SumWithFloat = 0.1f + 0.1F + 0.1f;

    Console.WriteLine("Decimal: " + SumWithDecimal);
    Console.WriteLine("Double: " + SumWithDouble);
    Console.WriteLine("Float: " + SumWithFloat);



    C# Boolean
    TYPE        BIT     RANGE
    ---------------------------------------------------------------------------------------------------------------------------------
    bool        0/1     true/false



    C# String
    TYPE        BIT     SCHEME                      RANGE
    ---------------------------------------------------------------------------------------------------------------------------------
    char        16      ascii/utf-8 (unicode)       U+0000 > U+FFFF (U = Unicode, UTF-8), X+0000 > X+FFFF (X = Hexadecimal, ASCII)     
    string      64      ascii/utf-8 (unicode)       max 2GB (~ 1 000 000 000 characters)


    char text = '';

    string firstname = "Hans";
    string lastname = "Mattin-Lassei";

    string text = "Jag heter Hans Mattin-Lassei.";
    string text = "Jag heter " + firstname + " " + lastname +".";
    string text = String.Format("Jag heter {0} {1}.", firstname, lastname);
    string text = $"Jag heter {firstname} {lastname}.";

    string citat = "\"Jag tänker därför finns jag\"";
    string json  = "{ \"firstName\": \"Hans\", \"lastName\": \"Mattin-Lassei\" }"; 

    string urn = "c:\\Users\\Hans\\Documents\\program.cs";
    string urn = @"c:\Users\Hans\Documents\program.cs";
    string urn = @$"c:\Users\{firstname}\Documents\program.cs";
    

*/
#endregion

#region OPERANDER
/*
    OPERANDER

    C#                                          JS                              ANNAT
    --------------------------------------------------------------------------------------------------------
    ==      lika med                            (JS:     ===)                   -eq
    !=      inte lika med                       (JS:     !==)                   -ne
    <       mindre än                                                           -lt
    <=      mindre eller lika med                                               -lt
    >       större än                                                           -gt    
    >=      större eller lika med                                               -gt
    &&      och                                                                 and
    ||      eller                                                               or

    !       inte                                                                not    
 
*/
#endregion

#region IF SATSER
/*
    IF SATSER

    --------------------------------------------------------------
    Enbart en IF

    if (true-statement)
        Console.WriteLine("if-satsen är sann.");

    --------------------------------------------------------------
    IF-sats med en else-del

    if (true-statement)
        Console.WriteLine("if-satsen är sann.");
    else
        Console.WriteLine("if-satsen är inte sann.");

    --------------------------------------------------------------
    Nestlad if-sats    

    if (true-statement)
        Console.WriteLine("if-satsen är sann.");
    else if (true-statement)
        Console.WriteLine("if-satsen är sann.");
    else
        Console.WriteLine("if-satsen är inte sann.");

    --------------------------------------------------------------
    Om fler än två saker ska göras

    if (true-statement) 
    {
        Console.WriteLine("Skriver ut rad 1");
        Console.WriteLine("Skriver ut rad 2");
    }

    --------------------------------------------------------------
    En förenklad version

    (true-statement) ? "if-satsen är sann"; : "if-satsen är inte sann";

    var text = (true) ? "if-satsen är sann" : "if-satsen är inte sann";
    Console.WriteLine(text);


*/
#endregion

#region SWITCH
/*
    SWITCH  (value == "text")

    switch(value)
    {
        case "text":
            ...gör något här
            break;

        case "password":
            ...gör något här
            break;

        case "email":
            ...gör något här
            break;

        default:
            ...gör något här
            break;
    }

 
*/
#endregion

#region LOOPAR
/*
    LOOPAR

    C#                                                      JS
    ----------------------------------------------------------------------------------------------------------------------------
    for(int i = 0; i < 10; i++) {}                          for(let i = 0; i < 10; i++) {} 
    foreach(var item in list) {}                            for(let item of list) {}
                                                            list.forEach(item => {})
                                                            list.map(item => {})
    
    while(true) {}                                          while(true) {}
    do {} while (true);                                     ---

*/
#endregion

#region NULLABLE
/*
    NULLABLE

    ?   nullable                <    kan tillåta nullvärden (null = jag vet inte...)
    ??  null-coalescing         <    om något är null så tilldelas ett annat värde
 
    Se exemplet: NullableExample.cs
    internal class NullableExample
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string Description { get; set; }
    }

    int? value = null;
    int sum = value ?? 0;
    Console.WriteLine(sum);

*/
#endregion

#region VARIABLER
/*
    VARIABLER

    C#          Pascal              FirstName
    JS          camelCase           firstName
    PY          snake_case          first_name

    
    SE EXEMPLET FÖR VariableExample.cs
        Field       firstName                                       inuti en klass
        Property    FirstName                                       inuti en klass med getters setters
        Parameter   firstName                                       input till en metod/funktion
        Variable    _firstName/firstName/FirstName/firstname        inuti en metod/funktion


    Beskrivning                                 Exempel
    ----------------------------------------------------------------------------------------------------------------
    datatyp variabelnamn = värde;               string  firstName = "Hans";     < har en fast datatyp
    dynamisk-datatyp variabelnamn = värde;      var     firstName = "Hans";     < blir vad den blir tilldelad
                                                dynamic firstName = "Hans";     < har en datatyp av typen dynamic
 
*/
#endregion

#region ARRAYER
/*
    ARRAYS
    En array kan vara av en eller flera dimensioner eller den kan vara jagged (Jagged är en array av arrayer)
    
    
    Beskrivning                         Exempel
    ---------------------------------------------------------------------------------------------------------
    datatyp[] NamnPåArrayen             string[] names, int[] values, User[] users etc.

    string[] names = new string[5];
    string[] names = new string[] { "Hans", "Tommy", "Joakim", "Haithem", "Stefan" };
    string[] names = { "Hans", "Tommy", "Joakim", "Haithem", "Stefan" };

    string[,] multiDimentional = new string[3,2];
    string[,] multiDimentional = { { "Hans", "Tommy", "Joakim" } , { "Haithem", "Stefan" } }

    string[][] jagged = new string[5][];
    jagged[0] = new string[5] { "Hans", "Tommy", "Joakim", "Haithem", "Stefan" };
*/
#endregion