using System.Runtime.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.Json;

namespace ProjectOOP.Class
{
    public class Products
    {
        public DateTime CreateAt { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string Type { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Note { get; set; }



        public Products()
        {
        }

    }
}
