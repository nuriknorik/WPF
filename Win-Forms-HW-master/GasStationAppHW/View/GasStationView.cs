using WinFormsApp6.Models;
using WinFormsApp6.Presenter;
using WinFormsApp6.View;

namespace WinFormsApp6
{
    public partial class GasStationView : Form
    {
        public GasStationPresenter gasStationPresenter { get; set; }
        public List<TotalPriceProductTransactions> transactions = new List<TotalPriceProductTransactions>();
        public GasStationView()
        {
            gasStationPresenter = new GasStationPresenter(this);
            InitializeComponent();
        }

        public delegate void Sum();
        private void CountDog_textBox_Click(object sender, EventArgs e) => gasStationPresenter.NewCount_textBox_Click(CountDog_textBox);
        private void HumCount_textBox_Click(object sender, EventArgs e) => gasStationPresenter.NewCount_textBox_Click(HumCount_textBox);
        private void PotatoCount_textBox_Click(object sender, EventArgs e) => gasStationPresenter.NewCount_textBox_Click(PotatoCount_textBox);
        private void CokaColaCount_textBox_Click(object sender, EventArgs e) => gasStationPresenter.NewCount_textBox_Click(CokaColaCount_textBox);
        private void textBox3_Click(object sender, EventArgs e) => gasStationPresenter.NewCount_textBox_Click(textBox3, '0');
        private void textBox4_Enter(object sender, EventArgs e) => gasStationPresenter.NewCount_textBox_Click(textBox4, '0');

        private void CountDog_textBox_Leave(object sender, EventArgs e) => gasStationPresenter.CountTextBoxLeave(CountDog_textBox, Sum_Product);
        private void HumCount_textBox_Leave(object sender, EventArgs e) => gasStationPresenter.CountTextBoxLeave(HumCount_textBox, Sum_Product);
        private void PotatoCount_textBox_Leave(object sender, EventArgs e) => gasStationPresenter.CountTextBoxLeave(PotatoCount_textBox, Sum_Product);
        private void CokaColaCount_textBox_Leave(object sender, EventArgs e) => gasStationPresenter.CountTextBoxLeave(CokaColaCount_textBox, Sum_Product);
        private void textBox3_Leave(object sender, EventArgs e) => gasStationPresenter.CountTextBoxLeave(textBox3, SumOilLitr, '0');
        private void textBox4_Leave(object sender, EventArgs e) => gasStationPresenter.CountTextBoxLeave(textBox4, SumOilCash, '0');

        #region Sum 
        public void SumOilLitr()
        {
            float Litr = Convert.ToSingle(textBox3.Text);
            float PriceOil = Convert.ToSingle(PriceOil_textBox.Text);
            Gas_Total_textBox.Text = (Litr * PriceOil).ToString();
            textBox4.Text = Gas_Total_textBox.Text;
        }
        public void SumOilCash()
        {
            float Cash = Convert.ToSingle(textBox4.Text);
            float PriceOil = Convert.ToSingle(PriceOil_textBox.Text);
            Gas_Total_textBox.Text = Cash.ToString();
            textBox3.Text = (Cash / PriceOil).ToString();
        }
        public void Sum_Product()
        {
            float sum = 0;
            if (!CountDog_textBox.ReadOnly) sum += Convert.ToSingle(CountDog_textBox.Text) * 4;
            if (!HumCount_textBox.ReadOnly) sum += Convert.ToSingle(HumCount_textBox.Text) * 5.4f;
            if (!PotatoCount_textBox.ReadOnly) sum += Convert.ToSingle(PotatoCount_textBox.Text) * 7.2f;
            if (!CokaColaCount_textBox.ReadOnly) sum += Convert.ToSingle(CokaColaCount_textBox.Text) * 4.4f;
            TotalCafetextBox.Text = sum.ToString();
        }
        #endregion
        private void CountDog_textBox_KeyPress(object sender, KeyPressEventArgs e) => gasStationPresenter.TextCheckedNumber(e, CountDog_textBox, 2);
        private void HumCount_textBox_KeyPress(object sender, KeyPressEventArgs e) => gasStationPresenter.TextCheckedNumber(e, HumCount_textBox, 2);
        private void PotatoCount_textBox_KeyPress(object sender, KeyPressEventArgs e) => gasStationPresenter.TextCheckedNumber(e, PotatoCount_textBox, 2);
        private void CokaColaCount_textBox_KeyPress(object sender, KeyPressEventArgs e) => gasStationPresenter.TextCheckedNumber(e, CokaColaCount_textBox, 2);
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) => gasStationPresenter.TextCheckedNumber(e, textBox3, 3);
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) => gasStationPresenter.TextCheckedNumber(e, textBox4, 3);

        private void HotDog_checkBox_CheckedChanged(object sender, EventArgs e) => ProductCheckBoxChaqnged(HotDog_checkBox, CountDog_textBox);
        private void Hamburger_checkBox_CheckedChanged(object sender, EventArgs e) => ProductCheckBoxChaqnged(Hamburger_checkBox, HumCount_textBox);
        private void Potato_checkBox_CheckedChanged(object sender, EventArgs e) => ProductCheckBoxChaqnged(Potato_checkBox, PotatoCount_textBox);
        private void Coka_Cola_checkBox4_CheckedChanged(object sender, EventArgs e) => ProductCheckBoxChaqnged(Coka_Cola_checkBox4, CokaColaCount_textBox);
        private void ProductCheckBoxChaqnged(CheckBox box, TextBox textBox)
        {
            if (box.Checked == false)
            {
                textBox.Text = "0";
                textBox.BackColor = Color.LightGray;
                textBox.ReadOnly = true;
                Sum_Product();
            }
            else
            {
                textBox.Text = "1";
                textBox.BackColor = Color.White;
                textBox.ReadOnly = false;
                Sum_Product();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => gasStationPresenter.PriceSelectedOil(Oil_Select_comboBox, PriceOil_textBox);

        private void LitrOil_radioButton_CheckedChanged(object sender, EventArgs e) => Oil_radioButton_CheckedChanged(LitrOil_radioButton, textBox3);
        private void CashOil_radioButton_CheckedChanged(object sender, EventArgs e) => Oil_radioButton_CheckedChanged(CashOil_radioButton, textBox4);
        public void Oil_radioButton_CheckedChanged(RadioButton radio, TextBox textBox)
        {
            textBox.Text = "0";
            Gas_Total_textBox.Text = "0";
            if (radio.Checked == true)
            {
                textBox.BackColor = Color.White;
                textBox.ReadOnly = false;
            }
            else
            {
                textBox.BackColor = Color.LightGray;
                textBox.ReadOnly = true;
            }
        }
        private void TotalButton_Click(object sender, EventArgs e)
        {
            float totalCafe = Convert.ToSingle(TotalCafetextBox.Text);
            float totalGas = Convert.ToSingle(Gas_Total_textBox.Text);
            TotalSum.Text = (totalCafe + totalGas).ToString();
            TotalPriceProductTransactions productTransactions = new TotalPriceProductTransactions()
            {
                TotalCafe = totalCafe,
                TotalGasStation = totalGas,
            };
            gasStationPresenter.AddTransactions(transactions, productTransactions);
        }
  
        private void HistoryButton_Click(object sender, EventArgs e)
        {
        var oilPaymentHistoryView = new OilPaymentHistoryView(this);
            oilPaymentHistoryView.Show();
            this.Hide();
        }
    }

    
}

