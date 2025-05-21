using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client;
using PotionBrewery.BLL;
using PotionBrewery.Models;

namespace Potion_Brewery {
    public partial class IngredientForm : Form {

        private readonly IngredientService _ingredientService;
        public IngredientForm(IngredientService ingredientService) {
            InitializeComponent();
            _ingredientService = ingredientService;
            //Load += IngredientForm_Load;
        }

        private async void BtnAdd_Click(object sender, EventArgs e) {
            var dialog = new IngredientEditorForm();
            if (dialog.ShowDialog() == DialogResult.OK) {
                await _ingredientService.AddIngredient(dialog.Ingredient);
                await LoadIngredientsAsync();
            }
        }

        private async void IngredientForm_Load(object sender, EventArgs e) {
            await LoadIngredientsAsync();
        }

        private async Task LoadIngredientsAsync() {
            var ingredients = await _ingredientService.GetIngredients();

            dataGridView1.DataSource = ingredients
                .Select(i => new {
                    i.IngredientId,
                    i.Name,
                    i.StockQuantity,
                    i.MinThreshold,
                    BelowThreshold = i.StockQuantity < i.MinThreshold ? "⚠️ Low Stock" : ""
                })
                .ToList();
            dataGridView1.Columns["IngredientId"].Visible = false;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var id = (int)dataGridView1.SelectedRows[0].Cells["IngredientId"].Value;
                var ingredient = await _ingredientService.GetIngredient(id);
                var dialog = new IngredientEditorForm(ingredient);
                if (dialog.ShowDialog() == DialogResult.OK) {
                    await _ingredientService.UpdateIngredient(dialog.Ingredient);
                    await LoadIngredientsAsync();
                }
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var id = (int)dataGridView1.SelectedRows[0].Cells["IngredientId"].Value;
                var confirm = MessageBox.Show("Are you sure you want to delete this ingredient?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes) {
                    await _ingredientService.DeleteIngredient(id);
                    await LoadIngredientsAsync();
                }
            }
        }
    }
}
