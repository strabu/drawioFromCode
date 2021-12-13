using DrawIOFromCode;

var dw = new DrawIOWriter();

using (var xw = dw.WriteHeader("diagrams/sample1.g.drawio"))
{
    dw.AddClass(xw, 2, "Fooh", 40, 40);
    dw.AddClass(xw, 3, "Bar", 40, 140);
    dw.Inherits(xw, 4, 3, 2);

    dw.AddClass(xw, 5, "Bla", 40, 240);
    dw.AddClass(xw, 6, "Bli", 40, 340);
    dw.AddClass(xw, 7, "Blupp", 140, 340);
    dw.Inherits(xw, 8, 6, 5);
    dw.Inherits(xw, 9, 7, 5);

    dw.WriteFooter(xw);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("done.");
