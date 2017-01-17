using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrettyHair.Interfaces;
using System.Management;

namespace DatabaseLayer
{
    class GuidKeyGenerator : IKeyGenerator
    {
        private static volatile GuidKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static GuidKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new GuidKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        public string NextKey()
        {
            return Guid.NewGuid().ToString();
        }
    }

    class CustomerKeyGenerator : IKeyGenerator
    {
        private static volatile CustomerKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static CustomerKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new CustomerKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private int nextKey;

        private CustomerKeyGenerator()
        {
            
        }

        public virtual string NextKey()
        {
            nextKey++;
            return nextKey.ToString();
        }
    }

    class ProductKeyGenerator
    {
        private static volatile ProductKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static ProductKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new ProductKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private string nextKey;
        
        private ProductKeyGenerator()
        {

        }

        public virtual string NextKey()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }

            DateTime date = new DateTime();
            string dato = date.ToString("yyyyMMddHmmss");
            nextKey = dato + cpuInfo;
            return nextKey;
        }
    }
}
