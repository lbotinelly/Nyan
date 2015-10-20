﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Nyan.Core.Assembly
{
    public static class Management
    {
        static Dictionary<string, System.Reflection.Assembly> _assys = new Dictionary<string, System.Reflection.Assembly>();

        static Management()
        {
            // This bootstrapper loads all assemblies placed in the same physical directory as the caller project,
            // And keep a static reference to them.

            LoadLocalAssemblies();
        }
        private static void LoadLocalAssemblies()
        {
            List<System.Reflection.Assembly> allAssemblies = new List<System.Reflection.Assembly>();

            var assylist = Directory.GetFiles(Settings.Current.BaseDirectory, "*.dll");

            foreach (string dll in assylist)
            {
                try
                {
                    var assy = System.Reflection.Assembly.LoadFile(dll);

                    if (!_assys.ContainsKey(assy.ToString()))
                        _assys.Add(assy.ToString(), assy);

                    allAssemblies.Add(assy);

                }
                catch { }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<Type> GetClassesByInterface<T>()
        {
            var type = typeof(T);
            List<Type> ret = new List<Type>();

            foreach (var item in _assys.Values)
            {
                Type[] preTypes;

                try
                {
                    preTypes = item.GetTypes();
                }
                catch
                {
                    // Well, this loading can fail by a (long) variety of reasons. 
                    // It's not a real problem not to catch exceptions here. 
                    continue;
                }

                foreach (var item3 in preTypes)
                {
                    if (!item3.IsInterface)
                    {
                        if (type.IsAssignableFrom(item3))
                        {
                            ret.Add(item3);
                        }
                    }
                }
            }

            return ret;
        }
    }
}
