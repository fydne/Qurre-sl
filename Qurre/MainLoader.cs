﻿using System.Collections.Generic;
namespace Qurre
{
    public class PluginManager
    {
        public static readonly List<Plugin> plugins;
        public static string LogsDirectory { get; }
        public static string ConfigsDirectory { get; }
        public static string LoadedDependenciesDirectory { get; }
        public static string PluginsDirectory { get; }
        public static string QurreDirectory { get; }
        public static string AppDataDirectory { get; }
        public static int Planid { get; }
        public static string Plan { get; }
        public static Version Version { get; }
        public static string ManagedAssembliesDirectory { get; }
        public static string ConfigsPath { get; }

        public static void Disable();
        public static void Enable();
        public static void LoadPlugin(string mod);
        public static IEnumerator<float> LoadPlugins();
        public static void Reload();
        public static void ReloadPlugins();
    }
}