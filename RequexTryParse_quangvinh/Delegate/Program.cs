using Delegate;

    
        Mathems ma = new();
        ma.Add(10, 5);

//c2
new Mathems().Multi(10, 5);

//c3
Mathems.Div(10, 5);

Abc dele = new Mathems().Multi;
dele(10,5);