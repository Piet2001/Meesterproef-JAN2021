
namespace View
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_naam = new System.Windows.Forms.TextBox();
            this.tb_Orde = new System.Windows.Forms.TextBox();
            this.tb_Lijsttrekker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsb_Partijen = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_naam
            // 
            this.tb_naam.Location = new System.Drawing.Point(92, 49);
            this.tb_naam.Name = "tb_naam";
            this.tb_naam.Size = new System.Drawing.Size(664, 27);
            this.tb_naam.TabIndex = 5;
            // 
            // tb_Orde
            // 
            this.tb_Orde.Location = new System.Drawing.Point(92, 16);
            this.tb_Orde.Name = "tb_Orde";
            this.tb_Orde.Size = new System.Drawing.Size(664, 27);
            this.tb_Orde.TabIndex = 4;
            // 
            // tb_Lijsttrekker
            // 
            this.tb_Lijsttrekker.Location = new System.Drawing.Point(92, 85);
            this.tb_Lijsttrekker.Name = "tb_Lijsttrekker";
            this.tb_Lijsttrekker.Size = new System.Drawing.Size(664, 27);
            this.tb_Lijsttrekker.TabIndex = 3;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uitslagen";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

