using System.Reflection;

// additional assemblies
// System.Data.DataSet ds;
// HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return; // quit the app

// loop thru assemblies that my app refernces
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load sassembly to read its details
    Assembly a = Assembly.Load(name);

    // variable to count num of methods
    int methodCount = 0;

    // loop thru all types in assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up method count
        methodCount += t.GetMethods().Count();
    }

    // output the count of types + their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
    );
}