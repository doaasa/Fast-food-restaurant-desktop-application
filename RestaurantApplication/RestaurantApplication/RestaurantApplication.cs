using System.Security.Cryptography.X509Certificates;

namespace RestaurantApplication
{
    public partial class RestaurantApplication : Form
    {
        public RestaurantApplication()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCB.Checked == true)
            {
                FriesTB.Enabled = true;
            }
            if (FriesCB.Checked == false)
            {
                FriesTB.Enabled = false;
                FriesTB.Text = "0";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLBL.Text = DateTime.Now.ToLongTimeString();
        }

        private void RestaurantApplication_Load(object sender, EventArgs e)
        {
            DateLBL.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            FriesTB.Text = "0";
            ChickenTB.Text = "0";
            BurgerTB.Text = "0";
            BurritoTB.Text = "0";
            CoffeeTB.Text = "0";
            DonutsTB.Text = "0";
            HotdogTB.Text = "0";
            MilkshakeTB.Text = "0";
            PancakesTB.Text = "0";
            WaterTB.Text = "0";
            TeaTB.Text = "0";
            TacoTB.Text = "0";

        }


        private void BurgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCB.Checked == true)
            {
                BurgerTB.Enabled = true;
            }
            if (BurgerCB.Checked == false)
            {
                BurgerTB.Enabled = false;
                BurgerTB.Text = "0";
            }
        }

        private void TacoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TacoCB.Checked == true)
            {
                TacoTB.Enabled = true;
            }
            if (TacoCB.Checked == false)
            {
                TacoTB.Enabled = false;
                TacoTB.Text = "0";
            }
        }

        private void BurritoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BurritoCB.Checked == true)
            {
                BurritoTB.Enabled = true;
            }
            if (BurritoCB.Checked == false)
            {
                BurritoTB.Enabled = false;
                BurritoTB.Text = "0";
            }
        }

        private void HotdogCB_CheckedChanged(object sender, EventArgs e)
        {
            if (HotdogCB.Checked == true)
            {
                HotdogTB.Enabled = true;
            }
            if (HotdogCB.Checked == false)
            {
                HotdogTB.Enabled = false;
                HotdogTB.Text = "0";
            }
        }

        private void ChickenCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCB.Checked == true)
            {
                ChickenTB.Enabled = true;
            }
            if (ChickenCB.Checked == false)
            {
                ChickenTB.Enabled = false;
                ChickenTB.Text = "0";
            }
        }

        private void TeaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCB.Checked == true)
            {
                TeaTB.Enabled = true;
            }
            if (TeaCB.Checked == false)
            {
                TeaTB.Enabled = false;
                TeaTB.Text = "0";
            }
        }

        private void CoffeeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCB.Checked == true)
            {
                CoffeeTB.Enabled = true;
            }
            if (CoffeeCB.Checked == false)
            {
                CoffeeTB.Enabled = false;
                CoffeeTB.Text = "0";
            }
        }

        private void WaterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCB.Checked == true)
            {
                WaterTB.Enabled = true;
            }
            if (WaterCB.Checked == false)
            {
                WaterTB.Enabled = false;
                WaterTB.Text = "0";
            }
        }

        private void DonutsCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DonutsCB.Checked == true)
            {
                DonutsTB.Enabled = true;
            }
            if (DonutsCB.Checked == false)
            {
                DonutsTB.Enabled = false;
                DonutsTB.Text = "0";
            }
        }

        private void PancakeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakeCB.Checked == true)
            {
                PancakesTB.Enabled = true;
            }
            if (PancakeCB.Checked == false)
            {
                PancakesTB.Enabled = false;
                PancakesTB.Text = "0";
            }
        }

        private void MilkshakeCB_CheckedChanged(object sender, EventArgs e)
        {

            if (MilkshakeCB.Checked == true)
            {
                MilkshakeTB.Enabled = true;
            }
            if (MilkshakeCB.Checked == false)
            {
                MilkshakeTB.Enabled = false;
                MilkshakeTB.Text = "0";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            FriesTB.Text = "0";
            ChickenTB.Text = "0";
            BurgerTB.Text = "0";
            BurritoTB.Text = "0";
            CoffeeTB.Text = "0";
            DonutsTB.Text = "0";
            HotdogTB.Text = "0";
            MilkshakeTB.Text = "0";
            PancakesTB.Text = "0";
            WaterTB.Text = "0";
            TeaTB.Text = "0";
            TacoTB.Text = "0";

            FriesCB.Checked = false;
            ChickenCB.Checked = false;
            BurgerCB.Checked = false;
            TacoCB.Checked = false;
            HotdogCB.Checked = false;
            BurritoCB.Checked = false;
            TeaCB.Checked = false;
            CoffeeCB.Checked = false;
            WaterCB.Checked = false;
            DonutsCB.Checked = false;
            PancakeCB.Checked = false;
            MilkshakeCB.Checked = false;

            SubtotalLBL.Text = "";
            TotalLBL.Text = "";
            TaxLBL.Text = "";
            ReceiptTB.Clear();
        }
        double friesTotal; double burgerTotal; double TacoTotal; double BurritoTotal; double HotdogTotal;
        double ChickenTotal; double TeaTotal; double WaterTotal; double CoffeeTotal; double DonutsTotal;
        double PancakeTotal; double MilkshakeTotal; double SubTotal = 0; double tax; double total;
        private void AddBTN_Click(object sender, EventArgs e)
        {
            double burgerUP = double.Parse(BurgerUP.Text);
            double friesUP = double.Parse(FriesUP.Text);
            double tacoUP = double.Parse(TacoUP.Text);
            double burritoUP = double.Parse(BurritoUP.Text);
            double hotdogUP = double.Parse(HotdogUP.Text);
            double chickenUP = double.Parse(ChickenUP.Text);

            double teaUP = double.Parse(TeaUP.Text);
            double waterUP = double.Parse(WaterUP.Text);
            double coffeeUP = double.Parse(CoffeeUP.Text);
            double donutsUP = double.Parse(DonutsUP.Text);
            double pancakeUP = double.Parse(PancakesUP.Text);
            double milkshakeUP = double.Parse(MilkshakeUP.Text);

            friesTotal = friesUP * Convert.ToDouble(FriesTB.Text);
            burgerTotal = burgerUP * Convert.ToDouble(BurgerTB.Text);
            TacoTotal = tacoUP * Convert.ToDouble(TacoTB.Text);
            BurritoTotal = burritoUP * Convert.ToDouble(BurritoTB.Text);

            HotdogTotal = hotdogUP * Convert.ToDouble(HotdogTB.Text);
            ChickenTotal = chickenUP * Convert.ToDouble(ChickenTB.Text);
            TeaTotal = teaUP * Convert.ToDouble(TeaTB.Text);
            WaterTotal = waterUP * Convert.ToDouble(WaterTB.Text);

            CoffeeTotal = coffeeUP * Convert.ToDouble(CoffeeTB.Text);
            DonutsTotal = donutsUP * Convert.ToDouble(DonutsTB.Text);
            PancakeTotal = pancakeUP * Convert.ToDouble(PancakesTB.Text);
            MilkshakeTotal = milkshakeUP * Convert.ToDouble(MilkshakeTB.Text);

            //Add the Receipt
            ReceiptTB.Clear();
            SubTotal = 0;
            ReceiptTB.AppendText(Environment.NewLine);
            ReceiptTB.AppendText("\t\t         FAST FOOD Restaurant\t\t" + DateLBL.Text + Environment.NewLine);
            ReceiptTB.AppendText("\t\t      *****************************" + Environment.NewLine);

            if (FriesCB.Checked == true)
            {
                ReceiptTB.AppendText("\tFries:\t" + friesTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + friesTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (BurgerCB.Checked == true)
            {
                ReceiptTB.AppendText("\tBurger:\t" + burgerTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + burgerTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }

            if (TacoCB.Checked == true)
            {
                ReceiptTB.AppendText("\tTaco:\t" + TacoTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + TacoTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (BurritoCB.Checked == true)
            {
                ReceiptTB.AppendText("\tBurrito:\t" + BurritoTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + BurritoTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (HotdogCB.Checked == true)
            {
                ReceiptTB.AppendText("\tHotdog:\t" + HotdogTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + HotdogTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (ChickenCB.Checked == true)
            {
                ReceiptTB.AppendText("\tChicken:\t" + ChickenTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + ChickenTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }

            if (TeaCB.Checked == true)
            {
                ReceiptTB.AppendText("\tTea:\t" + TeaTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + TeaTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (CoffeeCB.Checked == true)
            {
                ReceiptTB.AppendText("\tCoffee:\t" + CoffeeTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + CoffeeTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }

            if (WaterCB.Checked == true)
            {
                ReceiptTB.AppendText("\tWater:\t" + WaterTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + WaterTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (DonutsCB.Checked == true)
            {
                ReceiptTB.AppendText("\tDonuts:\t" + DonutsTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + DonutsTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }

            if (PancakeCB.Checked == true)
            {
                ReceiptTB.AppendText("\tPancakes:\t" + PancakeTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + PancakeTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            if (MilkshakeCB.Checked == true)
            {
                ReceiptTB.AppendText("\tMilkshake:\t" + MilkshakeTotal + "L.E" + Environment.NewLine);
                SubTotal = SubTotal + MilkshakeTotal;
                SubtotalLBL.Text = "" + SubTotal;
            }
            tax = SubTotal * .05;
            TaxLBL.Text = tax.ToString();
            total = tax + SubTotal;
            TotalLBL.Text = total.ToString();

        }

        private void PrintBTN_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK) 
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTB.Text+" Subtotal: "+
                SubtotalLBL.Text+"Tax: "+TaxLBL.Text+"Total: "+TotalLBL.Text,
                new Font("Gill Sans MT",13,FontStyle.Regular),Brushes.Blue,new Point(130));
        }
    }
}