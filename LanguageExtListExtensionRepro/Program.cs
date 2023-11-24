// See https://aka.ms/new-console-template for more information
var foo = new List<Foo>();
var bar = new List<Foo>().Zip(foo).All(c => c.First == c.Second);
var barz = foo.Append(new() { Barz = new Bar[] { } });

internal record Foo
{
    public Bar[] Barz { get; set; }
}

internal record Bar { }
