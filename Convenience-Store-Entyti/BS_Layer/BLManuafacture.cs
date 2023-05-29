using Convenience_Store_Entyti.UserControlGroup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLManuafacturer
    {
        public DataTable TakeManuafacturer()
        {
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            var mas = from p in qlstoreEntity.Manuafacturers select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("mID");
            dt.Columns.Add("mName");
            dt.Columns.Add("mLocation");
            foreach (var p in mas)
            {
                dt.Rows.Add(p.mID, p.mName,p.mLocation);
            }
            return dt;
        }
        public bool AddManuafacturer(string mID, string mName,string mLocation, ref string err)
        {
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password); Manuafacturer ma = new Manuafacturer();
            ma.mID = mID; ma.mName = mName;ma.mLocation = mLocation;
            qlstoreEntity.Manuafacturers.Add(ma);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteManuafacturerr(ref string err, string mID)
        {
           
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password); 
            Manuafacturer ma = new Manuafacturer();
            ma.mID = mID;
            qlstoreEntity.Manuafacturers.Attach(ma);
            qlstoreEntity.Manuafacturers.Remove(ma);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool UpdateManuafacturer(string mID, string mName,string mLocation, ref string err)
        {
             var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
            var maQuery = (from ma in qlstoreEntity.Manuafacturers
                           where ma.mID == mID
                           select ma).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.mName = mName;
                maQuery.mLocation = mLocation;
                qlstoreEntity.SaveChanges();
            }
            return true;
        }
    }
}
