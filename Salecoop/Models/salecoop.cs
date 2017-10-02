using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salecoop.Models
{
    public class salecoop
    {
        [Key]
        public int idsale { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล เลขที่ใบเสนอราคา")]
        public string quotationNo { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dayindate { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล ผู้เสนอราคา")]
        public string useroffer { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล ชื่อสหกรณ์")]
        public string coopName { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล ลำดับ")]
        public string sequence { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล รายการ")]
        public string listorder { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล จำนวน")]
        public int amount { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล ราคาขาย(รวมVAT)")]
        public decimal salepricesumvat { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล ต้นทุน(รวมVAT)")]
        public decimal costsumvat { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล กำไรเบื้องต้น")]
        public decimal profitaftersale { get; set; }
        public string status { get; set; }
    }
}