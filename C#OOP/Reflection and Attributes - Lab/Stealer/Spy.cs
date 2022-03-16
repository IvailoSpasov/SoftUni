using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFiels)
        {

            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields =
                classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (var field in classFields
                .Where(f => requestedFiels.Contains(f.Name)))
            {
                var value = field.GetValue(classInstance);
                sb.AppendLine($"{field.Name}: {value}");
            }

            return sb.ToString().Trim();

        }
        public string AnalyzeAcessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            MethodInfo[] nonpublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in nonpublicMethods.Where(x=>x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have be public!");
            }

            foreach (var method in publicMethods.Where(x=>x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().TrimEnd();

        }
        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);
            var privateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder()
                .AppendLine($"All Private Methods of Class: {className}")
                .AppendLine($"Base Class: {classType.BaseType.Name}");
            foreach (var method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString().Trim();

        }

        public string CollectGetterAndSetters(string className)
        {
            Type classType = Type.GetType(className);
            var methods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            StringBuilder sb = new StringBuilder();

            foreach (var method in methods
                .Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType.FullName}");
            }
            foreach (var method in methods
                .Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will return {method.GetParameters().First().ParameterType}");
            }
            return sb.ToString().Trim();
        }


    }
}
