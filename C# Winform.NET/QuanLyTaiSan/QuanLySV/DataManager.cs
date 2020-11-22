using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    interface IDataManagerTLDHArcGISApp
    {
        void updateData();
    }
    class DataManager
    {
        public static DataManager DataManagerInstance;
        private List<IDataManagerTLDHArcGISApp> observers = new List<IDataManagerTLDHArcGISApp>();
        private Data data = new Data();
        public Data GetDetailData()
        {
            return this.data;
        }
        public void SetDetailData(Data _detailData)
        {
            this.data = _detailData;
            ///this.updateToLocal(Data);
            this.listenChange();
        }
        public void addObserver(IDataManagerTLDHArcGISApp DataManager)
        {
            observers.Add(DataManager);
        }
        public void removeObserver(IDataManagerTLDHArcGISApp DataManager)
        {
            observers.Remove(DataManager);
        }
        public void updateToLocal(Data _detailData)
        {
            /*this.Data = _detailData;*/
        }
        public void loadDataLocal()
        {
        }
        public static DataManager GetDataManager()
        {
            if (DataManagerInstance == null)
            {
                DataManagerInstance = new DataManager();
                DataManagerInstance.loadDataLocal();
            }
            return DataManagerInstance;
        }
        public void listenChange()
        {
            foreach (IDataManagerTLDHArcGISApp DataManager in observers.ToList())
            {
                DataManager.updateData();
            }
        }
    }
}
