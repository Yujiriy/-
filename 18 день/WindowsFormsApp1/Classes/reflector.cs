using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Reflector
    {
        // Выводит всё содержимое класса в текстовый файл
        public static string PrintDataOfClass(string className)
        {
            Type type = Type.GetType(className);
            if (type != null)
            {
                string fileName = className + "_Содержимое.txt";
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (MemberInfo member in type.GetMembers())
                    {
                        writer.WriteLine(member.ToString());
                    }
                }
                string fileContent = File.ReadAllText(fileName);
                return $"Содержимое класса {className} записано в файл {fileName}\n\nСодержимое файла:\n{fileContent}";
                // Console.WriteLine($"Содержимое класса {className} записано в файл {fileName}");
            }
            else
            {
                return $"Класс {className} не найден";
                //Console.WriteLine($"Класс {className} не найден");
            }
        }

        // Извлекает все общедоступные публичные методы класса
        public static string GetMethods(string className)
        {
            Type type = Type.GetType(className);
            if (type != null)
            {
                MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (MethodInfo method in methods)
                {
                    stringBuilder.AppendLine(method.Name);
                }
                return stringBuilder.ToString();
            }
            else
            {
                return $"Класс {className} не найден";
            }
        }

        // Получает информацию о полях и свойствах класса
        public static string GetFieldsAndProperties(string className)
        {
            Type type = Type.GetType(className);
            if (type != null)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"Поля класса {className}:");
                foreach (FieldInfo field in type.GetFields())
                {
                    stringBuilder.AppendLine(field.Name);
                }

                stringBuilder.AppendLine($"Свойства класса {className}:");
                foreach (PropertyInfo property in type.GetProperties())
                {
                    stringBuilder.AppendLine(property.Name);
                }

                return stringBuilder.ToString();
            }
            else
            {
                return $"Класс {className} не найден";
            }
        }

        // Получает все реализованные классом интерфейсы
        public static string GetInterfaces(string className)
        {
            Type type = Type.GetType(className);
            if (type != null)
            {
                Type[] interfaces = type.GetInterfaces();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Type iface in interfaces)
                {
                    stringBuilder.AppendLine(iface.Name);
                }
                return stringBuilder.ToString();
            }
            else
            {
                return $"Класс {className} не найден";
            }
        }

        // Выводит имена методов класса, которые содержат заданный тип параметра
        public static string PrintMethodsByParameter(string className, string parameterTypeName)
        {
            Type type = Type.GetType(className);
            if (type != null)
            {
                MethodInfo[] methods = type.GetMethods();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (MethodInfo method in methods)
                {
                    foreach (ParameterInfo parameter in method.GetParameters())
                    {
                        if (parameter.ParameterType.Name == parameterTypeName)
                        {
                            stringBuilder.AppendLine(method.Name);
                            break;
                        }
                    }
                }
                return stringBuilder.ToString();
            }
            else
            {
                return $"Класс {className} не найден";
            }
        }

        // Вызывает метод класса, значения параметров читаются из текстового файла
        public static string CallMethodFromFile(string className, string methodName, string fileName)
        {
            Type type = Type.GetType(className);
            if (type != null)
            {
                MethodInfo method = type.GetMethod(methodName);
                if (method != null)
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    object[] parameterValues = new object[parameters.Length];

                    if (File.Exists(fileName))
                    {
                        string[] lines = File.ReadAllLines(fileName);
                        if (lines.Length == parameters.Length)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                Type parameterType = parameters[i].ParameterType;
                                object parameterValue = Convert.ChangeType(lines[i], parameterType);
                                parameterValues[i] = parameterValue;
                            }
                        }
                        else
                        {
                            return "Количество значений в файле не соответствует количеству параметров метода";
                        }
                    }
                    else
                    {
                        return $"Файл {fileName} не найден";
                    }

                    object instance = Activator.CreateInstance(type);
                    object result = method.Invoke(instance, parameterValues);
                    return $"Результат вызова метода {className}.{methodName}: {result}";
                }
                else
                {
                    return $"Метод {methodName} не найден в классе {className}";
                }
            }
            else
            {
                return $"Класс {className} не найден";
            }
        }
    }
}
