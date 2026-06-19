Console.WriteLine("### Struct DateTime ###");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

//Criar uma data específica usando formato: aaaa, mm, dd
DateTime dataHoje = new DateTime(2026, 06, 15);
Console.WriteLine(dataHoje);


//Difinindo horas
DateTime dataHoraHoje = new DateTime(2026, 06, 15, 19, 30, 15);
Console.WriteLine(dataHoraHoje);

DateTime hoje = DateTime.Now;
Console.WriteLine("\n\n");

//extrair informações da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);
Console.WriteLine("\n");


//adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));
Console.WriteLine("\n");

//obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);
Console.WriteLine("\n");

//data no formato longo e curso
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());
Console.WriteLine("\n");
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();