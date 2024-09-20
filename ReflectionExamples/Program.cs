using System.Reflection;


Type t = typeof(Math);
MethodInfo[] methods = t.GetMethods();
int index = 1;
foreach (MethodInfo method in methods)
{
    Console.Write($"{index++}) ");
    ParameterInfo[] parameters = method.GetParameters();
    Type returnType = method.ReturnType;
    Console.Write(returnType.Name);
    Console.Write(' ');
    Console.Write(method.Name);
    Console.Write("(");
    if (parameters.Length > 0)
    {
        foreach (ParameterInfo param in parameters)
        {
            Console.Write(param.ParameterType.Name);
            Console.Write(" ");
            Console.Write(param.Name);
            if (parameters[parameters.Length - 1].Name != param.Name)
            {
                Console.Write(',');
            }
        }
    }
    Console.Write(");");
    Console.WriteLine();
}

Console.WriteLine("Please Select a Method");
int selection = int.Parse(Console.ReadLine());
var selectedMethod = methods[selection - 1];
var selectedMethodParameters = selectedMethod.GetParameters();
object[] selectedMethodParamsValue = new object[selectedMethodParameters.Length];

for (int i = 0; i < selectedMethodParameters.Length; i++)
{
    var ParameterType = selectedMethodParameters[i].ParameterType;
    var ParameterMethodType = ParameterType.GetMethod("Parse", new Type[] { typeof(string) });

    var paramValue = Console.ReadLine();
    selectedMethodParamsValue[i] = ParameterMethodType.Invoke(null, new object[] { paramValue });
}

var result = selectedMethod.Invoke(null, selectedMethodParamsValue);
Console.WriteLine(result);