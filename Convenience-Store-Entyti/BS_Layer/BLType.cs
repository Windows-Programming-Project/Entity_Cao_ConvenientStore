using Convenience_Store_Entyti.UserControlGroup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
    class BLType
    {
        public DataTable TakeType()
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            var tys = from p in qlstoreEntity.Types select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("tID");
            dt.Columns.Add("tName");
            foreach (var p in tys)
            {
                dt.Rows.Add(p.tID, p.tName);
            }
            return dt;
        }
        public bool AddType(string tID, string tName,ref string err)
        {
            
            var qlstoreEntity = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);

            Type ty = new Type();
            ty.tID = tID; ty.tName = tName;
            qlstoreEntity.Types.Add(ty);
            qlstoreEntity.SaveChanges();
            return true;
        }
        public bool DeleteType(ref string err, string tID)
        {
            
            var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
                Type ty = new Type();
            ty.tID = tID;
            dbContext.Types.Attach(ty);
            dbContext.Types.Remove(ty);
            dbContext.SaveChanges();
            return true;
        }
        public bool UpdateType(string tID, string tName, ref string err)
        {
            
            var dbContext = new ConvenienceStoreManagementEntities1( UserControlAcountLogin.UserLogin, UserControlAcountLogin.Password);
                var tyQuery = (from ty in dbContext.Types
                           where ty.tID == tID
                           select ty).SingleOrDefault();
            if (tyQuery != null)
            {
                tyQuery.tName = tName;
                dbContext.SaveChanges();
            }
            return true;
        }
    }
}
