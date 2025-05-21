namespace Potion_Brewery {
    partial class PotionBrewingForm {
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
            RecipesCombo = new ComboBox();
            dataGridView1 = new DataGridView();
            IngredientName = new DataGridViewTextBoxColumn();
            RequiredQuantity = new DataGridViewTextBoxColumn();
            AvailableQuantity = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            label1 = new Label();
            StartBrewingBtn = new Button();
            BrewingProgressBar = new ProgressBar();
            StatusLabel = new Label();
            CustomName = new TextBox();
            CustomAttributes = new TextBox();
            BrewedPotionGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BrewedPotionGrid).BeginInit();
            SuspendLayout();
            // 
            // RecipesCombo
            // 
            RecipesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            RecipesCombo.FormattingEnabled = true;
            RecipesCombo.Location = new Point(127, 25);
            RecipesCombo.Name = "RecipesCombo";
            RecipesCombo.Size = new Size(461, 29);
            RecipesCombo.TabIndex = 0;
            RecipesCombo.SelectedIndexChanged += RecipesCombo_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IngredientName, RequiredQuantity, AvailableQuantity, Remark });
            dataGridView1.Location = new Point(128, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(714, 118);
            dataGridView1.TabIndex = 1;
            // 
            // IngredientName
            // 
            IngredientName.HeaderText = "Ingredient Name";
            IngredientName.Name = "IngredientName";
            IngredientName.ReadOnly = true;
            // 
            // RequiredQuantity
            // 
            RequiredQuantity.HeaderText = "Required Quantity";
            RequiredQuantity.Name = "RequiredQuantity";
            RequiredQuantity.ReadOnly = true;
            // 
            // AvailableQuantity
            // 
            AvailableQuantity.HeaderText = "Available Quantity";
            AvailableQuantity.Name = "AvailableQuantity";
            AvailableQuantity.ReadOnly = true;
            // 
            // Remark
            // 
            Remark.HeaderText = "Remark";
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 2;
            label1.Text = "Select Recipe";
            // 
            // StartBrewingBtn
            // 
            StartBrewingBtn.Location = new Point(127, 255);
            StartBrewingBtn.Name = "StartBrewingBtn";
            StartBrewingBtn.Size = new Size(129, 40);
            StartBrewingBtn.TabIndex = 3;
            StartBrewingBtn.Text = "Start Brewing";
            StartBrewingBtn.UseVisualStyleBackColor = true;
            StartBrewingBtn.Click += StartBrewingBtn_Click;
            // 
            // BrewingProgressBar
            // 
            BrewingProgressBar.Location = new Point(127, 310);
            BrewingProgressBar.Name = "BrewingProgressBar";
            BrewingProgressBar.Size = new Size(714, 23);
            BrewingProgressBar.TabIndex = 4;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(129, 352);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 21);
            StatusLabel.TabIndex = 5;
            StatusLabel.Click += StatusLabel_Click;
            // 
            // CustomName
            // 
            CustomName.Location = new Point(127, 211);
            CustomName.Name = "CustomName";
            CustomName.PlaceholderText = "Custom Name";
            CustomName.Size = new Size(375, 29);
            CustomName.TabIndex = 6;
            // 
            // CustomAttributes
            // 
            CustomAttributes.Location = new Point(508, 211);
            CustomAttributes.Name = "CustomAttributes";
            CustomAttributes.PlaceholderText = "Custom Attribute";
            CustomAttributes.Size = new Size(334, 29);
            CustomAttributes.TabIndex = 7;
            // 
            // BrewedPotionGrid
            // 
            BrewedPotionGrid.AllowUserToAddRows = false;
            BrewedPotionGrid.AllowUserToDeleteRows = false;
            BrewedPotionGrid.AllowUserToResizeColumns = false;
            BrewedPotionGrid.AllowUserToResizeRows = false;
            BrewedPotionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BrewedPotionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BrewedPotionGrid.Location = new Point(127, 360);
            BrewedPotionGrid.Name = "BrewedPotionGrid";
            BrewedPotionGrid.ReadOnly = true;
            BrewedPotionGrid.RowHeadersVisible = false;
            BrewedPotionGrid.Size = new Size(715, 217);
            BrewedPotionGrid.TabIndex = 8;
            // 
            // PotionBrewingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 589);
            Controls.Add(BrewedPotionGrid);
            Controls.Add(CustomAttributes);
            Controls.Add(CustomName);
            Controls.Add(StatusLabel);
            Controls.Add(BrewingProgressBar);
            Controls.Add(StartBrewingBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(RecipesCombo);
            Name = "PotionBrewingForm";
            Text = "Potion Brewing Form";
            Load += PotionBrewingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BrewedPotionGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RecipesCombo;
        private DataGridView dataGridView1;
        private Label label1;
        private Button StartBrewingBtn;
        private ProgressBar BrewingProgressBar;
        private Label StatusLabel;
        private DataGridViewTextBoxColumn IngredientName;
        private DataGridViewTextBoxColumn RequiredQuantity;
        private DataGridViewTextBoxColumn AvailableQuantity;
        private DataGridViewTextBoxColumn Remark;
        private TextBox CustomName;
        private TextBox CustomAttributes;
        private DataGridView BrewedPotionGrid;
    }
}