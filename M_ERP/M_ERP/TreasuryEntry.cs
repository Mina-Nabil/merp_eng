using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace M_ERP
{
    class TreasuryEntry
    {
        MySqlCommand cmd;
        MySqlDataReader reader;

        public TreasuryEntry() {
            Varibles.setConnection();
            cmd = Varibles.getCommand();
        }

        public const int TE_IN = 1;
        public const int TE_OUT = 2;
        public const int TE_PAYABLES = 3;

        public void addToTreasury(Double inCount, Double outCount, DateTime TEDate, String TEComment, String OpTitle, int OpType, Int32 SpplrID , Int32 ClntID,Double TE_BLNCE )
        {
            String query;
            if(SpplrID == 0 && ClntID == 0) {
                query = "INSERT INTO `merp`.`treasuryentries` (`TE_IN`, `TE_OUT`, `TE_DATE`, `TE_OPTITLE`, `TE_CMMTS`," +
                                   " `TE_OPTYPE_ID` , `TE_BLNCE`)" +
                                   " VALUES ('" + inCount + "', '" + outCount + "', '" + TEDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + OpTitle + "', '" + TEComment + "',  " +
                                   "  '" + OpType + "' , '"+TE_BLNCE+"');";
            }

            else if (ClntID == 0)
            {
                query = "INSERT INTO `merp`.`treasuryentries` (`TE_IN`, `TE_OUT`, `TE_DATE`, `TE_OPTITLE`, `TE_CMMTS`," +
                               " `TE_SPPLR_ID`,  `TE_OPTYPE_ID` , `TE_BLNCE`)" +
                               " VALUES ('" + inCount + "', '" + outCount + "', '" + TEDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + OpTitle + "', '" + TEComment + "',  " +
                               "  '" + SpplrID + "', '" + OpType + "' , '" + TE_BLNCE + "');";
            }

            else 
            {

                query = "INSERT INTO `merp`.`treasuryentries` (`TE_IN`, `TE_OUT`, `TE_DATE`, `TE_OPTITLE`, `TE_CMMTS`," +
                                " `TE_CLNT_ID`, `TE_OPTYPE_ID` , `TE_BLNCE`)" +
                                " VALUES ('" + inCount + "', '" + outCount + "', '" + TEDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + OpTitle + "', '" + TEComment + "',  " +
                                "  '" + ClntID + "', '" + OpType + "' , '" + TE_BLNCE + "');";

            }
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }


    }
}
