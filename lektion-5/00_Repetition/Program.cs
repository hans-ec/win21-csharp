/*
    using _00_Repetition;

    var model = new EnumExample();

    if(model._state == State.NoModel)
    {
        model.CaptureImage();

        if(model._image != null)
            model.PrepareImageForProcessing();

        if (model._state == State.ImagePrepared)
            model.ProcessingImage();
    }

*/



/*

    using _00_Repetition;

    var structExample = new StructExample();
    var classExample = new ClassExample();


    classExample.Name = "Namn 1";

    Console.WriteLine($"STRUCT: {structExample.Name}, CLASS: {classExample.Name}");
    Console.ReadKey();

    classExample.Name = "Hans";
    Console.WriteLine($"STRUCT: {structExample.Name}, CLASS: {classExample.Name}");
    Console.ReadKey();

*/


using _00_Repetition;

GetterSetterExample gsExample = new GetterSetterExample();
gsExample.FirstName = "Hans";
gsExample.LastName = "Mattin-Lassei";


Console.WriteLine($"{gsExample.FirstName} {gsExample.LastName}");
Console.WriteLine($"{gsExample.FullName}");


Console.ReadKey();