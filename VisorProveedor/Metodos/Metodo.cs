using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VisorProveedor.Metodos
{
    class Metodo
       
    {
        Conexion.Cone c = new Conexion.Cone();
        public DataTable Datos(string VendorID) 
        {   
            
              string sql = "select ap.InvoiceDate,ap.DueDate,ap.InvoiceNum,ap.DocInvoiceAmt,ap.DocInvoiceBal,cur.CurrSymbol, " +
            " ap.Description,ap.DiscountDate,ap.DocDiscountAmt,ap.DebitMemo,ap.PayHold,ap.InvoiceAmt,ap.InvoiceBal, " +
            " ap.DiscountAmt,ap.CurrencyCode,ap.GroupID,ap.VendorNum,ap.OpenPayable,ap.Rounding,ap.GLControlType,ap.CPay, " +
            " ap.DocRounding,ap.CPayLinked,ap.GLControlCode,ap.Rpt1DiscountAmt,ap.Rpt2DiscountAmt,ap.Rpt3DiscountAmt, " +
            " ap.Rpt1InvoiceAmt,ap.CPayDocInvoiceBal,ap.Rpt2InvoiceAmt,ap.CPayCheckNum,ap.Rpt3InvoiceAmt,ap.CPayCheckDate, " +
            " ap.Rpt1InvoiceBal,ap.CPayInvoiceBal,ap.Rpt2InvoiceBal,ap.Rpt3InvoiceBal,ap.Rpt1InvoiceVendorAmt, " +
            " ap.Rpt2InvoiceVendorAmt,ap.Rpt3InvoiceVendorAmt,ap.Rpt1PayAmounts,ap.Rpt2PayAmounts,ap.Rpt3PayAmounts, " +
            " ap.InPrice,ap.Rpt1Rounding,ap.Rpt2Rounding,ap.DevInt2,ap.DevDec1,ap.Rpt3Rounding,ap.DevDec2,ap.DevDec3, " +
            " ap.Rpt1TaxAmt,ap.DevDec4,ap.DevLog1,ap.Rpt2TaxAmt,ap.DevLog2,ap.DevChar1,ap.Rpt3TaxAmt,ap.DevChar2, " +
            " ap.DevDate1,ap.Rpt1UnpostedBal,ap.DevDate2,ap.PaymentNumber,ap.Rpt2UnpostedBal,ap.CycleCode,ap.Duration, " +
            " ap.Rpt3UnpostedBal,ap.EndDate,ap.MaxValueAmt,ap.RateGrpCode,ap.DocMaxValueAmt,ap.Rpt1MaxValueAmt, " +
            " ap.Rpt1CPayInvoiceBal,ap.Rpt2MaxValueAmt,ap.Rpt3MaxValueAmt,ap.Rpt2CPayInvoiceBal,ap.HoldInvoice, " +
            " ap.CopyLatestInvoice,ap.Rpt3CPayInvoiceBal,ap.OverrideEndDate,ap.CycleInactive,ap.AllowOverrideLI, " +
            " ap.RecurSource,ap.InstanceNum,ap.MatchedFromLI,ap.RecurBalance,ap.DocRecurBalance,ap.ApplyDate,ap.Rpt1RecurBalance, " +
            " ap.Rpt2RecurBalance,ap.FiscalYearSuffix,ap.Rpt3RecurBalance,ap.LastDate,ap.FiscalCalendarID,ap.IsRecurring, " +
            " ap.InvoiceNumList,ap.IsMaxValue,ap.CHISRCodeLine,ap.TaxPoint,ap.DMReason,ap.UrgentPayment,ap.TaxRateDate,  " +
            " ap.ReadyToCalc,ap.RecalcBeforePost,ap.GetDfltTaxIds,ap.PMUID,ap.HeadNum,ap.PayDiscDays,ap.TaxSvcID, " +
            " ap.PayDiscPer,ap.TWDeclareYear,ap.TWDeclarePeriod,ap.WithholdAmt,ap.APChkGrpID,ap.InvoiceType,ap.DocWithholdAmt, " +
            " ap.Rpt1WithholdAmt,ap.Rpt2WithholdAmt,ap.Rpt3WithholdAmt,ap.CustOverride,ap.PayDiscPartPay,ap.PIPayment, " +
            " ap.CorrectionInv,ap.TaxRateGrpCode,ap.LockTaxRate,ap.SEBankRef,ap.SEPayCode,ap.GUIFormatCode,ap.GUITaxTypeCode, " +
            " ap.GUIDeductCode,ap.ChangedBy,ap.ChangeDate,ap.PrePayHeadNum,ap.TaxDestination,ap.PrePayment,ap.APLOCID, " +
            " ap.Plant,ap.GUIImportTaxBasis,ap.DocGUIImportTaxBasis,ap.Rpt1GUIImportTaxBasis,ap.Rpt2GUIImportTaxBasis, " +
            " ap.Rpt3GUIImportTaxBasis,ap.OvrDefTaxDate,ap.ClaimRef,ap.EmpID,ap.InBankFile,ap.BankID,ap.SelfLegalNumber, " +
            " ap.SelfTranDocTypeID,ap.MainSite,ap.CardCode,ap.SiteCode,ap.BankGiroAcctNbr,ap.BranchID,ap.SupAgentName, " +
            " ap.SupAgentTaxRegNo,ap.NonDeductCode,ap.AssetTypeCode,ap.Cash,ap.CreditCard,ap.Normal,ap.CardID,ap.CardHolderTaxID, " +
            " ap.InvoiceNum,ap.CardMemberName,ap.Excluded,ap.Deferred,ap.NonDeductAmt,ap.NonDeductDocAmt,ap.NonDeductRpt1Amt, " +
            " ap.NonDeductRpt2Amt,ap.NonDeductRpt3Amt,ap.NonDeductVATAmt,ap.NonDeductVATDocAmt,ap.NonDeductVATRpt1Amt, " +
            " ap.NonDeductVATRpt2Amt,ap.NonDeductVATRpt3Amt,ap.ImportNum,ap.ImportedFrom,ap.ImportedDate,ap.AdvTaxInv ," +
            " ap.DocRounding,	ap.Rounding,ap.InvoiceVendorAmt,ap.Rpt1InvoiceAmt,ap.Rpt3InvoiceVendorAmt,ap.Rpt1TaxAmt,ap.Rpt2TaxAmt, " +
            " ap.Rpt3TaxAmt,ap.Rpt2Rounding,ap.Rpt3Rounding,ap.Rpt1InvoiceAmt,ap.Rpt2InvoiceAmt,ap.Rpt3InvoiceAmt,ap.Rpt1RecurBalance, " +
            " ap.Rpt1DiscountAmt,ap.Rpt2DiscountAmt,ap.Rpt3DiscountAmt,ap.Rpt1InvoiceBal,ap.Rpt2InvoiceBal,ap.Rpt3InvoiceBal, " +
            " ap.Rpt1UnpostedBal,ap.Rpt2UnpostedBal,ap.Rpt3UnpostedBal,ap.Rpt2RecurBalance,cur.CurrencyID,ap.ApplyDate, " +
            " ap.TranDocTypeID,ap.Rpt3RecurBalance,tdt.Description,tdt.SystemTranID,cre.CurrentRate,xs.UseTaxRate,ap.TranType, " +
            " ap.GuiImportTaxBasis,vb.IBANCode,vb.SwiftNum,ap.Rpt1TaxAmt,ap.Rpt2TaxAmt,ap.Rpt3TaxAmt,ap.DocTaxAmt,ap.TaxAmt, " +
            " ap.CustomsNumber,ap.ReceivedDate,ap.PrePaymentNum,ap.DocPrePaymentAmt,ap.PrePaymentAmt,ap.Rpt1PrePaymentAmt, " +
            " ap.Rpt2PrePaymentAmt,ap.Rpt3PrePaymentAmt,apl.Description,gc.Description,gt.Description,pm.Name,pm.SummarizePerCustomer, " +
            " pm.Type,ap.InvoiceNum,crg.Description,ap.LastDate,ap.RecurBalance,pm.PMUID,pm.CardCode,vb.BankName,vb.BankGiroAcctNbr, " + 
            " vb.BankAcctNumber,vb.SwiftNum,ap.InstanceNum,vb.IBANCode,vb.LocalBIC,vb.BankName,ac.Description," +
            " ad.Description, rc.Inactive,pt.TermsType " +

              " from Erp.Vendor v inner join Erp.APInvHed ap on v.VendorNum=ap.VendorNum " +
              " left outer join Erp.RecurringCycle rc on ap.CycleCode=rc.CycleCode " +
              " inner join Erp.PurTerms pt on v.TermsCode=pt.TermsCode " +
              " left outer join erp.AGDestination ad on ap.AGDestinationCode=ad.DestinationCode " +
              " left outer join Erp.AGCustoms ac on ap.AGCustomsCode=ac.CustomsCode " +
              " left outer join Erp.VendBank vb on v.VendorNum=vb.VendorNum " +
              " left outer join Erp.CurrRateGrp crg on ap.RateGrpCode=crg.RateGrpCode " +
              " left outer join Erp.PayMethod pm on vb.PMUID=pm.PMUID " +
              " left outer join Erp.GLCntrlType gt on ap.GLControlType=gt.GLControlType " +
              " left outer join Erp.GLCntrl gc on gt.GLControlType=gc.GLControlType "  +
              " left outer join Erp.Currency cur on crg.AltCrossCurrCode=cur.CurrencyCode " +
              " left outer join Erp.APLOC apl on cur.Company=apl.Company " +
              " left outer join Erp.XbSyst xs on cur.CurrencyCode=xs.GlobalCurrencyCode " +
              " left outer join Erp.CurrExRate cre on cur.CurrencyCode=cre.SourceCurrCode " +
        " left outer join Erp.TranDocType tdt on xs.THTaxRecDocType=tdt.TranDocTypeID where VendorID = '" + VendorID + " '";
             DataSet dtver = new DataSet();
             SqlDataAdapter sqd = new SqlDataAdapter(sql,c.cn);
             sqd.Fill(dtver,"Fila");
             return dtver.Tables["Fila"];

        }
        public DataTable Conid(string VendorID1)
        {
            Conexion.Cone c = new Conexion.Cone();
     string sql = "select VendorID,Name,VendorNum,City,State,Country From Erp.Vendor where VendorID like '%" + VendorID1 + "%' ";
            DataSet dtverid = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(sql, c.cn);
            sqd.Fill(dtverid, "Resul");
            return dtverid.Tables["Resul"];
        }
        public DataTable ConNum (int VendorNum1)
        {
          
       string sql = "select VendorID,Name,VendorNum,City,State,Country From Erp.Vendor where VendorNum = '" + VendorNum1 + " ' ";
            DataSet dtverNum = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(sql, c.cn);
            sqd.Fill(dtverNum, "Resul");
            return dtverNum.Tables["Resul"];
        }
        public DataTable ConNom(string VendorName)
        {

        string sql = "select VendorID,Name,VendorNum,City,State,Country From Erp.Vendor where name like '%" + VendorName + "%' ";
            DataSet dtverNom = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(sql, c.cn);
            sqd.Fill(dtverNom, "Resul");
            return dtverNom.Tables["Resul"];
        }
        public DataTable ConNAda()
        {
       
            string sql = "select VendorID,Name,VendorNum,City,State,Country From Erp.Vendor";
            DataSet dtverSINN = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(sql, c.cn);
            sqd.Fill(dtverSINN, "Resul");
            return dtverSINN.Tables["Resul"];
        }
        public DataTable PruebaGit()
        {

            string sql = "select top 500 CustNum, CustID, Name,Address1,Address2,Address3,City from Erp.Customer";
            DataSet dtverSINN = new DataSet();
            SqlDataAdapter sqd = new SqlDataAdapter(sql, c.cn);
            sqd.Fill(dtverSINN, "Resul");
            return dtverSINN.Tables["Resul"];
        }
    }
}
