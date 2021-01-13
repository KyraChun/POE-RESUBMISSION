namespace GADE5112___20104162___Task_1
{
    partial class GameForm
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
            this.heroStats_LB = new System.Windows.Forms.Label();
            this.heroName_TB = new System.Windows.Forms.TextBox();
            this.heroName_LB = new System.Windows.Forms.Label();
            this.heroAttack_ListBox = new System.Windows.Forms.ListBox();
            this.enemyStats_LB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attack_BTN = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.RichTextBox();
            this.load_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.shop_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // heroStats_LB
            // 
            this.heroStats_LB.AutoSize = true;
            this.heroStats_LB.Location = new System.Drawing.Point(382, 131);
            this.heroStats_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heroStats_LB.Name = "heroStats_LB";
            this.heroStats_LB.Size = new System.Drawing.Size(75, 17);
            this.heroStats_LB.TabIndex = 1;
            this.heroStats_LB.Text = "Hero Stats";
            // 
            // heroName_TB
            // 
            this.heroName_TB.Location = new System.Drawing.Point(182, 50);
            this.heroName_TB.Margin = new System.Windows.Forms.Padding(4);
            this.heroName_TB.Name = "heroName_TB";
            this.heroName_TB.Size = new System.Drawing.Size(186, 22);
            this.heroName_TB.TabIndex = 2;
            this.heroName_TB.TextChanged += new System.EventHandler(this.heroName_TB_TextChanged);
            // 
            // heroName_LB
            // 
            this.heroName_LB.AutoSize = true;
            this.heroName_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroName_LB.Location = new System.Drawing.Point(382, 100);
            this.heroName_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heroName_LB.Name = "heroName_LB";
            this.heroName_LB.Size = new System.Drawing.Size(89, 17);
            this.heroName_LB.TabIndex = 3;
            this.heroName_LB.Text = "Hero Name";
            this.heroName_LB.Click += new System.EventHandler(this.heroName_LB_Click);
            // 
            // heroAttack_ListBox
            // 
            this.heroAttack_ListBox.FormattingEnabled = true;
            this.heroAttack_ListBox.ItemHeight = 16;
            this.heroAttack_ListBox.Location = new System.Drawing.Point(91, 377);
            this.heroAttack_ListBox.Name = "heroAttack_ListBox";
            this.heroAttack_ListBox.Size = new System.Drawing.Size(134, 100);
            this.heroAttack_ListBox.TabIndex = 4;
            this.heroAttack_ListBox.SelectedIndexChanged += new System.EventHandler(this.heroAttack_ListBox_SelectedIndexChanged);
            // 
            // enemyStats_LB
            // 
            this.enemyStats_LB.AutoSize = true;
            this.enemyStats_LB.Location = new System.Drawing.Point(382, 312);
            this.enemyStats_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyStats_LB.Name = "enemyStats_LB";
            this.enemyStats_LB.Size = new System.Drawing.Size(87, 17);
            this.enemyStats_LB.TabIndex = 5;
            this.enemyStats_LB.Text = "Enemy Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type in your Hero\'s Name";
            // 
            // attack_BTN
            // 
            this.attack_BTN.Location = new System.Drawing.Point(246, 377);
            this.attack_BTN.Name = "attack_BTN";
            this.attack_BTN.Size = new System.Drawing.Size(88, 100);
            this.attack_BTN.TabIndex = 7;
            this.attack_BTN.Text = "Attack\r\n(Space)";
            this.attack_BTN.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(200, 529);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(134, 46);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.map.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(55, 100);
            this.map.Name = "map";
            this.map.ReadOnly = true;
            this.map.Size = new System.Drawing.Size(313, 271);
            this.map.TabIndex = 9;
            this.map.Text = "";
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(385, 529);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(134, 46);
            this.load_btn.TabIndex = 10;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 529);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(134, 46);
            this.start_btn.TabIndex = 11;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // shop_btn
            // 
            this.shop_btn.Location = new System.Drawing.Point(171, 591);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(196, 54);
            this.shop_btn.TabIndex = 12;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = true;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 119);
            this.label2.TabIndex = 13;
            this.label2.Text = "H - Hero\r\nX - Wall\r\nW - Weapon\r\nG - Gold\r\nK - Goblin\r\nM - Mage\r\nL - Leader\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(528, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 154);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(646, 657);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.map);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.attack_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyStats_LB);
            this.Controls.Add(this.heroAttack_ListBox);
            this.Controls.Add(this.heroName_LB);
            this.Controls.Add(this.heroName_TB);
            this.Controls.Add(this.heroStats_LB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Rogue Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label heroStats_LB;
        private System.Windows.Forms.TextBox heroName_TB;
        private System.Windows.Forms.Label heroName_LB;
        private System.Windows.Forms.ListBox heroAttack_ListBox;
        private System.Windows.Forms.Label enemyStats_LB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attack_BTN;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.RichTextBox map;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button shop_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

