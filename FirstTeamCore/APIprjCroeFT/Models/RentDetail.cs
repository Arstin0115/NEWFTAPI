﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace APIprjCroeFT.Models
{
    public partial class RentDetail
    {
        public RentDetail()
        {
            SelfOrder = new HashSet<SelfOrder>();
        }

        public int 租賃商店id { get; set; }
        public string 產品名稱 { get; set; }
        public string 產品說明 { get; set; }
        public int? 庫存 { get; set; }
        public string 圖片 { get; set; }
        public int? 數量 { get; set; }
        public int? 單日租金 { get; set; }
        public string 建立人 { get; set; }
        public DateTime? 建立時間 { get; set; }
        public string 修改人 { get; set; }
        public DateTime? 修改時間 { get; set; }

        public virtual ICollection<SelfOrder> SelfOrder { get; set; }
    }
}