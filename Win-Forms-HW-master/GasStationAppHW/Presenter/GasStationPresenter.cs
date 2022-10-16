using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp6.GasStationView;
using WinFormsApp6.Presenter;
using WinFormsApp6.Models;

namespace WinFormsApp6.Presenter
{
    public class GasStationPresenter
    {
        GasStationView View { get; set; }
        public GasStationPresenter(GasStationView stationView)
        {
            View = stationView;
        }

        public void NewCount_textBox_Click(TextBox box, char number = '1')
        {
            if (box.ReadOnly == false)
            {
                if (box.Text[0] == number)
                    box.Text = "";
            }
        }

        public void CountTextBoxLeave(TextBox box, Sum sum, char total = '1')
        {
            if (box.ReadOnly == false)
            {
                if (box.Text.Length == 0 || box.Text[0] == '0')
                    box.Text = total.ToString();
            }
            sum();
        }

        public void TextCheckedNumber(KeyPressEventArgs e, TextBox box, int MaxSize)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || box.Text.Length >= MaxSize && e.KeyChar != 8)
                e.Handled = true;
        }

        public void PriceSelectedOil(ComboBox Oil, TextBox PriceOil)
        {
            switch (Oil.SelectedIndex)
            {
                case 0:
                    PriceOil.Text = "3,20";
                    break;
                case 1:
                    PriceOil.Text = "3";
                    break;
                case 2:
                    PriceOil.Text = "2,80";
                    break;
                default:
                    PriceOil.Text = "2,60";
                    break;
            }
        }

        public void SaveToHistoryTransactions(TextBox GasTotal , TextBox CafeTotal)
        {
            var totalPriceProduct = new TotalPriceProductTransactions()
            {
                TotalCafe = Convert.ToSingle(CafeTotal.Text),
                TotalGasStation = Convert.ToSingle(GasTotal.Text),
            };
        }

        public void AddTransactions(List<TotalPriceProductTransactions> ListTransactions , TotalPriceProductTransactions transactions)
        {
            ListTransactions.Add(transactions);
        }

    }
}
