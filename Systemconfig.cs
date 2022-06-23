using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace HMITranfer
{
    public class Systemconfig
    {
        private static readonly string Fileconfig = Directory.GetCurrentDirectory() + @"\" + "Config.xml";
        public static Config Config = new Config();
        public Systemconfig()
        {
            Config = GetData<Config>();
        }

        /// <summary>
        /// Get Config of Application from file system configuration
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetData<T>()
        {
            if (File.Exists(Fileconfig))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                Stream stream = new FileStream(Fileconfig, FileMode.Open);
                T mapping = (T)xmlSerializer.Deserialize(stream);
                stream.Close();
                return mapping;
            }
            else
            {
                T generic = (T)Activator.CreateInstance(typeof(T));

                //

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                Stream stream = new FileStream(Fileconfig, FileMode.Create);
                using (XmlWriter xmlwriter = new XmlTextWriter(stream, Encoding.UTF8))
                {
                    xmlSerializer.Serialize(xmlwriter, generic);
                    xmlwriter.Close();
                }
                stream.Close();
                return generic;
            }
        }
        /// <summary>
        /// Update Config of Application setting to file Sysyemconfig
        /// </summary>
        /// <param name="data">Systemconfig data type object</param>
        public static void UpdateData(object data)
        {
            Type type = data.GetType();
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (TextWriter textWriter = new StreamWriter(Fileconfig))
            {
                xmlSerializer.Serialize(textWriter, data);
                textWriter.Close();
            }
        }
    }
}
