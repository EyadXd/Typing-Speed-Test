
namespace Typing_Test
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
            this.TbChallengeText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbType = new System.Windows.Forms.TextBox();
            this.PnKeyboard = new System.Windows.Forms.Panel();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PnKeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbChallengeText
            // 
            this.TbChallengeText.BackColor = System.Drawing.SystemColors.Window;
            this.TbChallengeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbChallengeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChallengeText.Location = new System.Drawing.Point(9, 19);
            this.TbChallengeText.Multiline = true;
            this.TbChallengeText.Name = "TbChallengeText";
            this.TbChallengeText.Size = new System.Drawing.Size(883, 121);
            this.TbChallengeText.TabIndex = 0;
            this.TbChallengeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.TbChallengeText);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Challenge Text Here !";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Window;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(183, 49);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(29, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 60);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Location = new System.Drawing.Point(246, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 60);
            this.panel2.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.Window;
            this.btnDone.Enabled = false;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(6, 6);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(183, 49);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Location = new System.Drawing.Point(461, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 60);
            this.panel3.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Window;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(183, 49);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.TbType);
            this.groupBox2.Location = new System.Drawing.Point(29, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type Here !";
            // 
            // TbType
            // 
            this.TbType.BackColor = System.Drawing.SystemColors.Window;
            this.TbType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbType.Enabled = false;
            this.TbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbType.Location = new System.Drawing.Point(8, 19);
            this.TbType.Multiline = true;
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(884, 89);
            this.TbType.TabIndex = 0;
            this.TbType.TextChanged += new System.EventHandler(this.TbType_TextChanged);
            this.TbType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // PnKeyboard
            // 
            this.PnKeyboard.BackColor = System.Drawing.Color.Black;
            this.PnKeyboard.Controls.Add(this.btnBackSpace);
            this.PnKeyboard.Controls.Add(this.btnSpace);
            this.PnKeyboard.Controls.Add(this.button27);
            this.PnKeyboard.Controls.Add(this.button28);
            this.PnKeyboard.Controls.Add(this.button29);
            this.PnKeyboard.Controls.Add(this.button30);
            this.PnKeyboard.Controls.Add(this.button31);
            this.PnKeyboard.Controls.Add(this.button32);
            this.PnKeyboard.Controls.Add(this.button33);
            this.PnKeyboard.Controls.Add(this.button34);
            this.PnKeyboard.Controls.Add(this.button35);
            this.PnKeyboard.Controls.Add(this.button36);
            this.PnKeyboard.Controls.Add(this.button16);
            this.PnKeyboard.Controls.Add(this.button17);
            this.PnKeyboard.Controls.Add(this.button18);
            this.PnKeyboard.Controls.Add(this.button19);
            this.PnKeyboard.Controls.Add(this.button20);
            this.PnKeyboard.Controls.Add(this.button21);
            this.PnKeyboard.Controls.Add(this.button22);
            this.PnKeyboard.Controls.Add(this.button23);
            this.PnKeyboard.Controls.Add(this.button24);
            this.PnKeyboard.Controls.Add(this.button25);
            this.PnKeyboard.Controls.Add(this.button26);
            this.PnKeyboard.Controls.Add(this.button15);
            this.PnKeyboard.Controls.Add(this.button14);
            this.PnKeyboard.Controls.Add(this.button13);
            this.PnKeyboard.Controls.Add(this.button12);
            this.PnKeyboard.Controls.Add(this.button11);
            this.PnKeyboard.Controls.Add(this.button10);
            this.PnKeyboard.Controls.Add(this.button9);
            this.PnKeyboard.Controls.Add(this.button8);
            this.PnKeyboard.Controls.Add(this.button7);
            this.PnKeyboard.Controls.Add(this.button6);
            this.PnKeyboard.Controls.Add(this.button5);
            this.PnKeyboard.Controls.Add(this.button4);
            this.PnKeyboard.Enabled = false;
            this.PnKeyboard.Location = new System.Drawing.Point(29, 432);
            this.PnKeyboard.Name = "PnKeyboard";
            this.PnKeyboard.Size = new System.Drawing.Size(904, 301);
            this.PnKeyboard.TabIndex = 6;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.Silver;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(782, 107);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(118, 26);
            this.btnBackSpace.TabIndex = 34;
            this.btnBackSpace.Tag = "\'\\b\'";
            this.btnBackSpace.Text = "Backspace";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.Color.Silver;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(82, 242);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(666, 43);
            this.btnSpace.TabIndex = 33;
            this.btnSpace.Tag = " ";
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Silver;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(690, 172);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(32, 43);
            this.button27.TabIndex = 32;
            this.button27.Tag = "?";
            this.button27.Text = "/";
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Silver;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(625, 172);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(32, 43);
            this.button28.TabIndex = 31;
            this.button28.Tag = ">";
            this.button28.Text = ".";
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Silver;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(560, 172);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(32, 43);
            this.button29.TabIndex = 30;
            this.button29.Tag = ",";
            this.button29.Text = "<";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Silver;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(495, 172);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(32, 43);
            this.button30.TabIndex = 29;
            this.button30.Tag = "m";
            this.button30.Text = "M";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Silver;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(430, 172);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(32, 43);
            this.button31.TabIndex = 28;
            this.button31.Tag = "n";
            this.button31.Text = "N";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Silver;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(365, 172);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(32, 43);
            this.button32.TabIndex = 27;
            this.button32.Tag = "b";
            this.button32.Text = "B";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Silver;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(300, 172);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(32, 43);
            this.button33.TabIndex = 26;
            this.button33.Tag = "v";
            this.button33.Text = "V";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Silver;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(235, 172);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(32, 43);
            this.button34.TabIndex = 25;
            this.button34.Tag = "c";
            this.button34.Text = "C";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Silver;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(170, 172);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(32, 43);
            this.button35.TabIndex = 24;
            this.button35.Tag = "x";
            this.button35.Text = "X";
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Silver;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(105, 172);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(32, 43);
            this.button36.TabIndex = 23;
            this.button36.Tag = "z";
            this.button36.Text = "Z";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Silver;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(732, 100);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(32, 43);
            this.button16.TabIndex = 22;
            this.button16.Tag = "\'";
            this.button16.Text = "\"";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Silver;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(667, 100);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(32, 43);
            this.button17.TabIndex = 21;
            this.button17.Tag = ":";
            this.button17.Text = ";";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Silver;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(602, 100);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(32, 43);
            this.button18.TabIndex = 20;
            this.button18.Tag = "l";
            this.button18.Text = "L";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Silver;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(537, 100);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(32, 43);
            this.button19.TabIndex = 19;
            this.button19.Tag = "k";
            this.button19.Text = "K";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Silver;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(472, 100);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(32, 43);
            this.button20.TabIndex = 18;
            this.button20.Tag = "j";
            this.button20.Text = "J";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Silver;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(407, 100);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(32, 43);
            this.button21.TabIndex = 17;
            this.button21.Tag = "h";
            this.button21.Text = "H";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Silver;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(342, 100);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(32, 43);
            this.button22.TabIndex = 16;
            this.button22.Tag = "g";
            this.button22.Text = "G";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Silver;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(277, 100);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(32, 43);
            this.button23.TabIndex = 15;
            this.button23.Tag = "f";
            this.button23.Text = "F";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Silver;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(212, 100);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(32, 43);
            this.button24.TabIndex = 14;
            this.button24.Tag = "d";
            this.button24.Text = "D";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Silver;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(147, 100);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(32, 43);
            this.button25.TabIndex = 13;
            this.button25.Tag = "s";
            this.button25.Text = "S";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Silver;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(82, 100);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(32, 43);
            this.button26.TabIndex = 12;
            this.button26.Tag = "a";
            this.button26.Text = "A";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Silver;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(822, 28);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(32, 43);
            this.button15.TabIndex = 11;
            this.button15.Tag = "}";
            this.button15.Text = "]";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(748, 28);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(32, 43);
            this.button14.TabIndex = 10;
            this.button14.Tag = "{";
            this.button14.Text = "[";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(674, 28);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 43);
            this.button13.TabIndex = 9;
            this.button13.Tag = "p";
            this.button13.Text = "P";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(600, 28);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 43);
            this.button12.TabIndex = 8;
            this.button12.Tag = "o";
            this.button12.Text = "O";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(526, 28);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 43);
            this.button11.TabIndex = 7;
            this.button11.Tag = "i";
            this.button11.Text = "I";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(452, 28);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 43);
            this.button10.TabIndex = 6;
            this.button10.Tag = "u";
            this.button10.Text = "U";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(378, 28);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 43);
            this.button9.TabIndex = 5;
            this.button9.Tag = "y";
            this.button9.Text = "Y";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(304, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 43);
            this.button8.TabIndex = 4;
            this.button8.Tag = "t";
            this.button8.Text = "T";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(230, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 43);
            this.button7.TabIndex = 3;
            this.button7.Tag = "r";
            this.button7.Text = "R";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(156, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 43);
            this.button6.TabIndex = 2;
            this.button6.Tag = "e";
            this.button6.Text = "E";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(82, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 43);
            this.button5.TabIndex = 1;
            this.button5.Tag = "w";
            this.button5.Text = "W";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 43);
            this.button4.TabIndex = 0;
            this.button4.Tag = "q";
            this.button4.Text = "Q";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 783);
            this.Controls.Add(this.PnKeyboard);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PnKeyboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbChallengeText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbType;
        private System.Windows.Forms.Panel PnKeyboard;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Timer timer1;
    }
}

