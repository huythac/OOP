using System.Runtime.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.Json;

namespace ProjectOOP
{
    public class Products
    {
        public DateTime CreateAt { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public string Customer { get; set; }
        public int Price { get; set; }
        public string Note { get; set; }



        public Products()
        {
        }

    }
}
