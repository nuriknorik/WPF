using System.Text;
using WinFormsApp6.Presenter;

namespace WinFormsApp6.View
{
    public partial class OilPaymentHistoryView : Form
    {
        public OilPaymentHistoryPresenter oilPaymentHistoryPresenter;
        public GasStationView gasStationView;
        public OilPaymentHistoryView(GasStationView stationView)
        {
            gasStationView = stationView;
            oilPaymentHistoryPresenter = new OilPaymentHistoryPresenter(this);
            InitializeComponent();
            OilHistoryPayment_listBox.Items.AddRange(gasStationView.transactions.ToArray());
        }

        private void ClearOilHistory_button_Click(object sender, EventArgs e)
        {
            OilHistoryPayment_listBox.Items.Clear();
            gasStationView.transactions.Clear();
        }

        private void SelectDeleteOil_Button_Click(object sender, EventArgs e) => oilPaymentHistoryPresenter.SelectDeleteHistory(OilHistoryPayment_listBox, gasStationView.transactions);
        private void OilPaymentHistoryView_FormClosing(object sender, FormClosingEventArgs e) => gasStationView.Show();
        private void Print_button_Click(object sender, EventArgs e)
        {
            var AllPrintOil = new StringBuilder();

            foreach (int item in OilHistoryPayment_listBox.SelectedIndices)
            {
                AllPrintOil.Append(gasStationView.transactions[item].LongToString());
            }
            MessageBox.Show(AllPrintOil.ToString());
        }
    }
}

