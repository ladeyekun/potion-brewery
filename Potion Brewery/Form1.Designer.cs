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
            SuspendLayout();
            // 
            // btnManageIngredients
            // 
            btnManageIngredients.Location = new Point(36, 271);
            btnManageIngredients.Name = "btnManageIngredients";
            btnManageIngredients.Size = new Size(199, 37);
            btnManageIngredients.TabIndex = 0;
            btnManageIngredients.Text = "Manage Ingredients";
            btnManageIngredients.UseVisualStyleBackColor = true;
            btnManageIngredients.Click += btnManageIngredients_Click;
            // 
            // btnPotionRecipe
            // 
            btnPotionRecipe.Location = new Point(36, 327);
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
            TotalIngredientLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalIngredientLabel.ForeColor = SystemColors.MenuHighlight;
            TotalIngredientLabel.Location = new Point(315, 38);
            TotalIngredientLabel.Name = "TotalIngredientLabel";
            TotalIngredientLabel.Size = new Size(38, 45);
            TotalIngredientLabel.TabIndex = 2;
            TotalIngredientLabel.Text = "0";
            // 
            // LowStockLabel
            // 
            LowStockLabel.AutoSize = true;
            LowStockLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LowStockLabel.ForeColor = Color.Red;
            LowStockLabel.Location = new Point(315, 103);
            LowStockLabel.Name = "LowStockLabel";
            LowStockLabel.Size = new Size(38, 45);
            LowStockLabel.TabIndex = 3;
            LowStockLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(273, 45);
            label1.TabIndex = 4;
            label1.Text = "Total Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(36, 103);
            label2.Name = "label2";
            label2.Size = new Size(257, 45);
            label2.TabIndex = 5;
            label2.Text = "Low Stock Alert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(36, 174);
            label3.Name = "label3";
            label3.Size = new Size(215, 45);
            label3.TabIndex = 7;
            label3.Text = "Total Recipes";
            // 
            // TotalRecipesLabel
            // 
            TotalRecipesLabel.AutoSize = true;
            TotalRecipesLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalRecipesLabel.ForeColor = SystemColors.MenuHighlight;
            TotalRecipesLabel.Location = new Point(315, 174);
            TotalRecipesLabel.Name = "TotalRecipesLabel";
            TotalRecipesLabel.Size = new Size(38, 45);
            TotalRecipesLabel.TabIndex = 6;
            TotalRecipesLabel.Text = "0";
            // 
            // ManageBrewingBtn
            // 
            ManageBrewingBtn.Location = new Point(36, 388);
            ManageBrewingBtn.Name = "ManageBrewingBtn";
            ManageBrewingBtn.Size = new Size(199, 37);
            ManageBrewingBtn.TabIndex = 8;
            ManageBrewingBtn.Text = "Manage Brewing";
            ManageBrewingBtn.UseVisualStyleBackColor = true;
            ManageBrewingBtn.Click += ManageBrewingBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 575);
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
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
