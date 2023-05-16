using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLSupplier
    {
        public DataTable TakeSupplier()
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var sups = from p in qlstoreEntity.Suppliers select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("sID");
            dt.Columns.Add("mID");
            dt.Columns.Add("sName");
            foreach (var p in sups)
            {
                dt.Rows.Add(p.sID, p.mID, p.sName);
            }
            return dt;
        }
        public bool AddSupplier(string sID, string mID, string sName, ref string err)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Supplier sup = new Supplier();
            sup.sID = sID; sup.mID = mID; sup.sName = sName;
            qlstoreEntity.Suppliers.Add(sup);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteSupplier(ref string err, string sID)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            Supplier sup = new Supplier();
            sup.sID = sID;
            qlstoreEntity.Suppliers.Attach(sup);
            qlstoreEntity.Suppliers.Remove(sup);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateSupplier(string sID, string mID, string sName, ref string err)
        {
            ConvenienceStoreManagementEntities1 qlstoreEntity = new ConvenienceStoreManagementEntities1();
            var supQuery = (from sup in qlstoreEntity.Suppliers
                           where sup.sID == sID
                           select sup).SingleOrDefault();
            if (supQuery != null)
            {
                supQuery.mID = mID;
                supQuery.sName = sName;
                qlstoreEntity.SaveChanges();
            }
            return true;
        }
    }
}
