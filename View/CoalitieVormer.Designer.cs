
namespace View
{
    partial class CoalitieVormer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsb_Partijen = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_naam = new System.Windows.Forms.TextBox();
            this.tb_Orde = new System.Windows.Forms.TextBox();
            this.tb_Lijsttrekker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_maxZetels = new System.Windows.Forms.Label();
            this.bt_saveUitslag = new System.Windows.Forms.Button();
            this.cb_verkiezing = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lsb_uitslagen = new System.Windows.Forms.ListBox();
            this.nud_zetels = new System.Windows.Forms.NumericUpDown();
            this.nud_percentage = new System.Windows.Forms.NumericUpDown();
            this.nud_stemmen = new System.Windows.Forms.NumericUpDown();
            this.cb_partijen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lsb_Coalitie = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_add_coalitie = new System.Windows.Forms.Button();
            this.cb_Uitslagregels = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_save_coalitie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zetels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_percentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stemmen)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsb_Partijen);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Partijen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsb_Partijen
            // 
            this.lsb_Partijen.FormattingEnabled = true;
            this.lsb_Partijen.ItemHeight = 20;
            this.lsb_Partijen.Location = new System.Drawing.Point(8, 189);
            this.lsb_Partijen.Name = "lsb_Partijen";
            this.lsb_Partijen.Size = new System.Drawing.Size(763, 204);
            this.lsb_Partijen.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_naam);
            this.groupBox1.Controls.Add(this.tb_Orde);
            this.groupBox1.Controls.Add(this.tb_Lijsttrekker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toevoegen";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(629, 119);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(94, 29);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_naam
            // 
            this.tb_naam.Location = new System.Drawing.Point(92, 49);
            this.tb_naam.Name = "tb_naam";
            this.tb_naam.Size = new System.Drawing.Size(664, 27);
            this.tb_naam.TabIndex = 1;
            // 
            // tb_Orde
            // 
            this.tb_Orde.Location = new System.Drawing.Point(92, 16);
            this.tb_Orde.Name = "tb_Orde";
            this.tb_Orde.Size = new System.Drawing.Size(664, 27);
            this.tb_Orde.TabIndex = 0;
            // 
            // tb_Lijsttrekker
            // 
            this.tb_Lijsttrekker.Location = new System.Drawing.Point(92, 85);
            this.tb_Lijsttrekker.Name = "tb_Lijsttrekker";
            this.tb_Lijsttrekker.Size = new System.Drawing.Size(664, 27);
            this.tb_Lijsttrekker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lijsttrekker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orde";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_maxZetels);
            this.tabPage2.Controls.Add(this.bt_saveUitslag);
            this.tabPage2.Controls.Add(this.cb_verkiezing);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lsb_uitslagen);
            this.tabPage2.Controls.Add(this.nud_zetels);
            this.tabPage2.Controls.Add(this.nud_percentage);
            this.tabPage2.Controls.Add(this.nud_stemmen);
            this.tabPage2.Controls.Add(this.cb_partijen);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uitslagen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_maxZetels
            // 
            this.lb_maxZetels.AutoSize = true;
            this.lb_maxZetels.Location = new System.Drawing.Point(260, 149);
            this.lb_maxZetels.Name = "lb_maxZetels";
            this.lb_maxZetels.Size = new System.Drawing.Size(62, 20);
            this.lb_maxZetels.TabIndex = 12;
            this.lb_maxZetels.Text = "(max: 0)";
            // 
            // bt_saveUitslag
            // 
            this.bt_saveUitslag.Location = new System.Drawing.Point(482, 84);
            this.bt_saveUitslag.Name = "bt_saveUitslag";
            this.bt_saveUitslag.Size = new System.Drawing.Size(137, 80);
            this.bt_saveUitslag.TabIndex = 11;
            this.bt_saveUitslag.Text = "SAVE";
            this.bt_saveUitslag.UseVisualStyleBackColor = true;
            this.bt_saveUitslag.Click += new System.EventHandler(this.bt_saveUitslag_Click);
            // 
            // cb_verkiezing
            // 
            this.cb_verkiezing.FormattingEnabled = true;
            this.cb_verkiezing.Location = new System.Drawing.Point(104, 5);
            this.cb_verkiezing.Name = "cb_verkiezing";
            this.cb_verkiezing.Size = new System.Drawing.Size(684, 28);
            this.cb_verkiezing.TabIndex = 10;
            this.cb_verkiezing.SelectedIndexChanged += new System.EventHandler(this.cb_verkiezing_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Verkiezing";
            // 
            // lsb_uitslagen
            // 
            this.lsb_uitslagen.FormattingEnabled = true;
            this.lsb_uitslagen.ItemHeight = 20;
            this.lsb_uitslagen.Location = new System.Drawing.Point(9, 203);
            this.lsb_uitslagen.Name = "lsb_uitslagen";
            this.lsb_uitslagen.Size = new System.Drawing.Size(775, 204);
            this.lsb_uitslagen.TabIndex = 8;
            // 
            // nud_zetels
            // 
            this.nud_zetels.Location = new System.Drawing.Point(104, 142);
            this.nud_zetels.Name = "nud_zetels";
            this.nud_zetels.Size = new System.Drawing.Size(150, 27);
            this.nud_zetels.TabIndex = 7;
            // 
            // nud_percentage
            // 
            this.nud_percentage.DecimalPlaces = 2;
            this.nud_percentage.Location = new System.Drawing.Point(105, 106);
            this.nud_percentage.Name = "nud_percentage";
            this.nud_percentage.Size = new System.Drawing.Size(150, 27);
            this.nud_percentage.TabIndex = 6;
            // 
            // nud_stemmen
            // 
            this.nud_stemmen.Location = new System.Drawing.Point(105, 74);
            this.nud_stemmen.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_stemmen.Name = "nud_stemmen";
            this.nud_stemmen.Size = new System.Drawing.Size(150, 27);
            this.nud_stemmen.TabIndex = 5;
            // 
            // cb_partijen
            // 
            this.cb_partijen.FormattingEnabled = true;
            this.cb_partijen.Location = new System.Drawing.Point(104, 39);
            this.cb_partijen.Name = "cb_partijen";
            this.cb_partijen.Size = new System.Drawing.Size(684, 28);
            this.cb_partijen.TabIndex = 4;
            this.cb_partijen.SelectedIndexChanged += new System.EventHandler(this.cb_partijen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Zetels";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Percentage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stemmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Partij";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_save_coalitie);
            this.tabPage3.Controls.Add(this.lsb_Coalitie);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.bt_add_coalitie);
            this.tabPage3.Controls.Add(this.cb_Uitslagregels);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Maak Coalitie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lsb_Coalitie
            // 
            this.lsb_Coalitie.FormattingEnabled = true;
            this.lsb_Coalitie.ItemHeight = 20;
            this.lsb_Coalitie.Location = new System.Drawing.Point(9, 90);
            this.lsb_Coalitie.Name = "lsb_Coalitie";
            this.lsb_Coalitie.Size = new System.Drawing.Size(775, 324);
            this.lsb_Coalitie.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "De volgende partijen zijn geselecteerd voor de coalitie:";
            // 
            // bt_add_coalitie
            // 
            this.bt_add_coalitie.Location = new System.Drawing.Point(690, 8);
            this.bt_add_coalitie.Name = "bt_add_coalitie";
            this.bt_add_coalitie.Size = new System.Drawing.Size(94, 29);
            this.bt_add_coalitie.TabIndex = 13;
            this.bt_add_coalitie.Text = "Add";
            this.bt_add_coalitie.UseVisualStyleBackColor = true;
            this.bt_add_coalitie.Click += new System.EventHandler(this.bt_add_coalitie_Click);
            // 
            // cb_Uitslagregels
            // 
            this.cb_Uitslagregels.FormattingEnabled = true;
            this.cb_Uitslagregels.Location = new System.Drawing.Point(80, 8);
            this.cb_Uitslagregels.Name = "cb_Uitslagregels";
            this.cb_Uitslagregels.Size = new System.Drawing.Size(596, 28);
            this.cb_Uitslagregels.TabIndex = 12;
            this.cb_Uitslagregels.SelectedIndexChanged += new System.EventHandler(this.cb_Uitslagregels_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Uitslag";
            // 
            // bt_save_coalitie
            // 
            this.bt_save_coalitie.Enabled = false;
            this.bt_save_coalitie.Location = new System.Drawing.Point(690, 44);
            this.bt_save_coalitie.Name = "bt_save_coalitie";
            this.bt_save_coalitie.Size = new System.Drawing.Size(94, 29);
            this.bt_save_coalitie.TabIndex = 16;
            this.bt_save_coalitie.Text = "Save";
            this.bt_save_coalitie.UseVisualStyleBackColor = true;
            // 
            // CoalitieVormer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CoalitieVormer";
            this.Text = "CoalitieVormer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zetels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_percentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stemmen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naam;
        private System.Windows.Forms.TextBox tb_Orde;
        private System.Windows.Forms.TextBox tb_Lijsttrekker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ListBox lsb_Partijen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsb_uitslagen;
        private System.Windows.Forms.NumericUpDown nud_zetels;
        private System.Windows.Forms.NumericUpDown nud_percentage;
        private System.Windows.Forms.NumericUpDown nud_stemmen;
        private System.Windows.Forms.ComboBox cb_partijen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_verkiezing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_saveUitslag;
        private System.Windows.Forms.Label lb_maxZetels;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bt_add_coalitie;
        private System.Windows.Forms.ComboBox cb_Uitslagregels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lsb_Coalitie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_save_coalitie;
    }
}

