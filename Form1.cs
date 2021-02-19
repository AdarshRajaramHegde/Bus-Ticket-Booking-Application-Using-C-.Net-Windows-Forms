using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdarshRajaram_Hegde_Assignment2_MS806
{
    public partial class Form1 : Form
    {
        // Global Variable, Constants are declared and Intialized to 0.
        int TotalGuests;
        const decimal DEPARTUREATSEVEN = 7.00m, DEPARTUREATEIGHT = 8.00m, DEPARTUREATNINE = 9.00m, DEPARTUREATTEN = 10.00m, DEPARTUREATELEVEN = 11.00m, DEPARTUREATONE = 13.00m;
        const int CLIFFSOFMOHER = 55, KYLEMOREABBEY = 50, BUNRATTYCASTLE = 75, THEBURREN = 45, CONNEMARA = 75, BELMULLET = 99;
        const decimal DEPARTUREAT7 = 0.2m, DEPARTUREAT8 = 0.1m, DEPARTUREAT9 = 0.05m, DEPARTUREAT13 = 0.25m, LUNCHCOST = 11.50m, DISCOUNT = 0.925m;
        const int FIVESTARHTOEL = 100, FOURSTARHOTEL = 75, THREESTARHOTEL = 50;
        String LocationName;
        decimal DepartureTime=0m,TotalCostValue=0m, TripCost=0m, HotelCost=0m, LunchCost=0m, TotalCost=0m, TotalTransactions = 0m, TotalTripCosts = 0m, TotalLunchCost = 0m,  AverageRevenue = 0m, ValueChoosen = 0m;
        decimal TotaLunchCostValue=0m, TotalHotelCostValue=0m;
        private void RadioButton5Star_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void ClearButtonToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            //Exit Button which closes the application.
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void LabelDepartureTimeValues_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton4Star_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            //Clear button which clears the value in all labels and focus shifts to TotalGuest text box.
            TextBoxTotalGuests.Text = "";
            ListBoxLocationAndPrice.SelectedIndex = -1;
            ListBoxDepartureTime.SelectedIndex = -1;
            //unchecking the radio buttons.
            RadioButton5Star.Checked = false;
            RadioButton4Star.Checked = false;
            RadioButton3Star.Checked = false;
            CheckBoxLunch.Checked = false;
            LabelDepartureTimeValue.Text = "";
            LabelTripcostValue.Text = "";
            LabelLocationNameValue.Text = "";
            LabelTotalTripFessValue.Text = "";
            LabelHotelCostValue.Text = "";
            LabelLunchCostValue.Text = "";
            LabelTotalCostValue.Text = "";
            LabelTotalTransactionsValue.Text = "";
            LabelTotalTripFessValue.Text = "";
            LabelValueOfOptionChoosenValue.Text = "";
            LabelAverageRevenueValue.Text = "";
            // code which makes buttons and Labels to invisible.
            ButtonBook.Enabled = false;
            RadioButtonNoHotel.Visible = false;
            ButtonSummary.Enabled = true;
            ButtonDisplay.Enabled = true;
            GroupBoxGuestTripDetails.Visible = false;
            GroupBoxSummary.Visible = false;
            // focus shifted towards total guest textbox.
            TextBoxTotalGuests.Focus();

        }

        private void BookButton_Click(object sender, EventArgs e)
        {


            // if yes option is clicked in Message Box options.
            if (MessageBox.Show(string.Format("Please Find the Below details of the Booking and Proceed with Yes to Confirm" + "\n\n" + "No. of guests is " + TotalGuests + "\n\n" + "Location is " + LocationName + "\n\n" + "Departure time is " + DepartureTime + "\n\n" + "Total Cost of the trip is " + "€" + TotalCost), "\n\n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TotalTransactions = TotalTransactions + 1;
                TotalCostValue = TotalCostValue + TotalCost; 
                TotalTripCosts = TotalTripCosts + TripCost;  
                AverageRevenue = Math.Round((TotalCostValue / TotalTransactions),2);
                GroupBoxGuestTripDetails.Visible = false;
                ButtonDisplay.Enabled = false;
                ButtonSummary.Enabled = true;
                ButtonBook.Enabled = false;
                ButtonClear_Click(sender, e);
                TotaLunchCostValue = TotaLunchCostValue + LunchCost;
                TotalHotelCostValue = TotalHotelCostValue + HotelCost;
                ValueChoosen = TotalHotelCostValue + TotalLunchCost;
            }
            else{
                //if No is clicked in Message Box, Clear button is executed.
                ButtonClear_Click(sender, e);
            }
        }
        private void RadioButton3Star_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void RadioButtonNoHotel_CheckedChanged(object sender, EventArgs e)
        {
            //if No Hotel button is clicked the Value of the Hotelcost is changed dynamically.
            if (RadioButtonNoHotel.Checked)
            {
                //calculations fro Total cost, trip cost and lunch cost.
                TotalCost = TripCost + LunchCost;
                LabelHotelCostValue.Text = "€" + 0.ToString();
                LabelTotalCostValue.Text = "€" + TotalCost.ToString();
            }
            else {
                // No Hotel button is not opted.
                LabelTripcostValue.Text = "€" + TripCost.ToString();
                LabelHotelCostValue.Text = "€" + TotalHotelCostValue.ToString();
                LabelLunchCostValue.Text = "€" + TotalLunchCost.ToString();
                LabelTotalCostValue.Text = "€" + TotalCost.ToString();
            }

        }

        private void LabelHotelCostValue_Click(object sender, EventArgs e)
        {

        }

        private void LabelLocationNameValues_Click(object sender, EventArgs e)
        {

        }

        private void LabelTripcostValue_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            //calculations for Details in summary group box.
            LabelTotalTransactionsValue.Text = TotalTransactions.ToString();
            LabelTotalTripFessValue.Text = "€" + TotalTripCosts.ToString();
            LabelValueOfOptionChoosenValue.Text = "€" + ValueChoosen.ToString(); 
            LabelAverageRevenueValue.Text = "€" + AverageRevenue.ToString();
            // code makes some parts of the form to invisible.
            GroupBoxSummary.Visible = true;
            GroupBoxGuestTripDetails.Visible = false;
            ButtonDisplay.Enabled = false;
            ButtonBook.Enabled = false;
            ButtonClear.Focus();
        }

        private void TextBoxLunchCost_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {

            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This is executed when form loads at first time.
            ButtonDisplay.Enabled = true;
            ButtonBook.Enabled = false;
            ButtonSummary.Enabled = false;
            ButtonClear.Enabled = true;
            ButtonExit.Enabled = true;
            GroupBoxGuestTripDetails.Visible = false;
            GroupBoxSummary.Visible = false;
           RadioButtonNoHotel.Visible = false;
           // helps to focus on the Total guest Box.
            this.ActiveControl = TextBoxTotalGuests;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            // error providers is cleared once values are selected properly.
            ErrorProviderLocatonListBox.Clear();
            ErrorProviderDepartureListBox.Clear();
            TextBoxTotalGuestErrorProvider.Clear();
            // try block for exception handling.
            try
            {
                TotalGuests = int.Parse(TextBoxTotalGuests.Text);
                if (TotalGuests > 0)
                {
                    //checking Non negative total guests execption.

                    int LocationIndex = ListBoxLocationAndPrice.SelectedIndex;
                    // null value exception.
                    if (LocationIndex != -1)
                    {
                        // switch case to select the options from the location list box.
                        switch (LocationIndex)
                        {
                            case 0:
                                TripCost = TotalGuests * CLIFFSOFMOHER;
                                LocationName = "Cliffs Of Moher";
                                break;
                            case 1:
                                TripCost = TotalGuests * KYLEMOREABBEY;
                                LocationName = "Kylemore Abbey";
                                break;
                            case 2:
                                TripCost = TotalGuests * BUNRATTYCASTLE;
                                LocationName = "Bunratty Castle";
                                break;
                            case 3:
                                TripCost = TotalGuests * THEBURREN;
                                LocationName = "The Burren";
                                break;
                            case 4:
                                TripCost = TotalGuests * CONNEMARA;
                                LocationName = "Connemara";
                                break;
                            case 5:
                                TripCost = TotalGuests * BELMULLET;
                                LocationName = "Belmullet";
                                break;
                        }



                        int DepartureTimeIndex = ListBoxDepartureTime.SelectedIndex;
                        if (DepartureTimeIndex != -1)
                        {
                            // checking for Null Value exception for listbox Departure time.
                            switch (DepartureTimeIndex)
                            {
                                //switch cases to parse the departure time selected. 
                                case 0:
                                    DepartureTime = DEPARTUREATSEVEN;
                                    TripCost = TripCost - (DEPARTUREAT7 * TripCost);
                                    break;
                                case 1:
                                    DepartureTime = DEPARTUREATEIGHT;
                                    TripCost = TripCost - (DEPARTUREAT8 * TripCost);
                                    break;
                                case 2:
                                    DepartureTime = DEPARTUREATNINE;
                                    TripCost = TripCost - (DEPARTUREAT9 * TripCost);
                                    break;
                                case 3:
                                    DepartureTime = DEPARTUREATTEN;
                                    break;
                                case 4:
                                    DepartureTime = DEPARTUREATELEVEN;
                                    break;
                                case 5:
                                    DepartureTime = DEPARTUREATONE;
                                    TripCost = TripCost - (DEPARTUREAT13 * TripCost);
                                    break;
                            }

                            if (RadioButton5Star.Checked)
                            {
                                // Radio button for hotels.
                                HotelCost = FIVESTARHTOEL * TotalGuests;
                            }
                            else if (RadioButton4Star.Checked)
                            {
                                // Radio button for hotels.
                                HotelCost = FOURSTARHOTEL * TotalGuests;
                            }
                            else if (RadioButton3Star.Checked)
                            {
                                // Radio button for hotels.
                                HotelCost = THREESTARHOTEL * TotalGuests;
                            }

                            if (CheckBoxLunch.Checked)
                            {
                                // Lunch cost check box calculation.
                                LunchCost = TotalGuests * LUNCHCOST;
                            }

                            if (TotalGuests >= 3)
                            {
                                // if there are guests >=3, than 7.5% discountis applied.
                                TotalCost = DISCOUNT * (TripCost + HotelCost + LunchCost);
                            }
                            else
                            {
                                // if total guests are less than 3 and Total cost is calculated without Discount.
                                TotalCost = TripCost + HotelCost + LunchCost;
                            }
                            // Values in Group box guest trip details are displayed.
                            LabelLocationNameValue.Text = LocationName.ToString();
                            LabelDepartureTimeValue.Text = DepartureTime.ToString();
                            LabelTripcostValue.Text = "€" + TripCost.ToString();
                            TotalCost = Math.Round(TotalCost, 2);
                            LabelHotelCostValue.Text = "€" + HotelCost.ToString();
                            LabelLunchCostValue.Text = "€" + LunchCost.ToString();
                            LabelTotalCostValue.Text = "€" + TotalCost.ToString();
                            //code to make invisible some part of the form.
                            ButtonDisplay.Enabled = true;
                            ButtonSummary.Enabled = true;
                            ButtonBook.Enabled = true;
                            ButtonClear.Enabled = true;
                            ButtonExit.Enabled = true;
                            GroupBoxGuestTripDetails.Visible = true;
                            ButtonBook.Focus();
                            RadioButtonNoHotel.Visible= true;
                        }
                        else
                        {
                            // Null value exception for departure time list box.
                            MessageBox.Show("Please Select the Departure Time");
                            ErrorProviderDepartureListBox.SetError(ListBoxDepartureTime, "Please Select the Location");
                        }
                    }
                    else
                    {
                        //Null vlaue execption for Location listbox.
                        MessageBox.Show("Please Select the Location");
                        ErrorProviderLocatonListBox.SetError(ListBoxLocationAndPrice, "Please Select the Location");
                    }
                }
                else {
                    //Negative value exception for total number of guests.
                    MessageBox.Show("Please Provide Positive Whole Number in Total Guests Option");
                }

            }

            catch
            {
                // catch blocks for Total number of guests.
                MessageBox.Show("Please Enter the Total Guests");
                this.ActiveControl = TextBoxTotalGuests;
                TextBoxTotalGuestErrorProvider.SetError(TextBoxTotalGuests, "Please Enter The Total Guests");
            }

        }
    } }




