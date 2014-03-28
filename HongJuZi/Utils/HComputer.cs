using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using HongJuZi.Core;
using System.Net;

namespace HongJuZi.Utils
{
    public class HComputer: HObject
    {
        /// <summary>
        /// 得到CPU编号
        /// </summary>
        /// <returns></returns>
        public static string getCpu()
        {
            try {
                string strCpu = null;
                ManagementClass myCpu = new ManagementClass("Win32_Processor");
                ManagementObjectCollection myCpuConnection = myCpu.GetInstances();
                foreach (ManagementObject myObject in myCpuConnection) {
                    strCpu = myObject.Properties["Processorid"].Value.ToString();
                    break;
                }

                return strCpu;
            }
            catch (Exception ex) {
                return "";
            }
        }
 
      /// <summary>
      /// 得到硬盘卷标号
      /// </summary>
      /// <returns></returns>
       public static string GetDiskVolumeSerialNumber()
        {
            ManagementClass mc = 
                 new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObject disk = 
                 new ManagementObject("win32_logicaldisk.deviceid=\"E:\"");
            disk.Get();

            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }

        /// <summary>
        /// Get Mac
        /// </summary>
        /// <returns></returns>
       public static string GetNetCardMAC()
       {
           try {
               string stringMAC = "";
               ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration");
               ManagementObjectCollection MOC = MC.GetInstances();

               foreach (ManagementObject MO in MOC) {
                   if ((bool)MO["IPEnabled"] == true) {
                       stringMAC += MO["MACAddress"].ToString();

                   }
               }
               return stringMAC;
           }
           catch {
               return "";
           }
       }

        /// <summary>
        /// Get Local Ip Address
        /// </summary>
        /// <returns></returns>
       public static String getLocalIp()
       {
           string strHostName = Dns.GetHostName(); //得到本机的主机名
           IPHostEntry ipEntry = Dns.GetHostByName(strHostName); //取得本机IP
           string strAddr = ipEntry.AddressList[0].ToString();

           return(strAddr);       
        }

        //Get Local Mac Address
       public static string getLocalMac()
       {
           string mac = null;
           ManagementObjectSearcher query = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");
           ManagementObjectCollection queryCollection = query.Get();
           foreach (ManagementObject mo in queryCollection) {
               if (mo["IPEnabled"].ToString() == "True")
                   mac = mo["MacAddress"].ToString();
           }
           return (mac);
       }

    }
}
