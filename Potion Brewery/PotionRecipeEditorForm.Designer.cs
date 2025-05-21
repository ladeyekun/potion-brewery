namespace Potion_Brewery {
    partial class PotionRecipeEditorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            RecipeName = new TextBox();
            RecipeDescription = new TextBox();
            RecipeBrewingTime = new NumericUpDown();
            IngredientCombo = new ComboBox();
            IngredientQnty = new NumericUpDown();
            AddIngredientBtn = new Button();
            dataGridView1 = new DataGridView();
            IngredientName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            SaveRecipeBtn = new Button();
            RemoveIngredientBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RecipeBrewingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientQnty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RecipeName
            // 
            RecipeName.Location = new Point(198, 35);
            RecipeName.Name = "RecipeName";
            RecipeName.PlaceholderText = "Potion Name";
            RecipeName.Size = new Size(266, 29);
            RecipeName.TabIndex = 0;
            // 
            // RecipeDescription
            // 
            RecipeDescription.Location = new Point(198, 79);
            RecipeDescription.Name = "RecipeDescription";
            RecipeDescription.PlaceholderText = "Description";
            RecipeDescription.Size = new Size(266, 29);
            RecipeDescription.TabIndex = 1;
            // 
            // RecipeBrewingTime
            // 
            RecipeBrewingTime.Location = new Point(198, 131);
            RecipeBrewingTime.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            RecipeBrewingTime.Name = "RecipeBrewingTime";
            RecipeBrewingTime.Size = new Size(266, 29);
            RecipeBrewingTime.TabIndex = 2;
            // 
            // IngredientCombo
            // 
            IngredientCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            IngredientCombo.FormattingEnabled = true;
            IngredientCombo.Location = new Point(198, 178);
            IngredientCombo.Name = "IngredientCombo";
            IngredientCombo.Size = new Size(268, 29);
            IngredientCombo.TabIndex = 3;
            IngredientCombo.SelectedIndexChanged += IngredientCombo_SelectedIndexChanged;
            // 
            // IngredientQnty
            // 
            IngredientQnty.Location = new Point(472, 179);
            IngredientQnty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            IngredientQnty.Name = "IngredientQnty";
            IngredientQnty.Size = new Size(120, 29);
            IngredientQnty.TabIndex = 4;
            // 
            // AddIngredientBtn
            // 
            AddIngredientBtn.Location = new Point(611, 179);
            AddIngredientBtn.Name = "AddIngredientBtn";
            AddIngredientBtn.Size = new Size(130, 29);
            AddIngredientBtn.TabIndex = 5;
            AddIngredientBtn.Text = "Add Ingredient";
            AddIngredientBtn.UseVisualStyleBackColor = true;
            AddIngredientBtn.Click += AddIngredientBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IngredientName, Quantity });
            dataGridView1.Location = new Point(198, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(543, 117);
            dataGridView1.TabIndex = 6;
            // 
            // IngredientName
            // 
            IngredientName.HeaderText = "Ingredient";
            IngredientName.Name = "IngredientName";
            IngredientName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // SaveRecipeBtn
            // 
            SaveRecipeBtn.Location = new Point(198, 385);
            SaveRecipeBtn.Name = "SaveRecipeBtn";
            SaveRecipeBtn.Size = new Size(107, 35);
            SaveRecipeBtn.TabIndex = 7;
            SaveRecipeBtn.Text = "Save Recipe";
            SaveRecipeBtn.UseVisualStyleBackColor = true;
            SaveRecipeBtn.Click += SaveRecipeBtn_Click;
            // 
            // RemoveIngredientBtn
            // 
            RemoveIngredientBtn.Location = new Point(335, 385);
            RemoveIngredientBtn.Name = "RemoveIngredientBtn";
            RemoveIngredientBtn.Size = new Size(158, 35);
            RemoveIngredientBtn.TabIndex = 8;
            RemoveIngredientBtn.Text = "Remove Ingredient";
            RemoveIngredientBtn.UseVisualStyleBackColor = true;
            RemoveIngredientBtn.Click += RemoveIngredientBtn_Click;
            // 
            // PotionRecipeEditorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveIngredientBtn);
            Controls.Add(SaveRecipeBtn);
            Controls.Add(dataGridView1);
            Controls.Add(AddIngredientBtn);
            Controls.Add(IngredientQnty);
            Controls.Add(IngredientCombo);
            Controls.Add(RecipeBrewingTime);
            Controls.Add(RecipeDescription);
            Controls.Add(RecipeName);
            Name = "PotionRecipeEditorForm";
            Text = "Potion Recipe Editor Form";
            Load += PotionRecipeEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipeBrewingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientQnty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RecipeName;
        private TextBox RecipeDescription;
        private NumericUpDown RecipeBrewingTime;
        private ComboBox IngredientCombo;
        private NumericUpDown IngredientQnty;
        private Button AddIngredientBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IngredientName;
        private DataGridViewTextBoxColumn Quantity;
        private Button SaveRecipeBtn;
        private Button RemoveIngredientBtn;
    }
}