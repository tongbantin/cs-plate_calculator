using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PlateCalculator : Form
    {
        public PlateCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Calculate()
        {
            var unit = "kg";
            var want = new List<Plate>();
            want.Add(new Plate() { weight = float.Parse(txt_wg1.Text), qty = Convert.ToInt32(txt_qty11.Text),price = Convert.ToInt32(textprice1.Text) });
            want.Add(new Plate() { weight = float.Parse(txt_wg2.Text), qty = Convert.ToInt32(txt_qty2.Text), price = Convert.ToInt32(textprice2.Text) });
            want.Add(new Plate() { weight = float.Parse(txt_wg3.Text), qty = Convert.ToInt32(txt_qty3.Text), price = Convert.ToInt32(textprice3.Text) });
            want.Add(new Plate() { weight = float.Parse(txt_wg4.Text), qty = Convert.ToInt32(txt_qty4.Text), price = Convert.ToInt32(textprice4.Text) });
            want.Add(new Plate() { weight = float.Parse(txt_wg5.Text), qty = Convert.ToInt32(txt_qty5.Text), price = Convert.ToInt32(textprice5.Text) });
            want.Add(new Plate() { weight = float.Parse(txt_wg6.Text), qty = Convert.ToInt32(txt_qty6.Text), price = Convert.ToInt32(textprice6.Text) });
            want = want.OrderBy(x => x.weight).ToList();
            var divide = rad_2dumbbell.Checked ? 4 : 2;
            var barwg = rad_barbell.Checked ? float.Parse(txt_bar_wg.Text) : float.Parse(txt_dum_wg.Text);
            displayPrice(want);
            var res = cal(want, divide);
            displayOutput(res, unit, barwg);
            
        }
        public List<Combination_result> cal(List<Plate> want, int divide_val = 2)
        {
            var newplate = want;
            var miss = want.Where(x => x.qty < divide_val || x.qty % divide_val != 0).ToList();
            newplate.ForEach(x => x.qty = x.qty / divide_val);
            miss.ForEach(x => newplate.Remove(x));
            var lstwg = new List<float>();
            foreach (var item in newplate)
            {
                for (int i = 0; i < item.qty; i++)
                {
                    lstwg.Add(item.weight);
                }
            }
            var res = GetCombination(lstwg);
            //foreach (var item in res)
            //{
            //    item.total *= 2;
            //    item.weight.AddRange(item.weight);
            //}
            return res;
        }
        public void displayPrice(List<Plate> plate)
        {
            var wg = 0f;
            var qty = 0;
            var price = 0f;
            foreach (var item in plate)
            {
                wg += item.weight * item.qty;
                qty += item.qty;
            }
            price = wg * float.Parse(txt_price.Text);
            lbl_totalwg.Text = wg.ToString();
            lbl_totalqty.Text = qty.ToString();
            lbl_totalprice.Text = price.ToString();
            lbltotalpriceqty.Text = plate.Sum(x => x.price * x.qty).ToString();

        }
        public void Clear() {
            txt_Result.Clear();
            lbl_totalwg.Text = "0";
            lbl_totalqty.Text = "0";
            lbl_totalprice.Text = "0";
        }
        public void displayOutput(List<Combination_result> data, string unit, float barweight = 0)
        {
            txt_Result.Text += String.Format("   =====   {0} {1} /{2}lbs"+Environment.NewLine + Environment.NewLine, barweight, unit, Math.Round(2.20462262 * barweight, 2));
            foreach (var item in data)
            {
                var totalkg = (item.total * 2) + barweight;
                var totallb = Math.Round(2.20462262 * totalkg,2);
                var str = String.Format("( {0} )=====( {1} ) = {2} {3} /{4} lbs", String.Join(" | ", item.weight), String.Join(" | ", item.weight.OrderByDescending(x => x)), totalkg, unit, totallb);
                txt_Result.Text += str + Environment.NewLine + Environment.NewLine;
            }
        }
        static List<Combination_result> GetCombination(List<float> list)
        {
            var result_lst = new List<Combination_result>();
            var strtset = "";
            double count = Math.Pow(2, list.Count);
            List<float> m_total = new List<float>();
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                strtset += str + " ";
                var total = 0f;
                List<string> txtmem = new List<string>();
                for (int j = 0; j < str.Length; j++)
                {

                    if (str[j] == '1')
                    {
                        total += list[j];
                        txtmem.Add(list[j].ToString());
                    }
                }
                if (!m_total.Contains(total))
                {
                    //Console.Write(String.Join("+", txtmem) + "=" + total);
                    //Console.WriteLine();
                    m_total.Add(total);
                    result_lst.Add(new Combination_result() { weight = txtmem, total = total });
                }

            }
            return result_lst.OrderBy(x => x.total).ToList();

        }
        public class Plate
        {
            public float weight { get; set; }
            public int qty { get; set; }
            public int price { get; set; }
        }
        public class Combination_result
        {
            public List<string> weight { get; set; }
            public float total { get; set; }
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            Clear();
            Calculate();
        }

        private void numeric_change(object sender, EventArgs e)
        {
            NumericUpDown tb = (NumericUpDown)sender;
            if (tb.Value%2!=0)
            {
                tb.Value += 1;
            }
        }
    }
}
