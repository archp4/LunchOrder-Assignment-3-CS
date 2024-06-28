namespace LunchOrder
{
    public partial class LunchOrder : Form
    {

        private string textTitle = "Add-on items ";
        private int selectIndex = 0;
        private string[] option1 = ["Lettuce, tomato and onions", "Pepperoni", "Croutons", "Guac"];
        private string[] option2 = ["Ketchup, mustard and mayo", "Sausage", "Bacon bits", "Drink"];
        private string[] option3 = ["French fries", "Olives", "Bread sticks", "Chips"];
        private string[] groupTitle = ["$.75/each", "$.50/each", "$.25/each", "$.35/each"];
        private double subtotal = 0;
        private double[] group2Amounts = [.75, .50, .25, .35];
        private double[] mainCourseAmounts = [6.95, 5.95, 4.95, 5.95];
        private double[] tips = [0, 0.08, 0.12, 0.18];


        public LunchOrder()
        {
            InitializeComponent();
            cbTips.Items.Clear();
            foreach (double t in tips)
            {
                cbTips.Items.Add((t * 100).ToString() + "%");
            }
            cbTips.SelectedIndex = 1;
            radioButton1.Select();
        }

        private void updateGroup2()
        {
            groupBox2.Text = textTitle + groupTitle[selectIndex];
            checkBox1.Text = option1[selectIndex];
            checkBox2.Text = option2[selectIndex];
            checkBox3.Text = option3[selectIndex];
        }

        private void updateMainCourseIndex(int index)
        {
            selectIndex = index;
            updateGroup2();
            subtotal = mainCourseAmounts[selectIndex];
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            updateTotal();
        }

        private void updateTotal()
        {

            double tipAmount = subtotal * tips[cbTips.SelectedIndex];
            double withTax = (subtotal * .0775);
            double orderTotal = subtotal + tipAmount + withTax;
            tbSubTotal.Text = subtotal.ToString("C2");
            tbTax.Text = withTax.ToString("C2");
            tbOrderTotal.Text = orderTotal.ToString("C2");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateMainCourseIndex(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updateMainCourseIndex(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            updateMainCourseIndex(2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            updateMainCourseIndex(3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                subtotal += group2Amounts[selectIndex];
            }
            else
            {
                subtotal -= group2Amounts[selectIndex];
            }
            updateTotal();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                subtotal += group2Amounts[selectIndex];
            }
            else
            {
                subtotal -= group2Amounts[selectIndex];
            }
            updateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                subtotal += group2Amounts[selectIndex];
            }
            else
            {
                subtotal -= group2Amounts[selectIndex];
            }
            updateTotal();
        }

        private void cbTips_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTotal();
        }

        private void clearOrder()
        {
            radioButton1.Select();
            cbTips.SelectedIndex = 1;
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are have selected " + (tips[cbTips.SelectedIndex] * 100) + "% for tip" +
                "\nWith Order Total :" + tbOrderTotal.Text +
                "\nAre you sure ?", "Confirm the Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your has be placed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearOrder();
            }
        }
    }
}
