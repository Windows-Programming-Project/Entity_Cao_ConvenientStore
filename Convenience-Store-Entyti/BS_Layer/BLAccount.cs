using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Entyti.BS_Layer
{
   class BLAccount
    {
        //public DataTable TakeAccount()
        //{
        //    ConvenienceStoreManagementEntities qlstoreEntity = new ConvenienceStoreManagementEntities();
        //    var det = from p in qlstoreEntity.Accounts select p;
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("aUsername");
        //    dt.Columns.Add("aPassword");
        //    dt.Columns.Add("eID");
        //    dt.Columns.Add("aEmail");
        //    dt.Columns.Add("Active");
        //    foreach (var p in det)
        //    {
        //        dt.Rows.Add(p.aUsername, p.aPassword, p.eID, p.aEmail,p.Active);
        //    }
        //    return dt;
        //}
        //public bool AddAccount(string aUsername, string aPassword, string eID, string aEmail, bool Active, ref string err)
        //{
        //    try
        //    {
        //        // create a new instance of the DbContext object
        //        ConvenienceStoreManagementEntities qlstoreEntity = new ConvenienceStoreManagementEntities();

        //        // create a new instance of the Account object and set its properties
        //        Account acc = new Account();
        //        acc.aUsername = aUsername;
        //        acc.aPassword = aPassword;
        //        acc.eID = eID;
        //        acc.aEmail = aEmail;
        //        acc.Active = Active;

        //        // add the account to the DbContext
        //        qlstoreEntity.Accounts.Add(acc);

        //        // save changes to the database
        //        qlstoreEntity.SaveChanges();

        //        // return true to indicate success
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // set the "err" parameter to the error message
        //        err = ex.Message;

        //        // return false to indicate failure
        //        return false;
        //    }
        //}
        //public bool UpdateAccount(string aUsername, string aPassword, string eID, string aEmail, bool Active, ref string err)
        //{
        //    try
        //    {
        //        // create a new instance of the DbContext object
        //        ConvenienceStoreManagementEntities qlstoreEntity = new ConvenienceStoreManagementEntities();

        //        // get the account to be updated from the DbContext
        //        Account acc = qlstoreEntity.Accounts.FirstOrDefault(a => a.aUsername == aUsername);

        //        if (acc != null)
        //        {
        //            // update the account properties
        //            acc.aPassword = aPassword;
        //            acc.eID = eID;
        //            acc.aEmail = aEmail;
        //            acc.Active = Active;

        //            // save changes to the database
        //            qlstoreEntity.SaveChanges();

        //            // return true to indicate success
        //            return true;
        //        }
        //        else
        //        {
        //            // set the "err" parameter to an error message
        //            err = "Account not found";

        //            // return false to indicate failure
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // set the "err" parameter to the error message
        //        err = ex.Message;

        //        // return false to indicate failure
        //        return false;
        //    }
        //}
        //public bool DeleteAccount(string aUsername, ref string err)
        //{
        //    try
        //    {
        //        // create a new instance of the DbContext object
        //        ConvenienceStoreManagementEntities qlstoreEntity = new ConvenienceStoreManagementEntities();

        //        // get the account to be deleted from the DbContext
        //        Account acc = qlstoreEntity.Accounts.FirstOrDefault(a => a.aUsername == aUsername);

        //        if (acc != null)
        //        {
        //            // remove the account from the DbContext
        //            qlstoreEntity.Accounts.Remove(acc);

        //            // save changes to the database
        //            qlstoreEntity.SaveChanges();

        //            // return true to indicate success
        //            return true;
        //        }
        //        else
        //        {
        //            // set the "err" parameter to an error message
        //            err = "Account not found";

        //            // return false to indicate failure
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // set the "err" parameter to the error message
        //        err = ex.Message;

        //        // return false to indicate failure
        //        return false;
        //    }
        //}


    }
}
