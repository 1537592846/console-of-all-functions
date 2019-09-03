using console_of_all_functions.libraries.intern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace console_of_all_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Type command: ");
                    string entry = Console.ReadLine();
                    Console.WriteLine("_____________________________");

                    if (entry.ToLower().StartsWith("hacks")){
                        Type type = Type.GetType("console_of_all_functions.libraries.hacks.Hacks");

                        foreach (var method in type.GetRuntimeMethods())
                        {
                            if (type.GetMethods().Contains(method) || !method.IsAssembly)
                            {
                                continue;
                            }

                            string line = method.Name;
                            
                            Console.WriteLine(line);
                        }
                    }

                    if (entry.ToLower().StartsWith("hack "))
                    {
                        string library = "hacks";
                        string className = "Hacks";
                        Type type = Type.GetType("console_of_all_functions.libraries." + library + "." + className);
                        string function = type.GetRuntimeMethods().Where(x => x.Name.ToLower() == entry.Substring(5)).First().Name;

                        RunFunction(library, className, function + "()");
                    }

                    if (entry.ToLower() == "exit")
                    {
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(1500);
                        return;
                    }

                    if (entry.ToLower() == "help")
                    {
                        Console.WriteLine("exit                                             Ends the program");
                        Console.WriteLine("libraries                                        Show current libraries");
                        Console.WriteLine("classes 'library'                                Show current classes on the specified library");
                        Console.WriteLine("functions 'library' 'class'                      Show current functions ont the specified class in the library");
                        Console.WriteLine("run 'library' 'class' 'function'('parameters')   Execute define function, use ';' to separate parameters");
                    }

                    if (entry.ToLower() == "libraries")
                    {
                        ShowLibraries();
                    }

                    if (entry.ToLower().StartsWith("classes"))
                    {
                        ShowClasses(entry.Split(' ')[1]);
                    }

                    if (entry.ToLower().StartsWith("functions"))
                    {
                        ShowFunctions(entry.Split(' ')[1], entry.Split(' ')[2]);
                    }

                    if (entry.ToLower().StartsWith("run"))
                    {
                        string library = entry.Split(' ')[1];
                        string className = entry.Split(' ')[2];
                        string function = entry.Substring(library.Count() + className.Count() + 6);
                        RunFunction(library, className, function);
                    }

                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Problem executing command, check sintax");
                }
            }
        }

        static void ShowLibraries()
        {
            var librariesList = new List<string>();
            var typeList = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Namespace != null && x.Namespace.Contains("libraries") && x.Namespace.EndsWith("hacks") && !x.Namespace.EndsWith("intern")).ToList();

            foreach (var type in typeList)
            {
                librariesList.Add(type.Namespace.Substring(type.Namespace.LastIndexOf('.') + 1));
            }

            foreach (var libraryName in librariesList.Distinct().OrderBy(x => x))
            {
                Console.WriteLine(libraryName);
            }
        }

        static void ShowClasses(string library)
        {
            var classList = Assembly.GetExecutingAssembly().GetTypes()
                 .Where(t => t.Namespace == "console_of_all_functions.libraries." + library)
                 .ToList();

            foreach (var className in classList)
            {
                Console.WriteLine(className.Name);
            }
        }

        static void ShowFunctions(string library, string className)
        {
            Type type = Type.GetType("console_of_all_functions.libraries." + library + "." + className);

            foreach (var method in type.GetRuntimeMethods())
            {
                if (type.GetMethods().Contains(method) || !method.IsAssembly)
                {
                    continue;
                }

                string line = method.Name;
                line += "(";
                string parameters = "";

                foreach (var parameter in method.GetParameters())
                {
                    if (parameters != "")
                    {
                        parameters += ", ";
                    }

                    parameters += parameter.ParameterType.Name + " " + parameter.Name;
                }

                line += parameters;
                line += ")";

                Console.WriteLine(line);
            }
        }

        static void RunFunction(string library, string className, string function)
        {
            Type type = Type.GetType("console_of_all_functions.libraries." + library + "." + className);
            var parameters = function.Contains("()") ? new string[] { } : function.Substring(function.IndexOf('(') + 1, function.Length - function.IndexOf('(') - 2).Split(';');
            MethodInfo method = type.GetRuntimeMethods().Where(x => x.Name == function.Split('(')[0]).Where(x => x.GetParameters().Count() == parameters.Count()).First();
            List<object> parameterList = new List<object>();

            if (parameters.Count() != 0)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    parameterList.Add(Parse.ParseValue(method.GetParameters()[i].ParameterType.Name, parameters[i]));
                }
            }

            method.Invoke(null, parameterList.ToArray());
            return;
        }
    }
}
