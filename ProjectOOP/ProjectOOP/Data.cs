using ProjectOOP;
using System;
using System.IO;
using System.Text.Json;

public class Data
{
    private Food food;
    private Thing thing;
    private xThing xThing;
    private Trip trip;
    private string jsonT1;
    private string jsonT2;
    private string jsonT3;
    private string jsonT4;
    string compileInfoPath = @"C:\Users\ACER\Downloads\json.txt"; // Đường dẫn tới tệp tin lưu thông tin biên dịch
    string foodPath = @"C:\Users\ACER\Downloads\HangHoa.txt"; 

    public Data()
    {
        DateTime currentTime = DateTime.Today;
        food = new Food(currentTime, "59C Nguyễn Đình Chiểu - P. Võ Thị Sáu - Q.3", " 279 Nguyễn Tri Phương - P.5 - Q.10", "Food", 20, "xxx");
        thing = new Thing(currentTime, "279 Nguyễn Tri Phương - P.5 - Q.10", "91 Đường 3/2 - P.11 - Q.10", "Thing", 15, "yyy");
        xThing = new xThing(currentTime, "91 Đường 3/2 - P.11 - Q.10", "196 Trần Quang Khải - P. Tân Định - Q.1", "xThing", 15, "yyy");
        trip=new Trip (currentTime, "196 Trần Quang Khải - P. Tân Định - Q.1", "Đường Nguyễn Văn Linh, Khu chức năng số 15, Khu đô thị mới Nam thành phố, xã Phong Phú, huyện Bình Chánh", "Trip",30,"zzz");
        jsonT1 = JsonSerializer.Serialize(food);
        jsonT2 = JsonSerializer.Serialize(thing);
        jsonT3 = JsonSerializer.Serialize(trip);
        jsonT4 = JsonSerializer.Serialize(xThing);

        // Ghi thông tin biên dịch vào tệp tin
       //WriteCompileInfo();
    }

    private void WriteCompileInfo()
    {
        using (FileStream fs = new FileStream(compileInfoPath, FileMode.Append, FileAccess.Write))
        using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8))
        {
            sw.WriteLine(jsonT1); // Ghi JSON của food
            sw.WriteLine(jsonT2); // Ghi JSON của thing
            sw.WriteLine(jsonT3);
            sw.WriteLine(jsonT4);
        }
    }
    public void Serialize()
    {
        
        using (StreamWriter sw = new StreamWriter(compileInfoPath))
        {
            sw.WriteLine(jsonT1); // Ghi JSON của food
            sw.WriteLine(jsonT2); // Ghi JSON của thing
            sw.WriteLine(jsonT3); // Ghi JSON của trip
            sw.WriteLine(jsonT4);
            sw.Flush();
        }
    }
    public Products Deserialize(int typeProduct)
    {
        string jsonString = ReadSpecificLine(compileInfoPath, typeProduct);
        Products deserializeProduct = JsonSerializer.Deserialize<Products>(jsonString);

        return deserializeProduct;
    }

    public string ReadSpecificLine(string filePath,int specificLine)
    {
        using(StreamReader sr = new StreamReader(filePath))
        {
            for(int i=0; i < specificLine; i++)
            {
                //sr.ReadLine();               
            }
            string jsonSpecificLine = sr.ReadLine();
            return jsonSpecificLine;
        }
    }

    public void HienThiGia()
    {

    }

}
