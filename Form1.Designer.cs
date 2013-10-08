namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.calcScreen = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.decimal_btn = new System.Windows.Forms.Button();
            this.switchSign = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.memAdd = new System.Windows.Forms.Button();
            this.memStore = new System.Windows.Forms.Button();
            this.memRecall = new System.Windows.Forms.Button();
            this.memClear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clear_Entry = new System.Windows.Forms.Button();
            this.clear_All = new System.Windows.Forms.Button();
            this.open_paren = new System.Windows.Forms.Button();
            this.close_paren = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.operation_txt = new System.Windows.Forms.TextBox();
            this.paren_txt = new System.Windows.Forms.TextBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mem_text = new System.Windows.Forms.TextBox();
            this.radian_btn = new System.Windows.Forms.RadioButton();
            this.degrees_btn = new System.Windows.Forms.RadioButton();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calcScreen
            // 
            this.calcScreen.BackColor = System.Drawing.SystemColors.Window;
            this.calcScreen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calcScreen.Location = new System.Drawing.Point(125, 34);
            this.calcScreen.MaxLength = 32;
            this.calcScreen.Name = "calcScreen";
            this.calcScreen.ReadOnly = true;
            this.calcScreen.Size = new System.Drawing.Size(199, 20);
            this.calcScreen.TabIndex = 0;
            this.calcScreen.TabStop = false;
            this.calcScreen.Text = "0";
            this.calcScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven
            // 
            this.seven.ForeColor = System.Drawing.Color.Blue;
            this.seven.Location = new System.Drawing.Point(128, 126);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(32, 30);
            this.seven.TabIndex = 2;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.number_btn);
            // 
            // eight
            // 
            this.eight.ForeColor = System.Drawing.Color.Blue;
            this.eight.Location = new System.Drawing.Point(169, 126);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(32, 30);
            this.eight.TabIndex = 3;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.number_btn);
            // 
            // nine
            // 
            this.nine.ForeColor = System.Drawing.Color.Blue;
            this.nine.Location = new System.Drawing.Point(210, 126);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(32, 30);
            this.nine.TabIndex = 4;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.number_btn);
            // 
            // sqrt
            // 
            this.sqrt.ForeColor = System.Drawing.Color.Blue;
            this.sqrt.Location = new System.Drawing.Point(292, 126);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(32, 30);
            this.sqrt.TabIndex = 6;
            this.sqrt.TabStop = false;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.other_btn);
            // 
            // percent
            // 
            this.percent.ForeColor = System.Drawing.Color.Blue;
            this.percent.Location = new System.Drawing.Point(292, 159);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(32, 30);
            this.percent.TabIndex = 11;
            this.percent.TabStop = false;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.other_btn);
            // 
            // multiply
            // 
            this.multiply.ForeColor = System.Drawing.Color.Red;
            this.multiply.Location = new System.Drawing.Point(251, 159);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(32, 30);
            this.multiply.TabIndex = 10;
            this.multiply.TabStop = false;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operation_btn);
            // 
            // six
            // 
            this.six.ForeColor = System.Drawing.Color.Blue;
            this.six.Location = new System.Drawing.Point(210, 159);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(32, 30);
            this.six.TabIndex = 9;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.number_btn);
            // 
            // five
            // 
            this.five.ForeColor = System.Drawing.Color.Blue;
            this.five.Location = new System.Drawing.Point(169, 159);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(32, 30);
            this.five.TabIndex = 8;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.number_btn);
            // 
            // four
            // 
            this.four.ForeColor = System.Drawing.Color.Blue;
            this.four.Location = new System.Drawing.Point(128, 159);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(32, 30);
            this.four.TabIndex = 7;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.number_btn);
            // 
            // inverse
            // 
            this.inverse.ForeColor = System.Drawing.Color.Blue;
            this.inverse.Location = new System.Drawing.Point(292, 192);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(32, 30);
            this.inverse.TabIndex = 16;
            this.inverse.TabStop = false;
            this.inverse.Text = "1/x";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.other_btn);
            // 
            // subtract
            // 
            this.subtract.ForeColor = System.Drawing.Color.Red;
            this.subtract.Location = new System.Drawing.Point(251, 192);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(32, 30);
            this.subtract.TabIndex = 15;
            this.subtract.TabStop = false;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operation_btn);
            // 
            // three
            // 
            this.three.ForeColor = System.Drawing.Color.Blue;
            this.three.Location = new System.Drawing.Point(210, 192);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(32, 30);
            this.three.TabIndex = 14;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.number_btn);
            // 
            // two
            // 
            this.two.ForeColor = System.Drawing.Color.Blue;
            this.two.Location = new System.Drawing.Point(169, 192);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(32, 30);
            this.two.TabIndex = 13;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.number_btn);
            // 
            // one
            // 
            this.one.ForeColor = System.Drawing.Color.Blue;
            this.one.Location = new System.Drawing.Point(128, 192);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(32, 30);
            this.one.TabIndex = 12;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.number_btn);
            // 
            // equals
            // 
            this.equals.ForeColor = System.Drawing.Color.Red;
            this.equals.Location = new System.Drawing.Point(292, 225);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(32, 30);
            this.equals.TabIndex = 21;
            this.equals.TabStop = false;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_btn);
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.Color.Red;
            this.add.Location = new System.Drawing.Point(251, 225);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(32, 30);
            this.add.TabIndex = 20;
            this.add.TabStop = false;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operation_btn);
            // 
            // decimal_btn
            // 
            this.decimal_btn.ForeColor = System.Drawing.Color.Blue;
            this.decimal_btn.Location = new System.Drawing.Point(210, 225);
            this.decimal_btn.Name = "decimal_btn";
            this.decimal_btn.Size = new System.Drawing.Size(32, 30);
            this.decimal_btn.TabIndex = 19;
            this.decimal_btn.TabStop = false;
            this.decimal_btn.Text = ".";
            this.decimal_btn.UseVisualStyleBackColor = true;
            this.decimal_btn.Click += new System.EventHandler(this.other_btn);
            // 
            // switchSign
            // 
            this.switchSign.ForeColor = System.Drawing.Color.Blue;
            this.switchSign.Location = new System.Drawing.Point(169, 225);
            this.switchSign.Name = "switchSign";
            this.switchSign.Size = new System.Drawing.Size(32, 30);
            this.switchSign.TabIndex = 18;
            this.switchSign.TabStop = false;
            this.switchSign.Text = "+/-";
            this.switchSign.UseVisualStyleBackColor = true;
            this.switchSign.Click += new System.EventHandler(this.other_btn);
            // 
            // zero
            // 
            this.zero.ForeColor = System.Drawing.Color.Blue;
            this.zero.Location = new System.Drawing.Point(128, 225);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(32, 30);
            this.zero.TabIndex = 17;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.number_btn);
            // 
            // memAdd
            // 
            this.memAdd.ForeColor = System.Drawing.Color.Red;
            this.memAdd.Location = new System.Drawing.Point(86, 225);
            this.memAdd.Name = "memAdd";
            this.memAdd.Size = new System.Drawing.Size(35, 30);
            this.memAdd.TabIndex = 25;
            this.memAdd.TabStop = false;
            this.memAdd.Text = "M+";
            this.memAdd.UseVisualStyleBackColor = true;
            this.memAdd.Click += new System.EventHandler(this.memory_btn);
            // 
            // memStore
            // 
            this.memStore.ForeColor = System.Drawing.Color.Red;
            this.memStore.Location = new System.Drawing.Point(86, 192);
            this.memStore.Name = "memStore";
            this.memStore.Size = new System.Drawing.Size(35, 30);
            this.memStore.TabIndex = 24;
            this.memStore.TabStop = false;
            this.memStore.Text = "M";
            this.memStore.UseVisualStyleBackColor = true;
            this.memStore.Click += new System.EventHandler(this.memory_btn);
            // 
            // memRecall
            // 
            this.memRecall.ForeColor = System.Drawing.Color.Red;
            this.memRecall.Location = new System.Drawing.Point(86, 159);
            this.memRecall.Name = "memRecall";
            this.memRecall.Size = new System.Drawing.Size(35, 30);
            this.memRecall.TabIndex = 23;
            this.memRecall.TabStop = false;
            this.memRecall.Text = "MR";
            this.memRecall.UseVisualStyleBackColor = true;
            this.memRecall.Click += new System.EventHandler(this.memory_btn);
            // 
            // memClear
            // 
            this.memClear.ForeColor = System.Drawing.Color.Red;
            this.memClear.Location = new System.Drawing.Point(86, 126);
            this.memClear.Name = "memClear";
            this.memClear.Size = new System.Drawing.Size(35, 30);
            this.memClear.TabIndex = 22;
            this.memClear.TabStop = false;
            this.memClear.Text = "MC";
            this.memClear.UseVisualStyleBackColor = true;
            this.memClear.Click += new System.EventHandler(this.memory_btn);
            // 
            // backspace
            // 
            this.backspace.ForeColor = System.Drawing.Color.Red;
            this.backspace.Location = new System.Drawing.Point(251, 94);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(73, 30);
            this.backspace.TabIndex = 27;
            this.backspace.TabStop = false;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.other_btn);
            // 
            // clear_Entry
            // 
            this.clear_Entry.ForeColor = System.Drawing.Color.Red;
            this.clear_Entry.Location = new System.Drawing.Point(210, 60);
            this.clear_Entry.Name = "clear_Entry";
            this.clear_Entry.Size = new System.Drawing.Size(50, 30);
            this.clear_Entry.TabIndex = 28;
            this.clear_Entry.TabStop = false;
            this.clear_Entry.Text = "CE";
            this.clear_Entry.UseVisualStyleBackColor = true;
            this.clear_Entry.Click += new System.EventHandler(this.clear_btn);
            // 
            // clear_All
            // 
            this.clear_All.ForeColor = System.Drawing.Color.Red;
            this.clear_All.Location = new System.Drawing.Point(273, 60);
            this.clear_All.Name = "clear_All";
            this.clear_All.Size = new System.Drawing.Size(51, 30);
            this.clear_All.TabIndex = 29;
            this.clear_All.TabStop = false;
            this.clear_All.Text = "C";
            this.clear_All.UseVisualStyleBackColor = true;
            this.clear_All.Click += new System.EventHandler(this.clear_btn);
            // 
            // open_paren
            // 
            this.open_paren.ForeColor = System.Drawing.Color.Purple;
            this.open_paren.Location = new System.Drawing.Point(128, 94);
            this.open_paren.Name = "open_paren";
            this.open_paren.Size = new System.Drawing.Size(32, 30);
            this.open_paren.TabIndex = 30;
            this.open_paren.TabStop = false;
            this.open_paren.Text = "(";
            this.open_paren.UseVisualStyleBackColor = true;
            this.open_paren.Click += new System.EventHandler(this.other_btn);
            // 
            // close_paren
            // 
            this.close_paren.ForeColor = System.Drawing.Color.Purple;
            this.close_paren.Location = new System.Drawing.Point(169, 94);
            this.close_paren.Name = "close_paren";
            this.close_paren.Size = new System.Drawing.Size(32, 30);
            this.close_paren.TabIndex = 31;
            this.close_paren.TabStop = false;
            this.close_paren.Text = ")";
            this.close_paren.UseVisualStyleBackColor = true;
            this.close_paren.Click += new System.EventHandler(this.other_btn);
            // 
            // pi
            // 
            this.pi.ForeColor = System.Drawing.Color.Purple;
            this.pi.Location = new System.Drawing.Point(210, 94);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(32, 30);
            this.pi.TabIndex = 32;
            this.pi.TabStop = false;
            this.pi.Text = "pi";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.trig_btn);
            // 
            // divide
            // 
            this.divide.ForeColor = System.Drawing.Color.Red;
            this.divide.Location = new System.Drawing.Point(251, 126);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(32, 30);
            this.divide.TabIndex = 34;
            this.divide.TabStop = false;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operation_btn);
            // 
            // operation_txt
            // 
            this.operation_txt.BackColor = System.Drawing.SystemColors.InfoText;
            this.operation_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.operation_txt.Enabled = false;
            this.operation_txt.ForeColor = System.Drawing.Color.LimeGreen;
            this.operation_txt.Location = new System.Drawing.Point(99, 34);
            this.operation_txt.Name = "operation_txt";
            this.operation_txt.ReadOnly = true;
            this.operation_txt.Size = new System.Drawing.Size(20, 20);
            this.operation_txt.TabIndex = 35;
            this.operation_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paren_txt
            // 
            this.paren_txt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.paren_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paren_txt.ForeColor = System.Drawing.Color.Purple;
            this.paren_txt.Location = new System.Drawing.Point(128, 64);
            this.paren_txt.MaxLength = 32;
            this.paren_txt.Name = "paren_txt";
            this.paren_txt.ReadOnly = true;
            this.paren_txt.Size = new System.Drawing.Size(73, 20);
            this.paren_txt.TabIndex = 49;
            this.paren_txt.TabStop = false;
            this.paren_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy_btn,
            this.paste_btn});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copy_btn
            // 
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy_btn.Size = new System.Drawing.Size(144, 22);
            this.copy_btn.Text = "Copy";
            this.copy_btn.Click += new System.EventHandler(this.menu_btn);
            // 
            // paste_btn
            // 
            this.paste_btn.Name = "paste_btn";
            this.paste_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste_btn.Size = new System.Drawing.Size(144, 22);
            this.paste_btn.Text = "Paste";
            this.paste_btn.Click += new System.EventHandler(this.menu_btn);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitGroup});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // digitGroup
            // 
            this.digitGroup.Name = "digitGroup";
            this.digitGroup.Size = new System.Drawing.Size(152, 22);
            this.digitGroup.Text = "Digit Grouping";
            this.digitGroup.Click += new System.EventHandler(this.menu_btn);
            // 
            // about_btn
            // 
            this.about_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicstoolStripMenuItem,
            this.aboutCalculatorToolStripMenuItem});
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(44, 20);
            this.about_btn.Text = "Help";
            // 
            // helpTopicstoolStripMenuItem
            // 
            this.helpTopicstoolStripMenuItem.Name = "helpTopicstoolStripMenuItem";
            this.helpTopicstoolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.helpTopicstoolStripMenuItem.Text = "Documentation";
            this.helpTopicstoolStripMenuItem.Click += new System.EventHandler(this.helpPopup);
            // 
            // aboutCalculatorToolStripMenuItem
            // 
            this.aboutCalculatorToolStripMenuItem.Name = "aboutCalculatorToolStripMenuItem";
            this.aboutCalculatorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutCalculatorToolStripMenuItem.Text = "About Calculator";
            this.aboutCalculatorToolStripMenuItem.Click += new System.EventHandler(this.about_Popup);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.about_btn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mem_text
            // 
            this.mem_text.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mem_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mem_text.Enabled = false;
            this.mem_text.ForeColor = System.Drawing.Color.Red;
            this.mem_text.Location = new System.Drawing.Point(86, 100);
            this.mem_text.MaxLength = 32;
            this.mem_text.Name = "mem_text";
            this.mem_text.ReadOnly = true;
            this.mem_text.Size = new System.Drawing.Size(35, 20);
            this.mem_text.TabIndex = 56;
            this.mem_text.TabStop = false;
            this.mem_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radian_btn
            // 
            this.radian_btn.AutoSize = true;
            this.radian_btn.Checked = true;
            this.radian_btn.Location = new System.Drawing.Point(13, 120);
            this.radian_btn.Name = "radian_btn";
            this.radian_btn.Size = new System.Drawing.Size(64, 17);
            this.radian_btn.TabIndex = 57;
            this.radian_btn.TabStop = true;
            this.radian_btn.Text = "Radians";
            this.radian_btn.UseVisualStyleBackColor = true;
            this.radian_btn.Click += new System.EventHandler(this.toggleMode_btn);
            // 
            // degrees_btn
            // 
            this.degrees_btn.AutoSize = true;
            this.degrees_btn.Location = new System.Drawing.Point(13, 137);
            this.degrees_btn.Name = "degrees_btn";
            this.degrees_btn.Size = new System.Drawing.Size(65, 17);
            this.degrees_btn.TabIndex = 58;
            this.degrees_btn.Text = "Degrees";
            this.degrees_btn.UseVisualStyleBackColor = true;
            this.degrees_btn.Click += new System.EventHandler(this.toggleMode_btn);
            // 
            // cos
            // 
            this.cos.ForeColor = System.Drawing.Color.Purple;
            this.cos.Location = new System.Drawing.Point(12, 189);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(64, 30);
            this.cos.TabIndex = 59;
            this.cos.TabStop = false;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.trig_btn);
            // 
            // tan
            // 
            this.tan.ForeColor = System.Drawing.Color.Purple;
            this.tan.Location = new System.Drawing.Point(12, 219);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(64, 30);
            this.tan.TabIndex = 60;
            this.tan.TabStop = false;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.trig_btn);
            // 
            // sin
            // 
            this.sin.ForeColor = System.Drawing.Color.Purple;
            this.sin.Location = new System.Drawing.Point(12, 159);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(64, 30);
            this.sin.TabIndex = 61;
            this.sin.TabStop = false;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.trig_btn);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 62;
            // 
            // status_txt
            // 
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 54);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.degrees_btn);
            this.Controls.Add(this.radian_btn);
            this.Controls.Add(this.mem_text);
            this.Controls.Add(this.paren_txt);
            this.Controls.Add(this.operation_txt);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.memAdd);
            this.Controls.Add(this.clear_All);
            this.Controls.Add(this.close_paren);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.clear_Entry);
            this.Controls.Add(this.memStore);
            this.Controls.Add(this.open_paren);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.memRecall);
            this.Controls.Add(this.memClear);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.calcScreen);
            this.Controls.Add(this.add);
            this.Controls.Add(this.decimal_btn);
            this.Controls.Add(this.switchSign);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 325);
            this.MinimumSize = new System.Drawing.Size(350, 325);
            this.Name = "Calculator";
            this.Text = "Calculator #";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcScreen;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button decimal_btn;
        private System.Windows.Forms.Button switchSign;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button memAdd;
        private System.Windows.Forms.Button memStore;
        private System.Windows.Forms.Button memRecall;
        private System.Windows.Forms.Button memClear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear_Entry;
        private System.Windows.Forms.Button clear_All;
        private System.Windows.Forms.Button open_paren;
        private System.Windows.Forms.Button close_paren;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox operation_txt;
        private System.Windows.Forms.TextBox paren_txt;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copy_btn;
        private System.Windows.Forms.ToolStripMenuItem paste_btn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitGroup;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.ToolStripMenuItem aboutCalculatorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox mem_text;
        private System.Windows.Forms.RadioButton radian_btn;
        private System.Windows.Forms.RadioButton degrees_btn;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.ToolStripMenuItem helpTopicstoolStripMenuItem;
    }
}

