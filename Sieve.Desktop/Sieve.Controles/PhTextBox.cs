﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sieve.Controles
{
    public class PhTextBox : TextBox
    {
        private static readonly IDictionary<int, Keys[]> keys;

        public enum TextType { Normal, Numeric }

        private string _placeholder = string.Empty;
        private Color _placeholderColor = Color.Gray;
        private bool _isShowingPlaceholder = true;
        private bool _isForeColor = true;
        private Color _foreColorBackup;

        private event EventHandler PlaceholderChange;
        private event EventHandler PlaceholderColorChange;

        [Browsable(true)]
        public string Placeholder { get => _placeholder; set { _placeholder = value; PlaceholderChange?.Invoke(this, EventArgs.Empty); } }

        [Browsable(true)]
        [DefaultValue(typeof(Color), "Gray")]
        public Color PlaceholderColor { get => _placeholderColor; set { _placeholderColor = value; PlaceholderColorChange?.Invoke(this, EventArgs.Empty); } }

        private bool IsPlaceholder { get => this.Text == this.Placeholder; }
        
        private bool IsEmpty { get => string.IsNullOrWhiteSpace(this.Text); }

        [Browsable(true)]
        [DefaultValue("")]
        public string Mask { get; set; }

        [Browsable(true)]
        [DefaultValue(typeof(TextType), "Normal")]
        public TextType Type { get; set; }

        public PhTextBox() : base()
        {
            for (int i = 0; i < 10; i++)
            {
                Keys.D0
                keys.Add(i, new [Keys. ])
            }

            this.PlaceholderChange += PhTextBox_PlaceholderChange;
            this.PlaceholderColorChange += PhTextBox_PlaceholderColorChange;
            this.GotFocus += PhTextBox_GotFocus;
            this.LostFocus += PhTextBox_LostFocus;
            this.TextChanged += PhTextBox_TextChanged;
            this.KeyDown += PhTextBox_KeyDown;

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

        private void PhTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Type == TextType.Numeric)
            {
                e.
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

        private void PhTextBox_TextChanged(object sender, EventArgs e)
        {
            _isShowingPlaceholder = IsEmpty;
        }

        private void PhTextBox_LostFocus(object sender, EventArgs e)
        {
            if (_isShowingPlaceholder)
            {
                SetForeColor(this.PlaceholderColor);
                this.Text = this.Placeholder;
            }
            else
            {

            }
        }

        private void PhTextBox_GotFocus(object sender, EventArgs e)
        {
            if (IsPlaceholder)
            {
                this.Text = string.Empty;
                RestoreForeColor();
            }
            else
            {

            }
        }

        private void PhTextBox_PlaceholderColorChange(object sender, EventArgs e)
        {
            if (IsPlaceholder)
            {
                SetForeColor(this.PlaceholderColor);
            }
        }

        private void PhTextBox_PlaceholderChange(object sender, EventArgs e)
        {
            if (IsPlaceholder || IsEmpty)
                this.Text = this.Placeholder;
        }
    }
}
