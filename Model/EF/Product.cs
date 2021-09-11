namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên sản phẩm ")]
        public string Name { get; set; }
       

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        [Display(Name = "Tiêu đề")]
        public string MetaTitle { get; set; }
        

        [StringLength(500)]
        [Display(Name = "Miêu tả")]
        public string Description { get; set; }
        

        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
       

        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }
        [Display(Name = "Giá bán")]
        public decimal? Price { get; set; }
       

        public decimal? PromotionPrice { get; set; }

        public bool? IncludedVAT { get; set; }

        public int Quantity { get; set; }
        [Display(Name = "Mã Danh mục")]
        public long? CategoryID { get; set; }
        

        [Column(TypeName = "ntext")]
        [Display(Name = "Chi tiết sản phẩm ")]
        public string Detail { get; set; }

        [Display(Name = "Chất lượng sản phẩm")]
        public int? Warranty { get; set; }
       

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        [Display(Name = "Từ khóa")]

        public string MetaKeywords { get; set; }
        
        [StringLength(250)]
        [Display(Name = "Mô tả từ khóa")]

        public string MetaDescriptions { get; set; }
        [Display(Name = "Trạng thái")]

        public bool? Status { get; set; }
       

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }
    }
}
