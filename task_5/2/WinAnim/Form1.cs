namespace WinAnim
{
    public partial class FormAnimation : Form
    {
        public FormAnimation()
        {
            InitializeComponent();
        }

        private void buttonAW_BLEND_Click(object sender, EventArgs e)
        {
            // Скрываем окно
            this.Hide();
            // Запускаем анимацию. Второй параметр в скобках — время анимации в миллисекундах.
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass.AnimateWindowFlags.AW_BLEND);
            // Отображаем кнопки после анимации
            this.buttonAWBLEND.Invalidate();
            this.buttonCenterAWSLIDE.Invalidate();
            this.buttonHORAWSLIDE.Invalidate();
        }

        private void buttonHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE |
            WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.buttonAWBLEND.Invalidate();
            this.buttonCenterAWSLIDE.Invalidate();
            this.buttonHORAWSLIDE.Invalidate();
        }

        private void buttonAW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_CENTER |
            WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.buttonAWBLEND.Invalidate();
            this.buttonCenterAWSLIDE.Invalidate();
            this.buttonHORAWSLIDE.Invalidate();
        }
    }
}