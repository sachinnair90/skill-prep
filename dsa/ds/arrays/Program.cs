// See https://aka.ms/new-console-template for more information
var assm = System.Reflection.Assembly.GetEntryAssembly();

var classes = new Dictionary<string, ISolution>();

foreach (System.Reflection.TypeInfo ti in assm.DefinedTypes)
{
  if (ti.ImplementedInterfaces.Contains(typeof(ISolution)))
  {
    classes.Add(ti.FullName, assm.CreateInstance(ti.FullName) as ISolution);
  }
}

Console.WriteLine("Select the solution you want to see.");

var index = 0;
var keys = classes.Keys.ToList();
foreach (var key in keys)
{
  Console.WriteLine($"{index + 1}. {classes[key].Name}");
  index++;
}

var response = Convert.ToInt32(Console.ReadLine()) - 1;

classes[keys[response]].Run();

Console.ReadKey();
