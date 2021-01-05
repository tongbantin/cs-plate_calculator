namespace WindowsFormsApp2
{
    partial class PlateCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlateCalculator));
            this.rad_barbell = new System.Windows.Forms.RadioButton();
            this.rad_1dumbbell = new System.Windows.Forms.RadioButton();
            this.rad_2dumbbell = new System.Windows.Forms.RadioButton();
            this.txt_bar_wg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dum_wg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_wg1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty11 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_wg2 = new System.Windows.Forms.TextBox();
            this.txt_qty2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_wg3 = new System.Windows.Forms.TextBox();
            this.txt_qty3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_qty5 = new System.Windows.Forms.NumericUpDown();
            this.txt_qty4 = new System.Windows.Forms.NumericUpDown();
            this.txt_wg5 = new System.Windows.Forms.TextBox();
            this.txt_wg4 = new System.Windows.Forms.TextBox();
            this.txt_wg6 = new System.Windows.Forms.TextBox();
            this.txt_qty6 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.lbl_totalwg = new System.Windows.Forms.Label();
            this.lbl_totalqty = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textprice1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textprice2 = new System.Windows.Forms.TextBox();
            this.textprice3 = new System.Windows.Forms.TextBox();
            this.textprice4 = new System.Windows.Forms.TextBox();
            this.textprice5 = new System.Windows.Forms.TextBox();
            this.textprice6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbltotalpriceqty = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty6)).BeginInit();
            this.SuspendLayout();
            // 
            // rad_barbell
            // 
            this.rad_barbell.AutoSize = true;
            this.rad_barbell.Checked = true;
            this.rad_barbell.Location = new System.Drawing.Point(42, 12);
            this.rad_barbell.Name = "rad_barbell";
            this.rad_barbell.Size = new System.Drawing.Size(57, 17);
            this.rad_barbell.TabIndex = 0;
            this.rad_barbell.TabStop = true;
            this.rad_barbell.Text = "Barbell";
            this.rad_barbell.UseVisualStyleBackColor = true;
            // 
            // rad_1dumbbell
            // 
            this.rad_1dumbbell.AutoSize = true;
            this.rad_1dumbbell.Location = new System.Drawing.Point(299, 12);
            this.rad_1dumbbell.Name = "rad_1dumbbell";
            this.rad_1dumbbell.Size = new System.Drawing.Size(98, 17);
            this.rad_1dumbbell.TabIndex = 0;
            this.rad_1dumbbell.Text = "SingleDumbbell";
            this.rad_1dumbbell.UseVisualStyleBackColor = true;
            // 
            // rad_2dumbbell
            // 
            this.rad_2dumbbell.AutoSize = true;
            this.rad_2dumbbell.Location = new System.Drawing.Point(442, 12);
            this.rad_2dumbbell.Name = "rad_2dumbbell";
            this.rad_2dumbbell.Size = new System.Drawing.Size(103, 17);
            this.rad_2dumbbell.TabIndex = 0;
            this.rad_2dumbbell.Text = "DoubleDumbbell";
            this.rad_2dumbbell.UseVisualStyleBackColor = true;
            // 
            // txt_bar_wg
            // 
            this.txt_bar_wg.Location = new System.Drawing.Point(27, 48);
            this.txt_bar_wg.Name = "txt_bar_wg";
            this.txt_bar_wg.Size = new System.Drawing.Size(100, 20);
            this.txt_bar_wg.TabIndex = 1;
            this.txt_bar_wg.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "kg";
            // 
            // txt_dum_wg
            // 
            this.txt_dum_wg.Location = new System.Drawing.Point(299, 48);
            this.txt_dum_wg.Name = "txt_dum_wg";
            this.txt_dum_wg.Size = new System.Drawing.Size(100, 20);
            this.txt_dum_wg.TabIndex = 1;
            this.txt_dum_wg.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "kg";
            // 
            // txt_wg1
            // 
            this.txt_wg1.Location = new System.Drawing.Point(27, 115);
            this.txt_wg1.Name = "txt_wg1";
            this.txt_wg1.Size = new System.Drawing.Size(40, 20);
            this.txt_wg1.TabIndex = 1;
            this.txt_wg1.Text = "1.25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "kg";
            // 
            // txt_qty11
            // 
            this.txt_qty11.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty11.Location = new System.Drawing.Point(105, 115);
            this.txt_qty11.Name = "txt_qty11";
            this.txt_qty11.Size = new System.Drawing.Size(47, 20);
            this.txt_qty11.TabIndex = 1;
            this.txt_qty11.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty11.ValueChanged += new System.EventHandler(this.numeric_change);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "qty";
            // 
            // txt_wg2
            // 
            this.txt_wg2.Location = new System.Drawing.Point(27, 141);
            this.txt_wg2.Name = "txt_wg2";
            this.txt_wg2.Size = new System.Drawing.Size(40, 20);
            this.txt_wg2.TabIndex = 1;
            this.txt_wg2.Text = "2.5";
            // 
            // txt_qty2
            // 
            this.txt_qty2.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty2.Location = new System.Drawing.Point(105, 141);
            this.txt_qty2.Name = "txt_qty2";
            this.txt_qty2.Size = new System.Drawing.Size(47, 20);
            this.txt_qty2.TabIndex = 1;
            this.txt_qty2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty2.ValueChanged += new System.EventHandler(this.numeric_change);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "qty";
            // 
            // txt_wg3
            // 
            this.txt_wg3.Location = new System.Drawing.Point(27, 167);
            this.txt_wg3.Name = "txt_wg3";
            this.txt_wg3.Size = new System.Drawing.Size(40, 20);
            this.txt_wg3.TabIndex = 1;
            this.txt_wg3.Text = "5";
            // 
            // txt_qty3
            // 
            this.txt_qty3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty3.Location = new System.Drawing.Point(105, 167);
            this.txt_qty3.Name = "txt_qty3";
            this.txt_qty3.Size = new System.Drawing.Size(47, 20);
            this.txt_qty3.TabIndex = 1;
            this.txt_qty3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty3.ValueChanged += new System.EventHandler(this.numeric_change);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "qty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "kg";
            // 
            // txt_qty5
            // 
            this.txt_qty5.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty5.Location = new System.Drawing.Point(105, 219);
            this.txt_qty5.Name = "txt_qty5";
            this.txt_qty5.Size = new System.Drawing.Size(47, 20);
            this.txt_qty5.TabIndex = 3;
            this.txt_qty5.ValueChanged += new System.EventHandler(this.numeric_change);
            // 
            // txt_qty4
            // 
            this.txt_qty4.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty4.Location = new System.Drawing.Point(105, 193);
            this.txt_qty4.Name = "txt_qty4";
            this.txt_qty4.Size = new System.Drawing.Size(47, 20);
            this.txt_qty4.TabIndex = 4;
            this.txt_qty4.ValueChanged += new System.EventHandler(this.numeric_change);
            // 
            // txt_wg5
            // 
            this.txt_wg5.Location = new System.Drawing.Point(27, 219);
            this.txt_wg5.Name = "txt_wg5";
            this.txt_wg5.Size = new System.Drawing.Size(40, 20);
            this.txt_wg5.TabIndex = 5;
            this.txt_wg5.Text = "15";
            // 
            // txt_wg4
            // 
            this.txt_wg4.Location = new System.Drawing.Point(27, 193);
            this.txt_wg4.Name = "txt_wg4";
            this.txt_wg4.Size = new System.Drawing.Size(40, 20);
            this.txt_wg4.TabIndex = 6;
            this.txt_wg4.Text = "10";
            // 
            // txt_wg6
            // 
            this.txt_wg6.Location = new System.Drawing.Point(27, 245);
            this.txt_wg6.Name = "txt_wg6";
            this.txt_wg6.Size = new System.Drawing.Size(40, 20);
            this.txt_wg6.TabIndex = 5;
            this.txt_wg6.Text = "20";
            // 
            // txt_qty6
            // 
            this.txt_qty6.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_qty6.Location = new System.Drawing.Point(105, 245);
            this.txt_qty6.Name = "txt_qty6";
            this.txt_qty6.Size = new System.Drawing.Size(47, 20);
            this.txt_qty6.TabIndex = 3;
            this.txt_qty6.ValueChanged += new System.EventHandler(this.numeric_change);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "kg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "kg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "qty";
            // 
            // txt_Result
            // 
            this.txt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Result.Location = new System.Drawing.Point(299, 74);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Result.Size = new System.Drawing.Size(643, 342);
            this.txt_Result.TabIndex = 9;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(611, 12);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(177, 23);
            this.btn_cal.TabIndex = 10;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // lbl_totalwg
            // 
            this.lbl_totalwg.AutoSize = true;
            this.lbl_totalwg.Location = new System.Drawing.Point(27, 282);
            this.lbl_totalwg.Name = "lbl_totalwg";
            this.lbl_totalwg.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalwg.TabIndex = 11;
            this.lbl_totalwg.Text = "0";
            // 
            // lbl_totalqty
            // 
            this.lbl_totalqty.AutoSize = true;
            this.lbl_totalqty.Location = new System.Drawing.Point(111, 282);
            this.lbl_totalqty.Name = "lbl_totalqty";
            this.lbl_totalqty.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalqty.TabIndex = 11;
            this.lbl_totalqty.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(74, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "kg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "qty";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(58, 74);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(41, 20);
            this.txt_price.TabIndex = 1;
            this.txt_price.Text = "59";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(105, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "baht/kg";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "price";
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.AutoSize = true;
            this.lbl_totalprice.Location = new System.Drawing.Point(27, 309);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalprice.TabIndex = 11;
            this.lbl_totalprice.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(74, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "baht";
            // 
            // textprice1
            // 
            this.textprice1.Location = new System.Drawing.Point(198, 114);
            this.textprice1.Name = "textprice1";
            this.textprice1.Size = new System.Drawing.Size(40, 20);
            this.textprice1.TabIndex = 1;
            this.textprice1.Text = "275";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(244, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "bht/qty";
            // 
            // textprice2
            // 
            this.textprice2.Location = new System.Drawing.Point(198, 141);
            this.textprice2.Name = "textprice2";
            this.textprice2.Size = new System.Drawing.Size(40, 20);
            this.textprice2.TabIndex = 1;
            this.textprice2.Text = "275";
            // 
            // textprice3
            // 
            this.textprice3.Location = new System.Drawing.Point(198, 166);
            this.textprice3.Name = "textprice3";
            this.textprice3.Size = new System.Drawing.Size(40, 20);
            this.textprice3.TabIndex = 1;
            this.textprice3.Text = "550";
            // 
            // textprice4
            // 
            this.textprice4.Location = new System.Drawing.Point(198, 193);
            this.textprice4.Name = "textprice4";
            this.textprice4.Size = new System.Drawing.Size(40, 20);
            this.textprice4.TabIndex = 1;
            this.textprice4.Text = "1100";
            // 
            // textprice5
            // 
            this.textprice5.Location = new System.Drawing.Point(198, 218);
            this.textprice5.Name = "textprice5";
            this.textprice5.Size = new System.Drawing.Size(40, 20);
            this.textprice5.TabIndex = 1;
            this.textprice5.Text = "1650";
            // 
            // textprice6
            // 
            this.textprice6.Location = new System.Drawing.Point(198, 244);
            this.textprice6.Name = "textprice6";
            this.textprice6.Size = new System.Drawing.Size(40, 20);
            this.textprice6.TabIndex = 1;
            this.textprice6.Text = "2200";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(244, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "bht/qty";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(244, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "bht/qty";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(244, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "bht/qty";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(244, 222);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "bht/qty";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(244, 247);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "bht/qty";
            // 
            // lbltotalpriceqty
            // 
            this.lbltotalpriceqty.AutoSize = true;
            this.lbltotalpriceqty.Location = new System.Drawing.Point(195, 309);
            this.lbltotalpriceqty.Name = "lbltotalpriceqty";
            this.lbltotalpriceqty.Size = new System.Drawing.Size(13, 13);
            this.lbltotalpriceqty.TabIndex = 17;
            this.lbltotalpriceqty.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(244, 309);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "baht";
            // 
            // PlateCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lbltotalpriceqty);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_totalqty);
            this.Controls.Add(this.lbl_totalprice);
            this.Controls.Add(this.lbl_totalwg);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_qty6);
            this.Controls.Add(this.txt_qty5);
            this.Controls.Add(this.txt_wg6);
            this.Controls.Add(this.txt_qty4);
            this.Controls.Add(this.txt_wg5);
            this.Controls.Add(this.txt_wg4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_qty3);
            this.Controls.Add(this.txt_qty2);
            this.Controls.Add(this.txt_wg3);
            this.Controls.Add(this.txt_qty11);
            this.Controls.Add(this.txt_wg2);
            this.Controls.Add(this.txt_dum_wg);
            this.Controls.Add(this.textprice6);
            this.Controls.Add(this.textprice5);
            this.Controls.Add(this.textprice4);
            this.Controls.Add(this.textprice3);
            this.Controls.Add(this.textprice2);
            this.Controls.Add(this.textprice1);
            this.Controls.Add(this.txt_wg1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_bar_wg);
            this.Controls.Add(this.rad_2dumbbell);
            this.Controls.Add(this.rad_1dumbbell);
            this.Controls.Add(this.rad_barbell);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlateCalculator";
            this.Text = "PlateCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_barbell;
        private System.Windows.Forms.RadioButton rad_1dumbbell;
        private System.Windows.Forms.RadioButton rad_2dumbbell;
        private System.Windows.Forms.TextBox txt_bar_wg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dum_wg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_wg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_qty11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_wg2;
        private System.Windows.Forms.NumericUpDown txt_qty2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_wg3;
        private System.Windows.Forms.NumericUpDown txt_qty3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txt_qty5;
        private System.Windows.Forms.NumericUpDown txt_qty4;
        private System.Windows.Forms.TextBox txt_wg5;
        private System.Windows.Forms.TextBox txt_wg4;
        private System.Windows.Forms.TextBox txt_wg6;
        private System.Windows.Forms.NumericUpDown txt_qty6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label lbl_totalwg;
        private System.Windows.Forms.Label lbl_totalqty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textprice1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textprice2;
        private System.Windows.Forms.TextBox textprice3;
        private System.Windows.Forms.TextBox textprice4;
        private System.Windows.Forms.TextBox textprice5;
        private System.Windows.Forms.TextBox textprice6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbltotalpriceqty;
        private System.Windows.Forms.Label label27;
    }
}

