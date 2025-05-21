namespace Potion_Brewery
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
        private void InitializeComponent() {
            btnManageIngredients = new Button();
            btnPotionRecipe = new Button();
            TotalIngredientLabel = new Label();
            LowStockLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TotalRecipesLabel = new Label();
            ManageBrewingBtn = new Button();
            MostBrewedPotionsGrid = new DataGridView();
            MostUsedIngredientGrid = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            TotalBrewedPotionsLabel = new Label();
            TotalBrewedPotionsValue = new Label();
            MostIngredientUsedLabel = new Label();
            MostIngredientUsedValue = new Label();
            ((System.ComponentModel.ISupportInitialize)MostBrewedPotionsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostUsedIngredientGrid).BeginInit();
            SuspendLayout();
            // 
            // btnManageIngredients
            // 
            btnManageIngredients.Location = new Point(36, 496);
            btnManageIngredients.Name = "btnManageIngredients";
            btnManageIngredients.Size = new Size(199, 37);
            btnManageIngredients.TabIndex = 0;
            btnManageIngredients.Text = "Manage Ingredients";
            btnManageIngredients.UseVisualStyleBackColor = true;
            btnManageIngredients.Click += btnManageIngredients_Click;
            // 
            // btnPotionRecipe
            // 
            btnPotionRecipe.Location = new Point(353, 496);
            btnPotionRecipe.Name = "btnPotionRecipe";
            btnPotionRecipe.Size = new Size(199, 37);
            btnPotionRecipe.TabIndex = 1;
            btnPotionRecipe.Text = "Manage Potion Recipe";
            btnPotionRecipe.UseVisualStyleBackColor = true;
            btnPotionRecipe.Click += btnPotionRecipe_Click;
            // 
            // TotalIngredientLabel
            // 
            TotalIngredientLabel.AutoSize = true;
            TotalIngredientLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            TotalIngredientLabel.ForeColor = SystemColors.MenuHighlight;
            TotalIngredientLabel.Location = new Point(278, 38);
            TotalIngredientLabel.Name = "TotalIngredientLabel";
            TotalIngredientLabel.Size = new Size(33, 37);
            TotalIngredientLabel.TabIndex = 2;
            TotalIngredientLabel.Text = "0";
            // 
            // LowStockLabel
            // 
            LowStockLabel.AutoSize = true;
            LowStockLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            LowStockLabel.ForeColor = Color.Red;
            LowStockLabel.Location = new Point(630, 38);
            LowStockLabel.Name = "LowStockLabel";
            LowStockLabel.Size = new Size(33, 37);
            LowStockLabel.TabIndex = 3;
            LowStockLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 4;
            label1.Text = "Total Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(386, 38);
            label2.Name = "label2";
            label2.Size = new Size(219, 37);
            label2.TabIndex = 5;
            label2.Text = "Low Stock Alert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(754, 38);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 7;
            label3.Text = "Total Recipes";
            // 
            // TotalRecipesLabel
            // 
            TotalRecipesLabel.AutoSize = true;
            TotalRecipesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            TotalRecipesLabel.ForeColor = SystemColors.MenuHighlight;
            TotalRecipesLabel.Location = new Point(989, 38);
            TotalRecipesLabel.Name = "TotalRecipesLabel";
            TotalRecipesLabel.Size = new Size(33, 37);
            TotalRecipesLabel.TabIndex = 6;
            TotalRecipesLabel.Text = "0";
            // 
            // ManageBrewingBtn
            // 
            ManageBrewingBtn.Location = new Point(665, 496);
            ManageBrewingBtn.Name = "ManageBrewingBtn";
            ManageBrewingBtn.Size = new Size(199, 37);
            ManageBrewingBtn.TabIndex = 8;
            ManageBrewingBtn.Text = "Manage Brewing";
            ManageBrewingBtn.UseVisualStyleBackColor = true;
            ManageBrewingBtn.Click += ManageBrewingBtn_Click;
            // 
            // MostBrewedPotionsGrid
            // 
            MostBrewedPotionsGrid.AllowUserToAddRows = false;
            MostBrewedPotionsGrid.AllowUserToDeleteRows = false;
            MostBrewedPotionsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostBrewedPotionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostBrewedPotionsGrid.Location = new Point(39, 261);
            MostBrewedPotionsGrid.Name = "MostBrewedPotionsGrid";
            MostBrewedPotionsGrid.ReadOnly = true;
            MostBrewedPotionsGrid.RowHeadersVisible = false;
            MostBrewedPotionsGrid.Size = new Size(537, 193);
            MostBrewedPotionsGrid.TabIndex = 9;
            // 
            // MostUsedIngredientGrid
            // 
            MostUsedIngredientGrid.AllowUserToAddRows = false;
            MostUsedIngredientGrid.AllowUserToDeleteRows = false;
            MostUsedIngredientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostUsedIngredientGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostUsedIngredientGrid.Location = new Point(615, 261);
            MostUsedIngredientGrid.Name = "MostUsedIngredientGrid";
            MostUsedIngredientGrid.ReadOnly = true;
            MostUsedIngredientGrid.RowHeadersVisible = false;
            MostUsedIngredientGrid.Size = new Size(499, 193);
            MostUsedIngredientGrid.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 230);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 11;
            label4.Text = "Most Brewed Potions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 230);
            label5.Name = "label5";
            label5.Size = new Size(159, 21);
            label5.TabIndex = 12;
            label5.Text = "Most Used Ingredient";
            // 
            // TotalBrewedPotionsLabel
            // 
            TotalBrewedPotionsLabel.AutoSize = true;
            TotalBrewedPotionsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            TotalBrewedPotionsLabel.ForeColor = SystemColors.MenuHighlight;
            TotalBrewedPotionsLabel.Location = new Point(36, 116);
            TotalBrewedPotionsLabel.Name = "TotalBrewedPotionsLabel";
            TotalBrewedPotionsLabel.Size = new Size(290, 37);
            TotalBrewedPotionsLabel.TabIndex = 14;
            TotalBrewedPotionsLabel.Text = "Total Brewed Potions";
            // 
            // TotalBrewedPotionsValue
            // 
            TotalBrewedPotionsValue.AutoSize = true;
            TotalBrewedPotionsValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            TotalBrewedPotionsValue.ForeColor = SystemColors.MenuHighlight;
            TotalBrewedPotionsValue.Location = new Point(353, 116);
            TotalBrewedPotionsValue.Name = "TotalBrewedPotionsValue";
            TotalBrewedPotionsValue.Size = new Size(33, 37);
            TotalBrewedPotionsValue.TabIndex = 13;
            TotalBrewedPotionsValue.Text = "0";
            // 
            // MostIngredientUsedLabel
            // 
            MostIngredientUsedLabel.AutoSize = true;
            MostIngredientUsedLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            MostIngredientUsedLabel.ForeColor = SystemColors.MenuHighlight;
            MostIngredientUsedLabel.Location = new Point(484, 116);
            MostIngredientUsedLabel.Name = "MostIngredientUsedLabel";
            MostIngredientUsedLabel.Size = new Size(296, 37);
            MostIngredientUsedLabel.TabIndex = 16;
            MostIngredientUsedLabel.Text = "Most Ingredient Used";
            // 
            // MostIngredientUsedValue
            // 
            MostIngredientUsedValue.AutoSize = true;
            MostIngredientUsedValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            MostIngredientUsedValue.ForeColor = SystemColors.MenuHighlight;
            MostIngredientUsedValue.Location = new Point(801, 116);
            MostIngredientUsedValue.Name = "MostIngredientUsedValue";
            MostIngredientUsedValue.Size = new Size(33, 37);
            MostIngredientUsedValue.TabIndex = 15;
            MostIngredientUsedValue.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 575);
            Controls.Add(MostIngredientUsedLabel);
            Controls.Add(MostIngredientUsedValue);
            Controls.Add(TotalBrewedPotionsLabel);
            Controls.Add(TotalBrewedPotionsValue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(MostUsedIngredientGrid);
            Controls.Add(MostBrewedPotionsGrid);
            Controls.Add(ManageBrewingBtn);
            Controls.Add(label3);
            Controls.Add(TotalRecipesLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LowStockLabel);
            Controls.Add(TotalIngredientLabel);
            Controls.Add(btnPotionRecipe);
            Controls.Add(btnManageIngredients);
            Name = "Form1";
            Text = "Potion Brewery Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MostBrewedPotionsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostUsedIngredientGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageIngredients;
        private Button btnPotionRecipe;
        private Label TotalIngredientLabel;
        private Label LowStockLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TotalRecipesLabel;
        private Button ManageBrewingBtn;
        private DataGridView MostBrewedPotionsGrid;
        private DataGridView MostUsedIngredientGrid;
        private Label label4;
        private Label label5;
        private Label TotalBrewedPotionsLabel;
        private Label TotalBrewedPotionsValue;
        private Label MostIngredientUsedLabel;
        private Label MostIngredientUsedValue;
    }
}
