namespace Potion_Brewery {
    partial class PotionRecipeForm {
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
            dataGridView1 = new DataGridView();
            AddRecipeBtn = new Button();
            EditRecipeBtn = new Button();
            DeleteRecipeBtn = new Button();
            PrevScreenBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(787, 150);
            dataGridView1.TabIndex = 0;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(49, 292);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(113, 44);
            AddRecipeBtn.TabIndex = 1;
            AddRecipeBtn.Text = "Add Recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // EditRecipeBtn
            // 
            EditRecipeBtn.Location = new Point(211, 292);
            EditRecipeBtn.Name = "EditRecipeBtn";
            EditRecipeBtn.Size = new Size(133, 44);
            EditRecipeBtn.TabIndex = 2;
            EditRecipeBtn.Text = "Edit Recipe";
            EditRecipeBtn.UseVisualStyleBackColor = true;
            EditRecipeBtn.Click += EditRecipeBtn_Click;
            // 
            // DeleteRecipeBtn
            // 
            DeleteRecipeBtn.Location = new Point(390, 292);
            DeleteRecipeBtn.Name = "DeleteRecipeBtn";
            DeleteRecipeBtn.Size = new Size(113, 44);
            DeleteRecipeBtn.TabIndex = 3;
            DeleteRecipeBtn.Text = "Delete Recipe";
            DeleteRecipeBtn.UseVisualStyleBackColor = true;
            DeleteRecipeBtn.Click += DeleteRecipeBtn_Click;
            // 
            // PrevScreenBtn
            // 
            PrevScreenBtn.Location = new Point(576, 292);
            PrevScreenBtn.Name = "PrevScreenBtn";
            PrevScreenBtn.Size = new Size(145, 44);
            PrevScreenBtn.TabIndex = 4;
            PrevScreenBtn.Text = "Previous Screen";
            PrevScreenBtn.UseVisualStyleBackColor = true;
            // 
            // PotionRecipeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrevScreenBtn);
            Controls.Add(DeleteRecipeBtn);
            Controls.Add(EditRecipeBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(dataGridView1);
            Name = "PotionRecipeForm";
            Text = "PotionRecipeForm";
            Load += PotionRecipeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddRecipeBtn;
        private Button EditRecipeBtn;
        private Button DeleteRecipeBtn;
        private Button PrevScreenBtn;
    }
}