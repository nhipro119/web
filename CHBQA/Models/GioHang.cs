using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHBQA.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int id_sp { get; set; }
        [Display(Name = "Tên Sản Phẩm")]
        public string ten_sp { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh1 { get; set; }
        [Display(Name = "Giá bán")]
        public int giaban { get; set; }
        [Display(Name = "Số lượng")]
        public int sl { get; set; }
        [Display(Name = "Thành tiền")]
        public Double dThanhtien
        {
            get { return sl * giaban; }
        }


        public GioHang(int id)
        {
            id_sp = id;
            SanPham sanpham = data.SanPhams.Single(n => n.id_sp == id_sp);
            ten_sp = sanpham.ten_sp;
            hinh1 = sanpham.hinh1;
            giaban = int.Parse(sanpham.giaban.ToString());
            sl = 1;
        }
    }
}