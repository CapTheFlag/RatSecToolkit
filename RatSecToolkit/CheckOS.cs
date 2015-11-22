using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace RatSecToolkit
{
    class CheckOS
    {
        private const string baseReg =
    @"SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002bE10318}\";

        public static bool SetMAC(string nicid, string newmac)
        {
            bool ret = false;
            using (RegistryKey bkey = GetBaseKey())
            using (RegistryKey key = bkey.OpenSubKey(baseReg + nicid))
            {
                if (key != null)
                {
                    key.SetValue("NetworkAddress", newmac, RegistryValueKind.String);

                    ManagementObjectSearcher mos = new ManagementObjectSearcher(
                        new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE Index = " + nicid));

                    foreach (ManagementObject o in mos.Get().OfType<ManagementObject>())
                    {
                        o.InvokeMethod("Disable", null);
                        o.InvokeMethod("Enable", null);
                        ret = true;
                    }
                }
            }

            return ret;
        }

        public static IEnumerable<string> GetNicIds()
        {
            using (RegistryKey bkey = GetBaseKey())
            using (RegistryKey key = bkey.OpenSubKey(baseReg))
            {
                if (key != null)
                {
                    foreach (string name in key.GetSubKeyNames().Where(n => n != "Properties"))
                    {
                        using (RegistryKey sub = key.OpenSubKey(name))
                        {
                            if (sub != null)
                            {
                                object busType = sub.GetValue("BusType");
                                string busStr = busType != null ? busType.ToString() : string.Empty;
                                if (busStr != string.Empty)
                                {
                                    yield return name;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static RegistryKey GetBaseKey()
        {
            return RegistryKey.OpenBaseKey(
                RegistryHive.LocalMachine,
                Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
        }
        public static string macId()
        {
            return identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
        }

        private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() == "True")
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            return result;
        }
        //Return a hardware identifier
        private static string identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
    }
}
