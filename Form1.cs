using System.Windows.Forms;

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

        private void GenerateGridButton_Click(object sender, EventArgs e)
        {
            int minCoordinate = 0;
            int maxCoordinate = 50;
            if (maxYCoordinateTextBox.Text.Length > 0 && maxXCoordinateTextBox.Text.Length > 0)
            {
                int y = int.Parse(maxYCoordinateTextBox.Text);
                int x = int.Parse(maxXCoordinateTextBox.Text);

                if (x >= minCoordinate &&
                    y >= minCoordinate &&
                    x <= maxCoordinate &&
                    y <= maxCoordinate)
                {
                    Grid.Initiate(x, y, this);
                }
            }
        }

        private void GenerateRobotButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(RobotXCoordinateTextBox.Text);
            int y = int.Parse(RobotYCoordinateTextBox.Text);
            char robotOrientation = Char.Parse(RobotOrientationTextBox.Text);
            Robot robot = new Robot(robotOrientation, new Point(x, y));
            Grid.gridElements[x, y].SetRobotInElement(robot);
        }

        private void SendCommandButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(RobotXCoordinateTextBox.Text);
            int y = int.Parse(RobotYCoordinateTextBox.Text);
           
            string command = sendCommandTextBox.Text;
            CommandProcessor.ProcessCommand(command, Grid.gridElements[x, y].getRobotInElement());
        }
    }
}