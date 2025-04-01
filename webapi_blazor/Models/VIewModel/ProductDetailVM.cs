using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
namespace webapi_blazor.Models.ViewModel
{
    public class ProductDetailVM
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ListImage { get; set; } ="[]";// Có thể là URL hoặc đường dẫn đến hình ảnh

        [NotMapped]
        public List<string> ImgList {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
            get;
            //get => hàm xử lý
            set;
        } = new List<string>();
        public ProductDetailVM(){
            List<ImageUrlVM> lst = JsonSerializer.Deserialize<List<ImageUrlVM>>(ListImage);
            foreach(var img in lst){
                ImgList.Add(img.ImageUrl);
            }
        }
    }
    public class ProductDetailResultVM
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ImageUrlVM> ListImage { get; set; } = new List<ImageUrlVM>();// Có thể là URL hoặc đường dẫn đến hình ảnh
     
     
    }
}
public class ImageUrlVM {
    public string ImageUrl{get;set;} = "";
}