using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DataStorage
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;


            }
        }
        private List<RawDataItem> rawdata;
        private List<SummaryDataItemPurchase> sumdataPurchase;
        private List<SummaryDataItemSale> sumdataSale;
        private char devider = '%';
        public DataStorage() { }

        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Name = items[0].Trim(),
                        //Part = items[1].Trim(),
                        Group = Convert.ToInt32(items[1].Trim()),
                        PurchasePrice = Convert.ToDouble(items[2].Trim()),
                        SalePrice = Convert.ToDouble(items[3].Trim()),
                        Count = Convert.ToSingle(items[4].Trim())
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummarySale();
                BuildSummaryPurchase();
            }
            catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        private void BuildSummarySale()
        {
            Dictionary<int, double> tmp = new Dictionary<int, double>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Group))
                {
                    tmp[item.Group] += item.SalePrice;
                }
                else
                {
                    tmp[item.Group] = item.SalePrice;
                }
            }

            sumdataSale = new List<SummaryDataItemSale>();
            foreach (var item in tmp)
            {
                sumdataSale.Add(new SummaryDataItemSale()
                {
                    GroupName = Utils.GetGroupByNumber(item.Key),
                    GroupSummSale = item.Value,
                });
            }
        }

        private void BuildSummaryPurchase()
        {
            Dictionary<int, double> tmp = new Dictionary<int, double>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Group))
                {
                    tmp[item.Group] += item.PurchasePrice;
                }
                else
                {
                    tmp[item.Group] = item.PurchasePrice;
                }
            }

            sumdataPurchase = new List<SummaryDataItemPurchase>();
            foreach (var item in tmp)
            {
                sumdataPurchase.Add(new SummaryDataItemPurchase()
                {
                    GroupName = Utils.GetGroupByNumber(item.Key),
                    GroupSummPurchase = item.Value,

                });
            }
        }

        public static DataStorage DataCreator(String path)
        {

            DataStorage d = new DataStorage();
            if (d.InitData(path))
            {
                return d;
            }
            else
            {
                return null;
            }
        }

        public List<RawDataItem> GetRawData()
        {

            if (this.IsReady)
            {
                return rawdata;
            }
            else
            {
                return null;
            }
        }

        public List<SummaryDataItemPurchase> GetSummaryDataPurchase()
        {
            if (this.IsReady)
            {
                return sumdataPurchase;
            }
            else
            {
                return null;
            }
        }

        public List<SummaryDataItemSale> GetSummaryDataSale()
        {
            if (this.IsReady)
            {
                return sumdataSale;
            }
            else
            {
                return null;
            }
        }
    }
}
