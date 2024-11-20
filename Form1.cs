namespace RedBadgerForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minCoordinate = 0;
            int maxCoordinate = 50;
            if (maxXCoordinateTextBox.Text.Length > 0 && maxYCoordinateTextBox.Text.Length > 0)
            {
                int x = int.Parse(maxXCoordinateTextBox.Text);
                int y = int.Parse(maxYCoordinateTextBox.Text);

                if (x >= minCoordinate &&
                    y >= minCoordinate &&
                    x <= maxCoordinate &&
                    y <= maxCoordinate)
                {

                    Grid.Initiate(x, y, this);
                }
            }
        }
    }
}