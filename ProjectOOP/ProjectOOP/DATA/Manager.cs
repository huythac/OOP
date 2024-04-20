using ProjectOOP.Class;
using System.Text.Json;

public class Manager
{
    string fileProductOrder = @"FilePathOrder.txt"; // Lịch sử các đơn đã hoàn thành
    string compileInfoPath = @"FilePathProducts.txt"; // Đường dẫn tới tệp tin lưu thông tin biên dịch
    private List<Products> globalProducts;
    public int index = new Random().Next(0, 8);

    public Manager()
    {
        globalProducts = new List<Products>();
        LoadDataFromFile(compileInfoPath);
    }

    public List<Products> GlobalProducts()
    {
        return globalProducts;
    }
    public void GetProducts(ListView lst)
    {
        foreach(Products pr in globalProducts)
        {
            if (pr.ProductName == "Gà Rán")
            {
                ListViewItem listViewItem = lst.Items.Add("1");
                listViewItem.SubItems.Add(pr.ProductName);
                listViewItem.SubItems.Add(pr.Type);
            }
            else if(pr.ProductName == "Quần Áo")
            {
                ListViewItem listViewItem = lst.Items.Add("2");
                listViewItem.SubItems.Add(pr.ProductName);
                listViewItem.SubItems.Add(pr.Type);
            }
            else if (pr.ProductName == "Bàn Ghế")
            {
                ListViewItem listViewItem = lst.Items.Add("3");
                listViewItem.SubItems.Add(pr.ProductName);
                listViewItem.SubItems.Add(pr.Type);
            }
            else
            {
                ListViewItem listViewItem = lst.Items.Add("4");
                listViewItem.SubItems.Add(pr.ProductName);
                listViewItem.SubItems.Add(pr.Type);
            }
        }
    }

    public void LoadDataFromFile(string filePath)
    {
        //sử dụng FileStream để đọc từng dòng trong file
        //Biến từng dòng json thành đối tượng
        //Lưu đối tượng vào productsList

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (StreamReader sr = new StreamReader(fs))
        {
            // Đọc từng dòng trong file
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                // Chuyển đổi từ JSON thành đối tượng Product
                Products product = JsonSerializer.Deserialize<Products>(line);

                // Thêm đối tượng vào danh sách
                globalProducts.Add(product);
            }
        }
    }

}