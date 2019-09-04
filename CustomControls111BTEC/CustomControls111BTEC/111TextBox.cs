using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls111BTEC
{
    public partial class _111TextBox : UserControl
    {
        private string placeHolderText = "Texto";
        private bool enablePlaceHolder=true;
        public _111TextBox()
        {
            InitializeComponent();
            textHolderLabel.Text = placeHolderText;
            textHolderLabel.BackColor = textBox1.BackColor;

        }
        #region Propiedades
        /// <summary>
        /// Agregas el texto del PlaceHolder
        /// </summary>
        [Description("Texto de PlaceHolder"), Category("Style")]
        public string PalceHolderText
        {
            get { return this.placeHolderText; }
            set
            {
                textHolderLabel.Text = value;
                this.placeHolderText = value;
      
            }
        }
        /// <summary>
        /// Bandera para habilitar y deshabilitar el place holder
        /// </summary>
        [Description("Habilitar/Deshabilitar PlaceHolder"), Category("Style")]
        public bool EnablePalceHolder
        {
            get { return enablePlaceHolder; }
            set
            {
                if (textHolderLabel.Visible == true)
                {
                    textHolderLabel.Visible = value;
                    enablePlaceHolder = value;
                }
                    
                else
                {
                    enablePlaceHolder = value;
                }
            }
        }

        [Description("Habilitar/Deshabilitar PlaceHolder"), Category("Style")]
        public int BorderRadius
        {
            get { return bunifuElipse1.ElipseRadius; }
            set { bunifuElipse1.ElipseRadius = value; }
        }
        /// <summary>
        /// Color del texto del place holder
        /// </summary>
        [Description("PlaceHolder Color"), Category("Style")]
        public Color PlaceHolderColor
        {
            get { return textHolderLabel.ForeColor; }
            set { textHolderLabel.ForeColor = value; }
        }


        #endregion
        private void _111TextBox_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textHolderLabel.Visible = true  && enablePlaceHolder;
                textHolderLabel.Text = placeHolderText;
            }
            
        }

        private void _111TextBox_Enter(object sender, EventArgs e)
        {
            textHolderLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textHolderLabel.Visible = false;
            textBox1.Focus();
            _111TextBox_Enter(sender, e);
        }

        private void _111TextBox_ForeColorChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = this.ForeColor;
        }

        private void _111TextBox_BackColorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
