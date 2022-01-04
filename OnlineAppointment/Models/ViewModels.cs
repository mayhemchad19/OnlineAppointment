using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAppointment.Models
{
    public class ViewModels
    {
    }

    public class SaleViewMOdel
    {
        public int SaleID { get; set; }
        public string  Customer { get; set; }
        public string OrderNumber { get; set; }
        public decimal? FinalTotal { get; set; }
        public decimal? Discount { get; set; }

        public string DiscountType { get; set; }

        public decimal? DiscountedPrice { get; set; } //try mo daw
    }


    public class SaleSummaryViewMOdel
    {
        public string SaleNumber { get; set; }
        public DateTime? Date { get; set; }
        //public string Date { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
      
        public decimal? UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }

        public decimal? Total { get; set; }

        public decimal? totaltotal { get; set; }

    }



}//ayan na sir ok na po ayusin mo nlng
//ok po thank you po ng marami