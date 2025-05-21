namespace Potion_Brewery {
    partial class IngredientEditorForm {
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
            inputIngredient = new TextBox();
            inputStock = new NumericUpDown();
            inputThreshold = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)inputStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputThreshold).BeginInit();
            SuspendLayout();
            // 
            // inputIngredient
            // 
            inputIngredient.Location = new Point(238, 24);
            inputIngredient.Name = "inputIngredient";
            inputIngredient.Size = new Size(291, 29);
            inputIngredient.TabIndex = 0;
            // 
            // inputStock
            // 
            inputStock.Location = new Point(240, 79);
            inputStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            inputStock.Name = "inputStock";
            inputStock.Size = new Size(98, 29);
            inputStock.TabIndex = 1;
            // 
            // inputThreshold
            // 
            inputThreshold.Location = new Point(240, 143);
            inputThreshold.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            inputThreshold.Name = "inputThreshold";
            inputThreshold.Size = new Size(98, 29);
            inputThreshold.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 3;
            label1.Text = "Ingredient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 87);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 4;
            label2.Text = "Stock Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 145);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Threshold";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(111, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(241, 191);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // IngredientEditorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputThreshold);
            Controls.Add(inputStock);
            Controls.Add(inputIngredient);
            Name = "IngredientEditorForm";
            Text = "Ingredient Editor Form";
            Load += IngredientEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)inputStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputThreshold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputIngredient;
        private NumericUpDown inputStock;
        private NumericUpDown inputThreshold;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}