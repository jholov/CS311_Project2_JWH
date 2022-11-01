namespace CS311_Project2_JWH
{//This project sets up a GUI applicaiton
 //that runs and follows the rules of Craps.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }//end Form1

        private void lbl3_Click(object sender, EventArgs e)
        {

        }//end lbl3_Click
        
        //This method rolls two die randomly and determines if you win in Craps
        private void calculate_score()
        {
           
            Random rnd = new Random();
            float betAmount = float.Parse(txt1.Text);

            //Allows you to Roll when your bet is covered by your funds
            if (bankAmount >= betAmount)
            {
                int die1 = rnd.Next(6) + 1;
                int die2 = rnd.Next(6) + 1;
                int diceSum = die1 + die2;

                lbl1.Text = die1.ToString();
                lbl2.Text = die2.ToString();

                if (pointSet == false)
                {
                    //Determines on the first roll if you win or lose while also setting the point
                    switch (diceSum)
                    {
                        case 7:
                            lbl4.Text = "You Win!";
                            bankAmount = bankAmount += betAmount;
                            lbl3.Text = bankAmount.ToString("C2");

                            break;

                        case 11:
                            lbl4.Text = "You Win!";
                            bankAmount = bankAmount += betAmount;
                            lbl3.Text = bankAmount.ToString("C2");

                            break;

                        case 2:
                            lbl4.Text = "You Lose!";
                            bankAmount = bankAmount -= betAmount;
                            lbl3.Text = bankAmount.ToString("C2");
                            break;

                        case 3:
                            lbl4.Text = "You Lose!";
                            bankAmount = bankAmount -= betAmount;
                            lbl3.Text = bankAmount.ToString("C2");
                            break;

                        case 12:
                            lbl4.Text = "You Lose!";
                            bankAmount = bankAmount -= betAmount;
                            lbl3.Text = bankAmount.ToString("C2");
                            break;

                        default:
                            point = diceSum;
                            pointSet = true;
                            lbl4.Text = "Point is " + point;
                            break;

                    }//end switch

                } 
                  //Used to determine when the point is set, win and loss conditions
                  else if (pointSet == true && point == diceSum)
                   {
                      lbl4.Text = "You Win!";
                      bankAmount = bankAmount += betAmount;
                      lbl3.Text = bankAmount.ToString("C2");
                      pointSet = false;
                   }
                   else if (pointSet == true && diceSum == 7)
                    {
                       lbl4.Text = "You Lose!";
                       bankAmount = bankAmount -= betAmount;
                       lbl3.Text = bankAmount.ToString("C2");
                       pointSet = false;
                    }
                    else if (pointSet == true && diceSum != 7)
                     {

                     }
                        
      
            }
            //Triggers when the bet amount is higher than available funds
            else
            {
                MessageBox.Show("Insufficient Funds");
                
            }

        }//end calculate_score

        //This method calls the calculate_score() method when the roll button is clicked
        private void btn1_Click(object sender, EventArgs e)
        {

            calculate_score();
            
        }//end btn1_Click

        private void lbl1_Click(object sender, EventArgs e)
        {

        }//end lbl1_Click

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }//end txt1_TextChanged

        private void lbl4_Click(object sender, EventArgs e)
        {

        }//end lbl4_Click

        private void lbl5_Click(object sender, EventArgs e)
        {

        }//end lbl5_Click

        private void lbl6_Click(object sender, EventArgs e)
        {

        }//end lbl6_Click

        private void lbl2_Click(object sender, EventArgs e)
        {

        }//end lbl2_Click

        private void pb1_Click(object sender, EventArgs e)
        {
            
        }//end pb1_Click

        private void Form1_Load(object sender, EventArgs e)
        {

        }//end Form1_Load

    }//end Form1 

}//end Namespace