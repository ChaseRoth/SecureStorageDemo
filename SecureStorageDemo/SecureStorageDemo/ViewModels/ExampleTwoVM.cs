using SecureStorageDemo.Models;
using SecureStorageDemo.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureStorageDemo.ViewModels
{
    public class ExampleTwoVM : NotifyClass
    {
        private List<SaleInfo> salesInfos;
        public List<SaleInfo> SalesData {
            get => salesInfos;
            set
            {
                salesInfos = value;
                NotifyPropertyChanged();
            }
        }

        public ExampleTwoVM()
        {
            SalesData = new List<SaleInfo>
            {
                new SaleInfo { Year = "2002", Target = 300, Sale = 284 },
                new SaleInfo { Year = "2004", Target = 330, Sale = 382 },
                new SaleInfo { Year = "2006", Target = 180, Sale = 434 },
                new SaleInfo { Year = "2007", Target = 413, Sale = 581 },
                new SaleInfo { Year = "2009", Target = 620, Sale = 324 },
                new SaleInfo { Year = "2012", Target = 630, Sale = 882 }
            };
        }
    }
}
