using Microsoft.Win32;

namespace ScreenSaver
{
    public static class MyRegistry
    {
        static string MySubKey = "SOFTWARE\\alex";

        public static void SaveValue(string name, string value)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(MySubKey);
            key.SetValue(name, value);
        }

        public static void SaveValue(string name, int value)
        {
            SaveValue(name, value.ToString());
        }

        public static string LoadValue(string name, string defValue)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(MySubKey);
            if (key == null)
                return defValue;
            else
                return key.GetValue(name).ToString();
        }

        public static int LoadValue(string name, int defValue)
        {
            string value = LoadValue(name, defValue.ToString());
            try
            {
                return int.Parse(value.ToString());
            }
            catch
            {
                return defValue;
            }
        }
    }
}
