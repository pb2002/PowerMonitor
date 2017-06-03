using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Power_Monitor.Data
{
    class IOControl
    {
        public static Data CurrentData;
        public static void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("config.dat",FileMode.OpenOrCreate);
            try
            {
                CurrentData = (Data)formatter.Deserialize(fs);
            }
            catch(SerializationException e)
            {
                MessageBox.Show("An error occured during the loading process!\n"
                              + e.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrentData = new Data();
            }
            finally
            {
                fs.Close();
            }
        }
        public static void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("config.dat", FileMode.OpenOrCreate);
            try
            {
                formatter.Serialize(fs, CurrentData);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("An error occured during the saving process!\n"
                              + e.Message
                              + e.HResult,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
