using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;

namespace DailyBalanceSheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        int pets = 0;
        double schemeBottles = 0;
        double extraBottles = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private double ta = 0;
        private void Out1TextEdit1_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit1.EditValue) + Convert.ToDouble(Out2TextEdit1.EditValue) +
                         Convert.ToDouble(Out3TextEdit1.EditValue);
            OutTotalTextEdit1.Text = total.ToString();

            
        }

        private void Out2TextEdit1_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit1.EditValue) + Convert.ToDouble(Out2TextEdit1.EditValue) +
                         Convert.ToDouble(Out3TextEdit1.EditValue);
            OutTotalTextEdit1.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);
            SoldTextEdit1.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit1.EditValue);
            AmountTextEdit1.Text = amount.ToString();*/
        }

        private void Out3TextEdit1_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit1.EditValue) + Convert.ToDouble(Out2TextEdit1.EditValue) +
                  Convert.ToDouble(Out3TextEdit1.EditValue);
            OutTotalTextEdit1.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);
            SoldTextEdit1.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit1.EditValue);
            AmountTextEdit1.Text = amount.ToString();*/
        }

        private void Out1TextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit2.EditValue) + Convert.ToDouble(Out2TextEdit2.EditValue) +
                  Convert.ToDouble(Out3TextEdit2.EditValue);
            OutTotalTextEdit2.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);
            SoldTextEdit2.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();*/
        }
    

        private void Out2TextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit2.EditValue) + Convert.ToDouble(Out2TextEdit2.EditValue) +
                  Convert.ToDouble(Out3TextEdit2.EditValue);
            OutTotalTextEdit2.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);
            SoldTextEdit2.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();*/
        }

        private void Out3TextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit2.EditValue) + Convert.ToDouble(Out2TextEdit2.EditValue) +
                  Convert.ToDouble(Out3TextEdit2.EditValue);
            OutTotalTextEdit2.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);
            SoldTextEdit2.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();*/
        }

        private void Out1TextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit3.EditValue) + Convert.ToDouble(Out2TextEdit3.EditValue) +
                  Convert.ToDouble(Out3TextEdit3.EditValue);
            OutTotalTextEdit3.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);
            SoldTextEdit3.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();*/
        }

        private void Out2TextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit3.EditValue) + Convert.ToDouble(Out2TextEdit3.EditValue) +
                  Convert.ToDouble(Out3TextEdit3.EditValue);
            OutTotalTextEdit3.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);
            SoldTextEdit3.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();*/
        }

        private void Out3TextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit3.EditValue) + Convert.ToDouble(Out2TextEdit3.EditValue) +
                  Convert.ToDouble(Out3TextEdit3.EditValue);
            OutTotalTextEdit3.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);
            SoldTextEdit3.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();*/
        }

        private void Out1TextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit4.EditValue) + Convert.ToDouble(Out2TextEdit4.EditValue) +
                  Convert.ToDouble(Out3TextEdit4.EditValue);
            OutTotalTextEdit4.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit4.EditValue) - Convert.ToDouble(InTotalTextEdit4.EditValue);
            SoldTextEdit4.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit4.EditValue);
            AmountTextEdit4.Text = amount.ToString();*/
        }

        private void Out2TextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit4.EditValue) + Convert.ToDouble(Out2TextEdit4.EditValue) +
                     Convert.ToDouble(Out3TextEdit4.EditValue);
            OutTotalTextEdit4.Text = total.ToString();
        }

        private void Out3TextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit4.EditValue) + Convert.ToDouble(Out2TextEdit4.EditValue) +
                  Convert.ToDouble(Out3TextEdit4.EditValue);
            OutTotalTextEdit4.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit4.EditValue) - Convert.ToDouble(InTotalTextEdit4.EditValue);
            SoldTextEdit4.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit4.EditValue);
            AmountTextEdit4.Text = amount.ToString();*/
        }

        private void Out1TextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit5.EditValue) + Convert.ToDouble(Out2TextEdit5.EditValue) +
                  Convert.ToDouble(Out3TextEdit5.EditValue);
            OutTotalTextEdit5.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);
            SoldTextEdit5.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();*/
        }

        private void Out2TextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit5.EditValue) + Convert.ToDouble(Out2TextEdit5.EditValue) +
                  Convert.ToDouble(Out3TextEdit5.EditValue);
            OutTotalTextEdit5.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);
            SoldTextEdit5.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();*/
        }

        private void Out3TextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit5.EditValue) + Convert.ToDouble(Out2TextEdit5.EditValue) +
                  Convert.ToDouble(Out3TextEdit5.EditValue);
            OutTotalTextEdit5.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);
            SoldTextEdit5.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();*/
        }

        private void Out1TextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit6.EditValue) + Convert.ToDouble(Out2TextEdit6.EditValue) +
                  Convert.ToDouble(Out3TextEdit6.EditValue);
            OutTotalTextEdit6.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);
            SoldTextEdit6.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();*/
        }

        private void Out2TextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit6.EditValue) + Convert.ToDouble(Out2TextEdit6.EditValue) +
                  Convert.ToDouble(Out3TextEdit6.EditValue);
            OutTotalTextEdit6.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);
            SoldTextEdit6.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();*/
        }

        private void Out3TextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(Out1TextEdit6.EditValue) + Convert.ToDouble(Out2TextEdit6.EditValue) +
                  Convert.ToDouble(Out3TextEdit6.EditValue);
            OutTotalTextEdit6.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);
            SoldTextEdit6.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();*/
        }
        
        //in
        private void In1TextEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit1.EditValue) + Convert.ToDouble(In2TextEdit1.EditValue) +
                  Convert.ToDouble(In3TextEdit1.EditValue);
            InTotalTextEdit1.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);
            SoldTextEdit1.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit1.EditValue);
            AmountTextEdit1.Text = amount.ToString();*/
        }

        private void In2TextEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit1.EditValue) + Convert.ToDouble(In2TextEdit1.EditValue) +
                  Convert.ToDouble(In3TextEdit1.EditValue);
            InTotalTextEdit1.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);
            SoldTextEdit1.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit1.EditValue);
            AmountTextEdit1.Text = amount.ToString();*/
        }

        private void In3TextEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit1.EditValue) + Convert.ToDouble(In2TextEdit1.EditValue) +
                  Convert.ToDouble(In3TextEdit1.EditValue);
            InTotalTextEdit1.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);
            SoldTextEdit1.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit1.EditValue);
            AmountTextEdit1.Text = amount.ToString();*/
        }

        private void In1TextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit2.EditValue) + Convert.ToDouble(In2TextEdit2.EditValue) +
                     Convert.ToDouble(In3TextEdit2.EditValue);
            InTotalTextEdit2.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);
            SoldTextEdit2.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();*/
        }

        private void In2TextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit2.EditValue) + Convert.ToDouble(In2TextEdit2.EditValue) +
                                 Convert.ToDouble(In3TextEdit2.EditValue);
            InTotalTextEdit2.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);
            SoldTextEdit2.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();*/
        }

        private void In3TextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit2.EditValue) + Convert.ToDouble(In2TextEdit2.EditValue) +
                     Convert.ToDouble(In3TextEdit2.EditValue);
            InTotalTextEdit2.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);
            SoldTextEdit2.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();*/
        }

        private void In1TextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit3.EditValue) + Convert.ToDouble(In2TextEdit3.EditValue) +
                     Convert.ToDouble(In3TextEdit3.EditValue);
            InTotalTextEdit3.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);
            SoldTextEdit3.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();*/
        }

        private void In2TextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit3.EditValue) + Convert.ToDouble(In2TextEdit3.EditValue) +
                     Convert.ToDouble(In3TextEdit3.EditValue);
            InTotalTextEdit3.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);
            SoldTextEdit3.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();*/
        }

        private void In3TextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit3.EditValue) + Convert.ToDouble(In2TextEdit3.EditValue) +
                     Convert.ToDouble(In3TextEdit3.EditValue);
            InTotalTextEdit3.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);
            SoldTextEdit3.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();*/
        }

        private void In1TextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit4.EditValue) + Convert.ToDouble(In2TextEdit4.EditValue) +
                     Convert.ToDouble(In3TextEdit4.EditValue);
            InTotalTextEdit4.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit4.EditValue) - Convert.ToDouble(InTotalTextEdit4.EditValue);
            SoldTextEdit4.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit4.EditValue);
            AmountTextEdit4.Text = amount.ToString();*/
        }

        private void In2TextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit4.EditValue) + Convert.ToDouble(In2TextEdit4.EditValue) +
                     Convert.ToDouble(In3TextEdit4.EditValue);
            InTotalTextEdit4.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit4.EditValue) - Convert.ToDouble(InTotalTextEdit4.EditValue);
            SoldTextEdit4.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit4.EditValue);
            AmountTextEdit4.Text = amount.ToString();*/
        }

        private void In3TextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit4.EditValue) + Convert.ToDouble(In2TextEdit4.EditValue) +
                     Convert.ToDouble(In3TextEdit4.EditValue);
            InTotalTextEdit4.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit4.EditValue) - Convert.ToDouble(InTotalTextEdit4.EditValue);
            SoldTextEdit4.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit4.EditValue);
            AmountTextEdit4.Text = amount.ToString();*/
        }

        private void In1TextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit5.EditValue) + Convert.ToDouble(In2TextEdit5.EditValue) +
                     Convert.ToDouble(In3TextEdit5.EditValue);
            InTotalTextEdit5.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);
            SoldTextEdit5.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();*/
        }

        private void In2TextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit5.EditValue) + Convert.ToDouble(In2TextEdit5.EditValue) +
                     Convert.ToDouble(In3TextEdit5.EditValue);
            InTotalTextEdit5.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);
            SoldTextEdit5.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();*/
        }

        private void In3TextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit5.EditValue) + Convert.ToDouble(In2TextEdit5.EditValue) +
                     Convert.ToDouble(In3TextEdit5.EditValue);
            InTotalTextEdit5.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);
            SoldTextEdit5.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();*/
        }

        private void In1TextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit6.EditValue) + Convert.ToDouble(In2TextEdit6.EditValue) +
                     Convert.ToDouble(In3TextEdit6.EditValue);
            InTotalTextEdit6.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);
            SoldTextEdit6.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();*/
        }

        private void In2TextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit6.EditValue) + Convert.ToDouble(In2TextEdit6.EditValue) +
                     Convert.ToDouble(In3TextEdit6.EditValue);
            InTotalTextEdit6.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);
            SoldTextEdit6.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();*/
        }

        private void In3TextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double total = Convert.ToDouble(In1TextEdit6.EditValue) + Convert.ToDouble(In2TextEdit6.EditValue) +
                     Convert.ToDouble(In3TextEdit6.EditValue);
            InTotalTextEdit6.Text = total.ToString();

            /*double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);
            SoldTextEdit6.Text = sold.ToString();

            double amount = sold * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();*/
        }

        private void RateTextEdit1_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            //double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);

            double amount = pets * Convert.ToDouble(RateTextEdit1.EditValue);
            AmountTextEdit1.Text = amount.ToString();
        }

        private void RateTextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            //double sold = Convert.ToDouble(OutTotalTextEdit2.EditValue) - Convert.ToDouble(InTotalTextEdit2.EditValue);

            double amount = pets * Convert.ToDouble(RateTextEdit2.EditValue);
            AmountTextEdit2.Text = amount.ToString();
        }

        private void RateTextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            //double sold = Convert.ToDouble(OutTotalTextEdit3.EditValue) - Convert.ToDouble(InTotalTextEdit3.EditValue);

            double amount = pets * Convert.ToDouble(RateTextEdit3.EditValue);
            AmountTextEdit3.Text = amount.ToString();
        }

        private void RateTextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            //double sold = Convert.ToDouble(OutTotalTextEdit4.EditValue) - Convert.ToDouble(InTotalTextEdit4.EditValue);

            double amount = pets * Convert.ToDouble(RateTextEdit4.EditValue);
            AmountTextEdit4.Text = amount.ToString();
        }

        private void RateTextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            //double sold = Convert.ToDouble(OutTotalTextEdit5.EditValue) - Convert.ToDouble(InTotalTextEdit5.EditValue);

            double amount = pets * Convert.ToDouble(RateTextEdit5.EditValue);
            AmountTextEdit5.Text = amount.ToString();
        }

        private void RateTextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            //double sold = Convert.ToDouble(OutTotalTextEdit6.EditValue) - Convert.ToDouble(InTotalTextEdit6.EditValue);

            double amount = pets * Convert.ToDouble(RateTextEdit6.EditValue);
            AmountTextEdit6.Text = amount.ToString();
        }
        private void SoldTextEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            /*double totalSold = Convert.ToDouble(SoldTextEdit1.EditValue) + Convert.ToDouble(SoldTextEdit2.EditValue) +
                             Convert.ToDouble(SoldTextEdit3.EditValue) + Convert.ToDouble(SoldTextEdit4.EditValue) +
                             Convert.ToDouble(SoldTextEdit5.EditValue) + Convert.ToDouble(SoldTextEdit6.EditValue);

            TotalSoldTextEdit.Text = totalSold.ToString();*/

            AmountTextEdit1.Text = (pets * Convert.ToDouble(RateTextEdit1.EditValue)).ToString();
            pets = 0;
        }

        private void SoldTextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            /*double totalPets = Convert.ToDouble(SoldTextEdit1.EditValue) + Convert.ToDouble(SoldTextEdit2.EditValue) +
                               Convert.ToDouble(SoldTextEdit3.EditValue) + Convert.ToDouble(SoldTextEdit4.EditValue) +
                               Convert.ToDouble(SoldTextEdit5.EditValue) + Convert.ToDouble(SoldTextEdit6.EditValue);*/

            //TotalSoldTextEdit.Text = totalSold.ToString();
            AmountTextEdit2.Text = (pets*Convert.ToDouble(RateTextEdit2.EditValue)).ToString();
            pets = 0;
        }

        private void SoldTextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            /*double totalSold = Convert.ToDouble(SoldTextEdit1.EditValue) + Convert.ToDouble(SoldTextEdit2.EditValue) +
                               Convert.ToDouble(SoldTextEdit3.EditValue) + Convert.ToDouble(SoldTextEdit4.EditValue) +
                               Convert.ToDouble(SoldTextEdit5.EditValue) + Convert.ToDouble(SoldTextEdit6.EditValue);

            TotalSoldTextEdit.Text = totalSold.ToString();*/

            AmountTextEdit3.Text = (pets * Convert.ToDouble(RateTextEdit3.EditValue)).ToString();
            pets = 0;
        }

        private void SoldTextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            /*double totalSold = Convert.ToDouble(SoldTextEdit1.EditValue) + Convert.ToDouble(SoldTextEdit2.EditValue) +
                               Convert.ToDouble(SoldTextEdit3.EditValue) + Convert.ToDouble(SoldTextEdit4.EditValue) +
                               Convert.ToDouble(SoldTextEdit5.EditValue) + Convert.ToDouble(SoldTextEdit6.EditValue);

            TotalSoldTextEdit.Text = totalSold.ToString();*/

            AmountTextEdit4.Text = (pets * Convert.ToDouble(RateTextEdit4.EditValue)).ToString();
            pets = 0;
        }

        private void SoldTextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            /*double totalSold = Convert.ToDouble(SoldTextEdit1.EditValue) + Convert.ToDouble(SoldTextEdit2.EditValue) +
                               Convert.ToDouble(SoldTextEdit3.EditValue) + Convert.ToDouble(SoldTextEdit4.EditValue) +
                               Convert.ToDouble(SoldTextEdit5.EditValue) + Convert.ToDouble(SoldTextEdit6.EditValue);

            TotalSoldTextEdit.Text = totalSold.ToString();*/

            AmountTextEdit5.Text = (pets * Convert.ToDouble(RateTextEdit5.EditValue)).ToString();
            pets = 0;
        }

        private void SoldTextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e){
            /*double totalSold = Convert.ToDouble(SoldTextEdit1.EditValue) + Convert.ToDouble(SoldTextEdit2.EditValue) +
                               Convert.ToDouble(SoldTextEdit3.EditValue) + Convert.ToDouble(SoldTextEdit4.EditValue) +
                               Convert.ToDouble(SoldTextEdit5.EditValue) + Convert.ToDouble(SoldTextEdit6.EditValue);

            TotalSoldTextEdit.Text = totalSold.ToString();*/

            AmountTextEdit6.Text = (pets * Convert.ToDouble(RateTextEdit6.EditValue)).ToString();
            pets = 0;
        }

        private void AmountTextEdit1_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
             double totalAmount = Convert.ToDouble(AmountTextEdit1.EditValue) + Convert.ToDouble(AmountTextEdit2.EditValue) +
                                Convert.ToDouble(AmountTextEdit3.EditValue) + Convert.ToDouble(AmountTextEdit4.EditValue) +
                                Convert.ToDouble(AmountTextEdit5.EditValue) + Convert.ToDouble(AmountTextEdit6.EditValue);
 
             TotalAmountTextEdit.Text = totalAmount.ToString();
        }

        private void AmountTextEdit2_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalAmount = Convert.ToDouble(AmountTextEdit1.EditValue) + Convert.ToDouble(AmountTextEdit2.EditValue) +
                               Convert.ToDouble(AmountTextEdit3.EditValue) + Convert.ToDouble(AmountTextEdit4.EditValue) +
                               Convert.ToDouble(AmountTextEdit5.EditValue) + Convert.ToDouble(AmountTextEdit6.EditValue);

            TotalAmountTextEdit.Text = totalAmount.ToString();
        }

        private void AmountTextEdit3_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalAmount = Convert.ToDouble(AmountTextEdit1.EditValue) + Convert.ToDouble(AmountTextEdit2.EditValue) +
                               Convert.ToDouble(AmountTextEdit3.EditValue) + Convert.ToDouble(AmountTextEdit4.EditValue) +
                               Convert.ToDouble(AmountTextEdit5.EditValue) + Convert.ToDouble(AmountTextEdit6.EditValue);

            TotalAmountTextEdit.Text = totalAmount.ToString();
        }

        private void AmountTextEdit4_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalAmount = Convert.ToDouble(AmountTextEdit1.EditValue) + Convert.ToDouble(AmountTextEdit2.EditValue) +
                               Convert.ToDouble(AmountTextEdit3.EditValue) + Convert.ToDouble(AmountTextEdit4.EditValue) +
                               Convert.ToDouble(AmountTextEdit5.EditValue) + Convert.ToDouble(AmountTextEdit6.EditValue);

            TotalAmountTextEdit.Text = totalAmount.ToString();
        }

        private void AmountTextEdit5_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalAmount = Convert.ToDouble(AmountTextEdit1.EditValue) + Convert.ToDouble(AmountTextEdit2.EditValue) +
                               Convert.ToDouble(AmountTextEdit3.EditValue) + Convert.ToDouble(AmountTextEdit4.EditValue) +
                               Convert.ToDouble(AmountTextEdit5.EditValue) + Convert.ToDouble(AmountTextEdit6.EditValue);

            TotalAmountTextEdit.Text = totalAmount.ToString();
        }

        private void AmountTextEdit6_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalAmount = Convert.ToDouble(AmountTextEdit1.EditValue) + Convert.ToDouble(AmountTextEdit2.EditValue) +
                               Convert.ToDouble(AmountTextEdit3.EditValue) + Convert.ToDouble(AmountTextEdit4.EditValue) +
                               Convert.ToDouble(AmountTextEdit5.EditValue) + Convert.ToDouble(AmountTextEdit6.EditValue);

            TotalAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Recovery1TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalRecoveries = Convert.ToDouble(Recovery1TextEdit.EditValue) + Convert.ToDouble(Recovery2TextEdit.EditValue) +
                               Convert.ToDouble(Recovery3TextEdit.EditValue) + Convert.ToDouble(Recovery4TextEdit.EditValue) +
                               Convert.ToDouble(Recovery5TextEdit.EditValue);

            TotalRecoveriesTextEdit.Text = totalRecoveries.ToString();
            TotalWithRecoveriesTextEdit.Text =
                (totalRecoveries + Convert.ToDouble(TotalAmountTextEdit.EditValue)).ToString();
        }

        private void Recovery2TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalRecoveries = Convert.ToDouble(Recovery1TextEdit.EditValue) + Convert.ToDouble(Recovery2TextEdit.EditValue) +
                               Convert.ToDouble(Recovery3TextEdit.EditValue) + Convert.ToDouble(Recovery4TextEdit.EditValue) +
                               Convert.ToDouble(Recovery5TextEdit.EditValue);

            TotalRecoveriesTextEdit.Text = totalRecoveries.ToString();
            TotalWithRecoveriesTextEdit.Text =
                (totalRecoveries + Convert.ToDouble(TotalAmountTextEdit.EditValue)).ToString();
        }

        private void Recovery3TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalRecoveries = Convert.ToDouble(Recovery1TextEdit.EditValue) + Convert.ToDouble(Recovery2TextEdit.EditValue) +
                               Convert.ToDouble(Recovery3TextEdit.EditValue) + Convert.ToDouble(Recovery4TextEdit.EditValue) +
                               Convert.ToDouble(Recovery5TextEdit.EditValue);

            TotalRecoveriesTextEdit.Text = totalRecoveries.ToString();
            TotalWithRecoveriesTextEdit.Text =
                (totalRecoveries + Convert.ToDouble(TotalAmountTextEdit.EditValue)).ToString();
        }

        private void Recovery4TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalRecoveries = Convert.ToDouble(Recovery1TextEdit.EditValue) + Convert.ToDouble(Recovery2TextEdit.EditValue) +
                               Convert.ToDouble(Recovery3TextEdit.EditValue) + Convert.ToDouble(Recovery4TextEdit.EditValue) +
                               Convert.ToDouble(Recovery5TextEdit.EditValue);

            TotalRecoveriesTextEdit.Text = totalRecoveries.ToString();
            TotalWithRecoveriesTextEdit.Text =
                (totalRecoveries + Convert.ToDouble(TotalAmountTextEdit.EditValue)).ToString();
        }

        private void Recovery5TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            double totalRecoveries = Convert.ToDouble(Recovery1TextEdit.EditValue) + Convert.ToDouble(Recovery2TextEdit.EditValue) +
                               Convert.ToDouble(Recovery3TextEdit.EditValue) + Convert.ToDouble(Recovery4TextEdit.EditValue) +
                               Convert.ToDouble(Recovery5TextEdit.EditValue);

            TotalRecoveriesTextEdit.Text = totalRecoveries.ToString();
            TotalWithRecoveriesTextEdit.Text =
                (totalRecoveries + Convert.ToDouble(TotalAmountTextEdit.EditValue)).ToString();
        }

        private void Currency5000TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount5000TextEdit.Text = (5000*Convert.ToInt32(Currency5000TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency1000TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount1000TextEdit.Text = (1000 * Convert.ToInt32(Currency1000TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency500TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount500TextEdit.Text = (500 * Convert.ToInt32(Currency500TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency100TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount100TextEdit.Text = (100 * Convert.ToInt32(Currency100TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency50TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount50TextEdit.Text = (50 * Convert.ToInt32(Currency50TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency20TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount20TextEdit.Text = (20 * Convert.ToInt32(Currency20TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency10TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount10TextEdit.Text = (10 * Convert.ToInt32(Currency10TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void Currency5TextEdit_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            Amount5TextEdit.Text = (5 * Convert.ToInt32(Currency5TextEdit.EditValue)).ToString();

            long totalAmount = Convert.ToInt64(Amount5000TextEdit.EditValue) +
                               Convert.ToInt64(Amount1000TextEdit.EditValue) +
                               Convert.ToInt64(Amount500TextEdit.EditValue) +
                               Convert.ToInt64(Amount100TextEdit.EditValue) +
                               Convert.ToInt64(Amount50TextEdit.EditValue) + Convert.ToInt64(Amount20TextEdit.EditValue) +
                               Convert.ToInt64(Amount10TextEdit.EditValue) + Convert.ToInt64(Amount5TextEdit.EditValue);

            TotalCurrencyAmountTextEdit.Text = totalAmount.ToString();
        }

        private void SchemePetsTextEdit1_EditValueChanging(object sender, DevExpress.Xpf.Editors.EditValueChangingEventArgs e)
        {
            /*double sold = Convert.ToDouble(OutTotalTextEdit1.EditValue) - Convert.ToDouble(InTotalTextEdit1.EditValue);
            string s=sold.ToString();
            String[] ss;
            int remainingPets = 0;
            int remainingBottles = 0;
            int totalRemainingBottles = 0;
            if (s.Contains('.'))
            {
                ss = s.Split('.');
                remainingPets = Int32.Parse(ss[0]);
                remainingBottles = Int32.Parse(ss[1]);
                totalRemainingBottles = (remainingPets * 6) + remainingBottles;
            }
            else
            {
                remainingPets = Int32.Parse(s);
                totalRemainingBottles = remainingPets*6;
            }

            double rewardedBottles = Convert.ToDouble(SchemePetsTextEdit1.EditValue)/
                                     Convert.ToDouble(SchemeBottlesTextEdit1.EditValue);

        int bottlePerPet=0;
        int noOfPets=0;
        int noOfBottles=0;
        double totalBottles=0;
        int pets=0;
        double schemeBottles=0;
        int schemePets=0;
        double total=0;
        double extraBottles=0;

            totalBottles = totalRemainingBottles;
            total = totalBottles;

            while (true)
            {
                if (totalBottles <= 6)
                {
                    extraBottles = totalBottles;
                    break;
                }

                totalBottles -= 6;
                pets += 1;
                if (totalBottles > 0)
                {
                    totalBottles -= rewardedBottles;
                    schemeBottles += rewardedBottles;
                }

            }

            double schbottles = schemeBottles;

            while (true)
            {
                if (schbottles < 6)
                {
                    break;
                }
                else
                {
                    schbottles -= 6;
                    schemePets += 1;
                }
            }

                SoldTextEdit1.Text = pets + " pets & " + schemeBottles + " scheme bottles";*/


            //ta = pets*Convert.ToDouble(SoldTextEdit1.EditValue);
            //AmountTextEdit1.Text = ta.ToString();//             int missingbottles = totalRemainingBottles - ((pets*6) + (int)schemeBottles);
//             Console.WriteLine(pets);
//             Console.WriteLine(schemeBottles);
//             Console.WriteLine(extraBottles);
        }

        private void OutTotalTextEdit1_EditValueChanged(object sender,
            DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit1, InTotalTextEdit1, SchemePetsTextEdit1, SchemeBottlesTextEdit1);

            SoldTextEdit1.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0){
                RemainingLabel1.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel1.Visibility = Visibility.Visible;
            }

        }

        private void InTotalTextEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit1, InTotalTextEdit1, SchemePetsTextEdit1, SchemeBottlesTextEdit1);

            SoldTextEdit1.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel1.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel1.Visibility = Visibility.Visible;
            }
        }

        private void OutTotalTextEdit2_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit2, InTotalTextEdit2, SchemePetsTextEdit2, SchemeBottlesTextEdit2);

            SoldTextEdit2.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel2.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel2.Visibility = Visibility.Visible;
            }
        }

        private void InTotalTextEdit2_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit2, InTotalTextEdit2, SchemePetsTextEdit2, SchemeBottlesTextEdit2);

            SoldTextEdit2.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel2.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel2.Visibility = Visibility.Visible;
            }
        }

        private void OutTotalTextEdit3_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit3, InTotalTextEdit3, SchemePetsTextEdit3, SchemeBottlesTextEdit3);

            SoldTextEdit3.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel3.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel3.Visibility = Visibility.Visible;
            }
        }

        private void InTotalTextEdit3_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit3, InTotalTextEdit3, SchemePetsTextEdit3, SchemeBottlesTextEdit3);

            SoldTextEdit3.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel3.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel3.Visibility = Visibility.Visible;
            }
        }

        private void OutTotalTextEdit4_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit4, InTotalTextEdit4, SchemePetsTextEdit4, SchemeBottlesTextEdit4);

            SoldTextEdit4.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel4.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel4.Visibility = Visibility.Visible;
            }
        }

        private void InTotalTextEdit4_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit4, InTotalTextEdit4, SchemePetsTextEdit4, SchemeBottlesTextEdit4);

            SoldTextEdit4.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel4.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel4.Visibility = Visibility.Visible;
            }
        }

        private void OutTotalTextEdit5_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit5, InTotalTextEdit5, SchemePetsTextEdit5, SchemeBottlesTextEdit5);

            SoldTextEdit5.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel5.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel5.Visibility = Visibility.Visible;
            }
        }

        private void InTotalTextEdit5_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit5, InTotalTextEdit5, SchemePetsTextEdit5, SchemeBottlesTextEdit5);

            SoldTextEdit5.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel5.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel5.Visibility = Visibility.Visible;
            }
        }

        private void OutTotalTextEdit6_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit6, InTotalTextEdit6, SchemePetsTextEdit6, SchemeBottlesTextEdit6);

            SoldTextEdit6.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel6.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel6.Visibility = Visibility.Visible;
            }
        }

        private void InTotalTextEdit6_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CalculateScheme(OutTotalTextEdit6, InTotalTextEdit6, SchemePetsTextEdit6, SchemeBottlesTextEdit6);
            SoldTextEdit6.Text = pets + " pets & " + schemeBottles + " scheme bottles";
            if (extraBottles > 0)
            {
                RemainingLabel6.Content = "Remaining: " + extraBottles.ToString();
                RemainingLabel6.Visibility = Visibility.Visible;
            }
        }
        void CalculateScheme(TextEdit OutTotalTextEdit, TextEdit InTotalTextEdit, TextEdit SchemePetsTextEdit,
            TextEdit SchemeBottlesTextEdit)
        {
            pets = 0;
            schemeBottles = 0;
            extraBottles = 0;

            double sold = Convert.ToDouble(OutTotalTextEdit.EditValue) -
                          Convert.ToDouble(InTotalTextEdit.EditValue);
            string s = sold.ToString();
            String[] ss;
            int remainingPets = 0;
            int remainingBottles = 0;
            int totalRemainingBottles = 0;
            if (s.Contains('.'))
            {
                ss = s.Split('.');
                remainingPets = Int32.Parse(ss[0]);
                remainingBottles = Int32.Parse(ss[1]);
                totalRemainingBottles = (remainingPets*6) + remainingBottles;
            }
            else
            {
                remainingPets = Int32.Parse(s);
                totalRemainingBottles = remainingPets*6;
            }

            if (Convert.ToDouble(SchemePetsTextEdit.EditValue) == 0 ||
                Convert.ToDouble(SchemeBottlesTextEdit.EditValue) == 0)
            {
                pets = remainingPets;
                schemeBottles = remainingBottles;
            }
            else
            {
                double rewardedBottles = Convert.ToDouble(SchemePetsTextEdit.EditValue)/
                                         Convert.ToDouble(SchemeBottlesTextEdit.EditValue);

                int bottlePerPet = 0;
                int noOfPets = 0;
                int noOfBottles = 0;
                double totalBottles = 0;

                int schemePets = 0;
                double total = 0;



                totalBottles = totalRemainingBottles;
                total = totalBottles;

                while (true)
                {
                    if (totalBottles <= 6)
                    {
                        extraBottles = totalBottles;
                        break;
                    }

                    totalBottles -= 6;
                    pets += 1;
                    if (totalBottles > 0)
                    {
                        totalBottles -= rewardedBottles;
                        schemeBottles += rewardedBottles;
                    }

                }

                double schbottles = schemeBottles;

                while (true)
                {
                    if (schbottles < 6)
                    {
                        break;
                    }
                    else
                    {
                        schbottles -= 6;
                        schemePets += 1;
                    }
                }
            }
        }


    }
}
