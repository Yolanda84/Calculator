using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class NewCalculator : Form {

        private double _total = 0;
        private double _result = 0;
        private bool _dec = false;
        private string _operation = "";


        public NewCalculator() {
            InitializeComponent();
        }

        private void Num_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            ctrlResultBox.AppendText(button.Text);
        }

        private void Operation_Click(object sender, EventArgs e) {

            Button operButton = (Button)sender;
            _operation = operButton.Text;
            _total = double.Parse(ctrlResultBox.Text);
            ctrlResultBox.Text = Convert.ToString(_total) + _operation;
            ctrlResultBox.Text = "";
            _dec = false;
        }

        private void Dec_Click(object sender, EventArgs e) {
            if (_dec == false) {
                Button decim = (Button)sender;
                _dec = true;
                ctrlResultBox.AppendText(decim.Text);
            }

        }

        private void Clear_Click(object sender, EventArgs e) {
            _total = 0;
            _result = 0;
            _dec = false;
            _operation = "";
            ctrlResultBox.Text = "";
        }

        private void Equals_Click(object sender, EventArgs e) {

            if (ctrlResultBox.Text.Length == 0) {
                MessageBox.Show("You have no numbers to calculate", "Unable to calculate", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            double number = double.Parse(ctrlResultBox.Text);

            if (ctrlResultBox.Text.Length > 0 && _operation == "+") {
                _result = _total + number;
                ctrlResultBox.Text = Convert.ToString(_result);
            }
            if (ctrlResultBox.Text.Length > 0 && _operation == "-") {
                _result = _total - number;
                ctrlResultBox.Text = Convert.ToString(_result);
            }
            if (ctrlResultBox.Text.Length > 0 && _operation == "*") {
                _result = _total * number;
                ctrlResultBox.Text = Convert.ToString(_result);
            }
            if (ctrlResultBox.Text.Length > 0 && _operation == "/") {
                _result = _total / number;
                ctrlResultBox.Text = Convert.ToString(_result);
            }

        }

        private void ctrlResultBox_TextChanged(object sender, EventArgs e) {

        }
    }
}
