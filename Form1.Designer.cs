namespace AdarshRajaram_Hegde_Assignment2_MS806
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListBoxLocationAndPrice = new System.Windows.Forms.ListBox();
            this.ListBoxDepartureTime = new System.Windows.Forms.ListBox();
            this.PanelHotelNames = new System.Windows.Forms.Panel();
            this.RadioButtonNoHotel = new System.Windows.Forms.RadioButton();
            this.RadioButton3Star = new System.Windows.Forms.RadioButton();
            this.RadioButton4Star = new System.Windows.Forms.RadioButton();
            this.RadioButton5Star = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelTotalGuests = new System.Windows.Forms.Label();
            this.TextBoxTotalGuests = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxLunch = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxGuestTripDetails = new System.Windows.Forms.GroupBox();
            this.LabelDepartureTimeValue = new System.Windows.Forms.Label();
            this.LabelDepartureTime = new System.Windows.Forms.Label();
            this.LabelLocationNameValue = new System.Windows.Forms.Label();
            this.LabelLocationName = new System.Windows.Forms.Label();
            this.LabelTotalCostValue = new System.Windows.Forms.Label();
            this.LabelLunchCostValue = new System.Windows.Forms.Label();
            this.LabelHotelCostValue = new System.Windows.Forms.Label();
            this.LabelTripcostValue = new System.Windows.Forms.Label();
            this.LabelTotalCost = new System.Windows.Forms.Label();
            this.LabelLunchCost = new System.Windows.Forms.Label();
            this.LabelHotelCost = new System.Windows.Forms.Label();
            this.LabelTripCost = new System.Windows.Forms.Label();
            this.GroupBoxSummary = new System.Windows.Forms.GroupBox();
            this.LabelAverageRevenueValue = new System.Windows.Forms.Label();
            this.LabelValueOfOptionChoosenValue = new System.Windows.Forms.Label();
            this.LabelTotalTripFessValue = new System.Windows.Forms.Label();
            this.LabelTotalTransactionsValue = new System.Windows.Forms.Label();
            this.LabelAverageRevenue = new System.Windows.Forms.Label();
            this.LabelValueOfOptionsChoosen = new System.Windows.Forms.Label();
            this.LabelTotalTripFess = new System.Windows.Forms.Label();
            this.LabelTotalTransactions = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSummary = new System.Windows.Forms.Button();
            this.ButtonBook = new System.Windows.Forms.Button();
            this.ButtonDisplay = new System.Windows.Forms.Button();
            this.ErrorProviderLocatonListBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderDepartureListBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxTotalGuestErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelHotelNames.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBoxGuestTripDetails.SuspendLayout();
            this.GroupBoxSummary.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderLocatonListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDepartureListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTotalGuestErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxLocationAndPrice
            // 
            this.ListBoxLocationAndPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxLocationAndPrice.FormattingEnabled = true;
            this.ListBoxLocationAndPrice.ItemHeight = 17;
            this.ListBoxLocationAndPrice.Items.AddRange(new object[] {
            "Cliffs of Moher\t€55",
            "Kylemore Abbey\t€50",
            "Bunratty Castle\t€75",
            "The Burren\t€45",
            "Connemara\t‎€75",
            "Belmullet\t\t‎€99"});
            this.ListBoxLocationAndPrice.Location = new System.Drawing.Point(20, 114);
            this.ListBoxLocationAndPrice.Name = "ListBoxLocationAndPrice";
            this.ListBoxLocationAndPrice.Size = new System.Drawing.Size(187, 106);
            this.ListBoxLocationAndPrice.TabIndex = 0;
            this.ListBoxLocationAndPrice.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ListBoxDepartureTime
            // 
            this.ListBoxDepartureTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxDepartureTime.FormattingEnabled = true;
            this.ListBoxDepartureTime.ItemHeight = 17;
            this.ListBoxDepartureTime.Items.AddRange(new object[] {
            "7.00\t\t20%",
            "8.00\t\t10%",
            "9.00\t\t05%",
            "10.00\t\t0%",
            "11.00\t\t0%",
            "13.00\t\t25%"});
            this.ListBoxDepartureTime.Location = new System.Drawing.Point(308, 122);
            this.ListBoxDepartureTime.Name = "ListBoxDepartureTime";
            this.ListBoxDepartureTime.Size = new System.Drawing.Size(199, 106);
            this.ListBoxDepartureTime.TabIndex = 1;
            this.ListBoxDepartureTime.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // PanelHotelNames
            // 
            this.PanelHotelNames.BackColor = System.Drawing.SystemColors.Window;
            this.PanelHotelNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHotelNames.Controls.Add(this.RadioButtonNoHotel);
            this.PanelHotelNames.Controls.Add(this.RadioButton3Star);
            this.PanelHotelNames.Controls.Add(this.RadioButton4Star);
            this.PanelHotelNames.Controls.Add(this.RadioButton5Star);
            this.PanelHotelNames.Location = new System.Drawing.Point(600, 114);
            this.PanelHotelNames.Name = "PanelHotelNames";
            this.PanelHotelNames.Size = new System.Drawing.Size(145, 124);
            this.PanelHotelNames.TabIndex = 2;
            // 
            // RadioButtonNoHotel
            // 
            this.RadioButtonNoHotel.AutoSize = true;
            this.RadioButtonNoHotel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonNoHotel.Location = new System.Drawing.Point(4, 95);
            this.RadioButtonNoHotel.Name = "RadioButtonNoHotel";
            this.RadioButtonNoHotel.Size = new System.Drawing.Size(88, 23);
            this.RadioButtonNoHotel.TabIndex = 5;
            this.RadioButtonNoHotel.TabStop = true;
            this.RadioButtonNoHotel.Text = "No Hotel";
            this.RadioButtonNoHotel.UseVisualStyleBackColor = true;
            this.RadioButtonNoHotel.CheckedChanged += new System.EventHandler(this.RadioButtonNoHotel_CheckedChanged);
            // 
            // RadioButton3Star
            // 
            this.RadioButton3Star.AutoSize = true;
            this.RadioButton3Star.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RadioButton3Star.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton3Star.Location = new System.Drawing.Point(4, 65);
            this.RadioButton3Star.Name = "RadioButton3Star";
            this.RadioButton3Star.Size = new System.Drawing.Size(130, 23);
            this.RadioButton3Star.TabIndex = 4;
            this.RadioButton3Star.TabStop = true;
            this.RadioButton3Star.Text = "3 Star   @   €55";
            this.RadioButton3Star.UseVisualStyleBackColor = false;
            this.RadioButton3Star.CheckedChanged += new System.EventHandler(this.RadioButton3Star_CheckedChanged);
            // 
            // RadioButton4Star
            // 
            this.RadioButton4Star.AutoSize = true;
            this.RadioButton4Star.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RadioButton4Star.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton4Star.Location = new System.Drawing.Point(4, 36);
            this.RadioButton4Star.Name = "RadioButton4Star";
            this.RadioButton4Star.Size = new System.Drawing.Size(130, 23);
            this.RadioButton4Star.TabIndex = 3;
            this.RadioButton4Star.TabStop = true;
            this.RadioButton4Star.Text = "4 Star   @   €75";
            this.RadioButton4Star.UseVisualStyleBackColor = false;
            this.RadioButton4Star.CheckedChanged += new System.EventHandler(this.RadioButton4Star_CheckedChanged);
            // 
            // RadioButton5Star
            // 
            this.RadioButton5Star.AutoSize = true;
            this.RadioButton5Star.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RadioButton5Star.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton5Star.Location = new System.Drawing.Point(4, 7);
            this.RadioButton5Star.Name = "RadioButton5Star";
            this.RadioButton5Star.Size = new System.Drawing.Size(138, 23);
            this.RadioButton5Star.TabIndex = 0;
            this.RadioButton5Star.TabStop = true;
            this.RadioButton5Star.Text = "5 Star   @   €100";
            this.RadioButton5Star.UseVisualStyleBackColor = false;
            this.RadioButton5Star.CheckedChanged += new System.EventHandler(this.RadioButton5Star_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hotels";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "*Rates  per person";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LabelTotalGuests
            // 
            this.LabelTotalGuests.AutoSize = true;
            this.LabelTotalGuests.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTotalGuests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalGuests.Location = new System.Drawing.Point(45, 40);
            this.LabelTotalGuests.Name = "LabelTotalGuests";
            this.LabelTotalGuests.Size = new System.Drawing.Size(94, 19);
            this.LabelTotalGuests.TabIndex = 9;
            this.LabelTotalGuests.Text = "Total Guests";
            this.LabelTotalGuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotalGuests.Click += new System.EventHandler(this.label7_Click);
            // 
            // TextBoxTotalGuests
            // 
            this.TextBoxTotalGuests.Location = new System.Drawing.Point(168, 37);
            this.TextBoxTotalGuests.Name = "TextBoxTotalGuests";
            this.TextBoxTotalGuests.Size = new System.Drawing.Size(30, 26);
            this.TextBoxTotalGuests.TabIndex = 10;
            this.TextBoxTotalGuests.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(304, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 49);
            this.label8.TabIndex = 11;
            this.label8.Text = "7.5 % OFF Book with 3+ guests and include Lunch and Hotels";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBoxLunch);
            this.groupBox1.Controls.Add(this.LabelTotalGuests);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextBoxTotalGuests);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ListBoxLocationAndPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PanelHotelNames);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ListBoxDepartureTime);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 274);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Details";
            // 
            // CheckBoxLunch
            // 
            this.CheckBoxLunch.AutoSize = true;
            this.CheckBoxLunch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxLunch.Location = new System.Drawing.Point(254, 244);
            this.CheckBoxLunch.Name = "CheckBoxLunch";
            this.CheckBoxLunch.Size = new System.Drawing.Size(220, 23);
            this.CheckBoxLunch.TabIndex = 12;
            this.CheckBoxLunch.Text = "Lunch @ €11.50 (per person)";
            this.CheckBoxLunch.UseVisualStyleBackColor = true;
            this.CheckBoxLunch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GroupBoxGuestTripDetails
            // 
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelDepartureTimeValue);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelDepartureTime);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelLocationNameValue);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelLocationName);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelTotalCostValue);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelLunchCostValue);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelHotelCostValue);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelTripcostValue);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelTotalCost);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelLunchCost);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelHotelCost);
            this.GroupBoxGuestTripDetails.Controls.Add(this.LabelTripCost);
            this.GroupBoxGuestTripDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxGuestTripDetails.Location = new System.Drawing.Point(32, 450);
            this.GroupBoxGuestTripDetails.Name = "GroupBoxGuestTripDetails";
            this.GroupBoxGuestTripDetails.Size = new System.Drawing.Size(362, 256);
            this.GroupBoxGuestTripDetails.TabIndex = 14;
            this.GroupBoxGuestTripDetails.TabStop = false;
            this.GroupBoxGuestTripDetails.Text = "Guest Trip Details";
            // 
            // LabelDepartureTimeValue
            // 
            this.LabelDepartureTimeValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelDepartureTimeValue.Location = new System.Drawing.Point(194, 74);
            this.LabelDepartureTimeValue.Name = "LabelDepartureTimeValue";
            this.LabelDepartureTimeValue.Size = new System.Drawing.Size(103, 26);
            this.LabelDepartureTimeValue.TabIndex = 20;
            // 
            // LabelDepartureTime
            // 
            this.LabelDepartureTime.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelDepartureTime.Location = new System.Drawing.Point(23, 74);
            this.LabelDepartureTime.Name = "LabelDepartureTime";
            this.LabelDepartureTime.Size = new System.Drawing.Size(120, 26);
            this.LabelDepartureTime.TabIndex = 19;
            this.LabelDepartureTime.Text = "Departure Time";
            // 
            // LabelLocationNameValue
            // 
            this.LabelLocationNameValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelLocationNameValue.Location = new System.Drawing.Point(163, 38);
            this.LabelLocationNameValue.Name = "LabelLocationNameValue";
            this.LabelLocationNameValue.Size = new System.Drawing.Size(164, 26);
            this.LabelLocationNameValue.TabIndex = 18;
            this.LabelLocationNameValue.Click += new System.EventHandler(this.LabelLocationNameValues_Click);
            // 
            // LabelLocationName
            // 
            this.LabelLocationName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLocationName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocationName.Location = new System.Drawing.Point(25, 39);
            this.LabelLocationName.Name = "LabelLocationName";
            this.LabelLocationName.Size = new System.Drawing.Size(94, 25);
            this.LabelLocationName.TabIndex = 17;
            this.LabelLocationName.Text = "Location";
            this.LabelLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTotalCostValue
            // 
            this.LabelTotalCostValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelTotalCostValue.Location = new System.Drawing.Point(194, 222);
            this.LabelTotalCostValue.Name = "LabelTotalCostValue";
            this.LabelTotalCostValue.Size = new System.Drawing.Size(103, 26);
            this.LabelTotalCostValue.TabIndex = 16;
            // 
            // LabelLunchCostValue
            // 
            this.LabelLunchCostValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelLunchCostValue.Location = new System.Drawing.Point(194, 180);
            this.LabelLunchCostValue.Name = "LabelLunchCostValue";
            this.LabelLunchCostValue.Size = new System.Drawing.Size(103, 27);
            this.LabelLunchCostValue.TabIndex = 13;
            this.LabelLunchCostValue.Click += new System.EventHandler(this.TextBoxLunchCost_Click);
            // 
            // LabelHotelCostValue
            // 
            this.LabelHotelCostValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelHotelCostValue.Location = new System.Drawing.Point(194, 141);
            this.LabelHotelCostValue.Name = "LabelHotelCostValue";
            this.LabelHotelCostValue.Size = new System.Drawing.Size(103, 30);
            this.LabelHotelCostValue.TabIndex = 14;
            this.LabelHotelCostValue.Click += new System.EventHandler(this.LabelHotelCostValue_Click);
            // 
            // LabelTripcostValue
            // 
            this.LabelTripcostValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelTripcostValue.Location = new System.Drawing.Point(194, 105);
            this.LabelTripcostValue.Name = "LabelTripcostValue";
            this.LabelTripcostValue.Size = new System.Drawing.Size(103, 26);
            this.LabelTripcostValue.TabIndex = 13;
            this.LabelTripcostValue.Click += new System.EventHandler(this.LabelTripcostValue_Click);
            // 
            // LabelTotalCost
            // 
            this.LabelTotalCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTotalCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalCost.Location = new System.Drawing.Point(23, 223);
            this.LabelTotalCost.Name = "LabelTotalCost";
            this.LabelTotalCost.Size = new System.Drawing.Size(94, 25);
            this.LabelTotalCost.TabIndex = 15;
            this.LabelTotalCost.Text = "Total Cost";
            this.LabelTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelLunchCost
            // 
            this.LabelLunchCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLunchCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLunchCost.Location = new System.Drawing.Point(23, 181);
            this.LabelLunchCost.Name = "LabelLunchCost";
            this.LabelLunchCost.Size = new System.Drawing.Size(94, 26);
            this.LabelLunchCost.TabIndex = 12;
            this.LabelLunchCost.Text = "Lunch Cost";
            this.LabelLunchCost.Click += new System.EventHandler(this.label11_Click);
            // 
            // LabelHotelCost
            // 
            this.LabelHotelCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelHotelCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHotelCost.Location = new System.Drawing.Point(23, 145);
            this.LabelHotelCost.Name = "LabelHotelCost";
            this.LabelHotelCost.Size = new System.Drawing.Size(94, 26);
            this.LabelHotelCost.TabIndex = 11;
            this.LabelHotelCost.Text = "Hotel Cost";
            this.LabelHotelCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTripCost
            // 
            this.LabelTripCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTripCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTripCost.Location = new System.Drawing.Point(25, 109);
            this.LabelTripCost.Name = "LabelTripCost";
            this.LabelTripCost.Size = new System.Drawing.Size(94, 26);
            this.LabelTripCost.TabIndex = 10;
            this.LabelTripCost.Text = "Trip Cost";
            this.LabelTripCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelTripCost.Click += new System.EventHandler(this.label9_Click);
            // 
            // GroupBoxSummary
            // 
            this.GroupBoxSummary.Controls.Add(this.LabelAverageRevenueValue);
            this.GroupBoxSummary.Controls.Add(this.LabelValueOfOptionChoosenValue);
            this.GroupBoxSummary.Controls.Add(this.LabelTotalTripFessValue);
            this.GroupBoxSummary.Controls.Add(this.LabelTotalTransactionsValue);
            this.GroupBoxSummary.Controls.Add(this.LabelAverageRevenue);
            this.GroupBoxSummary.Controls.Add(this.LabelValueOfOptionsChoosen);
            this.GroupBoxSummary.Controls.Add(this.LabelTotalTripFess);
            this.GroupBoxSummary.Controls.Add(this.LabelTotalTransactions);
            this.GroupBoxSummary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSummary.Location = new System.Drawing.Point(412, 467);
            this.GroupBoxSummary.Name = "GroupBoxSummary";
            this.GroupBoxSummary.Size = new System.Drawing.Size(362, 172);
            this.GroupBoxSummary.TabIndex = 15;
            this.GroupBoxSummary.TabStop = false;
            this.GroupBoxSummary.Text = "Summary";
            // 
            // LabelAverageRevenueValue
            // 
            this.LabelAverageRevenueValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelAverageRevenueValue.Location = new System.Drawing.Point(221, 132);
            this.LabelAverageRevenueValue.Name = "LabelAverageRevenueValue";
            this.LabelAverageRevenueValue.Size = new System.Drawing.Size(103, 26);
            this.LabelAverageRevenueValue.TabIndex = 19;
            // 
            // LabelValueOfOptionChoosenValue
            // 
            this.LabelValueOfOptionChoosenValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelValueOfOptionChoosenValue.Location = new System.Drawing.Point(221, 92);
            this.LabelValueOfOptionChoosenValue.Name = "LabelValueOfOptionChoosenValue";
            this.LabelValueOfOptionChoosenValue.Size = new System.Drawing.Size(103, 26);
            this.LabelValueOfOptionChoosenValue.TabIndex = 18;
            // 
            // LabelTotalTripFessValue
            // 
            this.LabelTotalTripFessValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelTotalTripFessValue.Location = new System.Drawing.Point(221, 57);
            this.LabelTotalTripFessValue.Name = "LabelTotalTripFessValue";
            this.LabelTotalTripFessValue.Size = new System.Drawing.Size(103, 26);
            this.LabelTotalTripFessValue.TabIndex = 17;
            // 
            // LabelTotalTransactionsValue
            // 
            this.LabelTotalTransactionsValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LabelTotalTransactionsValue.Location = new System.Drawing.Point(221, 25);
            this.LabelTotalTransactionsValue.Name = "LabelTotalTransactionsValue";
            this.LabelTotalTransactionsValue.Size = new System.Drawing.Size(103, 26);
            this.LabelTotalTransactionsValue.TabIndex = 16;
            // 
            // LabelAverageRevenue
            // 
            this.LabelAverageRevenue.AutoSize = true;
            this.LabelAverageRevenue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelAverageRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAverageRevenue.Location = new System.Drawing.Point(13, 139);
            this.LabelAverageRevenue.Name = "LabelAverageRevenue";
            this.LabelAverageRevenue.Size = new System.Drawing.Size(129, 19);
            this.LabelAverageRevenue.TabIndex = 15;
            this.LabelAverageRevenue.Text = "Average Revenue";
            this.LabelAverageRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAverageRevenue.Click += new System.EventHandler(this.label13_Click);
            // 
            // LabelValueOfOptionsChoosen
            // 
            this.LabelValueOfOptionsChoosen.AutoSize = true;
            this.LabelValueOfOptionsChoosen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelValueOfOptionsChoosen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueOfOptionsChoosen.Location = new System.Drawing.Point(13, 99);
            this.LabelValueOfOptionsChoosen.Name = "LabelValueOfOptionsChoosen";
            this.LabelValueOfOptionsChoosen.Size = new System.Drawing.Size(174, 19);
            this.LabelValueOfOptionsChoosen.TabIndex = 12;
            this.LabelValueOfOptionsChoosen.Text = "Value of options choosen";
            this.LabelValueOfOptionsChoosen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelValueOfOptionsChoosen.Click += new System.EventHandler(this.label14_Click);
            // 
            // LabelTotalTripFess
            // 
            this.LabelTotalTripFess.AutoSize = true;
            this.LabelTotalTripFess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTotalTripFess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalTripFess.Location = new System.Drawing.Point(13, 64);
            this.LabelTotalTripFess.Name = "LabelTotalTripFess";
            this.LabelTotalTripFess.Size = new System.Drawing.Size(110, 19);
            this.LabelTotalTripFess.TabIndex = 11;
            this.LabelTotalTripFess.Text = "Total Trip Fees";
            this.LabelTotalTripFess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTotalTransactions
            // 
            this.LabelTotalTransactions.AutoSize = true;
            this.LabelTotalTransactions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTotalTransactions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalTransactions.Location = new System.Drawing.Point(13, 32);
            this.LabelTotalTransactions.Name = "LabelTotalTransactions";
            this.LabelTotalTransactions.Size = new System.Drawing.Size(132, 19);
            this.LabelTotalTransactions.TabIndex = 10;
            this.LabelTotalTransactions.Text = "Total Transactions";
            this.LabelTotalTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Window;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(159, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(376, 40);
            this.label17.TabIndex = 16;
            this.label17.Text = "Mild Atlantic Bus Tours";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ButtonExit);
            this.panel3.Controls.Add(this.ButtonClear);
            this.panel3.Controls.Add(this.ButtonSummary);
            this.panel3.Controls.Add(this.ButtonBook);
            this.panel3.Controls.Add(this.ButtonDisplay);
            this.panel3.Location = new System.Drawing.Point(41, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 76);
            this.panel3.TabIndex = 17;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(582, 23);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(102, 38);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "&Exit";
            this.ToolTip.SetToolTip(this.ButtonExit, "Please Click to Close the Application");
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonClear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Location = new System.Drawing.Point(464, 23);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(83, 38);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "&Clear";
            this.ToolTip.SetToolTip(this.ButtonClear, "Please Click Here For Next Booking");
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSummary
            // 
            this.ButtonSummary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonSummary.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSummary.Location = new System.Drawing.Point(307, 23);
            this.ButtonSummary.Name = "ButtonSummary";
            this.ButtonSummary.Size = new System.Drawing.Size(107, 38);
            this.ButtonSummary.TabIndex = 2;
            this.ButtonSummary.Text = "&Summary";
            this.ButtonSummary.UseVisualStyleBackColor = false;
            this.ButtonSummary.Click += new System.EventHandler(this.ButtonSummary_Click);
            // 
            // ButtonBook
            // 
            this.ButtonBook.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonBook.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBook.Location = new System.Drawing.Point(153, 23);
            this.ButtonBook.Name = "ButtonBook";
            this.ButtonBook.Size = new System.Drawing.Size(102, 38);
            this.ButtonBook.TabIndex = 1;
            this.ButtonBook.Text = "&Book";
            this.ButtonBook.UseVisualStyleBackColor = false;
            this.ButtonBook.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // ButtonDisplay
            // 
            this.ButtonDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonDisplay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisplay.Location = new System.Drawing.Point(5, 23);
            this.ButtonDisplay.Name = "ButtonDisplay";
            this.ButtonDisplay.Size = new System.Drawing.Size(102, 38);
            this.ButtonDisplay.TabIndex = 0;
            this.ButtonDisplay.Text = "&Display";
            this.ButtonDisplay.UseVisualStyleBackColor = false;
            this.ButtonDisplay.Click += new System.EventHandler(this.ButtonDisplay_Click);
            // 
            // ErrorProviderLocatonListBox
            // 
            this.ErrorProviderLocatonListBox.ContainerControl = this;
            // 
            // ErrorProviderDepartureListBox
            // 
            this.ErrorProviderDepartureListBox.ContainerControl = this;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.SystemColors.Window;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TextBoxTotalGuestErrorProvider
            // 
            this.TextBoxTotalGuestErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.GroupBoxSummary);
            this.Controls.Add(this.GroupBoxGuestTripDetails);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mild Atlantic Bus Tours";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelHotelNames.ResumeLayout(false);
            this.PanelHotelNames.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBoxGuestTripDetails.ResumeLayout(false);
            this.GroupBoxSummary.ResumeLayout(false);
            this.GroupBoxSummary.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderLocatonListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderDepartureListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxTotalGuestErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxLocationAndPrice;
        private System.Windows.Forms.ListBox ListBoxDepartureTime;
        private System.Windows.Forms.Panel PanelHotelNames;
        private System.Windows.Forms.RadioButton RadioButton3Star;
        private System.Windows.Forms.RadioButton RadioButton4Star;
        private System.Windows.Forms.RadioButton RadioButton5Star;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelTotalGuests;
        private System.Windows.Forms.TextBox TextBoxTotalGuests;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBoxLunch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GroupBoxGuestTripDetails;
        private System.Windows.Forms.Label LabelTotalCost;
        private System.Windows.Forms.Label LabelLunchCost;
        private System.Windows.Forms.Label LabelHotelCost;
        private System.Windows.Forms.Label LabelTripCost;
        private System.Windows.Forms.GroupBox GroupBoxSummary;
        private System.Windows.Forms.Label LabelAverageRevenue;
        private System.Windows.Forms.Label LabelValueOfOptionsChoosen;
        private System.Windows.Forms.Label LabelTotalTripFess;
        private System.Windows.Forms.Label LabelTotalTransactions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSummary;
        private System.Windows.Forms.Button ButtonBook;
        private System.Windows.Forms.Button ButtonDisplay;
        private System.Windows.Forms.RadioButton RadioButtonNoHotel;
        private System.Windows.Forms.Label LabelTotalCostValue;
        private System.Windows.Forms.Label LabelLunchCostValue;
        private System.Windows.Forms.Label LabelHotelCostValue;
        private System.Windows.Forms.Label LabelTripcostValue;
        private System.Windows.Forms.Label LabelTotalTransactionsValue;
        private System.Windows.Forms.Label LabelAverageRevenueValue;
        private System.Windows.Forms.Label LabelValueOfOptionChoosenValue;
        private System.Windows.Forms.Label LabelTotalTripFessValue;
        private System.Windows.Forms.Label LabelLocationName;
        private System.Windows.Forms.Label LabelLocationNameValue;
        private System.Windows.Forms.Label LabelDepartureTimeValue;
        private System.Windows.Forms.Label LabelDepartureTime;
        private System.Windows.Forms.ErrorProvider ErrorProviderLocatonListBox;
        private System.Windows.Forms.ErrorProvider ErrorProviderDepartureListBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ErrorProvider TextBoxTotalGuestErrorProvider;
    }
}

