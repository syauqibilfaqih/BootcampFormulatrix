void Main()
{
    Application.Run(new CalculatorForm());
}

public class CalculatorForm : Form
{
    private TextBox displayTextBox;

    public CalculatorForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = "Simple Calculator";
        this.Size = new Size(300, 400);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        displayTextBox = new TextBox();
        displayTextBox.Dock = DockStyle.Top;
        displayTextBox.ReadOnly = true;
        displayTextBox.Multiline = true;
        displayTextBox.Height = 50;
        this.Controls.Add(displayTextBox);

        TableLayoutPanel buttonPanel = new TableLayoutPanel();
        buttonPanel.Dock = DockStyle.Fill;
        buttonPanel.RowCount = 5;
        buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
        buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
        buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
        buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
        buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
        buttonPanel.ColumnCount = 4;
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

        AddButton(buttonPanel, "7");
        AddButton(buttonPanel, "8");
        AddButton(buttonPanel, "9");
        AddButton(buttonPanel, "/");

        AddButton(buttonPanel, "4");
        AddButton(buttonPanel, "5");
        AddButton(buttonPanel, "6");
        AddButton(buttonPanel, "*");

        AddButton(buttonPanel, "1");
        AddButton(buttonPanel, "2");
        AddButton(buttonPanel, "3");
        AddButton(buttonPanel, "-");

        AddButton(buttonPanel, "0");
        AddButton(buttonPanel, ".");
        AddButton(buttonPanel, "=");
        AddButton(buttonPanel, "+");

        this.Controls.Add(buttonPanel);
    }

    private void AddButton(TableLayoutPanel panel, string text)
    {
        Button button = new Button();
        button.Text = text;
        button.Dock = DockStyle.Fill;
        button.Font = new Font("Arial", 16);
        button.Click += Button_Click;

        panel.Controls.Add(button);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (button.Text == "=")
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(displayTextBox.Text, "");
                displayTextBox.Text = result.ToString();
            }
            catch (Exception)
            {
                displayTextBox.Text = "Error";
            }
        }
        else
        {
            displayTextBox.Text += button.Text;
        }
    }
}
