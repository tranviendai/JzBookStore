﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên Sách")]
        [StringLength(50)]
        [Display(Name ="Tên Sách")]
        public string title { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập đơn vị tính")]
        [StringLength(24)]
        [Display(Name ="Đơn Vị")]
        public string unit { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00.###}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Vui lòng nhập giá tiền")]
        [Display(Name = "Giá Tiền")]
        public decimal price { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập mô tả về sách")]
        [StringLength(1000)]
        [Display(Name ="Mô Tả")]
        public string description { get; set; }

        [DataType(DataType.Upload)]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        [Display(Name ="Hình Ảnh")]
        public string image { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name ="Ngày Cập Nhật")]
        public DateTime updateDate { get; set; }
        [Display(Name ="Số lượng bán")]
        public int sellNumber { get; set; }

        [Display(Name = "Chủ đề")]
        public int subjectID { get; set; }
        [ForeignKey("subjectID")]
        public Subject subject { get; set; }

        public int publisherID { get; set; }
        [ForeignKey("publisherID")]

        public Publisher publisher { get; set; }

        ICollection<Author> Author { get; set; }
    }
}