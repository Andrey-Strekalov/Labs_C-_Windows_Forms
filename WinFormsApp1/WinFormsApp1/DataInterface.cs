using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DataInterface
    {
        extern List<RawDataItem> GetRawData();
        extern List<SummaryDataItemSale> GetSummaryDataSale();
        extern List<SummaryDataItemPurchase> GetSummaryDataPurchase();
    }
}
