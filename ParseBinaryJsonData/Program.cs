// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

byte[] jsonBinaryData = File.ReadAllBytes(@"SchoolStaff.json");
//Console.WriteLine(jsonBinaryData.Length);
string jsonStringData = Encoding.UTF8.GetString(jsonBinaryData);
//Console.WriteLine(jsonStringData);
SchoolStaff[] schoolStaff = JsonConvert.DeserializeObject<SchoolStaff[]>(jsonStringData);
Console.WriteLine(schoolStaff.Length);
foreach(SchoolStaff ss in schoolStaff)
{
    Console.WriteLine($"FirstName: {ss.FirstName} - LastName: {ss.LastName} - Grade: {ss.Grade}");
}