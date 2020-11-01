using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace M_ERP
{
    class InvLog
    {

        MySqlCommand cmd;
        MySqlDataReader reader;

        public InvLog() {
            Varibles.setConnection();
            cmd = Varibles.getCommand();
        }

        public void addToLog(int prodID, int inCount, int outCount, DateTime logDate, String logDesc, String OpName,int usr_id) { //old

            String query = "INSERT INTO `merp`.`inventory_log` (`INVLOG_PROD_ID`, `INVLOG_INCOUNT`, `INVLOG_OUTCOUNT`," +
                            " `INVLOG_DATE`, `INVLOG_DESC`, `INVLOG_OPTYPE` , `USR_ID`) VALUES" +
                            "('" + prodID + "', '" +  inCount + "', '" + outCount + "', '" + logDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + logDesc + "', '" + OpName + "' , '"+usr_id+"' )";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        
        }

        public void addToLog(int prodID, int inCount, int outCount, DateTime logDate, String logDesc, String OpName, int usr_id , int inv_id) // old
        {

            String query = "INSERT INTO `merp`.`inventory_log` (`INVLOG_PROD_ID`, `INVLOG_INCOUNT`, `INVLOG_OUTCOUNT`," +
                            " `INVLOG_DATE`, `INVLOG_DESC`, `INVLOG_OPTYPE` , `USR_ID` , `INVLOG_INV_ID`) VALUES" +
                            "('" + prodID + "', '" + inCount + "', '" + outCount + "', '" + logDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + logDesc + "', '" + OpName + "' , '" + usr_id + "' , '"+inv_id+"' )";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

        public void addToLog(int prodID, int inCount, int outCount, DateTime logDate, String logDesc, String OpName, int usr_id, int inv_id,double current_buyPrice , double current_sellPrice) // old
       {

            String query = "INSERT INTO `merp`.`inventory_log` (`INVLOG_PROD_ID`, `INVLOG_INCOUNT`, `INVLOG_OUTCOUNT`," +
                            " `INVLOG_DATE`, `INVLOG_DESC`, `INVLOG_OPTYPE` , `USR_ID` , `INVLOG_INV_ID`, `current_buy_price`, `current_sell_price`) VALUES" +
                            "('" + prodID + "', '" + inCount + "', '" + outCount + "', '" + logDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + logDesc + "', '" + OpName + "' , '" + usr_id + "' , '" + inv_id + "' , '" + current_buyPrice + "' , '"+ current_sellPrice + "' )";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

        public void addToLog(int prodID, int inCount, int outCount, DateTime logDate, String logDesc, String OpName, int usr_id, int inv_id, double current_buyPrice, double current_sellPrice, int inv_type_id) // new
        {

            String query = "INSERT INTO `merp`.`inventory_log` (`INVLOG_PROD_ID`, `INVLOG_INCOUNT`, `INVLOG_OUTCOUNT`," +
                            " `INVLOG_DATE`, `INVLOG_DESC`, `INVLOG_OPTYPE` , `USR_ID` , `INVLOG_INV_ID`, `current_buy_price`, `current_sell_price` , `invoice_type` ) VALUES" +
                            "('" + prodID + "', '" + inCount + "', '" + outCount + "', '" + logDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + logDesc + "', '" + OpName + "' , '" + usr_id + "' , '" + inv_id + "' , '" + current_buyPrice + "' , '" + current_sellPrice + "' , '" + inv_type_id + "' )";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

        public void addToLog(int prodID, int inCount, int outCount, DateTime logDate, String logDesc, String OpName, int usr_id, int inv_id, double current_buyPrice, double current_sellPrice, int inv_type_id,int current_blnc) // new
        {

            String query = "INSERT INTO `merp`.`inventory_log` (`INVLOG_PROD_ID`, `INVLOG_INCOUNT`, `INVLOG_OUTCOUNT`," +
                            " `INVLOG_DATE`, `INVLOG_DESC`, `INVLOG_OPTYPE` , `USR_ID` , `INVLOG_INV_ID`, `current_buy_price`, `current_sell_price` , `invoice_type` , `prd_current_blnc` ) VALUES" +
                            "('" + prodID + "', '" + inCount + "', '" + outCount + "', '" + logDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + logDesc + "', '" + OpName + "' , '" + usr_id + "' , '" + inv_id + "' , '" + current_buyPrice + "' , '" + current_sellPrice + "' , '" + inv_type_id + "' , '"+ current_blnc+"' )";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

        //, `INVLOG_INV_ID`
    }
}
