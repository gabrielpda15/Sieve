using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve.Controles
{
    public class SvTextBox : TextBox
    {
        public enum TextType { Normal, Numeric }

        private string _placeholder = string.Empty;
        private Color _placeholderColor = Color.Gray;
        private bool _isShowingPlaceholder = true;
        private bool _isForeColor = true;
        private Color _foreColorBackup;
        private int _oldMaxLength;
        private StringExtension.MaskType _mask = StringExtension.MaskType.None;

        private event EventHandler PlaceholderChange;
        private event EventHandler PlaceholderColorChange;
        private event EventHandler MaskChange;

        [Browsable(true)]
        public string Placeholder { get => _placeholder; set { _placeholder = value; PlaceholderChange?.Invoke(this, EventArgs.Empty); } }

        [Browsable(true)]
        [DefaultValue(typeof(Color), "Gray")]
        public Color PlaceholderColor { get => _placeholderColor; set { _placeholderColor = value; PlaceholderColorChange?.Invoke(this, EventArgs.Empty); } }

        [Browsable(true)]
        [DefaultValue(typeof(StringExtension.MaskType), "None")]
        public StringExtension.MaskType Mask { get => _mask; set { _mask = value; MaskChange?.Invoke(this, EventArgs.Empty); } }

        [Browsable(true)]
        [DefaultValue(2)]
        public int DecimalDigits { get; set; } = 2;

        [Browsable(true)]
        [DefaultValue(typeof(TextType), "Normal")]
        public TextType Type { get; set; } = TextType.Normal;

        private bool IsPlaceholder { get => this.Text == this.Placeholder; }
        
        private bool IsEmpty { get => string.IsNullOrWhiteSpace(this.Text); }

        public string Value 
        { 
            get 
            {
                if (this?.IsPlaceholder == true)
                    return "";
                return this?.Text;
            } 
        }

        public SvTextBox() : base()
        {
            this.PlaceholderChange += SvTextBox_PlaceholderChange;
            this.PlaceholderColorChange += SvTextBox_PlaceholderColorChange;
            this.MaskChange += SvTextBox_MaskChange;
            this.GotFocus += SvTextBox_GotFocus;
            this.LostFocus += SvTextBox_LostFocus;
            this.TextChanged += SvTextBox_TextChanged;
            this.KeyPress += SvTextBox_KeyPress;

            if (IsEmpty)
            {
                SetForeColor(this.PlaceholderColor);
                _isShowingPlaceholder = true;
                this.Text = this.Placeholder;
            }
            else
            {
                _isShowingPlaceholder = false;
            }
        }

        public void SetValue(string value)
        {
            SvTextBox_GotFocus(this, EventArgs.Empty);
            this.Text = value;
            SvTextBox_LostFocus(this, EventArgs.Empty);
        }

        private void SvTextBox_MaskChange(object sender, EventArgs e)
        {
            switch (Mask)
            {
                case StringExtension.MaskType.Money:
                    break;
                case StringExtension.MaskType.Phone:
                case StringExtension.MaskType.CPF:
                case StringExtension.MaskType.CNPJ:
                    this.MaxLength = 11;
                    break;
            }
        }

        private void SvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Type == TextType.Numeric)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                if (DecimalDigits == 0 && e.KeyChar == ',')
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }

                if (char.IsDigit(e.KeyChar) && (this.Text.IndexOf(',') > -1) && 
                    (this.Text.Length - (sender as TextBox).Text.IndexOf(',') - 1) >= DecimalDigits)
                {
                    e.Handled = true;
                }
            }            
        }

        private void RestoreForeColor()
        {
            this.ForeColor = _foreColorBackup;
            this._isForeColor = true;
        }

        private void SetForeColor(Color color)
        {                
            if (_isForeColor)
                _foreColorBackup = this.ForeColor;

            this.ForeColor = color;
            this._isForeColor = false;
        }

        private void SvTextBox_TextChanged(object sender, EventArgs e)
        {
            _isShowingPlaceholder = IsEmpty;
        }

        private void SvTextBox_LostFocus(object sender, EventArgs e)
        {
            if (_isShowingPlaceholder)
            {
                SetForeColor(this.PlaceholderColor);
                this.Text = this.Placeholder;
            }
            else
            {
                var temp = this.Text.Format(this.Mask);
                _oldMaxLength = this.MaxLength;
                this.MaxLength = temp.Length;
                this.Text = temp;
            }
        }

        private void SvTextBox_GotFocus(object sender, EventArgs e)
        {
            if (IsPlaceholder)
            {
                this.Text = string.Empty;
                RestoreForeColor();
            }
            else
            {
                var temp =  this.Text.Unformat(this.Mask);
                this.MaxLength = _oldMaxLength;
                this.Text = temp;
            }
        }

        private void SvTextBox_PlaceholderColorChange(object sender, EventArgs e)
        {
            if (IsPlaceholder)
            {
                SetForeColor(this.PlaceholderColor);
            }
        }

        private void SvTextBox_PlaceholderChange(object sender, EventArgs e)
        {
            if (IsPlaceholder || IsEmpty)
                this.Text = this.Placeholder;
        }
    }
}
