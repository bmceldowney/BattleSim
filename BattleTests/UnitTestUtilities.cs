using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BattleTests
{
    static class UnitTestUtilities
    {
        public static object RunStaticMethod(Type type, string methodName, object[] parameters)
        {
            BindingFlags flags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            return RunMethod(type, methodName, null, parameters, flags);
        }

        public static object RunInstanceMethod(Type type, string methodName, object instance, object[] parameters)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            return RunMethod(type, methodName, instance, parameters, flags);
        }

        private static object RunMethod(Type type, string methodName, object instance, object[] parameters, BindingFlags flags)
        {
            MethodInfo info;
            try
            {
                info = type.GetMethod(methodName, flags);
                if (info == null)
                {
                    throw new ArgumentException(string.Concat(" There is no method: '", methodName, "' for type '", type.ToString(), "'."));
                }
                return info.Invoke(instance, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
