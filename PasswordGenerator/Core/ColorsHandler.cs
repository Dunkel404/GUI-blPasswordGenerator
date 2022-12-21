namespace PasswordGenerator.Core
{
    public static class BlColors
    {
        public static bool State { get; set; }

        public static Color FormBackColor { get; set; }
        public static Color FormForeColor { get; set; }
        public static Color LabelBackColor { get; set; }
        public static Color LabelForeColor { get; set; }
        public static Color NavBarBackColor { get; set; }
        public static Color GenButtonBackColor { get; set; }

        // Valores RGB das cores
        private const string HtmlFormBackDark = "#2C2C32";
        private const string HtmlFormBackLight = "#e6e6eb";
        private const string HtmlFormForeDark = "#0B131B";
        private const string HtmlFormForeLight = "#F2FDFD";
        private const string HtmlLabelBack = "#0A0A0A";
        private const string HtmlLabelFore = "#F2FDFD";
        private const string HtmlNavBarBackDark = "#101012";
        //private const string HtmlNavBarBackLight = "#FFFFFF";
        private const string HtmlGenButtonBackDark = "#0B131B";
        private const string HtmlGenButtonBackLight = "#FF7F7F";

        // Armazene as cores em memória
        private static Color _formBackColor;
        private static Color _formForeColor;
        private static Color _labelBackColor;
        private static Color _labelForeColor;
        private static Color _navBarBackColor;
        private static Color _genButtonBackColor;

        public static void UpdateState(bool newState)
        {
            State = newState;

            // Atualize as cores apenas se o valor de "State" mudou
            //if (State != newState)
            {
                _formBackColor = State ? ColorTranslator.FromHtml(HtmlFormBackDark) : ColorTranslator.FromHtml(HtmlFormBackLight);
                _formForeColor = State ? ColorTranslator.FromHtml(HtmlFormForeLight) : ColorTranslator.FromHtml(HtmlFormForeDark);
                _labelBackColor = ColorTranslator.FromHtml(HtmlLabelBack);
                _labelForeColor = ColorTranslator.FromHtml(HtmlLabelFore);
                _navBarBackColor = State ? ColorTranslator.FromHtml(HtmlNavBarBackDark) : SystemColors.InactiveCaption;
                _genButtonBackColor = State ? ColorTranslator.FromHtml(HtmlGenButtonBackDark) : ColorTranslator.FromHtml(HtmlGenButtonBackLight);
            }

            // Atribua as cores armazenadas em memória às propriedades públicas
            FormBackColor = _formBackColor;
            FormForeColor = _formForeColor;
            LabelBackColor = _labelBackColor;
            LabelForeColor = _labelForeColor;
            NavBarBackColor = _navBarBackColor;
            GenButtonBackColor = _genButtonBackColor;
        }
    }
}
