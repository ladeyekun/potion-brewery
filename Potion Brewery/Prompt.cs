using System.Windows.Forms;

public static class Prompt {
    public static string ShowDialog(string text, string caption) {
        Form dialog = new Form() {
            Width = 400,
            Height = 150,
            Text = caption
        };
        Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
        TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
        Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 80 };
        confirmation.Click += (sender, e) => { dialog.Close(); };
        dialog.Controls.Add(textLabel);
        dialog.Controls.Add(inputBox);
        dialog.Controls.Add(confirmation);
        dialog.AcceptButton = confirmation;
        dialog.ShowDialog();
        return inputBox.Text;
    }
}
