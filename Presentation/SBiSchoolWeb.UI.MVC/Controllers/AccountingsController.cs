using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBiSchoolWeb.Business;
using SBiSchoolWeb.Entities;

namespace SBiSchoolWeb.UI.MVC.Controllers
{
    [HandleError]
    [Authorize]
    public class AccountingsController : Controller
    {
        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllAccounts()
        {
            AccountingComponent ac = new AccountingComponent();
            List<Account> Accounts = ac.GetAllAccounts();

            return View("AccountsListView", Accounts);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllAccountTypes()
        {
            AccountingComponent ac = new AccountingComponent();
            List<AccountType> AccountTypes = ac.GetAllAccountTypes();

            return View("AccountTypesListView", AccountTypes);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllChartofAccounts()
        {
            AccountingComponent ac = new AccountingComponent();
            List<COA> COAs = ac.GetAllChartofAccounts();

            return View("ChartOfAccountsListView", COAs);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllTransactionTypes()
        {
            AccountingComponent ac = new AccountingComponent();
            List<TransactionType> TransactionTypes = ac.GetAllTransactionTypes();

            return View("TransactionTypesListView", TransactionTypes);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllTransactionsAuthorizations()
        {
            AccountingComponent ac = new AccountingComponent();
            List<TransactionsAuthorization> TransactionsAuthorizations = ac.GetAllTransactionsAuthorizations();

            return View("TransactionsAuthorizationsListView", TransactionsAuthorizations);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllTransactions()
        {
            AccountingComponent ac = new AccountingComponent();
            List<Transaction> Transactions = ac.GetAllTransactions();

            return View("EnquiriesView", Transactions);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllBanks()
        {
            AccountingComponent ac = new AccountingComponent();
            List<Bank> Banks = ac.GetAllBanks();

            return View("BanksListView", Banks);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllEnquiries()
        {
            AccountingComponent ac = new AccountingComponent();
            List<Transaction> Transactions = ac.GetAllEnquiries();

            return View("EnquiriesView", Transactions);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllPayFees()
        {
            AccountingComponent ac = new AccountingComponent();
            List<Transaction> Transactions = ac.GetAllEnquiries();

            return View("PayFeesView", Transactions);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllGeneralPosts()
        {
            AccountingComponent ac = new AccountingComponent();
            List<Transaction> Transactions = ac.GetAllGeneralPosts();

            return View("GeneralPostsView", Transactions);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllBS_Level1s()
        {
            AccountingComponent ac = new AccountingComponent();
            List<BS_Level1> BS_Level1s = ac.GetAllBS_Level1s();

            return View("GeneralPostsView", BS_Level1s);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllBS_Level2s()
        {
            AccountingComponent ac = new AccountingComponent();
            List<BS_Level2> BS_Level2s = ac.GetAllBS_Level2s();

            return View("GeneralPostsView", BS_Level2s);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllPL_Level1s()
        {
            AccountingComponent ac = new AccountingComponent();
            List<PL_Level1> PL_Level1s = ac.GetAllPL_Level1s();

            return View("GeneralPostsView", PL_Level1s);
        }

        //[Authorize]
        [HandleError(View = "Error")]
        public ActionResult GetAllPL_Level2s()
        {
            AccountingComponent ac = new AccountingComponent();
            List<PL_Level2> PL_Level2s = ac.GetAllPL_Level2s();

            return View("GeneralPostsView", PL_Level2s);
        }





    }
}