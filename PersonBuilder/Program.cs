using PersonBuilder;

File.ReadLines("195a_persons_with_address.csv")
    .Skip(1)
    .Select(x => x.Split(";"))
    .ToList()
    .ForEach(x =>
    {
        var builder = new Person.Builder(x[0], x[1]);
        if(x[2].Length > 0)
        {
            builder.SetAge(Int32.Parse(x[2]));
        }

        if (x[3].Length > 0)
        {
            builder.SetPhone(x[3]);
        }

        if (x[4].Length > 0)
        {
            builder.SetAddress(x[4]);
        }

        builder.Build();
    });