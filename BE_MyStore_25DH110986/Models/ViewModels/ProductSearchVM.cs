using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace BE_MyStore_25DH110986.Models.ViewModels
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string SortOrder { get; set; }
        public int PageNumber { get; set; }//Trang hiện tại
        public int PageSize { get; set; } //Số sản phẩm mỗi trang
        public PagedList.IPagedList<Product> Products { get; set; }
    }
}