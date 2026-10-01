namespace uni_lessons_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger menyusu - 8");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger ve icki - 6");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qarisıq yemek - 7");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Eriste - 5");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Toyuqlu duyu - 8");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Salat - 4");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kartof fri - 3");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yemek kasasi - 7");
            textBox3.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silmək istədiyiniz yeməyi seçin.");
                return;
            }

            string yemek = listBox1.SelectedItem.ToString();
            int yer = yemek.LastIndexOf(" - ");
            string ad = yemek.Substring(0, yer);

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            textBox3.Clear();
            textBox2.Clear();

            MessageBox.Show(ad + " səbətdən silindi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
    "Xanalar sıfırlansınmı?",
    "Yenilə",
    MessageBoxButtons.YesNo
);

            if (cavab == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                maskedTextBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Əvvəlcə Yekun hesab düyməsinə basın.");
                return;
            }

            decimal mebleg;

            if (!decimal.TryParse(maskedTextBox1.Text, out mebleg))
            {
                MessageBox.Show("Məbləği düzgün daxil edin.");
                return;
            }

            decimal hesab = Convert.ToDecimal(textBox3.Text);

            if (mebleg < hesab)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
            }
            else
            {
                textBox2.Text = (mebleg - hesab).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            decimal cem = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string yemek = listBox1.Items[i].ToString();
                int yer = yemek.LastIndexOf(" - ");

                decimal qiymet = Convert.ToDecimal(yemek.Substring(yer + 3));
                cem = cem + qiymet;
            }

            textBox3.Text = cem.ToString();
            textBox2.Clear();
        }
    }
}
