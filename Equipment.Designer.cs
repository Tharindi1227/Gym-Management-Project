
namespace Gym_System
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.lbl_equip = new System.Windows.Forms.Label();
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.lnl_muscies = new System.Windows.Forms.Label();
            this.lbl_deliver = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.txt_equipname = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.txt_muscles = new System.Windows.Forms.TextBox();
            this.dob_ddate = new System.Windows.Forms.DateTimePicker();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_viewequip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_equip
            // 
            this.lbl_equip.AutoSize = true;
            this.lbl_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equip.Location = new System.Drawing.Point(344, 139);
            this.lbl_equip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_equip.Name = "lbl_equip";
            this.lbl_equip.Size = new System.Drawing.Size(151, 20);
            this.lbl_equip.TabIndex = 0;
            this.lbl_equip.Text = "Equipment Name";
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip.Location = new System.Drawing.Point(344, 191);
            this.lbl_descrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(106, 20);
            this.lbl_descrip.TabIndex = 1;
            this.lbl_descrip.Text = "Description";
            // 
            // lnl_muscies
            // 
            this.lnl_muscies.AutoSize = true;
            this.lnl_muscies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_muscies.Location = new System.Drawing.Point(344, 283);
            this.lnl_muscies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnl_muscies.Name = "lnl_muscies";
            this.lnl_muscies.Size = new System.Drawing.Size(128, 20);
            this.lnl_muscies.TabIndex = 2;
            this.lnl_muscies.Text = "Muscles Used";
            // 
            // lbl_deliver
            // 
            this.lbl_deliver.AutoSize = true;
            this.lbl_deliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deliver.Location = new System.Drawing.Point(344, 331);
            this.lbl_deliver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deliver.Name = "lbl_deliver";
            this.lbl_deliver.Size = new System.Drawing.Size(124, 20);
            this.lbl_deliver.TabIndex = 3;
            this.lbl_deliver.Text = "Delivery Date";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(344, 386);
            this.lbl_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(48, 20);
            this.lbl_cost.TabIndex = 4;
            this.lbl_cost.Text = "Cost";
            // 
            // txt_equipname
            // 
            this.txt_equipname.Location = new System.Drawing.Point(544, 135);
            this.txt_equipname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_equipname.Name = "txt_equipname";
            this.txt_equipname.Size = new System.Drawing.Size(132, 22);
            this.txt_equipname.TabIndex = 5;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(544, 187);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(229, 57);
            this.txt_description.TabIndex = 6;
            this.txt_description.Text = "";
            // 
            // txt_muscles
            // 
            this.txt_muscles.Location = new System.Drawing.Point(544, 274);
            this.txt_muscles.Margin = new System.Windows.Forms.Padding(4);
            this.txt_muscles.Name = "txt_muscles";
            this.txt_muscles.Size = new System.Drawing.Size(161, 22);
            this.txt_muscles.TabIndex = 7;
            // 
            // dob_ddate
            // 
            this.dob_ddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_ddate.Location = new System.Drawing.Point(544, 322);
            this.dob_ddate.Margin = new System.Windows.Forms.Padding(4);
            this.dob_ddate.Name = "dob_ddate";
            this.dob_ddate.Size = new System.Drawing.Size(161, 22);
            this.dob_ddate.TabIndex = 8;
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(544, 378);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(161, 22);
            this.txt_cost.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(319, 475);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 64);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(521, 475);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(123, 64);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_viewequip
            // 
            this.btn_viewequip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_viewequip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewequip.Location = new System.Drawing.Point(720, 475);
            this.btn_viewequip.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewequip.Name = "btn_viewequip";
            this.btn_viewequip.Size = new System.Drawing.Size(127, 64);
            this.btn_viewequip.TabIndex = 12;
            this.btn_viewequip.Text = "View Equipments";
            this.btn_viewequip.UseVisualStyleBackColor = false;
            this.btn_viewequip.Click += new System.EventHandler(this.btn_viewequip_Click);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 565);
            this.Controls.Add(this.btn_viewequip);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.dob_ddate);
            this.Controls.Add(this.txt_muscles);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_equipname);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_deliver);
            this.Controls.Add(this.lnl_muscies);
            this.Controls.Add(this.lbl_descrip);
            this.Controls.Add(this.lbl_equip);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_equip;
        private System.Windows.Forms.Label lbl_descrip;
        private System.Windows.Forms.Label lnl_muscies;
        private System.Windows.Forms.Label lbl_deliver;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.TextBox txt_equipname;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.TextBox txt_muscles;
        private System.Windows.Forms.DateTimePicker dob_ddate;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_viewequip;
    }
}