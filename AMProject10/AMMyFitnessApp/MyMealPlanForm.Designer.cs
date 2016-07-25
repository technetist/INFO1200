namespace AMMyFitnessApp
{
    partial class MyMealPlanForm
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
            this.lblCalorieCount = new System.Windows.Forms.Label();
            this.lblTitleCalorieCount = new System.Windows.Forms.Label();
            this.lstBoxMealType = new System.Windows.Forms.ListBox();
            this.lblTitleMealType = new System.Windows.Forms.Label();
            this.lstBoxFoodItems = new System.Windows.Forms.ListBox();
            this.lblTitleFoodItem = new System.Windows.Forms.Label();
            this.lblDisplayDate = new System.Windows.Forms.Label();
            this.lblTitleItemCalories = new System.Windows.Forms.Label();
            this.lblItemCalories = new System.Windows.Forms.Label();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnAddFoodItem = new System.Windows.Forms.Button();
            this.lstBoxBreakfast = new System.Windows.Forms.ListBox();
            this.lblTitleBreakfast = new System.Windows.Forms.Label();
            this.lstBoxLunch = new System.Windows.Forms.ListBox();
            this.lblTitleLunch = new System.Windows.Forms.Label();
            this.lstBoxDinner = new System.Windows.Forms.ListBox();
            this.lblTitleDinner = new System.Windows.Forms.Label();
            this.lstBoxSnack = new System.Windows.Forms.ListBox();
            this.lblTitleSnack = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalorieCount
            // 
            this.lblCalorieCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalorieCount.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorieCount.Location = new System.Drawing.Point(460, 13);
            this.lblCalorieCount.Name = "lblCalorieCount";
            this.lblCalorieCount.Size = new System.Drawing.Size(82, 30);
            this.lblCalorieCount.TabIndex = 7;
            this.lblCalorieCount.Text = "0";
            this.lblCalorieCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCalorieCount
            // 
            this.lblTitleCalorieCount.AutoSize = true;
            this.lblTitleCalorieCount.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCalorieCount.Location = new System.Drawing.Point(285, 18);
            this.lblTitleCalorieCount.Name = "lblTitleCalorieCount";
            this.lblTitleCalorieCount.Size = new System.Drawing.Size(169, 21);
            this.lblTitleCalorieCount.TabIndex = 6;
            this.lblTitleCalorieCount.Text = "Daily Calorie Count:";
            // 
            // lstBoxMealType
            // 
            this.lstBoxMealType.FormattingEnabled = true;
            this.lstBoxMealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.lstBoxMealType.Location = new System.Drawing.Point(60, 116);
            this.lstBoxMealType.Name = "lstBoxMealType";
            this.lstBoxMealType.Size = new System.Drawing.Size(93, 69);
            this.lstBoxMealType.TabIndex = 16;
            // 
            // lblTitleMealType
            // 
            this.lblTitleMealType.AutoSize = true;
            this.lblTitleMealType.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMealType.Location = new System.Drawing.Point(38, 96);
            this.lblTitleMealType.Name = "lblTitleMealType";
            this.lblTitleMealType.Size = new System.Drawing.Size(115, 17);
            this.lblTitleMealType.TabIndex = 15;
            this.lblTitleMealType.Text = "Select Meal Type:";
            this.lblTitleMealType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxFoodItems
            // 
            this.lstBoxFoodItems.FormattingEnabled = true;
            this.lstBoxFoodItems.Location = new System.Drawing.Point(222, 116);
            this.lstBoxFoodItems.Name = "lstBoxFoodItems";
            this.lstBoxFoodItems.Size = new System.Drawing.Size(123, 108);
            this.lstBoxFoodItems.TabIndex = 18;
            this.lstBoxFoodItems.SelectedIndexChanged += new System.EventHandler(this.lstBoxFoodItems_SelectedIndexChanged);
            // 
            // lblTitleFoodItem
            // 
            this.lblTitleFoodItem.AutoSize = true;
            this.lblTitleFoodItem.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFoodItem.Location = new System.Drawing.Point(230, 96);
            this.lblTitleFoodItem.Name = "lblTitleFoodItem";
            this.lblTitleFoodItem.Size = new System.Drawing.Size(115, 17);
            this.lblTitleFoodItem.TabIndex = 17;
            this.lblTitleFoodItem.Text = "Select Food Item:";
            this.lblTitleFoodItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayDate
            // 
            this.lblDisplayDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayDate.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDate.Location = new System.Drawing.Point(12, 9);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(129, 37);
            this.lblDisplayDate.TabIndex = 19;
            this.lblDisplayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleItemCalories
            // 
            this.lblTitleItemCalories.AutoSize = true;
            this.lblTitleItemCalories.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleItemCalories.Location = new System.Drawing.Point(412, 126);
            this.lblTitleItemCalories.Name = "lblTitleItemCalories";
            this.lblTitleItemCalories.Size = new System.Drawing.Size(91, 17);
            this.lblTitleItemCalories.TabIndex = 20;
            this.lblTitleItemCalories.Text = "Item Calories:";
            this.lblTitleItemCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemCalories
            // 
            this.lblItemCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemCalories.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCalories.Location = new System.Drawing.Point(416, 152);
            this.lblItemCalories.Name = "lblItemCalories";
            this.lblItemCalories.Size = new System.Drawing.Size(82, 30);
            this.lblItemCalories.TabIndex = 21;
            this.lblItemCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddMeal.FlatAppearance.BorderSize = 2;
            this.btnAddMeal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddMeal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMeal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.Location = new System.Drawing.Point(409, 199);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(96, 53);
            this.btnAddMeal.TabIndex = 22;
            this.btnAddMeal.Text = "Add to Meal";
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnAddFoodItem
            // 
            this.btnAddFoodItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddFoodItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFoodItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddFoodItem.FlatAppearance.BorderSize = 2;
            this.btnAddFoodItem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddFoodItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFoodItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodItem.Location = new System.Drawing.Point(222, 230);
            this.btnAddFoodItem.Name = "btnAddFoodItem";
            this.btnAddFoodItem.Size = new System.Drawing.Size(122, 25);
            this.btnAddFoodItem.TabIndex = 23;
            this.btnAddFoodItem.Text = "Add New Food Item";
            this.btnAddFoodItem.UseVisualStyleBackColor = false;
            this.btnAddFoodItem.Click += new System.EventHandler(this.btnAddFoodItem_Click);
            // 
            // lstBoxBreakfast
            // 
            this.lstBoxBreakfast.FormattingEnabled = true;
            this.lstBoxBreakfast.Location = new System.Drawing.Point(18, 297);
            this.lstBoxBreakfast.Name = "lstBoxBreakfast";
            this.lstBoxBreakfast.Size = new System.Drawing.Size(253, 108);
            this.lstBoxBreakfast.TabIndex = 25;
            // 
            // lblTitleBreakfast
            // 
            this.lblTitleBreakfast.AutoSize = true;
            this.lblTitleBreakfast.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBreakfast.Location = new System.Drawing.Point(15, 277);
            this.lblTitleBreakfast.Name = "lblTitleBreakfast";
            this.lblTitleBreakfast.Size = new System.Drawing.Size(70, 17);
            this.lblTitleBreakfast.TabIndex = 24;
            this.lblTitleBreakfast.Text = "Breakfast:";
            this.lblTitleBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxLunch
            // 
            this.lstBoxLunch.FormattingEnabled = true;
            this.lstBoxLunch.Location = new System.Drawing.Point(289, 297);
            this.lstBoxLunch.Name = "lstBoxLunch";
            this.lstBoxLunch.Size = new System.Drawing.Size(253, 108);
            this.lstBoxLunch.TabIndex = 27;
            // 
            // lblTitleLunch
            // 
            this.lblTitleLunch.AutoSize = true;
            this.lblTitleLunch.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLunch.Location = new System.Drawing.Point(286, 277);
            this.lblTitleLunch.Name = "lblTitleLunch";
            this.lblTitleLunch.Size = new System.Drawing.Size(50, 17);
            this.lblTitleLunch.TabIndex = 26;
            this.lblTitleLunch.Text = "Lunch:";
            this.lblTitleLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxDinner
            // 
            this.lstBoxDinner.FormattingEnabled = true;
            this.lstBoxDinner.Location = new System.Drawing.Point(18, 433);
            this.lstBoxDinner.Name = "lstBoxDinner";
            this.lstBoxDinner.Size = new System.Drawing.Size(253, 108);
            this.lstBoxDinner.TabIndex = 29;
            // 
            // lblTitleDinner
            // 
            this.lblTitleDinner.AutoSize = true;
            this.lblTitleDinner.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDinner.Location = new System.Drawing.Point(15, 413);
            this.lblTitleDinner.Name = "lblTitleDinner";
            this.lblTitleDinner.Size = new System.Drawing.Size(53, 17);
            this.lblTitleDinner.TabIndex = 28;
            this.lblTitleDinner.Text = "Dinner:";
            this.lblTitleDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBoxSnack
            // 
            this.lstBoxSnack.FormattingEnabled = true;
            this.lstBoxSnack.Location = new System.Drawing.Point(289, 433);
            this.lstBoxSnack.Name = "lstBoxSnack";
            this.lstBoxSnack.Size = new System.Drawing.Size(253, 108);
            this.lstBoxSnack.TabIndex = 31;
            // 
            // lblTitleSnack
            // 
            this.lblTitleSnack.AutoSize = true;
            this.lblTitleSnack.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSnack.Location = new System.Drawing.Point(286, 413);
            this.lblTitleSnack.Name = "lblTitleSnack";
            this.lblTitleSnack.Size = new System.Drawing.Size(49, 17);
            this.lblTitleSnack.TabIndex = 30;
            this.lblTitleSnack.Text = "Snack:";
            this.lblTitleSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(498, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 28);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(217, 574);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 28);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clea&r Meal Plan";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyMealPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 614);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstBoxSnack);
            this.Controls.Add(this.lblTitleSnack);
            this.Controls.Add(this.lstBoxDinner);
            this.Controls.Add(this.lblTitleDinner);
            this.Controls.Add(this.lblTitleLunch);
            this.Controls.Add(this.lblTitleBreakfast);
            this.Controls.Add(this.btnAddFoodItem);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.lblItemCalories);
            this.Controls.Add(this.lblTitleItemCalories);
            this.Controls.Add(this.lblDisplayDate);
            this.Controls.Add(this.lstBoxFoodItems);
            this.Controls.Add(this.lblTitleFoodItem);
            this.Controls.Add(this.lstBoxMealType);
            this.Controls.Add(this.lblTitleMealType);
            this.Controls.Add(this.lblCalorieCount);
            this.Controls.Add(this.lblTitleCalorieCount);
            this.Controls.Add(this.lstBoxLunch);
            this.Controls.Add(this.lstBoxBreakfast);
            this.Name = "MyMealPlanForm";
            this.Text = "My Meal Plan";
            this.Load += new System.EventHandler(this.MyMealPlanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalorieCount;
        private System.Windows.Forms.Label lblTitleCalorieCount;
        private System.Windows.Forms.ListBox lstBoxMealType;
        private System.Windows.Forms.Label lblTitleMealType;
        private System.Windows.Forms.ListBox lstBoxFoodItems;
        private System.Windows.Forms.Label lblTitleFoodItem;
        private System.Windows.Forms.Label lblDisplayDate;
        private System.Windows.Forms.Label lblTitleItemCalories;
        private System.Windows.Forms.Label lblItemCalories;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnAddFoodItem;
        private System.Windows.Forms.ListBox lstBoxBreakfast;
        private System.Windows.Forms.Label lblTitleBreakfast;
        private System.Windows.Forms.ListBox lstBoxLunch;
        private System.Windows.Forms.Label lblTitleLunch;
        private System.Windows.Forms.ListBox lstBoxDinner;
        private System.Windows.Forms.Label lblTitleDinner;
        private System.Windows.Forms.ListBox lstBoxSnack;
        private System.Windows.Forms.Label lblTitleSnack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
    }
}