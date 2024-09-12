namespace _5M02Checkbox
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void chkUnderlineChecked(object sender, EventArgs e)
        {
            if (chkUnderline.IsChecked)
                lblNapis.TextDecorations = TextDecorations.Underline;
            else
                lblNapis.TextDecorations = TextDecorations.None;
        }
        private void chkBoldChecked(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.IsChecked)
                lblNapis.FontAttributes = FontAttributes.Bold;
            else
                lblNapis.FontAttributes |= FontAttributes.None;
        }
        private void chkItalicChecked(object sender, EventArgs e)
        {
            if (chkItalic.IsChecked)
                lblNapis.FontAttributes = FontAttributes.Italic;
            else
                lblNapis.FontAttributes = FontAttributes.None;
        }
    }

}
