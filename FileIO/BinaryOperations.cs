using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FileIO
{
    class BinaryOperations
    {
        public static void BinarySerialization()
        {
            string path = @"C:\Users\223089864\Desktop\BridgeLabz\FileIO\BinaryFile.txt";
            PersonData data = new PersonData();
            data.name = "Priya";
            data.age = 21;
            data.phoneNum = 098765456;
            data.email = "abc@xyz.com";
            data.city = "chennai";
            data.state = "Tamil Nadu";
            data.addr = "Inforead Buildings";
            FileStream file = File.OpenWrite(path);
            //FileStream file = new FileStream(@"C:\Users\223089864\Desktop\BridgeLabz\FileIO\BinaryFile.txt", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, data);
            file.Close();
        }
        public static void BinaryDeserialization()
        {
            string path = @"C:\Users\223089864\Desktop\BridgeLabz\FileIO\BinaryFile.txt";
            FileStream file = File.OpenRead(path);
             
            BinaryFormatter formatter = new BinaryFormatter();
            PersonData person = (PersonData)formatter.Deserialize(file);
            Console.WriteLine("Person Details: ");
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.phoneNum);
            Console.WriteLine(person.email);
            Console.WriteLine(person.city);
            Console.WriteLine(person.state);
            Console.WriteLine(person.addr);
        }
        public static void JSONSerialization()
        {
            string path = @"C:\Users\223089864\Desktop\BridgeLabz\FileIO\JSONFile.json";
            PersonData person = new PersonData("Bhargav", 16, 0987678, "abc@xyz.com", "Chennai", "Tamil Nadu", "Greenwich Building");
            string result = JsonConvert.SerializeObject(person);
            File.WriteAllText(path, result);
            
        }
        public static void JSONDeserialize()
        {
            string path = @"C:\Users\223089864\Desktop\BridgeLabz\FileIO\JSONFile.json";
            string result = File.ReadAllText(path);
            PersonData person = JsonConvert.DeserializeObject<PersonData>(result);
            Console.WriteLine("Person Details: ");
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.phoneNum);
            Console.WriteLine(person.email);
            Console.WriteLine(person.city);
            Console.WriteLine(person.state);
            Console.WriteLine(person.addr);
        }
    }
}
