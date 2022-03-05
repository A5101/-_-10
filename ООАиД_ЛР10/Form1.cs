using System;
using System.Windows.Forms;

namespace ООАиД_ЛР10
{
    public partial class Form1 : Form
    {
        Observable observable;
        CountObserver coobs;
        CurrentObserver cuobs;
        public Form1()
        {
            InitializeComponent();
            observable = new Observable();  
            coobs = new CountObserver(this);
            cuobs = new CurrentObserver(this);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            observable = new Observable();
            coobs = new CountObserver(this);
            cuobs = new CurrentObserver(this);
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            observable.Change();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                observable.RegisterObserver(coobs);
                CountActTextBox.Text = coobs.Count.ToString();
            }
            if (!checkBox1.Checked)
            {
                observable.RemoveObserver(coobs);
                CountActTextBox.Text = "";
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                observable.RegisterObserver(cuobs);
                CurrStateTextBox.Text = cuobs.St.Stat.ToString();
            }
            if (!checkBox2.Checked)
            {
                observable.RemoveObserver(cuobs);
                CurrStateTextBox.Text = "";
            }
        }
        public TextBox GetCountTextBox()
        {
            return CountActTextBox;
        }
        public TextBox GetCurrStateTextBox()
        {
            return CurrStateTextBox;
        }
    }
}
