using Abstract;

Console.WriteLine("*********** INTERFACE ***********");
Focus focus = new Focus();
Console.WriteLine(focus.BrandName());
Console.WriteLine(focus.WheelNumber().ToString());
Console.WriteLine(focus.StandartColor());

Console.WriteLine("*********************");
Civic civic = new Civic();
Console.WriteLine(civic.BrandName());
Console.WriteLine(civic.WheelNumber().ToString());
Console.WriteLine(civic.StandartColor());

Console.WriteLine("*********************");
Corolla corolla = new Corolla();
Console.WriteLine(corolla.BrandName());
Console.WriteLine(corolla.WheelNumber().ToString());
Console.WriteLine(corolla.StandartColor());

Console.WriteLine("*********** ABSTRACT ***********");
NewFocus focus1 = new NewFocus();
Console.WriteLine(focus1.BrandName());
Console.WriteLine(focus1.WheelNumber().ToString());
Console.WriteLine(focus1.StandartColor());

Console.WriteLine("*********************");
NewCivic civic1 = new NewCivic();
Console.WriteLine(civic1.BrandName());
Console.WriteLine(civic1.WheelNumber().ToString());
Console.WriteLine(civic1.StandartColor());

Console.WriteLine("*********************");
NewCorolla corolla1 = new NewCorolla();
Console.WriteLine(corolla1.BrandName());
Console.WriteLine(corolla1.WheelNumber().ToString());
Console.WriteLine(corolla1.StandartColor());