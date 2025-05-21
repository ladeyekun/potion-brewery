using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotionBrewery.Models;

namespace Potion_Brewery {
    public partial class IngredientEditorForm : Form {
        public Ingredient Ingredient { get; private set; }
        public IngredientEditorForm(Ingredient existing = null) {
            InitializeComponent();

            Ingredient = existing ?? new Ingredient();
            if (existing != null) {
                inputIngredient.Text = existing.Name;
                inputStock.Value = existing.StockQuantity;
                inputThreshold.Value = existing.MinThreshold;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Ingredient.Name = inputIngredient.Text.Trim();
            Ingredient.StockQuantity = (int)inputStock.Value;
            Ingredient.MinThreshold = (int)inputThreshold.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IngredientEditorForm_Load(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
