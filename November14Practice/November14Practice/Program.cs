using November14Practice;
using November14Practice.Models;

string root = Directory.GetCurrentDirectory();

string directortPath = Path.Combine(root, "../../../Data");
string filePath = Path.Combine(directortPath, "jsondata.json");

if(!Directory.Exists(directortPath))
    Directory.CreateDirectory(directortPath);

if(!File.Exists(filePath))
    File.Create(filePath);


var data = await Helper.GetDataFromWeb("https://jsonplaceholder.typicode.com/posts");

var list = Helper.DeserializeObject<List<CustomObject>>(data);

var serialisedObject = Helper.SerializeObject(list);

Helper.WriteToFile(filePath, serialisedObject);
