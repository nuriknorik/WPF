using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp6.Models;
using WinFormsApp6.View;

namespace WinFormsApp6.Presenter
{
    public class OilPaymentHistoryPresenter
    {
        public OilPaymentHistoryView View;

        public OilPaymentHistoryPresenter(OilPaymentHistoryView paymentHistoryView)
        {
            View = paymentHistoryView;
        }

        public void SelectDeleteHistory(ListBox Oilhistory , List<TotalPriceProductTransactions> ListTotalPrices)
        {
            for (int i = Oilhistory.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int idx = Oilhistory.SelectedIndices[i];
                Oilhistory.Items.RemoveAt(idx);
                ListTotalPrices.RemoveAt(idx);
            }
        }

    }
}
